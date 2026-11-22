using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class GiamGiaDAO
{
    private GiamGia MappingToGiamGia(SqliteDataReader reader)
    {
        return new GiamGia
        {
            MaGiamGia = Convert.ToInt32(reader["MaGiamGia"]),
            MaHoaDon = Convert.ToInt32(reader["MaHoaDon"]),
            MaNhanVien = Convert.ToInt32(reader["MaNhanVien"]),
            LoaiGiamGia = reader["LoaiGiamGia"].ToString() ?? "Phần trăm",
            GiaTriGiam = Convert.ToDecimal(reader["GiaTriGiam"]),
            LyDo = reader["LyDo"] != DBNull.Value ? reader["LyDo"].ToString() : null
        };
    }

    public bool ThemGiamGia(GiamGia gg)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"INSERT INTO GIAM_GIA (MaHoaDon, MaNhanVien, LoaiGiamGia, GiaTriGiam, LyDo)
                           VALUES (@MaHoaDon, @MaNhanVien, @LoaiGiamGia, @GiaTriGiam, @LyDo)";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", gg.MaHoaDon);
            cmd.Parameters.AddWithValue("@MaNhanVien", gg.MaNhanVien);
            cmd.Parameters.AddWithValue("@LoaiGiamGia", gg.LoaiGiamGia);
            cmd.Parameters.AddWithValue("@GiaTriGiam", gg.GiaTriGiam);
            cmd.Parameters.AddWithValue("@LyDo", (object?)gg.LyDo ?? DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public List<GiamGia> LayGiamGiaTheoHoaDon(int maHoaDon)
    {
        var danhSach = new List<GiamGia>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT MaGiamGia, MaHoaDon, MaNhanVien, LoaiGiamGia, GiaTriGiam, LyDo 
                           FROM GIAM_GIA 
                           WHERE MaHoaDon = @MaHoaDon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                danhSach.Add(MappingToGiamGia(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }
}
