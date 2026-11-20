using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class MonAnDAO
{
    private MonAn MappingToMonAn(SqliteDataReader reader)
    {
        return new MonAn
        {
            MaMon = Convert.ToInt32(reader["MaMon"]),
            MaDanhMuc = Convert.ToInt32(reader["MaDanhMuc"]),
            TenMon = reader["TenMon"].ToString() ?? "",
            DonGia = Convert.ToDecimal(reader["DonGia"]),
            DonViTinh = reader["DonViTinh"].ToString() ?? "",
            TrangThai = reader["TrangThai"].ToString() ?? ""
        };
    }

    public List<MonAn> LayDanhSachMonAn()
    {
        var danhSach = new List<MonAn>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaMon, MaDanhMuc, TenMon, DonGia, DonViTinh, TrangThai FROM MON_AN";

            using var cmd = new SqliteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                danhSach.Add(MappingToMonAn(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }

    public List<MonAn> LayMonAnTheoDanhMuc(int maDanhMuc)
    {
        var danhSach = new List<MonAn>();

        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaMon, MaDanhMuc, TenMon, DonGia, DonViTinh, TrangThai FROM MON_AN WHERE MaDanhMuc = @MaDanhMuc";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                danhSach.Add(MappingToMonAn(reader));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return danhSach;
    }

    public MonAn? LayMonAnTheoMa(int maMon)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "SELECT MaMon, MaDanhMuc, TenMon, DonGia, DonViTinh, TrangThai FROM MON_AN WHERE MaMon = @MaMon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaMon", maMon);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MappingToMonAn(reader);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public bool ThemMonAn(MonAn mon)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"INSERT INTO MON_AN (MaDanhMuc, TenMon, DonGia, DonViTinh, TrangThai) 
                           VALUES (@MaDanhMuc, @TenMon, @DonGia, @DonViTinh, @TrangThai)";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDanhMuc", mon.MaDanhMuc);
            cmd.Parameters.AddWithValue("@TenMon", mon.TenMon);
            cmd.Parameters.AddWithValue("@DonGia", mon.DonGia);
            cmd.Parameters.AddWithValue("@DonViTinh", mon.DonViTinh);
            cmd.Parameters.AddWithValue("@TrangThai", mon.TrangThai);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool CapNhatMonAn(MonAn mon)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = @"UPDATE MON_AN 
                           SET MaDanhMuc = @MaDanhMuc, 
                               TenMon = @TenMon, 
                               DonGia = @DonGia, 
                               DonViTinh = @DonViTinh, 
                               TrangThai = @TrangThai 
                           WHERE MaMon = @MaMon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDanhMuc", mon.MaDanhMuc);
            cmd.Parameters.AddWithValue("@TenMon", mon.TenMon);
            cmd.Parameters.AddWithValue("@DonGia", mon.DonGia);
            cmd.Parameters.AddWithValue("@DonViTinh", mon.DonViTinh);
            cmd.Parameters.AddWithValue("@TrangThai", mon.TrangThai);
            cmd.Parameters.AddWithValue("@MaMon", mon.MaMon);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public bool XoaMonAn(int maMon)
    {
        try
        {
            using var conn = DBConnect.GetConnection();
            string sql = "DELETE FROM MON_AN WHERE MaMon = @MaMon";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaMon", maMon);

            return cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}

