using System;

namespace QuanLyCaPhe.Model;

public class LichSuChuyenBan
{
    public int MaLichSu { get; set; }
    public int MaHoaDon { get; set; }
    public int MaBanNguon { get; set; }
    public int MaBanDich { get; set; }
    public int MaNhanVien { get; set; }
    public DateTime ThoiGian { get; set; }
    public string LoaiThaoTac { get; set; } = "Chuyển bàn";
    public string LyDo { get; set; } = string.Empty;

    public LichSuChuyenBan()
    {
    }

    public LichSuChuyenBan(int maLichSu, int maBanNguon, int maBanDich, int maNhanVien, DateTime thoiGian, string loaiThaoTac = "Chuyển bàn", string lyDo = "", int maHoaDon = 0)
    {
        MaLichSu = maLichSu;
        MaHoaDon = maHoaDon;
        MaBanNguon = maBanNguon;
        MaBanDich = maBanDich;
        MaNhanVien = maNhanVien;
        ThoiGian = thoiGian;
        LoaiThaoTac = loaiThaoTac;
        LyDo = lyDo;
    }

    public override string ToString()
    {
        return $"LS #{MaLichSu} | Bàn #{MaBanNguon} -> Bàn #{MaBanDich} | NV: #{MaNhanVien} | Lúc: {ThoiGian:dd/MM/yyyy HH:mm} ({LoaiThaoTac}) - Lý do: {LyDo}";
    }
}
