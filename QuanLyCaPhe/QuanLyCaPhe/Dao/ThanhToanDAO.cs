using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class ThanhToanDAO
{
    private ThanhToan MappingToThanhToan(SqliteDataReader reader)
    {
        return new ThanhToan
        {
            MaThanhToan = Convert.ToInt32(reader["MaThanhToan"]),
            MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
            NgayThanhToan = Convert.ToDateTime(reader["NgayThanhToan"]),
            SoTien = Convert.ToDecimal(reader["SoTien"]),
            PhuongThuc = reader["PhuongThuc"].ToString() ?? "Tiền mặt",
            TrangThai = reader["TrangThai"].ToString() ?? "ThanhCong"
        };
    }

    public bool ThemThanhToan(ThanhToan tt)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"INSERT INTO THANH_TOAN (MaHoaDon, NgayThanhToan, SoTien, PhuongThuc, TrangThai)
                           VALUES (@MaHoaDon, @NgayThanhToan, @SoTien, @PhuongThuc, @TrangThai)";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", tt.MaHoaDon);
            cmd.Parameters.AddWithValue("@NgayThanhToan", tt.NgayThanhToan.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@SoTien", tt.SoTien);
            cmd.Parameters.AddWithValue("@PhuongThuc", tt.PhuongThuc);
            cmd.Parameters.AddWithValue("@TrangThai", tt.TrangThai);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public List<ThanhToan> LayThanhToanTheoHoaDon(int maHoaDon)
    {
        var danhSach = new List<ThanhToan>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT MaThanhToan, MaHoaDon, NgayThanhToan, SoTien, PhuongThuc, TrangThai 
                           FROM THANH_TOAN 
                           WHERE MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                danhSach.Add(MappingToThanhToan(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }
}
