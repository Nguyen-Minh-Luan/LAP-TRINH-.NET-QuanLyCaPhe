namespace QuanLyCaPhe.Model;

public class MonAn
{
    public int MaMon { get; set; }
    public int MaDanhMuc { get; set; }
    public string TenMon { get; set; }
    public decimal DonGia { get; set; }
    public string DonViTinh { get; set; }
    public string TrangThai { get; set; }

    public MonAn()
    {
    }

    public MonAn(int maMon, int maDanhMuc, string tenMon, decimal donGia, string donViTinh, string trangThai)
    {
        MaMon = maMon;
        MaDanhMuc = maDanhMuc;
        TenMon = tenMon;
        DonGia = donGia;
        DonViTinh = donViTinh;
        TrangThai = trangThai;
    }
}