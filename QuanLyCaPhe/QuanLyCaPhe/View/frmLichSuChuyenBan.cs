using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCaPhe.View;

public partial class frmLichSuChuyenBan : Form
{
    private List<LichSuChuyenBanItem> _danhSachGoc = new();

    public frmLichSuChuyenBan()
    {
        InitializeComponent();
    }

    private void frmLichSuChuyenBan_Load(object sender, EventArgs e)
    {
        KhoiTaoBoLoc();
        KhoiTaoDuLieuMau();
        HienThiDanhSach(_danhSachGoc);
    }

    private void KhoiTaoBoLoc()
    {
        // Mặc định lọc 7 ngày gần nhất
        dtpTuNgay.Value = DateTime.Today.AddDays(-7);
        dtpDenNgay.Value = DateTime.Today;

        // Danh sách bàn lọc
        cboBan.Items.Clear();
        cboBan.Items.Add("-- Tất cả bàn --");
        cboBan.Items.Add("Bàn 01 (Tầng 1)");
        cboBan.Items.Add("Bàn 02 (Tầng 1)");
        cboBan.Items.Add("Bàn 03 (Tầng 1)");
        cboBan.Items.Add("Bàn 04 (Tầng 1)");
        cboBan.Items.Add("Bàn 05 (Tầng 1)");
        cboBan.Items.Add("Bàn 06 (Tầng 2)");
        cboBan.Items.Add("Bàn 07 (Tầng 2)");
        cboBan.Items.Add("Bàn 08 (Tầng 2)");
        cboBan.Items.Add("Bàn 09 (Sân vườn)");
        cboBan.Items.Add("Bàn 10 (Sân vườn)");
        cboBan.SelectedIndex = 0;

        // Danh sách nhân viên lọc
        cboNhanVien.Items.Clear();
        cboNhanVien.Items.Add("-- Tất cả nhân viên --");
        cboNhanVien.Items.Add("Admin");
        cboNhanVien.Items.Add("Trần Thị Mai Anh");
        cboNhanVien.Items.Add("Nguyễn Văn Tuấn");
        cboNhanVien.Items.Add("Lê Thị Hương");
        cboNhanVien.SelectedIndex = 0;
    }

    private void KhoiTaoDuLieuMau()
    {
        _danhSachGoc = new List<LichSuChuyenBanItem>
        {
            new LichSuChuyenBanItem
            {
                MaChuyen = "CB-00025",
                BanNguon = "Bàn 02 (Tầng 1)",
                BanDich = "Bàn 08 (Tầng 2)",
                ThoiGian = DateTime.Now.AddHours(-2),
                NhanVien = "Trần Thị Mai Anh",
                TongTienDon = 150000,
                GhiChu = "Khách đông người muốn lên tầng 2 ngồi bàn lớn",
                DanhSachMon = new List<string> { "2x Cà phê sữa đá (70.000 đ)", "1x Trà đào cam sả (45.000 đ)", "1x Bánh Croissant (35.000 đ)" }
            },
            new LichSuChuyenBanItem
            {
                MaChuyen = "CB-00024",
                BanNguon = "Bàn 09 (Sân vườn)",
                BanDich = "Bàn 03 (Tầng 1)",
                ThoiGian = DateTime.Now.AddHours(-5),
                NhanVien = "Nguyễn Văn Tuấn",
                TongTienDon = 90000,
                GhiChu = "Trời mưa nên khách chuyển vào phòng lạnh tầng 1",
                DanhSachMon = new List<string> { "2x Cà phê đen đá (50.000 đ)", "1x Hạt hướng dương (40.000 đ)" }
            },
            new LichSuChuyenBanItem
            {
                MaChuyen = "CB-00023",
                BanNguon = "Bàn 05 (Tầng 1)",
                BanDich = "Bàn 06 (Tầng 2)",
                ThoiGian = DateTime.Now.AddDays(-1).AddHours(3),
                NhanVien = "Trần Thị Mai Anh",
                TongTienDon = 210000,
                GhiChu = "Khách cần ổ cắm sạc laptop để làm việc",
                DanhSachMon = new List<string> { "3x Trà vải lài (135.000 đ)", "1x Bánh Tiramisu (45.000 đ)", "1x Khoai tây chiên (30.000 đ)" }
            },
            new LichSuChuyenBanItem
            {
                MaChuyen = "CB-00022",
                BanNguon = "Bàn 01 (Tầng 1)",
                BanDich = "Bàn 04 (Tầng 1)",
                ThoiGian = DateTime.Now.AddDays(-2),
                NhanVien = "Admin",
                TongTienDon = 65000,
                GhiChu = "Tránh luồng gió điều hòa thổi trực tiếp",
                DanhSachMon = new List<string> { "1x Cacao nóng (40.000 đ)", "1x Nước suối (25.000 đ)" }
            },
            new LichSuChuyenBanItem
            {
                MaChuyen = "CB-00021",
                BanNguon = "Bàn 07 (Tầng 2)",
                BanDich = "Bàn 10 (Sân vườn)",
                ThoiGian = DateTime.Now.AddDays(-3),
                NhanVien = "Lê Thị Hương",
                TongTienDon = 120000,
                GhiChu = "Khách thích ngồi ngoài trời thoáng mát hút thuốc",
                DanhSachMon = new List<string> { "2x Sinh tố bơ (90.000 đ)", "1x Hạt điều (30.000 đ)" }
            }
        };
    }

    private void HienThiDanhSach(List<LichSuChuyenBanItem> danhSach)
    {
        dgvLichSuChuyenBan.Rows.Clear();
        int stt = 1;

        foreach (var item in danhSach)
        {
            int rowIndex = dgvLichSuChuyenBan.Rows.Add(
                stt++,
                item.MaChuyen,
                item.BanNguon,
                "➜",
                item.BanDich,
                item.ThoiGian.ToString("dd/MM/yyyy HH:mm"),
                item.NhanVien,
                item.TongTienDon.ToString("N0", CultureInfo.InvariantCulture) + " đ",
                item.GhiChu
            );

            dgvLichSuChuyenBan.Rows[rowIndex].Tag = item;
        }

        lblTongLuotChuyen.Text = $"Tổng số lượt chuyển bàn: {danhSach.Count} lượt";
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

        string banDuocChon = cboBan.SelectedIndex > 0 ? cboBan.SelectedItem.ToString()! : string.Empty;
        string nhanVienDuocChon = cboNhanVien.SelectedIndex > 0 ? cboNhanVien.SelectedItem.ToString()! : string.Empty;
        string tuKhoa = txtTimKiem.Text.Trim().ToLower();

        var ketQua = _danhSachGoc.Where(item =>
        {
            // Lọc theo thời gian
            if (item.ThoiGian < tuNgay || item.ThoiGian > denNgay)
                return false;

            // Lọc theo bàn
            if (!string.IsNullOrEmpty(banDuocChon))
            {
                if (!item.BanNguon.Equals(banDuocChon, StringComparison.OrdinalIgnoreCase) &&
                    !item.BanDich.Equals(banDuocChon, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            // Lọc theo nhân viên
            if (!string.IsNullOrEmpty(nhanVienDuocChon))
            {
                if (!item.NhanVien.Equals(nhanVienDuocChon, StringComparison.OrdinalIgnoreCase))
                    return false;
            }

            // Lọc theo từ khóa
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                bool matchMa = item.MaChuyen.ToLower().Contains(tuKhoa);
                bool matchGhiChu = item.GhiChu.ToLower().Contains(tuKhoa);
                bool matchBanNguon = item.BanNguon.ToLower().Contains(tuKhoa);
                bool matchBanDich = item.BanDich.ToLower().Contains(tuKhoa);

                if (!matchMa && !matchGhiChu && !matchBanNguon && !matchBanDich)
                    return false;
            }

            return true;
        }).ToList();

        HienThiDanhSach(ketQua);
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        dtpTuNgay.Value = DateTime.Today.AddDays(-7);
        dtpDenNgay.Value = DateTime.Today;
        cboBan.SelectedIndex = 0;
        cboNhanVien.SelectedIndex = 0;
        txtTimKiem.Clear();

        HienThiDanhSach(_danhSachGoc);
    }

    private void btnXemChiTiet_Click(object sender, EventArgs e)
    {
        if (dgvLichSuChuyenBan.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn một dòng chuyển bàn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var item = dgvLichSuChuyenBan.SelectedRows[0].Tag as LichSuChuyenBanItem;
        if (item == null)
            return;

        string chiTietMondStr = item.DanhSachMon.Count > 0
            ? string.Join("\n  • ", item.DanhSachMon)
            : "(Không có món)";

        string thongBao = $"=== CHI TIẾT LƯỢT CHUYỂN BÀN ===\n\n" +
                          $"• Mã chuyển bàn: {item.MaChuyen}\n" +
                          $"• Bàn ban đầu: {item.BanNguon}\n" +
                          $"• Bàn chuyển đến: {item.BanDich}\n" +
                          $"• Thời gian: {item.ThoiGian:dd/MM/yyyy HH:mm:ss}\n" +
                          $"• Nhân viên thực hiện: {item.NhanVien}\n" +
                          $"• Lý do / Ghi chú: {item.GhiChu}\n" +
                          $"• Tổng giá trị đơn: {item.TongTienDon:N0} đ\n\n" +
                          $"--- CÁC MÓN CHUYỂN THEO ĐƠN ---\n  • " + chiTietMondStr;

        MessageBox.Show(thongBao, "Chi tiết đơn chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void dgvLichSuChuyenBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            btnXemChiTiet_Click(sender, e);
        }
    }

    private void btnDong_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

/// <summary>
/// Model DTO chứa thông tin một lượt chuyển bàn
/// </summary>
public class LichSuChuyenBanItem
{
    public string MaChuyen { get; set; } = string.Empty;
    public string BanNguon { get; set; } = string.Empty;
    public string BanDich { get; set; } = string.Empty;
    public DateTime ThoiGian { get; set; }
    public string NhanVien { get; set; } = string.Empty;
    public decimal TongTienDon { get; set; }
    public string GhiChu { get; set; } = string.Empty;
    public List<string> DanhSachMon { get; set; } = new();
}
