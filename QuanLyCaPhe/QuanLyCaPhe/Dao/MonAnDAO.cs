using System.Data;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Utils;

public class MonAnDAO
{
   public DataTable getDanhSachMon()
   {
      DataTable dt = new DataTable();
      using var conn = DBConnect.GetConnection();
      string sql = @"SELECT MA.MaMon, MA.TenMon, DM.TenDanhMuc, MA.DonGia, MA.DonViTinh, MA.TrangThai
            FROM MON_AN MA
            JOIN DANH_MUC DM ON MA.MaDanhMuc = DM.MaDanhMuc";
      using var command = new SqliteCommand(sql, conn);
      using var reader = command.ExecuteReader();
      dt.Load(reader);
      return dt;
   }

   public DataTable timKiemMon(string keyword)
   {
       DataTable dt = new DataTable();
       using var conn = DBConnect.GetConnection();
       string sql = @"
          SELECT MA.MaMon, MA.TenMon, DM.TenDanhMuc,
               MA.DonGia, MA.DonViTinh, MA.TrangThai
        FROM MON_AN MA
        JOIN DANH_MUC DM ON MA.MaDanhMuc = DM.MaDanhMuc
        WHERE MA.TenMon LIKE @TuKhoa
           OR DM.TenDanhMuc LIKE @TuKhoa
        ";
       using var command = new SqliteCommand(sql, conn);
       command.Parameters.AddWithValue("@TuKhoa", $"%{keyword.Trim()}%");
       using var reader = command.ExecuteReader();
       dt.Load(reader);
       return dt;
   }
}