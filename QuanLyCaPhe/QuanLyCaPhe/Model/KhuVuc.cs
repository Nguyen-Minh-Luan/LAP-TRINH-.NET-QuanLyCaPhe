namespace QuanLyCaPhe.Model;

public class KhuVuc
{
    public int MaKhuVuc { get; set; }
    public string TenKhuVuc { get; set; } = string.Empty;
    public string? MoTa { get; set; }

    public KhuVuc()
    {
    }

    public KhuVuc(int maKhuVuc, string tenKhuVuc, string? moTa = null)
    {
        MaKhuVuc = maKhuVuc;
        TenKhuVuc = tenKhuVuc;
        MoTa = moTa;
    }

    public override string ToString()
    {
        return $"{TenKhuVuc} (Mã: {MaKhuVuc})";
    }
}
