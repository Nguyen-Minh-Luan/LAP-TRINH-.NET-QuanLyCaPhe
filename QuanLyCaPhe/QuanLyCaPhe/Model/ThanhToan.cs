namespace QuanLyCaPhe.Model;

public class ThanhToan
{
    public int MaThanhToan { get; set; }
    public int MaHoaDon { get; set; }
    public DateTime NgayThanhToan { get; set; }
    public decimal SoTien { get; set; }
    public string PhuongThuc { get; set; } = "Tiền mặt";
    public string TrangThai { get; set; } = "Thành công";

    public ThanhToan()
    {
    }

    public ThanhToan(int maThanhToan, int maHoaDon, DateTime ngayThanhToan, decimal soTien, string phuongThuc = "Tiền mặt", string trangThai = "Thành công")
    {
        MaThanhToan = maThanhToan;
        MaHoaDon = maHoaDon;
        NgayThanhToan = ngayThanhToan;
        SoTien = soTien;
        PhuongThuc = phuongThuc;
        TrangThai = trangThai;
    }

    public override string ToString()
    {
        return $"TT #{MaThanhToan} | HĐ #{MaHoaDon} | {SoTien:N0} VNĐ ({PhuongThuc}) - {TrangThai}";
    }
}
