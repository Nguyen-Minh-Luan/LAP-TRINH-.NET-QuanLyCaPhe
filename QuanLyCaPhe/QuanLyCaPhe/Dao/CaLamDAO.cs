using System.Data;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Utils;

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
}