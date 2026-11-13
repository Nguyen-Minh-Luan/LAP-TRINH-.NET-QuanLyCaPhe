using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCaPhe;

public partial class frmLichSuHoaDon : Form
{
    private List<HoaDonLichSuItem> _danhSachHoaDonGoc = new();

    public frmLichSuHoaDon()
    {
        InitializeComponent();
    }

    private void frmLichSuHoaDon_Load(object sender, EventArgs e)
    {
        KhoiTaoBoLoc();
        KhoiTaoDuLieuMau();
        HienThiDanhSachHoaDon(_danhSachHoaDonGoc);
    }

    private void KhoiTaoBoLoc()
    {
        // Khoảng ngày mặc định 7 ngày gần đây
        dtpTuNgay.Value = DateTime.Today.AddDays(-7);
        dtpDenNgay.Value = DateTime.Today;

        // Danh sách nhân viên
        cboNhanVien.Items.Clear();
        cboNhanVien.Items.Add("-- Tất cả thu ngân --");
        cboNhanVien.Items.Add("Admin");
        cboNhanVien.Items.Add("Trần Thị Mai Anh");
        cboNhanVien.Items.Add("Nguyễn Văn Tuấn");
        cboNhanVien.Items.Add("Lê Thị Hương");
        cboNhanVien.SelectedIndex = 0;
    }

    private void KhoiTaoDuLieuMau()
    {
        _danhSachHoaDonGoc = new List<HoaDonLichSuItem>
        {
            new HoaDonLichSuItem
            {
                MaHD = "HD00105",
                TenBan = "Bàn 01 (Tầng 1)",
                ThoiGian = DateTime.Now.AddMinutes(-25),
                ThuNgan = "Admin",
                TienMon = 150000,
                GiamGiaPhanTram = 10,
                HinhThucThanhToan = "Tiền mặt",
                DanhSachMon = new List<ChiTietHoaDonLichSuItem>
                {
                    new ChiTietHoaDonLichSuItem { TenMon = "Cà phê sữa đá", SoLuong = 2, DonGia = 35000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Trà đào cam sả", SoLuong = 1, DonGia = 45000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Bánh Croissant", SoLuong = 1, DonGia = 35000 }
                }
            },
            new HoaDonLichSuItem
            {
                MaHD = "HD00104",
                TenBan = "Bàn 08 (Tầng 2)",
                ThoiGian = DateTime.Now.AddHours(-2),
                ThuNgan = "Trần Thị Mai Anh",
                TienMon = 195000,
                GiamGiaPhanTram = 0,
                HinhThucThanhToan = "Chuyển khoản QR",
                DanhSachMon = new List<ChiTietHoaDonLichSuItem>
                {
                    new ChiTietHoaDonLichSuItem { TenMon = "Trà sữa Oolong nướng", SoLuong = 2, DonGia = 50000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Cà phê muối", SoLuong = 1, DonGia = 40000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Bánh Mousse chanh dây", SoLuong = 1, DonGia = 55000 }
                }
            },
            new HoaDonLichSuItem
            {
                MaHD = "HD00103",
                TenBan = "Bàn 03 (Tầng 1)",
                ThoiGian = DateTime.Now.AddHours(-4),
                ThuNgan = "Nguyễn Văn Tuấn",
                TienMon = 85000,
                GiamGiaPhanTram = 0,
                HinhThucThanhToan = "Tiền mặt",
                DanhSachMon = new List<ChiTietHoaDonLichSuItem>
                {
                    new ChiTietHoaDonLichSuItem { TenMon = "Bạc xỉu đá", SoLuong = 1, DonGia = 35000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Matcha Latte", SoLuong = 1, DonGia = 50000 }
                }
            },
            new HoaDonLichSuItem
            {
                MaHD = "HD00102",
                TenBan = "Bàn 05 (Tầng 1)",
                ThoiGian = DateTime.Now.AddDays(-1).AddHours(2),
                ThuNgan = "Admin",
                TienMon = 240000,
                GiamGiaPhanTram = 15,
                HinhThucThanhToan = "Thẻ ngân hàng",
                DanhSachMon = new List<ChiTietHoaDonLichSuItem>
                {
                    new ChiTietHoaDonLichSuItem { TenMon = "Cold Brew bưởi hồng", SoLuong = 2, DonGia = 55000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Trà ô long hoa cúc", SoLuong = 1, DonGia = 45000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Bánh Tiramisu", SoLuong = 1, DonGia = 45000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Khoai tây chiên", SoLuong = 1, DonGia = 40000 }
                }
            },
            new HoaDonLichSuItem
            {
                MaHD = "HD00101",
                TenBan = "Bàn 09 (Sân vườn)",
                ThoiGian = DateTime.Now.AddDays(-2),
                ThuNgan = "Lê Thị Hương",
                TienMon = 110000,
                GiamGiaPhanTram = 0,
                HinhThucThanhToan = "Chuyển khoản QR",
                DanhSachMon = new List<ChiTietHoaDonLichSuItem>
                {
                    new ChiTietHoaDonLichSuItem { TenMon = "Sinh tố xoài", SoLuong = 1, DonGia = 45000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Nước ép cam nguyên chất", SoLuong = 1, DonGia = 45000 },
                    new ChiTietHoaDonLichSuItem { TenMon = "Khăn lạnh", SoLuong = 4, DonGia = 5000 }
                }
            }
        };
    }

    private void HienThiDanhSachHoaDon(List<HoaDonLichSuItem> danhSach)
    {
        dgvHoaDon.Rows.Clear();
        int stt = 1;

        foreach (var item in danhSach)
        {
            int rowIndex = dgvHoaDon.Rows.Add(
                stt++,
                item.MaHD,
                item.TenBan,
                item.ThoiGian.ToString("dd/MM/yyyy HH:mm"),
                item.ThuNgan,
                item.TongTien.ToString("N0", CultureInfo.InvariantCulture) + " đ"
            );

            dgvHoaDon.Rows[rowIndex].Tag = item;
        }

        if (dgvHoaDon.Rows.Count > 0)
        {
            dgvHoaDon.Rows[0].Selected = true;
            HienThiChiTietHoaDon(dgvHoaDon.Rows[0].Tag as HoaDonLichSuItem);
        }
        else
        {
            XoaTrangChiTiet();
        }
    }

    private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvHoaDon.SelectedRows.Count > 0)
        {
            var item = dgvHoaDon.SelectedRows[0].Tag as HoaDonLichSuItem;
            HienThiChiTietHoaDon(item);
        }
    }

    private void HienThiChiTietHoaDon(HoaDonLichSuItem? hoaDon)
    {
        if (hoaDon == null)
        {
            XoaTrangChiTiet();
            return;
        }

        lblThongTinChiTietHD.Text = $"Chi tiết hóa đơn: {hoaDon.MaHD} ({hoaDon.TenBan})";

        dgvChiTietHoaDon.Rows.Clear();
        int stt = 1;

        foreach (var mon in hoaDon.DanhSachMon)
        {
            dgvChiTietHoaDon.Rows.Add(
                stt++,
                mon.TenMon,
                mon.SoLuong,
                mon.DonGia.ToString("N0", CultureInfo.InvariantCulture),
                mon.ThanhTien.ToString("N0", CultureInfo.InvariantCulture)
            );
        }

        decimal tienGiam = hoaDon.TienMon * (hoaDon.GiamGiaPhanTram / 100m);
        /*lblTienMonVal.Text = hoaDon.TienMon.ToString("N0", CultureInfo.InvariantCulture) + " đ";*/
        lblGiamGiaVal.Text = $"- {tienGiam:N0} đ ({hoaDon.GiamGiaPhanTram}%)";
        lblHinhThucVal.Text = hoaDon.HinhThucThanhToan;
        lblTongCongVal.Text = hoaDon.TongTien.ToString("N0", CultureInfo.InvariantCulture) + " đ";
    }

    private void XoaTrangChiTiet()
    {
        lblThongTinChiTietHD.Text = "Hóa đơn: Chưa chọn";
        dgvChiTietHoaDon.Rows.Clear();
        /*lblTienMonVal.Text = "0 đ";*/
        lblGiamGiaVal.Text = "- 0 đ (0%)";
        lblHinhThucVal.Text = "--";
        lblTongCongVal.Text = "0 đ";
    }

    private void btnTraCuu_Click(object sender, EventArgs e)
    {
        DateTime tuNgay = dtpTuNgay.Value.Date;
        DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

        if (tuNgay > denNgay)
        {
            MessageBox.Show("Từ ngày không thể lớn hơn đến ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string nhanVienDuocChon = cboNhanVien.SelectedIndex > 0 ? cboNhanVien.SelectedItem.ToString()! : string.Empty;
        string tuKhoa = txtTimKiem.Text.Trim().ToLower();

        var ketQua = _danhSachHoaDonGoc.Where(item =>
        {
            // Lọc theo thời gian
            if (item.ThoiGian < tuNgay || item.ThoiGian > denNgay)
                return false;

            // Lọc theo nhân viên
            if (!string.IsNullOrEmpty(nhanVienDuocChon))
            {
                if (!item.ThuNgan.Equals(nhanVienDuocChon, StringComparison.OrdinalIgnoreCase))
                    return false;
            }

            // Lọc theo từ khóa
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                bool matchMaHD = item.MaHD.ToLower().Contains(tuKhoa);
                bool matchTenBan = item.TenBan.ToLower().Contains(tuKhoa);
                bool matchMon = item.DanhSachMon.Any(m => m.TenMon.ToLower().Contains(tuKhoa));

                if (!matchMaHD && !matchTenBan && !matchMon)
                    return false;
            }

            return true;
        }).ToList();

        HienThiDanhSachHoaDon(ketQua);
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        dtpTuNgay.Value = DateTime.Today.AddDays(-7);
        dtpDenNgay.Value = DateTime.Today;
        cboNhanVien.SelectedIndex = 0;
        txtTimKiem.Clear();

        HienThiDanhSachHoaDon(_danhSachHoaDonGoc);
    }

    private void btnDong_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        // Giữ lại để tương thích các sự kiện cũ nếu cần
    }

    private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
    {
    }

    private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
    {
    }
}

/// <summary>
/// Model DTO chứa thông tin hóa đơn lịch sử
/// </summary>
public class HoaDonLichSuItem
{
    public string MaHD { get; set; } = string.Empty;
    public string TenBan { get; set; } = string.Empty;
    public DateTime ThoiGian { get; set; }
    public string ThuNgan { get; set; } = string.Empty;
    public decimal TienMon { get; set; }
    public decimal GiamGiaPhanTram { get; set; }
    public decimal TongTien => TienMon - (TienMon * GiamGiaPhanTram / 100m);
    public string HinhThucThanhToan { get; set; } = "Tiền mặt";
    public List<ChiTietHoaDonLichSuItem> DanhSachMon { get; set; } = new();
}

/// <summary>
/// Model DTO chứa thông tin chi tiết từng món trong hóa đơn
/// </summary>
public class ChiTietHoaDonLichSuItem
{
    public string TenMon { get; set; } = string.Empty;
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien => SoLuong * DonGia;
}
