namespace QuanLyCaPhe.Model;

public class NhanVien
{
    public int MaNhanVien { get; set; }
    public string HoTen { get; set; } = string.Empty;
    public string SoDienThoai { get; set; } = string.Empty;
    public string TenDangNhap { get; set; } = string.Empty;
    public string MatKhau { get; set; } = string.Empty;
    public string VaiTro { get; set; } = "Nhân viên";
    public string TrangThai { get; set; } = "Đang làm việc";

    public NhanVien()
    {
    }

    public NhanVien(int maNhanVien, string hoTen, string soDienThoai, string tenDangNhap, string matKhau, string vaiTro = "Nhân viên", string trangThai = "Đang làm việc")
    {
        MaNhanVien = maNhanVien;
        HoTen = hoTen;
        SoDienThoai = soDienThoai;
        TenDangNhap = tenDangNhap;
        MatKhau = matKhau;
        VaiTro = vaiTro;
        TrangThai = trangThai;
    }

    public override string ToString()
    {
        return $"{HoTen} ({TenDangNhap}) | Vai trò: {VaiTro} | SĐT: {SoDienThoai} ({TrangThai})";
    }
}
