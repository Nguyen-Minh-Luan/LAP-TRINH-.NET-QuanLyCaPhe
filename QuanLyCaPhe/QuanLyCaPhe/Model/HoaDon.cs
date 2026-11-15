namespace QuanLyCaPhe.Model;

public class HoaDon
{
    public int MaHoaDon { get; set; }
    public int MaNhanVien { get; set; }
    public int? MaKhuyenMai { get; set; }
    public DateTime NgayLap { get; set; }
    public decimal TongTien { get; set; }
    public decimal TienGiam { get; set; }
    public decimal ThanhTien { get; set; }
    public string TrangThai { get; set; } = "Chưa thanh toán";

    public HoaDon()
    {
    }

    public HoaDon(int maHoaDon, int maNhanVien, int? maKhuyenMai, DateTime ngayLap, decimal tongTien, decimal tienGiam, decimal thanhTien, string trangThai = "Chưa thanh toán")
    {
        MaHoaDon = maHoaDon;
        MaNhanVien = maNhanVien;
        MaKhuyenMai = maKhuyenMai;
        NgayLap = ngayLap;
        TongTien = tongTien;
        TienGiam = tienGiam;
        ThanhTien = thanhTien;
        TrangThai = trangThai;
    }

    public override string ToString()
    {
        return $"HĐ #{MaHoaDon} | NV: {MaNhanVien} | Ngày lập: {NgayLap:dd/MM/yyyy HH:mm} | Tổng: {TongTien:N0} | Giảm: {TienGiam:N0} | Thành tiền: {ThanhTien:N0} VNĐ ({TrangThai})";
    }
}
