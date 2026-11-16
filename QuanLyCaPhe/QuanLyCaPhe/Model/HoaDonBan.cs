namespace QuanLyCaPhe.Model;

public class HoaDonBan
{
    public int MaHoaDonBan { get; set; }
    public int MaHoaDon { get; set; }
    public int MaBan { get; set; }
    public DateTime ThoiGianBatDau { get; set; }
    public DateTime? ThoiGianKetThuc { get; set; }

    public HoaDonBan()
    {
    }

    public HoaDonBan(int maHoaDonBan, int maHoaDon, int maBan, DateTime thoiGianBatDau, DateTime? thoiGianKetThuc = null)
    {
        MaHoaDonBan = maHoaDonBan;
        MaHoaDon = maHoaDon;
        MaBan = maBan;
        ThoiGianBatDau = thoiGianBatDau;
        ThoiGianKetThuc = thoiGianKetThuc;
    }

    public override string ToString()
    {
        string ketThuc = ThoiGianKetThuc.HasValue ? ThoiGianKetThuc.Value.ToString("dd/MM/yyyy HH:mm") : "Chưa kết thúc";
        return $"HĐ-Bàn #{MaHoaDonBan} | HĐ #{MaHoaDon} - Bàn #{MaBan} | Từ: {ThoiGianBatDau:dd/MM/yyyy HH:mm} - Đến: {ketThuc}";
    }
}
