namespace QuanLyCaPhe.Model;

public class DanhMuc
{
    public int MaDanhMuc { get; set; }
    public string TenDanhMuc { get; set; } = string.Empty;
    public string? MoTa { get; set; }

    public DanhMuc()
    {
    }

    public DanhMuc(int maDanhMuc, string tenDanhMuc, string? moTa = null)
    {
        MaDanhMuc = maDanhMuc;
        TenDanhMuc = tenDanhMuc;
        MoTa = moTa;
    }

    public override string ToString()
    {
        return $"{TenDanhMuc} (Mã: {MaDanhMuc})";
    }
}
