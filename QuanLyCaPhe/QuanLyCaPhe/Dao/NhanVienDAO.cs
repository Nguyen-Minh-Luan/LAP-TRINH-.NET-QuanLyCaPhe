using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class NhanVienDAO
{
    public NhanVien? DangNhap(string tenDN, string mkDN)
    {
        using var conn = DBConnect.GetConnection();
        string checkNhanVienSQL = @"SELECT *
                                 From NHAN_VIEN
                                 WHERE TenDangNhap = @TenDangNhap
                                 AND MatKhau = @MatKhau
                                 AND TrangThai = 'Đang làm việc'";
        var command = new SqliteCommand(checkNhanVienSQL, conn);
        command.Parameters.AddWithValue("@TenDangNhap", tenDN);
        command.Parameters.AddWithValue("@MatKhau", mkDN);

        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            NhanVien nv = new NhanVien
            {
                MaNhanVien = reader.GetInt32(reader.GetOrdinal("MaNhanVien")),
                HoTen = reader.GetString(reader.GetOrdinal("HoTen")),
                TenDangNhap = reader.GetString(reader.GetOrdinal("TenDangNhap")),
                MatKhau = reader.GetString(reader.GetOrdinal("MatKhau")),
                SoDienThoai =  reader.GetString(reader.GetOrdinal("SoDienThoai")),
                VaiTro = reader.GetString(reader.GetOrdinal("VaiTro")),
                TrangThai = reader.GetString(reader.GetOrdinal("TrangThai"))
            };
            return nv;
        }
        return null;
    }

    public bool CapNhatNV(int maNV,NhanVien nv)
    {
        using var conn = DBConnect.GetConnection();
        string updateNhanVienSQL = @"UPDATE NHAN_VIEN
                                      SET HoTen = @HoTen, 
                                          SoDienThoai = @SoDienThoai,
                                          TenDangNhap = @TenDangNhap
                                          WHERE MaNhanVien = @MaNhanVien";
        var command = new SqliteCommand(updateNhanVienSQL, conn);
        command.Parameters.AddWithValue("@HoTen", nv.HoTen);
        command.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
        command.Parameters.AddWithValue("@TenDangNhap", nv.TenDangNhap);
        command.Parameters.AddWithValue("@MaNhanVien", maNV);

        return command.ExecuteNonQuery() > 0;
    }
    
}