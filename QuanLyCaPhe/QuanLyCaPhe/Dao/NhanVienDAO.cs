using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;
using System;
using System.Collections.Generic;

namespace QuanLyCaPhe.Dao;

public class NhanVienDAO
{
    public NhanVien? DangNhap(string tenDN, string mkDN)
    {
        using var conn = DBConnect.GetConnection();
        string checkNhanVienSQL = @"SELECT *
                                 FROM NHAN_VIEN
                                 WHERE TenDangNhap = @TenDangNhap
                                 AND MatKhau = @MatKhau
                                 AND TrangThai = 'Đang làm việc'";
        using var command = new SqliteCommand(checkNhanVienSQL, conn);
        command.Parameters.AddWithValue("@TenDangNhap", tenDN);
        command.Parameters.AddWithValue("@MatKhau", mkDN);

        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            return MapNhanVien(reader);
        }
        return null;
    }

    public List<NhanVien> LayDanhSachNhanVien()
    {
        var danhSach = new List<NhanVien>();
        using var conn = DBConnect.GetConnection();
        string sql = "SELECT * FROM NHAN_VIEN ORDER BY MaNhanVien DESC";

        using var command = new SqliteCommand(sql, conn);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            danhSach.Add(MapNhanVien(reader));
        }
        return danhSach;
    }

    public List<NhanVien> TimKiemNhanVien(string tuKhoa, string vaiTro = "Tất cả")
    {
        var danhSach = new List<NhanVien>();
        using var conn = DBConnect.GetConnection();
        string sql = @"SELECT * FROM NHAN_VIEN 
                       WHERE (HoTen LIKE @TuKhoa OR TenDangNhap LIKE @TuKhoa OR IFNULL(SoDienThoai, '') LIKE @TuKhoa)
                         AND (@VaiTro = 'Tất cả' OR VaiTro = @VaiTro)
                       ORDER BY MaNhanVien DESC";

        using var command = new SqliteCommand(sql, conn);
        command.Parameters.AddWithValue("@TuKhoa", $"%{tuKhoa.Trim()}%");
        command.Parameters.AddWithValue("@VaiTro", vaiTro);

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            danhSach.Add(MapNhanVien(reader));
        }
        return danhSach;
    }

    public bool KiemTraTrungTenDangNhap(string tenDN, int maNVBoQua = 0)
    {
        using var conn = DBConnect.GetConnection();
        string sql = @"SELECT COUNT(1) FROM NHAN_VIEN 
                       WHERE LOWER(TenDangNhap) = LOWER(@TenDangNhap) 
                         AND MaNhanVien <> @MaNhanVien";

        using var command = new SqliteCommand(sql, conn);
        command.Parameters.AddWithValue("@TenDangNhap", tenDN.Trim());
        command.Parameters.AddWithValue("@MaNhanVien", maNVBoQua);

        long count = (long)(command.ExecuteScalar() ?? 0);
        return count > 0;
    }

    public bool ThemNhanVien(NhanVien nv)
    {
        using var conn = DBConnect.GetConnection();
        string insertSQL = @"INSERT INTO NHAN_VIEN (HoTen, TenDangNhap, MatKhau, SoDienThoai, VaiTro, TrangThai)
                             VALUES (@HoTen, @TenDangNhap, @MatKhau, @SoDienThoai, @VaiTro, @TrangThai)";

        using var command = new SqliteCommand(insertSQL, conn);
        command.Parameters.AddWithValue("@HoTen", nv.HoTen.Trim());
        command.Parameters.AddWithValue("@TenDangNhap", nv.TenDangNhap.Trim());
        command.Parameters.AddWithValue("@MatKhau", nv.MatKhau);
        command.Parameters.AddWithValue("@SoDienThoai", string.IsNullOrWhiteSpace(nv.SoDienThoai) ? DBNull.Value : nv.SoDienThoai.Trim());
        command.Parameters.AddWithValue("@VaiTro", nv.VaiTro);
        command.Parameters.AddWithValue("@TrangThai", string.IsNullOrWhiteSpace(nv.TrangThai) ? "Đang làm việc" : nv.TrangThai);

        return command.ExecuteNonQuery() > 0;
    }

    public bool CapNhatNV(int maNV, NhanVien nv)
    {
        using var conn = DBConnect.GetConnection();
        string updateNhanVienSQL = @"UPDATE NHAN_VIEN
                                     SET HoTen = @HoTen, 
                                         SoDienThoai = @SoDienThoai,
                                         TenDangNhap = @TenDangNhap,
                                         VaiTro = @VaiTro,
                                         TrangThai = @TrangThai
                                     WHERE MaNhanVien = @MaNhanVien";
        using var command = new SqliteCommand(updateNhanVienSQL, conn);
        command.Parameters.AddWithValue("@HoTen", nv.HoTen.Trim());
        command.Parameters.AddWithValue("@SoDienThoai", string.IsNullOrWhiteSpace(nv.SoDienThoai) ? DBNull.Value : nv.SoDienThoai.Trim());
        command.Parameters.AddWithValue("@TenDangNhap", nv.TenDangNhap.Trim());
        command.Parameters.AddWithValue("@VaiTro", nv.VaiTro);
        command.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
        command.Parameters.AddWithValue("@MaNhanVien", maNV);

        return command.ExecuteNonQuery() > 0;
    }

    public bool capNhatMKNV(int maNV, string newMK)
    {
        using var conn = DBConnect.GetConnection();
        string updateMKNVSQL = @"UPDATE NHAN_VIEN
                                 SET MatKhau = @mkMoi
                                 WHERE MaNhanVien = @MaNhanVien";
        using var command = new SqliteCommand(updateMKNVSQL, conn);
        command.Parameters.AddWithValue("@mkMoi", newMK);
        command.Parameters.AddWithValue("@MaNhanVien", maNV);
        return command.ExecuteNonQuery() > 0;
    }

    public bool XoaNhanVien(int maNV)
    {
        using var conn = DBConnect.GetConnection();

        string checkRefSQL = @"SELECT 
            (SELECT COUNT(1) FROM HOA_DON WHERE MaNhanVien = @MaNhanVien) +
            (SELECT COUNT(1) FROM PHAN_CONG WHERE MaNhanVien = @MaNhanVien) +
            (SELECT COUNT(1) FROM LICH_SU_CHUYEN_BAN WHERE MaNhanVien = @MaNhanVien)";

        using (var checkCmd = new SqliteCommand(checkRefSQL, conn))
        {
            checkCmd.Parameters.AddWithValue("@MaNhanVien", maNV);
            long count = (long)(checkCmd.ExecuteScalar() ?? 0);
            if (count > 0)
            {
                throw new InvalidOperationException("Nhân viên này đã có dữ liệu hóa đơn hoặc lịch phân công. Vui lòng đổi trạng thái thành 'Nghỉ việc' thay vì xóa!");
            }
        }

        string deleteSQL = "DELETE FROM NHAN_VIEN WHERE MaNhanVien = @MaNhanVien";
        using var command = new SqliteCommand(deleteSQL, conn);
        command.Parameters.AddWithValue("@MaNhanVien", maNV);
        return command.ExecuteNonQuery() > 0;
    }

    private static NhanVien MapNhanVien(SqliteDataReader reader)
    {
        int colSdt = reader.GetOrdinal("SoDienThoai");
        return new NhanVien
        {
            MaNhanVien = reader.GetInt32(reader.GetOrdinal("MaNhanVien")),
            HoTen = reader.GetString(reader.GetOrdinal("HoTen")),
            TenDangNhap = reader.GetString(reader.GetOrdinal("TenDangNhap")),
            MatKhau = reader.GetString(reader.GetOrdinal("MatKhau")),
            SoDienThoai = reader.IsDBNull(colSdt) ? string.Empty : reader.GetString(colSdt),
            VaiTro = reader.GetString(reader.GetOrdinal("VaiTro")),
            TrangThai = reader.GetString(reader.GetOrdinal("TrangThai"))
        };
    }
}