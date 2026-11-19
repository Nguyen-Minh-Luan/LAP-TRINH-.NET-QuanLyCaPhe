using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class PhanCongDAO
{
    public void loadThongTinCaTruc(int maNV, Label lblThoiGianTruc, Label lblTenCa )
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
}