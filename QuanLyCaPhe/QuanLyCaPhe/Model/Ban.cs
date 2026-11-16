namespace QuanLyCaPhe.Model;

public class Ban
{
    public int MaBan { get; set; }
    public int MaKhuVuc { get; set; }
    public string TenBan { get; set; } = string.Empty;
    public string TrangThai { get; set; } = "Trống";
    public int SoChoNgoi { get; set; }

    public Ban()
    {
    }

    public Ban(int maBan, int maKhuVuc, string tenBan, string trangThai = "Trống", int soChoNgoi = 4)
    {
        MaBan = maBan;
        MaKhuVuc = maKhuVuc;
        TenBan = tenBan;
        TrangThai = trangThai;
        SoChoNgoi = soChoNgoi;
    }

    public override string ToString()
    {
        return $"{TenBan} ({SoChoNgoi} chỗ) - {TrangThai} (Mã KV: {MaKhuVuc})";
    }
}
