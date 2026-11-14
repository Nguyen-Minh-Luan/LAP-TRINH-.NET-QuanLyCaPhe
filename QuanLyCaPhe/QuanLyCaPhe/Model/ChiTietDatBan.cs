namespace QuanLyCaPhe.Model;

public class ChiTietDatBan
{
    public int MaChiTietDat { get; set; }
    public int MaBan { get; set; }
    public DateTime ThoiGianBatDau { get; set; }
    public DateTime ThoiGianKetThuc { get; set; }
    public string TrangThai { get; set; }

    public ChiTietDatBan()
    {
    }

    public ChiTietDatBan(int maChiTietDat, int maBan, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string trangThai)
    {
        MaChiTietDat = maChiTietDat;
        MaBan = maBan;
        ThoiGianBatDau = thoiGianBatDau;
        ThoiGianKetThuc = thoiGianKetThuc;
        TrangThai = trangThai;
    }

    public override string ToString()
    {
        return @$"Mã đặt: {MaChiTietDat} | Bàn: {MaBan} | Từ: {ThoiGianBatDau:dd/MM/yyyy HH:mm} - Đến: {ThoiGianKetThuc:dd/MM/yyyy HH:mm} ({TrangThai})";
    }
}
