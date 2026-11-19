using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class KhuVucDAO
{
    private KhuVuc MappingtoKhuVuc(SqliteDataReader reader)
    {
        return new KhuVuc
        {
            MaKhuVuc = Convert.ToInt32(reader["MaKhuVuc"]),
            TenKhuVuc = reader["TenKhuVuc"].ToString() ?? "",
            MoTa = reader["MoTa"] == DBNull.Value ? null : reader["MoTa"].ToString()
        };
    }

    public List<KhuVuc> LayDanhSachKhuVuc()
    {
        var danhSach = new List<KhuVuc>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaKhuVuc, TenKhuVuc, MoTa FROM KHU_VUC";

            using var cmd = new SqliteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                danhSach.Add(MappingtoKhuVuc(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }

    public KhuVuc? LayKhuVucTheoMa(int maKhuVuc)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaKhuVuc, TenKhuVuc, MoTa FROM KHU_VUC WHERE MaKhuVuc = @MaKhuVuc";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MappingtoKhuVuc(reader);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public bool ThemKhuVuc(KhuVuc kv)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "INSERT INTO KHU_VUC (TenKhuVuc, MoTa) VALUES (@TenKhuVuc, @MoTa)";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenKhuVuc", kv.TenKhuVuc);
            cmd.Parameters.AddWithValue("@MoTa", (object?)kv.MoTa ?? DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool CapNhatKhuVuc(KhuVuc kv)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "UPDATE KHU_VUC SET TenKhuVuc = @TenKhuVuc, MoTa = @MoTa WHERE MaKhuVuc = @MaKhuVuc";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenKhuVuc", kv.TenKhuVuc);
            cmd.Parameters.AddWithValue("@MoTa", (object?)kv.MoTa ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MaKhuVuc", kv.MaKhuVuc);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool XoaKhuVuc(int maKhuVuc)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "DELETE FROM KHU_VUC WHERE MaKhuVuc = @MaKhuVuc";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}
