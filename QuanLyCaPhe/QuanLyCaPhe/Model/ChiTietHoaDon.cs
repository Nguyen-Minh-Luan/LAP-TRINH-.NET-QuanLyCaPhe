namespace QuanLyCaPhe.Model;

public class ChiTietHoaDon
{
    public int MaChiTiet { get; set; }
    public int MaHoaDon { get; set; }
    public int MaMon { get; set; }
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien { get; set; }
    public string? GhiChu { get; set; }

    public ChiTietHoaDon()
    {
    }

    public ChiTietHoaDon(int maChiTiet, int maHoaDon, int maMon, int soLuong, decimal donGia, decimal? thanhTien = null, string? ghiChu = null)
    {
        MaChiTiet = maChiTiet;
        MaHoaDon = maHoaDon;
        MaMon = maMon;
        SoLuong = soLuong;
        DonGia = donGia;
        ThanhTien = thanhTien ?? (soLuong * donGia);
        GhiChu = ghiChu;
    }

    public override string ToString()
    {
        return $"CT #{MaChiTiet} | HĐ #{MaHoaDon} | Món #{MaMon} | SL: {SoLuong} x {DonGia:N0} = {ThanhTien:N0} VNĐ" +
               (string.IsNullOrEmpty(GhiChu) ? "" : $" ({GhiChu})");
    }
}
