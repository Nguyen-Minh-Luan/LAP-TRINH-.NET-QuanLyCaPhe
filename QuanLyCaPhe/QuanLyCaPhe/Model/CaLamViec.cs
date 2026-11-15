namespace QuanLyCaPhe.Model;

public class CaLamViec
{
    public int MaCa { get; set; }
    public string TenCa { get; set; } = string.Empty;
    public string GioBatDau { get; set; } = string.Empty;
    public string GioKetThuc { get; set; } = string.Empty;

    public CaLamViec()
    {
    }

    public CaLamViec(int maCa, string tenCa, string gioBatDau, string gioKetThuc)
    {
        MaCa = maCa;
        TenCa = tenCa;
        GioBatDau = gioBatDau;
        GioKetThuc = gioKetThuc;
    }

    public override string ToString()
    {
        return $"{TenCa} ({GioBatDau} - {GioKetThuc})";
    }
}
