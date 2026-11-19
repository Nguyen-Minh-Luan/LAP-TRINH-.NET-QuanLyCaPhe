using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class ChiTietHoaDonDAO
{
    private ChiTietHoaDon MappingToChiTiet(SqliteDataReader reader)
    {
        return new ChiTietHoaDon
        {
            MaChiTiet = Convert.ToInt32(reader["MaChiTiet"]),
            MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
            MaMon = Convert.ToInt32(reader["MaMon"]),
            SoLuong = Convert.ToInt32(reader["SoLuong"]),
            DonGia = Convert.ToDecimal(reader["DonGia"]),
            ThanhTien = Convert.ToDecimal(reader["ThanhTien"]),
            GhiChu = reader["GhiChu"] == DBNull.Value ? null : reader["GhiChu"].ToString()
        };
    }

    public List<ChiTietHoaDon> LayDanhSachChiTietTheoHoaDon(int maHoaDon)
    {
        var danhSach = new List<ChiTietHoaDon>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT MaChiTiet, MaHoaDon, MaMon, SoLuong, DonGia, ThanhTien, GhiChu 
                           FROM CHI_TIET_HOA_DON 
                           WHERE MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                danhSach.Add(MappingToChiTiet(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }

    public bool ThemChiTietHoaDon(ChiTietHoaDon ct)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"INSERT INTO CHI_TIET_HOA_DON (MaHoaDon, MaMon, SoLuong, DonGia, ThanhTien, GhiChu)
                           VALUES (@MaHoaDon, @MaMon, @SoLuong, @DonGia, @ThanhTien, @GhiChu)";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", ct.MaHoaDon);
            cmd.Parameters.AddWithValue("@MaMon", ct.MaMon);
            cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", ct.DonGia);
            cmd.Parameters.AddWithValue("@ThanhTien", ct.ThanhTien);
            cmd.Parameters.AddWithValue("@GhiChu", (object?)ct.GhiChu ?? DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool XoaChiTietTheoHoaDon(int maHoaDon)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "DELETE FROM CHI_TIET_HOA_DON WHERE MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            return cmd.ExecuteNonQuery() >= 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}
