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
        lblTenBan.Text = "BÀN: " + tenBan.ToUpper();
        lblMaHoaDon.Text = "Mã HĐ: " + maHoaDon;
        lblThuNgan.Text = "Thu ngân: " + thuNgan;
        lblGioVao.Text = "Giờ vào: " + DateTime.Now.AddHours(-1).ToString("HH:mm");

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

    private void frmThanhToan_Load(object sender, EventArgs e)
    {
        if (dgvChiTietHoaDon.Rows.Count == 0 && _tongTienMon == 0)
        {
            LoadDuLieuMauMacDinh();
        }

        TinhToanTien();
        VeHinhAnhQRDong();
    }

    /// <summary>
    /// Nạp dữ liệu mẫu khi mở test hoặc chưa có data truyền vào
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
                lblTienThoi.ForeColor = Color.Firebrick;
                lblTienThoi.Text = "Còn thiếu " + Math.Abs(tienThoi).ToString("N0", CultureInfo.InvariantCulture) + " đ";
            }
        }
        else
        {
            lblTienThoi.Text = "0 đ";
        }
    }

    private void nudGiamGia_ValueChanged(object sender, EventArgs e)
    {
        TinhToanTien();
        VeHinhAnhQRDong();
    }

    private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
    {
        // Format số tiền khi người dùng gõ
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

    private void btnTienDu_Click(object sender, EventArgs e)
    {
        txtTienKhachDua.Text = _tongCanThu.ToString("N0", CultureInfo.InvariantCulture);
    }

    private void btnMenhGia_Click(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            string raw = btn.Text.Replace(".", "").Trim();
            if (decimal.TryParse(raw, out decimal menhGia))
            {
                txtTienKhachDua.Text = menhGia.ToString("N0", CultureInfo.InvariantCulture);
            }
        }
    }

    private void radPaymentMethod_CheckedChanged(object sender, EventArgs e)
    {
        if (radChuyenKhoan.Checked)
        {
            pnlTienMat.Visible = false;
            pnlChuyenKhoan.Visible = true;
            VeHinhAnhQRDong();
        }
        else
        {
            pnlChuyenKhoan.Visible = false;
            pnlTienMat.Visible = true;
        }
    }

    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        if (radTienMat.Checked)
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

        string phuongThuc = radTienMat.Checked ? "Tiền mặt" : (radChuyenKhoan.Checked ? "Chuyển khoản QR" : "Thẻ ngân hàng");

        string thongBao = $"Thanh toán thành công!\n" +
                          $"- Bàn: {lblTenBan.Text}\n" +
                          $"- Tổng tiền: {_tongCanThu:N0} đ\n" +
                          $"- Hình thức: {phuongThuc}";

        if (chkInHoaDon.Checked)
        {
            thongBao += "\n\n(Lệnh in hóa đơn K80 đã được gửi tới máy in)";
        }

        MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnInTamTinh_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            $"Đã gửi lệnh in Phiếu tạm tính cho {lblTenBan.Text}.\nTổng tạm tính: {_tongCanThu:N0} đ.",
            "In tạm tính",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    /// <summary>
    /// Vẽ đồ họa QR Code mô phỏng chuyển khoản
    /// </summary>
    private void VeHinhAnhQRDong()
    {
        int size = 160;
        Bitmap bmp = new Bitmap(size, size);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            // Viền ngoài
            using Pen penBorder = new Pen(Color.FromArgb(70, 130, 180), 3);
            g.DrawRectangle(penBorder, 8, 8, size - 16, size - 16);

            // Giả lập các ô vuông định vị QR (3 góc)
            VeGocQR(g, 16, 16, 32);
            VeGocQR(g, size - 48, 16, 32);
            VeGocQR(g, 16, size - 48, 32);

            // Giả lập các ô vuông dữ liệu
            using Brush brushData = new SolidBrush(Color.FromArgb(45, 52, 54));
            for (int x = 55; x < size - 55; x += 12)
            {
                for (int y = 55; y < size - 55; y += 12)
                {
                    if ((x + y) % 8 == 0)
                        g.FillRectangle(brushData, x, y, 7, 7);
                }
            }

            // Logo VietQR ở giữa
            Rectangle rectLogo = new Rectangle(size / 2 - 26, size / 2 - 14, 52, 28);
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
        g.FillRectangle(Brushes.White, x + 5, y + 5, size - 10, size - 10);
        g.FillRectangle(brushDark, x + 9, y + 9, size - 18, size - 18);
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

