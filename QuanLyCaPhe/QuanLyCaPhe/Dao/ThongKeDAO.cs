using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Dao;

public class ThongKeDAO {
    public List<int> LayDanhSachNam() {
        var dsNam = new List<int>();
        try {
            using var conn = DBConnect.GetConnection();
            string sql = @"SELECT DISTINCT CAST(strftime('%Y', NgayTao) AS INTEGER) AS Nam
                           FROM HOA_DON
                           WHERE NgayTao IS NOT NULL
                           ORDER BY Nam DESC";

            using var cmd = new SqliteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                if (reader["Nam"] != DBNull.Value) {
                    int nam = Convert.ToInt32(reader["Nam"]);
                    if (nam > 2000 && !dsNam.Contains(nam))
                        dsNam.Add(nam);
                }
            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message); }

        int namHienTai = DateTime.Now.Year;
        if (!dsNam.Contains(namHienTai)) { dsNam.Insert(0, namHienTai); }
        return dsNam;
    }
    public DataTable ThongKeDoanhThuTheoNam(int nam) {
        DataTable dt = new DataTable();
        using var conn = DBConnect.GetConnection();

        string sql = @"SELECT CAST(strftime('%m', NgayTao) AS INTEGER) AS Thang,
                              COUNT(MaHoaDon) AS SoHoaDon,
                              IFNULL(SUM(ThanhTien), 0) AS DoanhThu
                       FROM HOA_DON
                       WHERE strftime('%Y', NgayTao) = @Nam
                         AND (TrangThai = 'DaThanhToan' OR TrangThai = 'Đã thanh toán')
                       GROUP BY Thang
                       ORDER BY Thang ASC";

        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Nam", nam.ToString());
        using var reader = cmd.ExecuteReader();
        dt.Load(reader);
        return dt;
    }
    public DataTable ThongKeMonBanChay(int nam) {
        DataTable dt = new DataTable();
        using var conn = DBConnect.GetConnection();

        string sql = @"SELECT ma.TenMon,
                              IFNULL(SUM(ct.SoLuong), 0) AS TongSoLuong,
                              IFNULL(SUM(ct.ThanhTien), 0) AS TongDoanhThu
                       FROM CHI_TIET_HOA_DON ct
                       JOIN HOA_DON hd ON ct.MaHoaDon = hd.MaHoaDon
                       JOIN MON_AN ma ON ct.MaMon = ma.MaMon
                       WHERE strftime('%Y', hd.NgayTao) = @Nam
                         AND (hd.TrangThai = 'DaThanhToan' OR hd.TrangThai = 'Đã thanh toán')
                       GROUP BY ma.MaMon, ma.TenMon
                       ORDER BY TongSoLuong DESC, TongDoanhThu DESC";

        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Nam", nam.ToString());

        using var reader = cmd.ExecuteReader();
        dt.Load(reader);
        return dt;
    }
}