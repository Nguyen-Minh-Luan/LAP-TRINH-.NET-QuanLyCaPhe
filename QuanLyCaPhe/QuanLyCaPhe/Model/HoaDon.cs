namespace QuanLyCaPhe.Model;

public class HoaDon
{
    public int MaHoaDon { get; set; }
    public int MaNhanVien { get; set; }
    public DateTime NgayTao { get; set; }
    public decimal TongTien { get; set; }
    public decimal TienGiam { get; set; }
    public decimal ThanhTien { get; set; }
    public string TrangThai { get; set; }

    public HoaDon()
    {
    }

    public HoaDon(int maHoaDon, int maNhanVien, DateTime ngayTao, decimal tongTien, decimal tienGiam, decimal thanhTien, string trangThai)
    {
        MaHoaDon = maHoaDon;
        MaNhanVien = maNhanVien;
        NgayTao = ngayTao;
        TongTien = tongTien;
        TienGiam = tienGiam;
        ThanhTien = thanhTien;
        TrangThai = trangThai;
    }

    public override string ToString()
    {
        return @$"Mã HĐ: {MaHoaDon} | NV: {MaNhanVien} | Ngày tạo: {NgayTao:dd/MM/yyyy HH:mm} | Tổng: {TongTien:N0} | Giảm: {TienGiam:N0} | Thành tiền: {ThanhTien:N0} VNĐ ({TrangThai})";
    }
}
