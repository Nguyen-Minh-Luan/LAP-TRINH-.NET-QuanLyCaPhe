using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyCaPhe;

public partial class frmThanhToan : Form
{
    private decimal _tongTienMon = 0;
    private decimal _tongCanThu = 0;
    private decimal _tienGiam = 0;

    public frmThanhToan()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Khởi tạo Form thanh toán với thông tin bàn và hóa đơn
    /// </summary>
    public frmThanhToan(string tenBan, string maHoaDon, string thuNgan, decimal tongTienMon, List<ChiTietMonItem>? danhSachMon = null) : this()
    {
        lblTenBan.Text = tenBan.ToUpper();
        lblMaHoaDon.Text = maHoaDon;
        lblThuNgan.Text = thuNgan;
        lblGioVao.Text = DateTime.Now.AddHours(-1).ToString("HH:mm");

        _tongTienMon = tongTienMon;

        if (danhSachMon != null && danhSachMon.Count > 0)
        {
            LoadDanhSachMon(danhSachMon);
        }
        else
        {
            LoadDuLieuMauMacDinh();
        }
    }

    private void frmThanhToan_Load(object? sender, EventArgs e)
    {
        tabHinhThuc.SelectedTab = tabTienMat;

        if (dgvChiTietHoaDon.Rows.Count == 0 && _tongTienMon == 0)
        {
            LoadDuLieuMauMacDinh();
        }

        TinhToanTien();
        VeHinhAnhQRDong();
    }

    /// <summary>
    /// Nạp dữ liệu mẫu khi mở kiểm tra hoặc chưa có dữ liệu truyền vào
    /// </summary>
    private void LoadDuLieuMauMacDinh()
    {
        var sampleItems = new List<ChiTietMonItem>
        {
            new ChiTietMonItem { STT = 1, TenMon = "Cà phê sữa đá", SoLuong = 2, DonGia = 35000 },
            new ChiTietMonItem { STT = 2, TenMon = "Trà đào cam sả", SoLuong = 1, DonGia = 45000 },
            new ChiTietMonItem { STT = 3, TenMon = "Bánh Croissant", SoLuong = 1, DonGia = 35000 }
        };

        _tongTienMon = 150000;
        LoadDanhSachMon(sampleItems);
    }

    public void LoadDanhSachMon(List<ChiTietMonItem> danhSachMon)
    {
        dgvChiTietHoaDon.Rows.Clear();
        int tongSoLuong = 0;
        int stt = 1;

        foreach (var item in danhSachMon)
        {
            dgvChiTietHoaDon.Rows.Add(
                stt++,
                item.TenMon,
                item.SoLuong,
                item.DonGia.ToString("N0", CultureInfo.InvariantCulture),
                item.ThanhTien.ToString("N0", CultureInfo.InvariantCulture)
            );
            tongSoLuong += item.SoLuong;
        }

        lblTongSoMon.Text = $"Tổng số lượng món: {tongSoLuong} ly/phần";
    }

    private void TinhToanTien()
    {
        decimal phanTramGiam = nudGiamGia.Value;
        _tienGiam = _tongTienMon * (phanTramGiam / 100m);
        _tongCanThu = _tongTienMon - _tienGiam;

        if (_tongCanThu < 0)
            _tongCanThu = 0;

        lblTongTienMon.Text = _tongTienMon.ToString("N0", CultureInfo.InvariantCulture) + " đ";
        lblTienGiam.Text = "- " + _tienGiam.ToString("N0", CultureInfo.InvariantCulture) + " đ";
        lblTongCanThu.Text = _tongCanThu.ToString("N0", CultureInfo.InvariantCulture) + " đ";
        lblSoTienQR.Text = $"Số tiền cần chuyển: {_tongCanThu:N0} đ";

        // Nếu đang ở tab Chuyển khoản, tự động cập nhật số tiền khách đưa bằng tổng cần thu
        if (tabHinhThuc.SelectedTab == tabChuyenKhoan)
        {
            txtTienKhachDua.Text = _tongCanThu.ToString("N0", CultureInfo.InvariantCulture);
            VeHinhAnhQRDong();
        }

        TinhTienThoi();
    }

    private void TinhTienThoi()
    {
        string textTienKhach = txtTienKhachDua.Text.Replace(".", "").Replace(",", "").Trim();
        if (decimal.TryParse(textTienKhach, out decimal tienKhachDua))
        {
            decimal tienThoi = tienKhachDua - _tongCanThu;
            if (tienThoi >= 0)
            {
                lblTienThoi.ForeColor = Color.ForestGreen;
                lblTienThoi.Text = tienThoi.ToString("N0", CultureInfo.InvariantCulture) + " đ";
            }
            else
            {
                lblTienThoi.ForeColor = Color.Red;
                lblTienThoi.Text = "Còn thiếu " + Math.Abs(tienThoi).ToString("N0", CultureInfo.InvariantCulture) + " đ";
            }
        }
        else
        {
            lblTienThoi.Text = "0 đ";
        }
    }

    private void tabHinhThuc_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (tabHinhThuc.SelectedTab == tabChuyenKhoan)
        {
            txtTienKhachDua.Text = _tongCanThu.ToString("N0", CultureInfo.InvariantCulture);
            lblSoTienQR.Text = $"Số tiền cần chuyển: {_tongCanThu:N0} đ";
            VeHinhAnhQRDong();
        }

        TinhTienThoi();
    }

    private void nudGiamGia_ValueChanged(object? sender, EventArgs e)
    {
        TinhToanTien();
    }

    private void txtTienKhachDua_TextChanged(object? sender, EventArgs e)
    {
        string raw = txtTienKhachDua.Text.Replace(".", "").Replace(",", "").Trim();
        if (long.TryParse(raw, out long val))
        {
            int selectionStart = txtTienKhachDua.SelectionStart;
            int oldLength = txtTienKhachDua.Text.Length;

            txtTienKhachDua.TextChanged -= txtTienKhachDua_TextChanged;
            txtTienKhachDua.Text = val.ToString("N0", CultureInfo.InvariantCulture);
            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;

            int newLength = txtTienKhachDua.Text.Length;
            int newPosition = selectionStart + (newLength - oldLength);
            if (newPosition >= 0 && newPosition <= txtTienKhachDua.Text.Length)
            {
                txtTienKhachDua.SelectionStart = newPosition;
            }
        }

        TinhTienThoi();
    }

    private void btnThanhToan_Click(object? sender, EventArgs e)
    {
        string hinhThuc = tabHinhThuc.SelectedTab == tabTienMat ? "Tiền mặt" : "Chuyển khoản (QR)";

        if (tabHinhThuc.SelectedTab == tabTienMat)
        {
            string raw = txtTienKhachDua.Text.Replace(".", "").Replace(",", "").Trim();
            decimal.TryParse(raw, out decimal tienKhachDua);

            if (tienKhachDua < _tongCanThu)
            {
                var dialogResult = MessageBox.Show(
                    $"Tiền khách đưa ({tienKhachDua:N0} đ) nhỏ hơn tổng cần thu ({_tongCanThu:N0} đ).\nBạn có chắc chắn muốn xác nhận?",
                    "Cảnh báo thanh toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult != DialogResult.Yes)
                    return;
            }
        }

        string thongBao = $"Thanh toán thành công!\n" +
                          $"- Bàn: {lblTenBan.Text}\n" +
                          $"- Số HĐ: {lblMaHoaDon.Text}\n" +
                          $"- Tổng tiền: {_tongCanThu:N0} đ\n" +
                          $"- Hình thức: {hinhThuc}";

        if (chkInHoaDon.Checked)
        {
            thongBao += "\n\n(Lệnh in hóa đơn đã được gửi tới máy in)";
        }

        MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnInTamTinh_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            $"Đã gửi lệnh in Phiếu tạm tính cho {lblTenBan.Text}.\nTổng tạm tính: {_tongCanThu:N0} đ.",
            "In tạm tính",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void btnHuy_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    /// <summary>
    /// Vẽ đồ họa QR Code mô phỏng chuyển khoản
    /// </summary>
    private void VeHinhAnhQRDong()
    {
        int size = 130;
        Bitmap bmp = new Bitmap(size, size);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            // Viền ngoài
            using Pen penBorder = new Pen(Color.FromArgb(70, 130, 180), 2.5f);
            g.DrawRectangle(penBorder, 5, 5, size - 10, size - 10);

            // Giả lập các ô vuông định vị QR (3 góc)
            VeGocQR(g, 10, 10, 26);
            VeGocQR(g, size - 36, 10, 26);
            VeGocQR(g, 10, size - 36, 26);

            // Giả lập các ô vuông dữ liệu
            using Brush brushData = new SolidBrush(Color.FromArgb(45, 52, 54));
            for (int x = 40; x < size - 40; x += 10)
            {
                for (int y = 40; y < size - 40; y += 10)
                {
                    if ((x + y) % 7 == 0 || (x * y) % 5 == 0)
                        g.FillRectangle(brushData, x, y, 6, 6);
                }
            }

            // Logo VietQR ở giữa
            Rectangle rectLogo = new Rectangle(size / 2 - 24, size / 2 - 12, 48, 24);
            g.FillRectangle(Brushes.White, rectLogo);
            g.DrawRectangle(Pens.Gray, rectLogo);

            using Font fontLogo = new Font("Segoe UI", 7.5f, FontStyle.Bold);
            using StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString("VietQR", fontLogo, Brushes.DarkBlue, rectLogo, sf);
        }

        picQRCode.Image?.Dispose();
        picQRCode.Image = bmp;
    }

    private void VeGocQR(Graphics g, int x, int y, int size)
    {
        using Brush brushDark = new SolidBrush(Color.FromArgb(41, 128, 185));
        g.FillRectangle(brushDark, x, y, size, size);
        g.FillRectangle(Brushes.White, x + 4, y + 4, size - 8, size - 8);
        g.FillRectangle(brushDark, x + 7, y + 7, size - 14, size - 14);
    }
}

/// <summary>
/// Model DTO chứa chi tiết món để hiển thị lên bảng thanh toán
/// </summary>
public class ChiTietMonItem
{
    public int STT { get; set; }
    public string TenMon { get; set; } = string.Empty;
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien => SoLuong * DonGia;
}
