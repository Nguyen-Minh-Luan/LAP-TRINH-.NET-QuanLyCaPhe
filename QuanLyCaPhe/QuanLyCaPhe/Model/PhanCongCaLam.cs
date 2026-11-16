namespace QuanLyCaPhe.Model;

public class PhanCongCaLam
{
    public int MaPhanCong { get; set; }
    public int MaNhanVien { get; set; }
    public int MaCa { get; set; }
    public DateTime NgayLam { get; set; }
    public string? GhiChu { get; set; }

    public PhanCongCaLam()
    {
    }

    public PhanCongCaLam(int maPhanCong, int maNhanVien, int maCa, DateTime ngayLam, string? ghiChu = null)
    {
        MaPhanCong = maPhanCong;
        MaNhanVien = maNhanVien;
        MaCa = maCa;
        NgayLam = ngayLam;
        GhiChu = ghiChu;
    }

    public override string ToString()
    {
        return $"Phân công #{MaPhanCong} | NV #{MaNhanVien} | Ca #{MaCa} | Ngày: {NgayLam:dd/MM/yyyy}" +
               (string.IsNullOrEmpty(GhiChu) ? "" : $" ({GhiChu})");
    }
}
