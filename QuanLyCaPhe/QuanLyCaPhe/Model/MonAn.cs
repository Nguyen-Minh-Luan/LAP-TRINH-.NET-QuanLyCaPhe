namespace QuanLyCaPhe.Model;

public class MonAn
{
    public int MaMon { get; set; }
    public int MaDanhMuc { get; set; }
    public string TenMon { get; set; } = string.Empty;
    public decimal DonGia { get; set; }
    public string? HinhAnh { get; set; }
    public string TrangThai { get; set; } = "Còn hàng";

    public MonAn()
    {
    }

    public MonAn(int maMon, int maDanhMuc, string tenMon, decimal donGia, string? hinhAnh = null, string trangThai = "Còn hàng")
    {
        MaMon = maMon;
        MaDanhMuc = maDanhMuc;
        TenMon = tenMon;
        DonGia = donGia;
        HinhAnh = hinhAnh;
        TrangThai = trangThai;
    }

    public override string ToString()
    {
        return $"Mã món: {MaMon} | Danh mục: {MaDanhMuc} | {TenMon} - {DonGia:N0} VNĐ ({TrangThai})";
    }
}
