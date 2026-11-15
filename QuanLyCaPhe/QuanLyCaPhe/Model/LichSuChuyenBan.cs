namespace QuanLyCaPhe.Model;

public class LichSuChuyenBan
{
    public int MaLichSu { get; set; }
    public int MaHoaDon { get; set; }
    public int MaBanCu { get; set; }
    public int MaBanMoi { get; set; }
    public DateTime ThoiGianChuyen { get; set; }
    public string? LyDo { get; set; }

    public LichSuChuyenBan()
    {
    }

    public LichSuChuyenBan(int maLichSu, int maHoaDon, int maBanCu, int maBanMoi, DateTime thoiGianChuyen, string? lyDo = null)
    {
        MaLichSu = maLichSu;
        MaHoaDon = maHoaDon;
        MaBanCu = maBanCu;
        MaBanMoi = maBanMoi;
        ThoiGianChuyen = thoiGianChuyen;
        LyDo = lyDo;
    }

    public override string ToString()
    {
        return $"LS #{MaLichSu} | HĐ #{MaHoaDon} | Bàn #{MaBanCu} -> Bàn #{MaBanMoi} | Lúc: {ThoiGianChuyen:dd/MM/yyyy HH:mm}" +
               (string.IsNullOrEmpty(LyDo) ? "" : $" | Lý do: {LyDo}");
    }
}
