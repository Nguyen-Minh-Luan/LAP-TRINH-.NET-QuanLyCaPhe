using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class BanDAO
{
    private Ban MappingtoBan(SqliteDataReader reader)
    {
        return new Ban
        {
            MaBan = Convert.ToInt32(reader["MaBan"]),
            MaKhuVuc = Convert.ToInt32(reader["MaKhuVuc"]),
            TenBan = reader["TenBan"].ToString() ?? "",
            TrangThai = reader["TrangThai"].ToString() ?? "",
            SoChoNgoi = Convert.ToInt32(reader["SoChoNgoi"]),
            TenNhom = reader["TenNhom"] == DBNull.Value ? null : reader["TenNhom"].ToString()
        };
    }
    public DataTable timKiemTenBan(string keyword)
    {
        DataTable dt = new DataTable();
        using var conn = DBConnect.GetConnection();
        string sql = @"SELECT MaBan, MaKhuVuc, TenBan, SoChoNgoi, TrangThai 
                        FROM BAN
                        WHERE TenBan LIKE @TuKhoa";
        using var command = new SqliteCommand(sql, conn);
        command.Parameters.AddWithValue("@TuKhoa", $"%{keyword}%");
        using var reader = command.ExecuteReader();
        dt.Load(reader);
        return dt;
    }
    public List<Ban> LayDanhSachBan()
    {
        var danhSach = new List<Ban>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaBan, MaKhuVuc, TenBan, TrangThai, SoChoNgoi, TenNhom FROM BAN";

            using var cmd = new SqliteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                danhSach.Add(MappingtoBan(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }

    public List<Ban> LayDanhSachBanTheoKhuVuc(int maKhuVuc)
    {
        var danhSach = new List<Ban>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaBan, MaKhuVuc, TenBan, TrangThai, SoChoNgoi, TenNhom FROM BAN WHERE MaKhuVuc = @MaKhuVuc";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                danhSach.Add(MappingtoBan(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }

    public Ban? LayBanTheoMa(int maBan)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaBan, MaKhuVuc, TenBan, TrangThai, SoChoNgoi, TenNhom FROM BAN WHERE MaBan = @MaBan";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaBan", maBan);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MappingtoBan(reader);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public bool ThemBan(Ban ban)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"INSERT INTO BAN (MaKhuVuc, TenBan, TrangThai, SoChoNgoi) 
                           VALUES (@MaKhuVuc, @TenBan, @TrangThai, @SoChoNgoi)";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKhuVuc", ban.MaKhuVuc);
            cmd.Parameters.AddWithValue("@TenBan", ban.TenBan);
            cmd.Parameters.AddWithValue("@TrangThai", ban.TrangThai);
            cmd.Parameters.AddWithValue("@SoChoNgoi", ban.SoChoNgoi);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool CapNhatBan(Ban ban)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"UPDATE BAN 
                           SET MaKhuVuc = @MaKhuVuc, 
                               TenBan = @TenBan, 
                               TrangThai = @TrangThai, 
                               SoChoNgoi = @SoChoNgoi 
                           WHERE MaBan = @MaBan";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKhuVuc", ban.MaKhuVuc);
            cmd.Parameters.AddWithValue("@TenBan", ban.TenBan);
            cmd.Parameters.AddWithValue("@TrangThai", ban.TrangThai);
            cmd.Parameters.AddWithValue("@SoChoNgoi", ban.SoChoNgoi);
            cmd.Parameters.AddWithValue("@MaBan", ban.MaBan);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool CapNhatTrangThai(int maBan, string trangThaiMoi)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = trangThaiMoi == "Trong"
                ? "UPDATE BAN SET TrangThai = @TrangThai, TenNhom = NULL WHERE MaBan = @MaBan"
                : "UPDATE BAN SET TrangThai = @TrangThai WHERE MaBan = @MaBan";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
            cmd.Parameters.AddWithValue("@MaBan", maBan);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool XoaBan(int maBan)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "DELETE FROM BAN WHERE MaBan = @MaBan";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaBan", maBan);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool GiaiPhongCacBanTheoHoaDon(int maHoaDon)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"UPDATE BAN 
                           SET TrangThai = 'Trong', TenNhom = NULL 
                           WHERE MaBan IN (SELECT MaBan FROM HOA_DON_BAN WHERE MaHoaDon = @MaHoaDon)";

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
}

