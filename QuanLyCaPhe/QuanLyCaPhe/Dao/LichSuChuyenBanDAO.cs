using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class LichSuChuyenBanDAO
{
    public int LayMaHoaDonChuaThanhToan(int maBan, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = @"SELECT hd.MaHoaDon 
                       FROM HOA_DON hd
                       JOIN HOA_DON_BAN hdb ON hd.MaHoaDon = hdb.MaHoaDon
                       WHERE hdb.MaBan = @MaBan 
                         AND (hd.TrangThai = 'ChuaThanhToan' OR hd.TrangThai = 'Chưa thanh toán')
                       ORDER BY hd.MaHoaDon DESC LIMIT 1";

        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaBan", maBan);

        object? result = cmd.ExecuteScalar();
        if (result != null && int.TryParse(result.ToString(), out int maHoaDon))
        {
            return maHoaDon;
        }

        return 0;
    }

    public string LayTrangThaiBan(int maBan, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = "SELECT TrangThai FROM BAN WHERE MaBan = @MaBan";

        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaBan", maBan);

        object? result = cmd.ExecuteScalar();
        return result?.ToString() ?? string.Empty;
    }

    public bool CapNhatHoaDonSangBanMoi(int maHoaDon, int maBanNguon, int maBanDich, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = @"UPDATE HOA_DON_BAN 
                       SET MaBan = @MaBanDich 
                       WHERE MaHoaDon = @MaHoaDon AND MaBan = @MaBanNguon";

        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaBanDich", maBanDich);
        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
        cmd.Parameters.AddWithValue("@MaBanNguon", maBanNguon);

        return cmd.ExecuteNonQuery() > 0;
    }

    public bool CapNhatTrangThaiBan(int maBan, string trangThaiMoi, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = "UPDATE BAN SET TrangThai = @TrangThai WHERE MaBan = @MaBan";

        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
        cmd.Parameters.AddWithValue("@MaBan", maBan);

        return cmd.ExecuteNonQuery() > 0;
    }

    public bool GhiLichSuChuyenBan(int maHoaDon, int maBanNguon, int maBanDich, int maNhanVien, string lyDo, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = @"INSERT INTO LICH_SU_CHUYEN_BAN 
                       (MaHoaDon, MaBanNguon, MaBanDich, MaNhanVien, ThoiGian, LoaiThaoTac, LyDo)
                       VALUES (@MaHoaDon, @MaBanNguon, @MaBanDich, @MaNhanVien, @ThoiGian, @LoaiThaoTac, @LyDo)";

        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon > 0 ? maHoaDon : DBNull.Value);
        cmd.Parameters.AddWithValue("@MaBanNguon", maBanNguon);
        cmd.Parameters.AddWithValue("@MaBanDich", maBanDich);
        cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien > 0 ? maNhanVien : 1);
        cmd.Parameters.AddWithValue("@ThoiGian", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        cmd.Parameters.AddWithValue("@LoaiThaoTac", "Chuyển bàn");
        cmd.Parameters.AddWithValue("@LyDo", string.IsNullOrWhiteSpace(lyDo) ? "Khách yêu cầu chuyển bàn" : lyDo.Trim());

        return cmd.ExecuteNonQuery() > 0;
    }

    public bool ChuyenBan(int maBanNguon, int maBanDich, int maNhanVien, string lyDo, out string thongBaoLoi)
    {
        thongBaoLoi = string.Empty;

        if (maBanNguon <= 0 || maBanDich <= 0)
        {
            thongBaoLoi = "Bàn nguồn hoặc bàn đích không hợp lệ.";
            return false;
        }

        if (maBanNguon == maBanDich)
        {
            thongBaoLoi = "Bàn chuyển đến không được trùng với bàn hiện tại.";
            return false;
        }

        try
        {
            using var conn = DBConnect.GetConnection();
            using var trans = conn.BeginTransaction();

            int maHoaDon = LayMaHoaDonChuaThanhToan(maBanNguon, conn, trans);
            if (maHoaDon <= 0)
            {
                trans.Rollback();
                thongBaoLoi = "Bàn nguồn hiện không có hóa đơn nào chưa thanh toán.";
                return false;
            }

            string trangThaiBanDich = LayTrangThaiBan(maBanDich, conn, trans);
            if (trangThaiBanDich != "Trong")
            {
                trans.Rollback();
                thongBaoLoi = "Bàn đích hiện đang có người hoặc không ở trạng thái trống.";
                return false;
            }

            CapNhatHoaDonSangBanMoi(maHoaDon, maBanNguon, maBanDich, conn, trans);

            CapNhatTrangThaiBan(maBanNguon, "Trong", conn, trans);

            CapNhatTrangThaiBan(maBanDich, "CoNguoi", conn, trans);

            GhiLichSuChuyenBan(maHoaDon, maBanNguon, maBanDich, maNhanVien, lyDo, conn, trans);

            trans.Commit();
            return true;
        }
        catch (Exception ex)
        {
            thongBaoLoi = "Lỗi trong quá trình chuyển bàn: " + ex.Message;
            return false;
        }
    }

    private List<string> LayDanhSachMonTheoHoaDon(int maHoaDon, SqliteConnection conn)
    {
        var danhSachMon = new List<string>();

        try
        {
            string sql = @"SELECT ct.SoLuong, m.TenMon, ct.ThanhTien 
                           FROM CHI_TIET_HOA_DON ct
                           JOIN MON_AN m ON ct.MaMon = m.MaMon
                           WHERE ct.MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int soLuong = Convert.ToInt32(reader["SoLuong"]);
                string tenMon = reader["TenMon"]?.ToString() ?? "";
                decimal thanhTien = Convert.ToDecimal(reader["ThanhTien"]);

                danhSachMon.Add($"{soLuong}x {tenMon} ({thanhTien:N0} đ)");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSachMon;
    }

    public List<LichSuChuyenBanModelDTO> LayDanhSachLichSu()
    {
        var danhSach = new List<LichSuChuyenBanModelDTO>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT 
                               ls.MaLichSu,
                               COALESCE(ls.MaHoaDon, 0) AS MaHoaDon,
                               COALESCE(hd.TongTien, 0) AS TongTienDon,
                               ls.MaBanNguon,
                               bn.TenBan AS TenBanNguon,
                               ls.MaBanDich,
                               bd.TenBan AS TenBanDich,
                               ls.MaNhanVien,
                               COALESCE(nv.HoTen, 'Nhân viên #' || ls.MaNhanVien) AS TenNhanVien,
                               ls.ThoiGian,
                               ls.LoaiThaoTac,
                               COALESCE(ls.LyDo, '') AS LyDo
                           FROM LICH_SU_CHUYEN_BAN ls
                           LEFT JOIN HOA_DON hd ON ls.MaHoaDon = hd.MaHoaDon
                           LEFT JOIN BAN bn ON ls.MaBanNguon = bn.MaBan
                           LEFT JOIN BAN bd ON ls.MaBanDich = bd.MaBan
                           LEFT JOIN NHAN_VIEN nv ON ls.MaNhanVien = nv.MaNhanVien
                           ORDER BY ls.MaLichSu DESC";

            using (var cmd = new SqliteCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var dto = new LichSuChuyenBanModelDTO
                    {
                        MaLichSu = Convert.ToInt32(reader["MaLichSu"]),
                        MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
                        TongTienDon = Convert.ToDecimal(reader["TongTienDon"]),
                        MaBanNguon = Convert.ToInt32(reader["MaBanNguon"]),
                        TenBanNguon = reader["TenBanNguon"]?.ToString() ?? "",
                        MaBanDich = Convert.ToInt32(reader["MaBanDich"]),
                        TenBanDich = reader["TenBanDich"]?.ToString() ?? "",
                        MaNhanVien = Convert.ToInt32(reader["MaNhanVien"]),
                        TenNhanVien = reader["TenNhanVien"]?.ToString() ?? "",
                        ThoiGian = Convert.ToDateTime(reader["ThoiGian"]),
                        LoaiThaoTac = reader["LoaiThaoTac"]?.ToString() ?? "Chuyển bàn",
                        LyDo = reader["LyDo"]?.ToString() ?? ""
                    };

                    danhSach.Add(dto);
                }
            }

            foreach (var item in danhSach)
            {
                if (item.MaHoaDon > 0)
                {
                    item.DanhSachMon = LayDanhSachMonTheoHoaDon(item.MaHoaDon, conn);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }
}

public class LichSuChuyenBanModelDTO
{
    public int MaLichSu { get; set; }
    public int MaHoaDon { get; set; }
    public decimal TongTienDon { get; set; }
    public int MaBanNguon { get; set; }
    public string TenBanNguon { get; set; } = string.Empty;
    public int MaBanDich { get; set; }
    public string TenBanDich { get; set; } = string.Empty;
    public int MaNhanVien { get; set; }
    public string TenNhanVien { get; set; } = string.Empty;
    public DateTime ThoiGian { get; set; }
    public string LoaiThaoTac { get; set; } = "Chuyển bàn";
    public string LyDo { get; set; } = string.Empty;
    public List<string> DanhSachMon { get; set; } = new();
}
