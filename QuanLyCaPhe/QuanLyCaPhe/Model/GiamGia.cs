namespace QuanLyCaPhe.Model;

public class GiamGia
{
    public int MaGiamGia { get; set; }
    public int MaHoaDon { get; set; }
    public int MaNhanVien { get; set; }
    public string LoaiGiamGia { get; set; } = "Phần trăm";
    public decimal GiaTriGiam { get; set; }
    public string? LyDo { get; set; }

    public GiamGia()
    {
    }

    public GiamGia(int maGiamGia, int maHoaDon, int maNhanVien, string loaiGiamGia, decimal giaTriGiam, string? lyDo = null)
    {
        MaGiamGia = maGiamGia;
        MaHoaDon = maHoaDon;
        MaNhanVien = maNhanVien;
        LoaiGiamGia = loaiGiamGia;
        GiaTriGiam = giaTriGiam;
        LyDo = lyDo;
    }

    public override string ToString()
    {
        return $"Giảm giá #{MaGiamGia} | HĐ #{MaHoaDon} | NV duyệt: #{MaNhanVien} | {LoaiGiamGia}: {GiaTriGiam:N0}" +
               (string.IsNullOrEmpty(LyDo) ? "" : $" ({LyDo})");
    }
}
