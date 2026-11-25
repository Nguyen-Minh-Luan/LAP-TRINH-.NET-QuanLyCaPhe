using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class GopBanDAO
{
    public Dictionary<int, int> LayHoaDonChuaThanhToanCuaCacBan(List<int> dsMaBan, SqliteConnection conn, SqliteTransaction trans)
    {
        var ketQua = new Dictionary<int, int>();

        foreach (int maBan in dsMaBan)
        {
            string sql = @"SELECT hd.MaHoaDon 
                           FROM HOA_DON hd
                           JOIN HOA_DON_BAN hdb ON hd.MaHoaDon = hdb.MaHoaDon
                           WHERE hdb.MaBan = @MaBan 
                             AND (hd.TrangThai = 'ChuaThanhToan' OR hd.TrangThai = 'Chưa thanh toán')
                           ORDER BY hd.MaHoaDon DESC LIMIT 1";

            using var cmd = new SqliteCommand(sql, conn, trans);
            cmd.Parameters.AddWithValue("@MaBan", maBan);
            object? res = cmd.ExecuteScalar();

            if (res != null && int.TryParse(res.ToString(), out int maHoaDon))
            {
                ketQua[maBan] = maHoaDon;
            }
        }

        return ketQua;
    }

    public int TaoHoaDonMoi(int maNhanVien, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = @"INSERT INTO HOA_DON (MaNhanVien, NgayTao, TongTien, TienGiam, ThanhTien, TrangThai)
                       VALUES (@MaNhanVien, @NgayTao, 0, 0, 0, 'ChuaThanhToan');
                       SELECT last_insert_rowid();";

        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien > 0 ? maNhanVien : 1);
        cmd.Parameters.AddWithValue("@NgayTao", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

        object? res = cmd.ExecuteScalar();
        if (res != null && int.TryParse(res.ToString(), out int id))
        {
            return id;
        }

        return 0;
    }

    public bool KiemTraLienKetHoaDonBan(int maHoaDon, int maBan, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = "SELECT COUNT(1) FROM HOA_DON_BAN WHERE MaHoaDon = @MaHoaDon AND MaBan = @MaBan";
        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
        cmd.Parameters.AddWithValue("@MaBan", maBan);
        long count = Convert.ToInt64(cmd.ExecuteScalar() ?? 0);
        return count > 0;
    }

    public bool ThemLienKetHoaDonBan(int maHoaDon, int maBan, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = @"INSERT INTO HOA_DON_BAN (MaHoaDon, MaBan, ThoiGianBatDau)
                       VALUES (@MaHoaDon, @MaBan, @ThoiGianBatDau)";
        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
        cmd.Parameters.AddWithValue("@MaBan", maBan);
        cmd.Parameters.AddWithValue("@ThoiGianBatDau", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool LienKetBanVaoHoaDon(int maHoaDon, int maBan, SqliteConnection conn, SqliteTransaction trans)
    {
        if (KiemTraLienKetHoaDonBan(maHoaDon, maBan, conn, trans))
        {
            return true;
        }
        return ThemLienKetHoaDonBan(maHoaDon, maBan, conn, trans);
    }

    public bool ChuyenChiTietMon(int maHoaDonPhu, int maHoaDonChinh, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = "UPDATE CHI_TIET_HOA_DON SET MaHoaDon = @MaHoaDonChinh WHERE MaHoaDon = @MaHoaDonPhu";
        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaHoaDonChinh", maHoaDonChinh);
        cmd.Parameters.AddWithValue("@MaHoaDonPhu", maHoaDonPhu);
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool CapNhatTongTienHoaDon(int maHoaDon, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = @"UPDATE HOA_DON 
                       SET TongTien = (SELECT COALESCE(SUM(ThanhTien), 0) FROM CHI_TIET_HOA_DON WHERE MaHoaDon = @MaHoaDon),
                           ThanhTien = (SELECT COALESCE(SUM(ThanhTien), 0) FROM CHI_TIET_HOA_DON WHERE MaHoaDon = @MaHoaDon) - TienGiam
                       WHERE MaHoaDon = @MaHoaDon";
        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool DongHoaDonPhu(int maHoaDonPhu, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = "UPDATE HOA_DON SET TrangThai = 'DaGopBan' WHERE MaHoaDon = @MaHoaDonPhu";
        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@MaHoaDonPhu", maHoaDonPhu);
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool ChuyenMonSangHoaDonChinh(int maHoaDonPhu, int maHoaDonChinh, SqliteConnection conn, SqliteTransaction trans)
    {
        ChuyenChiTietMon(maHoaDonPhu, maHoaDonChinh, conn, trans);
        CapNhatTongTienHoaDon(maHoaDonChinh, conn, trans);
        DongHoaDonPhu(maHoaDonPhu, conn, trans);
        return true;
    }

    public bool CapNhatTrangThaiBan(int maBan, string trangThaiMoi, string tenNhom, SqliteConnection conn, SqliteTransaction trans)
    {
        string sql = "UPDATE BAN SET TrangThai = @TrangThai, TenNhom = @TenNhom WHERE MaBan = @MaBan";
        using var cmd = new SqliteCommand(sql, conn, trans);
        cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
        cmd.Parameters.AddWithValue("@TenNhom", string.IsNullOrWhiteSpace(tenNhom) ? DBNull.Value : tenNhom.Trim());
        cmd.Parameters.AddWithValue("@MaBan", maBan);
        return cmd.ExecuteNonQuery() > 0;
    }

    public bool KiemTraTrungTenNhom(string tenNhom)
    {
        if (string.IsNullOrWhiteSpace(tenNhom)) return false;

        using var conn = DBConnect.GetConnection();
        string sql = "SELECT COUNT(1) FROM BAN WHERE TenNhom = @TenNhom";
        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TenNhom", tenNhom.Trim());
        return Convert.ToInt32(cmd.ExecuteScalar() ?? 0) > 0;
    }

    public bool GhiLichSuGopBan(int maBanNguon, int maBanDich, int maNhanVien, string lyDo, int maHoaDon, SqliteConnection conn, SqliteTransaction trans)
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
        cmd.Parameters.AddWithValue("@LoaiThaoTac", "Gộp bàn");
        cmd.Parameters.AddWithValue("@LyDo", string.IsNullOrWhiteSpace(lyDo) ? "Gộp bàn phục vụ nhóm khách" : lyDo.Trim());

        return cmd.ExecuteNonQuery() > 0;
    }

    public bool KiemTraCoBanDaGop(List<int> dsMaBan, SqliteConnection conn)
    {
        if (dsMaBan == null || dsMaBan.Count == 0) return false;

        string danhSachId = string.Join(",", dsMaBan);
        string sqlCheckGop = $"SELECT COUNT(1) FROM BAN WHERE TrangThai = 'GopBan' AND MaBan IN ({danhSachId})";
        using var cmdCheck = new SqliteCommand(sqlCheckGop, conn);
        long soBanDaGop = Convert.ToInt64(cmdCheck.ExecuteScalar() ?? 0);
        return soBanDaGop > 0;
    }

    public bool ThucHienGopBan(List<int> dsMaBan, int maNhanVien, string tenNhom, string ghiChu, out string thongBaoLoi)
    {
        thongBaoLoi = string.Empty;

        if (dsMaBan == null || dsMaBan.Count < 2)
        {
            thongBaoLoi = "Vui lòng chọn ít nhất 2 bàn để thực hiện gộp bàn.";
            return false;
        }

        try
        {
            using var conn = DBConnect.GetConnection();

            if (KiemTraCoBanDaGop(dsMaBan, conn))
            {
                thongBaoLoi = "Có bàn trong danh sách chọn đã được gộp trước đó. Không thể gộp đè!";
                return false;
            }

            using var trans = conn.BeginTransaction();

            var banVaHoaDon = LayHoaDonChuaThanhToanCuaCacBan(dsMaBan, conn, trans);
            var dsHoaDonDuyNhat = banVaHoaDon.Values.Distinct().ToList();

            int maHoaDonChinh = 0;

            if (dsHoaDonDuyNhat.Count == 0)
            {
                maHoaDonChinh = TaoHoaDonMoi(maNhanVien, conn, trans);
                if (maHoaDonChinh <= 0)
                {
                    trans.Rollback();
                    thongBaoLoi = "Không thể tạo hóa đơn mới cho nhóm bàn.";
                    return false;
                }
            }
            else
            {
                maHoaDonChinh = dsHoaDonDuyNhat[0];

                for (int i = 1; i < dsHoaDonDuyNhat.Count; i++)
                {
                    int hdPhu = dsHoaDonDuyNhat[i];
                    ChuyenMonSangHoaDonChinh(hdPhu, maHoaDonChinh, conn, trans);
                }
            }

            int maBanChinh = dsMaBan[0];
            string lyDoLog = !string.IsNullOrWhiteSpace(tenNhom)
                ? $"Gộp vào {tenNhom.Trim()}. {ghiChu.Trim()}".Trim()
                : (string.IsNullOrWhiteSpace(ghiChu) ? "Gộp nhóm bàn" : ghiChu.Trim());

            foreach (int maBan in dsMaBan)
            {
                LienKetBanVaoHoaDon(maHoaDonChinh, maBan, conn, trans);
                CapNhatTrangThaiBan(maBan, "GopBan", tenNhom, conn, trans);

                if (maBan != maBanChinh)
                {
                    GhiLichSuGopBan(maBan, maBanChinh, maNhanVien, lyDoLog, maHoaDonChinh, conn, trans);
                }
            }

            trans.Commit();
            return true;
        }
        catch (Exception ex)
        {
            thongBaoLoi = "Lỗi trong quá trình gộp bàn: " + ex.Message;
            return false;
        }
    }
}
