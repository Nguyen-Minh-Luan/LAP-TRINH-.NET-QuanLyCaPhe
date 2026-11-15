namespace QuanLyCaPhe.Model;

public class NguyenLieu
{
    public int MaNguyenLieu { get; set; }
    public string TenNguyenLieu { get; set; } = string.Empty;
    public string DonViTinh { get; set; } = string.Empty;
    public decimal SoLuongTon { get; set; }
    public decimal GiaNhap { get; set; }

    public NguyenLieu()
    {
    }

    public NguyenLieu(int maNguyenLieu, string tenNguyenLieu, string donViTinh, decimal soLuongTon, decimal giaNhap)
    {
        MaNguyenLieu = maNguyenLieu;
        TenNguyenLieu = tenNguyenLieu;
        DonViTinh = donViTinh;
        SoLuongTon = soLuongTon;
        GiaNhap = giaNhap;
    }

    public override string ToString()
    {
        return $"{TenNguyenLieu} (Mã: {MaNguyenLieu}) | Tồn: {SoLuongTon:N2} {DonViTinh} | Giá nhập: {GiaNhap:N0} VNĐ";
    }
}
