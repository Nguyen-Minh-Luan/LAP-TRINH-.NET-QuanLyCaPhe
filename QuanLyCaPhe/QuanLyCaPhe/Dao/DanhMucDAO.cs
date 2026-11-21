using System.Data;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class DanhMucDAO
{
    public DataTable timKiemDanhMuc(string tk)
    {
        DataTable dt = new DataTable();
        using var conn = DBConnect.GetConnection();
        string sql = @"SELECT TenDanhMuc, MoTa
                    FROM DANH_MUC
                    WHERE TenDanhMuc LIKE @TuKhoa
        ";
        using var command = new SqliteCommand(sql, conn);
        command.Parameters.AddWithValue("@TuKhoa", $"%{tk}%");
        using var reader = command.ExecuteReader();
        dt.Load(reader);
        return dt;
    }
    private DanhMuc MappingToDanhMuc(SqliteDataReader reader)
    {
        return new DanhMuc
        {
            MaDanhMuc = Convert.ToInt32(reader["MaDanhMuc"]),
            TenDanhMuc = reader["TenDanhMuc"].ToString() ?? "",
            MoTa = reader["MoTa"] == DBNull.Value ? null : reader["MoTa"].ToString()
        };
    }

    public List<DanhMuc> LayDanhSachDanhMuc()
    {
        var danhSach = new List<DanhMuc>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaDanhMuc, TenDanhMuc, MoTa FROM DANH_MUC";

            using var cmd = new SqliteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                danhSach.Add(MappingToDanhMuc(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }

    public DanhMuc? LayDanhMucTheoMa(int maDanhMuc)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaDanhMuc, TenDanhMuc, MoTa FROM DANH_MUC WHERE MaDanhMuc = @MaDanhMuc";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MappingToDanhMuc(reader);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public bool ThemDanhMuc(DanhMuc dm)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "INSERT INTO DANH_MUC (TenDanhMuc, MoTa) VALUES (@TenDanhMuc, @MoTa)";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDanhMuc", dm.TenDanhMuc);
            cmd.Parameters.AddWithValue("@MoTa", (object?)dm.MoTa ?? DBNull.Value);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool CapNhatDanhMuc(DanhMuc dm)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "UPDATE DANH_MUC SET TenDanhMuc = @TenDanhMuc, MoTa = @MoTa WHERE MaDanhMuc = @MaDanhMuc";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenDanhMuc", dm.TenDanhMuc);
            cmd.Parameters.AddWithValue("@MoTa", (object?)dm.MoTa ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MaDanhMuc", dm.MaDanhMuc);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool XoaDanhMuc(int maDanhMuc)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "DELETE FROM DANH_MUC WHERE MaDanhMuc = @MaDanhMuc";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}

