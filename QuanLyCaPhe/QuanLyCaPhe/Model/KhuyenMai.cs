namespace QuanLyCaPhe.Model;

public class KhuyenMai
{
    public int MaKhuyenMai { get; set; }
    public string TenKhuyenMai { get; set; } = string.Empty;
    public decimal PhanTramGiam { get; set; }
    public DateTime NgayBatDau { get; set; }
    public DateTime NgayKetThuc { get; set; }
    public string TrangThai { get; set; } = "Đang áp dụng";

    public KhuyenMai()
    {
    }

    public KhuyenMai(int maKhuyenMai, string tenKhuyenMai, decimal phanTramGiam, DateTime ngayBatDau, DateTime ngayKetThuc, string trangThai = "Đang áp dụng")
    {
        MaKhuyenMai = maKhuyenMai;
        TenKhuyenMai = tenKhuyenMai;
        PhanTramGiam = phanTramGiam;
        NgayBatDau = ngayBatDau;
        NgayKetThuc = ngayKetThuc;
        TrangThai = trangThai;
    }

    public override string ToString()
    {
        return $"{TenKhuyenMai} (Giảm {PhanTramGiam:0.##}%) | Hạn: {NgayBatDau:dd/MM/yyyy} - {NgayKetThuc:dd/MM/yyyy} ({TrangThai})";
    }
}
