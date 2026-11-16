namespace QuanLyCaPhe.Model;

public class CaLam
{
    public int MaCa { get; set; }
    public string TenCa { get; set; } = string.Empty;
    public TimeSpan GioBatDau { get; set; }
    public TimeSpan GioKetThuc { get; set; }

    public CaLam()
    {
    }

    public CaLam(int maCa, string tenCa, TimeSpan gioBatDau, TimeSpan gioKetThuc)
    {
        MaCa = maCa;
        TenCa = tenCa;
        GioBatDau = gioBatDau;
        GioKetThuc = gioKetThuc;
    }

    public CaLam(int maCa, string tenCa, string gioBatDau, string gioKetThuc)
    {
        MaCa = maCa;
        TenCa = tenCa;
        if (TimeSpan.TryParse(gioBatDau, out var start)) GioBatDau = start;
        if (TimeSpan.TryParse(gioKetThuc, out var end)) GioKetThuc = end;
    }

    public override string ToString()
    {
        return $"{TenCa} ({GioBatDau:hh\\:mm} - {GioKetThuc:hh\\:mm})";
    }
}
