using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class HoaDonDAO
{
    private HoaDon MappingToHoaDon(SqliteDataReader reader)
    {
        return new HoaDon
        {
            MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
            MaNhanVien = Convert.ToInt32(reader["MaNhanVien"]),
            NgayTao = Convert.ToDateTime(reader["NgayTao"]),
            TongTien = Convert.ToDecimal(reader["TongTien"]),
            TienGiam = Convert.ToDecimal(reader["TienGiam"]),
            ThanhTien = Convert.ToDecimal(reader["ThanhTien"]),
            TrangThai = reader["TrangThai"].ToString() ?? ""
        };
    }

    public List<HoaDon> LayDanhSachHoaDon()
    {
        var danhSach = new List<HoaDon>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT MaHoaDon, MaNhanVien, NgayTao, TongTien, TienGiam, ThanhTien, TrangThai 
                           FROM HOA_DON 
                           ORDER BY MaHoaDon DESC";

            using var cmd = new SqliteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                danhSach.Add(MappingToHoaDon(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }

    public HoaDon? LayHoaDonTheoMa(int maHoaDon)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT MaHoaDon, MaNhanVien, NgayTao, TongTien, TienGiam, ThanhTien, TrangThai 
                           FROM HOA_DON 
                           WHERE MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MappingToHoaDon(reader);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public int ThemHoaDon(HoaDon hd)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"INSERT INTO HOA_DON (MaNhanVien, NgayTao, TongTien, TienGiam, ThanhTien, TrangThai)
                           VALUES (@MaNhanVien, @NgayTao, @TongTien, @TienGiam, @ThanhTien, @TrangThai);
                           SELECT last_insert_rowid();";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNhanVien", hd.MaNhanVien);
            cmd.Parameters.AddWithValue("@NgayTao", hd.NgayTao.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
            cmd.Parameters.AddWithValue("@TienGiam", hd.TienGiam);
            cmd.Parameters.AddWithValue("@ThanhTien", hd.ThanhTien);
            cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);

            object? result = cmd.ExecuteScalar();
            if (result != null && long.TryParse(result.ToString(), out long newId))
            {
                return (int)newId;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return -1;
    }

    public bool CapNhatHoaDon(HoaDon hd)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"UPDATE HOA_DON 
                           SET TongTien = @TongTien, 
                               TienGiam = @TienGiam, 
                               ThanhTien = @ThanhTien, 
                               TrangThai = @TrangThai 
                           WHERE MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
            cmd.Parameters.AddWithValue("@TienGiam", hd.TienGiam);
            cmd.Parameters.AddWithValue("@ThanhTien", hd.ThanhTien);
            cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
            cmd.Parameters.AddWithValue("@MaHoaDon", hd.MaHoaDon);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool CapNhatTrangThai(int maHoaDon, string trangThaiMoi)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "UPDATE HOA_DON SET TrangThai = @TrangThai WHERE MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool XoaHoaDon(int maHoaDon)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "DELETE FROM HOA_DON WHERE MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public HoaDon? LayHoaDonChuaThanhToanTheoBan(int maBan)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT hd.MaHoaDon, hd.MaNhanVien, hd.NgayTao, hd.TongTien, hd.TienGiam, hd.ThanhTien, hd.TrangThai 
                           FROM HOA_DON hd
                           JOIN HOA_DON_BAN hdb ON hd.MaHoaDon = hdb.MaHoaDon
                           WHERE hdb.MaBan = @MaBan 
                             AND (hd.TrangThai = 'ChuaThanhToan' OR hd.TrangThai = 'Chưa thanh toán')
                           ORDER BY hd.MaHoaDon DESC LIMIT 1";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaBan", maBan);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MappingToHoaDon(reader);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public bool LienKetHoaDonBan(int maHoaDon, int maBan)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"INSERT INTO HOA_DON_BAN (MaHoaDon, MaBan, ThoiGianBatDau)
                           VALUES (@MaHoaDon, @MaBan, @ThoiGianBatDau)";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            cmd.Parameters.AddWithValue("@MaBan", maBan);
            cmd.Parameters.AddWithValue("@ThoiGianBatDau", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool ChotThanhToanHoaDon(int maHoaDon, decimal tongTien, decimal tienGiam, decimal thanhTien)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"UPDATE HOA_DON 
                           SET TongTien = @TongTien, 
                               TienGiam = @TienGiam, 
                               ThanhTien = @ThanhTien, 
                               TrangThai = 'DaThanhToan' 
                           WHERE MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TongTien", tongTien);
            cmd.Parameters.AddWithValue("@TienGiam", tienGiam);
            cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool KetThucHoaDonBan(int maHoaDon)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"UPDATE HOA_DON_BAN 
                           SET ThoiGianKetThuc = @ThoiGianKetThuc 
                           WHERE MaHoaDon = @MaHoaDon AND (ThoiGianKetThuc IS NULL OR ThoiGianKetThuc = '')";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ThoiGianKetThuc", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public List<HoaDonLichSuDTO> LayDanhSachHoaDonLichSu()
    {
        var danhSach = new List<HoaDonLichSuDTO>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT 
                               hd.MaHoaDon,
                               hd.NgayTao,
                               hd.TongTien,
                               hd.TienGiam,
                               hd.ThanhTien,
                               hd.TrangThai,
                               COALESCE(nv.HoTen, 'Nhân viên #' || hd.MaNhanVien) AS TenThuNgan,
                               COALESCE(tt.PhuongThuc, 'Tiền mặt') AS PhuongThucThanhToan,
                               GROUP_CONCAT(DISTINCT COALESCE(NULLIF(b.TenNhom, ''), b.TenBan)) AS DanhSachBan
                           FROM HOA_DON hd
                           LEFT JOIN NHAN_VIEN nv ON hd.MaNhanVien = nv.MaNhanVien
                           LEFT JOIN THANH_TOAN tt ON hd.MaHoaDon = tt.MaHoaDon
                           LEFT JOIN HOA_DON_BAN hdb ON hd.MaHoaDon = hdb.MaHoaDon
                           LEFT JOIN BAN b ON hdb.MaBan = b.MaBan
                           WHERE hd.TrangThai = 'DaThanhToan'
                           GROUP BY hd.MaHoaDon
                           ORDER BY hd.MaHoaDon DESC";

            using (var cmd = new SqliteCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    decimal tongTien = Convert.ToDecimal(reader["TongTien"]);
                    decimal tienGiam = Convert.ToDecimal(reader["TienGiam"]);
                    decimal giamGiaPhanTram = tongTien > 0 ? (tienGiam / tongTien * 100m) : 0;

                    var item = new HoaDonLichSuDTO
                    {
                        MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
                        NgayTao = Convert.ToDateTime(reader["NgayTao"]),
                        TongTien = tongTien,
                        TienGiam = tienGiam,
                        ThanhTien = Convert.ToDecimal(reader["ThanhTien"]),
                        GiamGiaPhanTram = Math.Round(giamGiaPhanTram, 1),
                        TenThuNgan = reader["TenThuNgan"]?.ToString() ?? "",
                        PhuongThucThanhToan = reader["PhuongThucThanhToan"]?.ToString() ?? "Tiền mặt",
                        TenBan = reader["DanhSachBan"]?.ToString() ?? "Mang về"
                    };

                    danhSach.Add(item);
                }
            }

            foreach (var hd in danhSach)
            {
                hd.DanhSachMon = LayChiTietMonTheoHoaDon(hd.MaHoaDon, conn);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }

    private List<ChiTietMonLichSuDTO> LayChiTietMonTheoHoaDon(int maHoaDon, SqliteConnection conn)
    {
        var danhSach = new List<ChiTietMonLichSuDTO>();
        try
        {
            string sql = @"SELECT m.TenMon, ct.SoLuong, ct.DonGia, ct.ThanhTien 
                           FROM CHI_TIET_HOA_DON ct
                           JOIN MON_AN m ON ct.MaMon = m.MaMon
                           WHERE ct.MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                danhSach.Add(new ChiTietMonLichSuDTO
                {
                    TenMon = reader["TenMon"]?.ToString() ?? "",
                    SoLuong = Convert.ToInt32(reader["SoLuong"]),
                    DonGia = Convert.ToDecimal(reader["DonGia"])
                });
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return danhSach;
    }
}

public class HoaDonLichSuDTO
{
    public int MaHoaDon { get; set; }
    public DateTime NgayTao { get; set; }
    public decimal TongTien { get; set; }
    public decimal TienGiam { get; set; }
    public decimal ThanhTien { get; set; }
    public decimal GiamGiaPhanTram { get; set; }
    public string TenThuNgan { get; set; } = string.Empty;
    public string PhuongThucThanhToan { get; set; } = "Tiền mặt";
    public string TenBan { get; set; } = string.Empty;
    public List<ChiTietMonLichSuDTO> DanhSachMon { get; set; } = new();
}

public class ChiTietMonLichSuDTO
{
    public string TenMon { get; set; } = string.Empty;
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
}
