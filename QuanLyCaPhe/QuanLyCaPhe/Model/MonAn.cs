namespace QuanLyCaPhe.Model;

public class MonAn
{
    public int MaMon { get; set; }
    public int MaDanhMuc { get; set; }
    public string TenMon { get; set; } = string.Empty;
    public decimal DonGia { get; set; }
    public string DonViTinh { get; set; } = "Phần";
    public string TrangThai { get; set; } = "Còn bán";
    public byte[]? HinhAnh { get; set; }

    public MonAn()
    {
    }

    public MonAn(int maMon, int maDanhMuc, string tenMon, decimal donGia, string donViTinh = "Phần", string trangThai = "Còn bán", byte[]? hinhAnh = null)
    {
        MaMon = maMon;
        MaDanhMuc = maDanhMuc;
        TenMon = tenMon;
        DonGia = donGia;
        DonViTinh = donViTinh;
        TrangThai = trangThai;
        HinhAnh = hinhAnh;
    }

    public override string ToString()
    {
        return $"#{MaMon} | {TenMon} - {DonGia:N0} VNĐ/{DonViTinh} ({TrangThai})";
    }
}
