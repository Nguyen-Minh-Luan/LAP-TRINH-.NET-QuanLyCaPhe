namespace QuanLyCaPhe.Model;

public class Ban
{
    public int MaBan { get; set; }
    public int MaKhuVuc { get; set; }
    public string TenBan { get; set; } = string.Empty;
    public string TrangThai { get; set; } = "Trống";

    public Ban()
    {
    }

    public Ban(int maBan, int maKhuVuc, string tenBan, string trangThai = "Trống")
    {
        MaBan = maBan;
        MaKhuVuc = maKhuVuc;
        TenBan = tenBan;
        TrangThai = trangThai;
    }

    public override string ToString()
    {
        return $"{TenBan} - {TrangThai} (Mã KV: {MaKhuVuc})";
    }
}
