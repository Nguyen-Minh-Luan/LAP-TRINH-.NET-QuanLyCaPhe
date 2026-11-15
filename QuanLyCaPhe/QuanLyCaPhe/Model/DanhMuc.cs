namespace QuanLyCaPhe.Model;

public class DanhMuc
{
    public int MaDanhMuc { get; set; }
    public string TenDanhMuc { get; set; } = string.Empty;
    public string TrangThai { get; set; } = "Hoạt động";

    public DanhMuc()
    {
    }

    public DanhMuc(int maDanhMuc, string tenDanhMuc, string trangThai = "Hoạt động")
    {
        MaDanhMuc = maDanhMuc;
        TenDanhMuc = tenDanhMuc;
        TrangThai = trangThai;
    }

    public override string ToString()
    {
        return $"{TenDanhMuc} (Mã: {MaDanhMuc}) - {TrangThai}";
    }
}
