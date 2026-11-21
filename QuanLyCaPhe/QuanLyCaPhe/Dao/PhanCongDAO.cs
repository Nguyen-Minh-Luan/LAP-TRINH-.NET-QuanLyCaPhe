using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;
using System.Data;

namespace QuanLyCaPhe.Dao;

public class PhanCongDAO
{
    public void loadThongTinCaTruc(int maNV, Label lblThoiGianTruc, Label lblTenCa)
    {
        using var conn = DBConnect.GetConnection();
        string caLamSQL = @"SELECT CL.TenCa, CL.GioBatDau, CL.GioKetThuc
            FROM PHAN_CONG PC
            JOIN CA_LAM CL ON PC.MaCa = CL.MaCa
            WHERE PC.MaNhanVien = @MaNhanVien";
        var command = new SqliteCommand(caLamSQL, conn);
        command.Parameters.AddWithValue("@MaNhanVien", maNV);
        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            lblTenCa.Text = reader["TenCa"].ToString();
            lblThoiGianTruc.Text = $"{reader["GioBatDau"]} - {reader["GioKetThuc"]}";
        }
    }
    public DataTable LayDanhSachPhanCong(string tuKhoa = "") {
        DataTable dt = new DataTable();
        using var conn = DBConnect.GetConnection();
        string sql = @"SELECT pc.MaPhanCong, pc.MaNhanVien, pc.MaCa, pc.NgayLam,
                              nv.HoTen AS TenNhanVien,
                              cl.TenCa || ' (' || substr(cl.GioBatDau, 1, 5) || ' - ' || substr(cl.GioKetThuc, 1, 5) || ')' AS TenCaHienThi
                       FROM PHAN_CONG pc
                       JOIN NHAN_VIEN nv ON pc.MaNhanVien = nv.MaNhanVien
                       JOIN CA_LAM cl ON pc.MaCa = cl.MaCa
                       WHERE (@TuKhoa = '' 
                              OR nv.HoTen LIKE @TuKhoaLike 
                              OR cl.TenCa LIKE @TuKhoaLike 
                              OR strftime('%d/%m/%Y', pc.NgayLam) LIKE @TuKhoaLike
                              OR pc.NgayLam LIKE @TuKhoaLike)
                       ORDER BY pc.NgayLam DESC, cl.GioBatDau ASC, pc.MaPhanCong DESC";

        using var cmd = new SqliteCommand(sql, conn);
        string kw = tuKhoa.Trim();
        cmd.Parameters.AddWithValue("@TuKhoa", kw);
        cmd.Parameters.AddWithValue("@TuKhoaLike", $"%{kw}%");

        using var reader = cmd.ExecuteReader();
        dt.Load(reader);
        return dt;
    }

    public bool KiemTraTrungLich(int maNhanVien, int maCa, DateTime ngayLam, int maPhanCongBoQua = 0) {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT COUNT(1) FROM PHAN_CONG
                       WHERE MaNhanVien = @MaNhanVien
                         AND MaCa = @MaCa
                         AND date(NgayLam) = date(@NgayLam)
                         AND MaPhanCong <> @MaPhanCong";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
            cmd.Parameters.AddWithValue("@MaCa", maCa);
            cmd.Parameters.AddWithValue("@NgayLam", ngayLam.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@MaPhanCong", maPhanCongBoQua);

            long count = (long)(cmd.ExecuteScalar() ?? 0);
            return count > 0;
        }
    public bool ThemPhanCong(PhanCong pc) {
        using var conn = DBConnect.GetConnection();
        string sql = @"INSERT INTO PHAN_CONG (MaNhanVien, MaCa, NgayLam)
                       VALUES (@MaNhanVien, @MaCa, @NgayLam)";

        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MaNhanVien", pc.MaNhanVien);
        cmd.Parameters.AddWithValue("@MaCa", pc.MaCa);
        cmd.Parameters.AddWithValue("@NgayLam", pc.NgayLam.ToString("yyyy-MM-dd"));

        return cmd.ExecuteNonQuery() > 0;
    }
    
    public bool CapNhatPhanCong(PhanCong pc) {
        using var conn = DBConnect.GetConnection();
        string sql = @"UPDATE PHAN_CONG
                       SET MaNhanVien = @MaNhanVien,
                           MaCa = @MaCa,
                           NgayLam = @NgayLam
                       WHERE MaPhanCong = @MaPhanCong";

        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MaNhanVien", pc.MaNhanVien);
        cmd.Parameters.AddWithValue("@MaCa", pc.MaCa);
        cmd.Parameters.AddWithValue("@NgayLam", pc.NgayLam.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@MaPhanCong", pc.MaPhanCong);

        return cmd.ExecuteNonQuery() > 0;
    }
    public bool XoaPhanCong(int maPhanCong) {
        using var conn = DBConnect.GetConnection();
        string sql = "DELETE FROM PHAN_CONG WHERE MaPhanCong = @MaPhanCong";

        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MaPhanCong", maPhanCong);

        return cmd.ExecuteNonQuery() > 0;
    }
}
        
