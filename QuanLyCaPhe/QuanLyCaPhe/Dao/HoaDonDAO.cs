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
}
