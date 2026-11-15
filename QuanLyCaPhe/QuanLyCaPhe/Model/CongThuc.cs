namespace QuanLyCaPhe.Model;

public class CongThuc
{
    public int MaMon { get; set; }
    public int MaNguyenLieu { get; set; }
    public decimal SoLuongCan { get; set; }

    public CongThuc()
    {
    }

    public CongThuc(int maMon, int maNguyenLieu, decimal soLuongCan)
    {
        MaMon = maMon;
        MaNguyenLieu = maNguyenLieu;
        SoLuongCan = soLuongCan;
    }

    public override string ToString()
    {
        return $"Món #{MaMon} - Nguyên liệu #{MaNguyenLieu} | Định lượng: {SoLuongCan:N2}";
    }
}
