using System.Data;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Utils;
using System.Collections.Generic;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.Dao;

public class CaLamDAO
{
    public DataTable getCaLam(int maNV)
    {
        DataTable dt = new DataTable();
        using var conn = DBConnect.GetConnection();
        string bangLamViecSQL = @"SELECT CL.TenCa, CL.GioBatDau, CL.GioKetThuc, PC.NgayLam
            FROM CA_LAM CL
            JOIN PHAN_CONG PC ON CL.MaCa = PC.MaCa
            WHERE PC.MaNhanVien = @MaNhanVien";
        using var command = new SqliteCommand(bangLamViecSQL, conn);
        command.Parameters.AddWithValue("@MaNhanVien", maNV);
        using var reader = command.ExecuteReader();
        dt.Load(reader);
        return dt;
    }
    private CaLam MappingToCaLam(SqliteDataReader reader)
    {
        string gioBatDauStr = reader["GioBatDau"]?.ToString() ?? "00:00:00";
        string gioKetThucStr = reader["GioKetThuc"]?.ToString() ?? "00:00:00";

        TimeSpan.TryParse(gioBatDauStr, out TimeSpan gioBatDau);
        TimeSpan.TryParse(gioKetThucStr, out TimeSpan gioKetThuc);

        return new CaLam
        {
            MaCa = Convert.ToInt32(reader["MaCa"]),
            TenCa = reader["TenCa"]?.ToString() ?? string.Empty,
            GioBatDau = gioBatDau,
            GioKetThuc = gioKetThuc
        };
    }

    public List<CaLam> LayDanhSachCaLam()
    {
        var danhSach = new List<CaLam>();
        using var conn = DBConnect.GetConnection();
        string sql = "SELECT MaCa, TenCa, GioBatDau, GioKetThuc FROM CA_LAM ORDER BY GioBatDau ASC, MaCa ASC";

        using var cmd = new SqliteCommand(sql, conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            danhSach.Add(MappingToCaLam(reader));
        }
        return danhSach;
    }

    public List<CaLam> TimKiemCaLam(string tuKhoa)
    {
        var danhSach = new List<CaLam>();
        using var conn = DBConnect.GetConnection();
        string sql = @"SELECT MaCa, TenCa, GioBatDau, GioKetThuc 
                       FROM CA_LAM 
                       WHERE CAST(MaCa AS TEXT) LIKE @TuKhoa 
                          OR TenCa LIKE @TuKhoa 
                          OR GioBatDau LIKE @TuKhoa 
                          OR GioKetThuc LIKE @TuKhoa
                       ORDER BY GioBatDau ASC, MaCa ASC";

        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TuKhoa", $"%{tuKhoa.Trim()}%");

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            danhSach.Add(MappingToCaLam(reader));
        }
        return danhSach;
    }

    public bool KiemTraTrungTenCa(string tenCa, int maCaBoQua = 0)
    {
        using var conn = DBConnect.GetConnection();
        string sql = @"SELECT COUNT(1) FROM CA_LAM 
                       WHERE LOWER(TRIM(TenCa)) = LOWER(TRIM(@TenCa)) 
                         AND MaCa <> @MaCa";

        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TenCa", tenCa);
        cmd.Parameters.AddWithValue("@MaCa", maCaBoQua);

        long count = (long)(cmd.ExecuteScalar() ?? 0);
        return count > 0;
    }

    public bool ThemCaLam(CaLam ca)
    {
        using var conn = DBConnect.GetConnection();
        string sql = @"INSERT INTO CA_LAM (TenCa, GioBatDau, GioKetThuc) 
                       VALUES (@TenCa, @GioBatDau, @GioKetThuc)";

        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TenCa", ca.TenCa.Trim());
        cmd.Parameters.AddWithValue("@GioBatDau", ca.GioBatDau.ToString(@"hh\:mm\:ss"));
        cmd.Parameters.AddWithValue("@GioKetThuc", ca.GioKetThuc.ToString(@"hh\:mm\:ss"));

        return cmd.ExecuteNonQuery() > 0;
    }

    public bool CapNhatCaLam(CaLam ca)
    {
        using var conn = DBConnect.GetConnection();
        string sql = @"UPDATE CA_LAM 
                       SET TenCa = @TenCa, 
                           GioBatDau = @GioBatDau, 
                           GioKetThuc = @GioKetThuc 
                       WHERE MaCa = @MaCa";

        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@TenCa", ca.TenCa.Trim());
        cmd.Parameters.AddWithValue("@GioBatDau", ca.GioBatDau.ToString(@"hh\:mm\:ss"));
        cmd.Parameters.AddWithValue("@GioKetThuc", ca.GioKetThuc.ToString(@"hh\:mm\:ss"));
        cmd.Parameters.AddWithValue("@MaCa", ca.MaCa);

        return cmd.ExecuteNonQuery() > 0;
    }

    public bool XoaCaLam(int maCa)
    {
        using var conn = DBConnect.GetConnection();

        string checkRefSql = "SELECT COUNT(1) FROM PHAN_CONG WHERE MaCa = @MaCa";
        using (var checkCmd = new SqliteCommand(checkRefSql, conn))
        {
            checkCmd.Parameters.AddWithValue("@MaCa", maCa);
            long count = (long)(checkCmd.ExecuteScalar() ?? 0);
            if (count > 0)
            {
                throw new InvalidOperationException("Ca làm việc này đã được phân công cho nhân viên. Không thể xóa!");
            }
        }

        string sql = "DELETE FROM CA_LAM WHERE MaCa = @MaCa";
        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MaCa", maCa);

        return cmd.ExecuteNonQuery() > 0;
    }
}