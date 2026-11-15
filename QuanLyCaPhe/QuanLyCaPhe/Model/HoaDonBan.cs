namespace QuanLyCaPhe.Model;

public class HoaDonBan
{
    public int MaHoaDon { get; set; }
    public int MaBan { get; set; }
    public DateTime ThoiGianVao { get; set; }

    public HoaDonBan()
    {
    }

    public HoaDonBan(int maHoaDon, int maBan, DateTime thoiGianVao)
    {
        MaHoaDon = maHoaDon;
        MaBan = maBan;
        ThoiGianVao = thoiGianVao;
    }

    public override string ToString()
    {
        return $"HĐ #{MaHoaDon} - Bàn #{MaBan} | Giờ vào: {ThoiGianVao:dd/MM/yyyy HH:mm}";
    }
}
