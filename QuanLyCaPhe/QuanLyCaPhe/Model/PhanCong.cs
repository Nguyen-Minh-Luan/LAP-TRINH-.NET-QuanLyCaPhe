namespace QuanLyCaPhe.Model;

public class PhanCong
{
    public int MaPhanCong { get; set; }
    public int MaNhanVien { get; set; }
    public int MaCa { get; set; }
    public DateTime NgayLam { get; set; }

    public PhanCong()
    {
    }

    public PhanCong(int maPhanCong, int maNhanVien, int maCa, DateTime ngayLam)
    {
        MaPhanCong = maPhanCong;
        MaNhanVien = maNhanVien;
        MaCa = maCa;
        NgayLam = ngayLam;
    }

    public override string ToString()
    {
        return $"Phân công #{MaPhanCong} | NV #{MaNhanVien} | Ca #{MaCa} | Ngày: {NgayLam:dd/MM/yyyy}";
    }
}
