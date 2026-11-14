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
   public override string ToString()
    {
        return @$"Mã món: {MaMon} | Danh mục: {MaDanhMuc} | {TenMon} - {DonGia:N0} VNĐ/{DonViTinh} ({TrangThai})";
    }
}