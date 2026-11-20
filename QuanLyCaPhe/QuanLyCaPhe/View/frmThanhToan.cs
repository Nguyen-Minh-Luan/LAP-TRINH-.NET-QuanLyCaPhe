using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe;

public partial class frmThanhToan : Form
{
    private decimal tongTienMon = 0;
    private decimal tongCanThu = 0;
    private decimal tienGiam = 0;

    private int maHoaDonId = 0;
    private int maBanId = 0;
    private int maNhanVienId = 1;

    private readonly HoaDonDAO hoaDonDao = new();
    private readonly ThanhToanDAO thanhToanDao = new();
    private readonly GiamGiaDAO giamGiaDao = new();
    private readonly BanDAO banDao = new();

    public frmThanhToan()
    {
        InitializeComponent();
    }

    public frmThanhToan(int maHoaDonId, int maBanId, string tenBan, string maHoaDon, string thuNgan, decimal tongTienMon, List<ChiTietMonItem>? danhSachMon = null, int maNhanVienId = 1) : this(tenBan, maHoaDon, thuNgan, tongTienMon, danhSachMon)
    {
        this.maHoaDonId = maHoaDonId;
        this.maBanId = maBanId;
        this.maNhanVienId = maNhanVienId;
    }

    public frmThanhToan(string tenBan, string maHoaDon, string thuNgan, decimal tongTienMon, List<ChiTietMonItem>? danhSachMon = null) : this()
    {
        lblTenBan.Text = tenBan.ToUpper();
        lblMaHoaDon.Text = maHoaDon;
        lblThuNgan.Text = thuNgan;
        lblGioVao.Text = DateTime.Now.AddHours(-1).ToString("HH:mm");

        this.tongTienMon = tongTienMon;

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

        if (dgvChiTietHoaDon.Rows.Count == 0 && tongTienMon == 0)
        {
            LoadDuLieuMauMacDinh();
        }

        TinhToanTien();
        HienThiAnhQR();
    }

    // Nạp dữ liệu món mẫu khi mở thử form mà chưa có dữ liệu truyền vào
    private void LoadDuLieuMauMacDinh()
    {
        var sampleItems = new List<ChiTietMonItem>
        {
            new ChiTietMonItem { STT = 1, TenMon = "Cà phê sữa đá", SoLuong = 2, DonGia = 35000 },
            new ChiTietMonItem { STT = 2, TenMon = "Trà đào cam sả", SoLuong = 1, DonGia = 45000 },
            new ChiTietMonItem { STT = 3, TenMon = "Bánh Croissant", SoLuong = 1, DonGia = 35000 }
        };

        tongTienMon = 150000;
        LoadDanhSachMon(sampleItems);
    }

    // Hiển thị danh sách món ăn lên bảng
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

    // Tính toán số tiền giảm giá và tổng tiền cần thu
    private void TinhToanTien()
    {
        decimal phanTramGiam = nudGiamGia.Value;
        tienGiam = tongTienMon * (phanTramGiam / 100m);
        tongCanThu = tongTienMon - tienGiam;

        if (tongCanThu < 0)
            tongCanThu = 0;

        lblTongTienMon.Text = tongTienMon.ToString("N0", CultureInfo.InvariantCulture) + " đ";
        lblTienGiam.Text = "- " + tienGiam.ToString("N0", CultureInfo.InvariantCulture) + " đ";
        lblTongCanThu.Text = tongCanThu.ToString("N0", CultureInfo.InvariantCulture) + " đ";
        lblSoTienQR.Text = $"Số tiền cần chuyển: {tongCanThu:N0} đ";

        if (tabHinhThuc.SelectedTab == tabChuyenKhoan)
        {
            txtTienKhachDua.Text = tongCanThu.ToString("N0", CultureInfo.InvariantCulture);
        }

        TinhTienThoi();
    }

    // Tính tiền thừa trả lại cho khách
    private void TinhTienThoi()
    {
        string textTienKhach = txtTienKhachDua.Text.Replace(".", "").Replace(",", "").Trim();
        if (decimal.TryParse(textTienKhach, out decimal tienKhachDua))
        {
            decimal tienThoi = tienKhachDua - tongCanThu;
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

    // Xử lý khi chuyển tab giữa Tiền mặt và Chuyển khoản QR
    private void tabHinhThuc_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (tabHinhThuc.SelectedTab == tabChuyenKhoan)
        {
            txtTienKhachDua.Text = tongCanThu.ToString("N0", CultureInfo.InvariantCulture);
            lblSoTienQR.Text = $"Số tiền cần chuyển: {tongCanThu:N0} đ";
        }

        TinhTienThoi();
    }

    // Xử lý khi thay đổi phần trăm giảm giá
    private void nudGiamGia_ValueChanged(object? sender, EventArgs e)
    {
        TinhToanTien();
    }

    // Định dạng tiền khách đưa thành dạng số có dấu phẩy và tính lại tiền thối
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

    // Xử lý khi bấm nút Xác nhận thanh toán
    private void btnThanhToan_Click(object? sender, EventArgs e)
    {
        string hinhThuc = tabHinhThuc.SelectedTab == tabTienMat ? "Tiền mặt" : "Chuyển khoản (QR)";
        string phuongThucDb = tabHinhThuc.SelectedTab == tabTienMat ? "Tiền mặt" : "Chuyển khoản";

        if (tabHinhThuc.SelectedTab == tabTienMat)
        {
            string raw = txtTienKhachDua.Text.Replace(".", "").Replace(",", "").Trim();
            decimal.TryParse(raw, out decimal tienKhachDua);

            if (tienKhachDua < tongCanThu)
            {
                var dialogResult = MessageBox.Show(
                    $"Tiền khách đưa ({tienKhachDua:N0} đ) nhỏ hơn tổng cần thu ({tongCanThu:N0} đ).\nBạn có chắc chắn muốn xác nhận?",
                    "Cảnh báo thanh toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult != DialogResult.Yes)
                    return;
            }
        }

        if (maHoaDonId > 0)
        {
            try
            {
                bool capNhatHd = hoaDonDao.ChotThanhToanHoaDon(maHoaDonId, tongTienMon, tienGiam, tongCanThu);
                if (!capNhatHd)
                {
                    MessageBox.Show("Không thể cập nhật trạng thái hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hoaDonDao.KetThucHoaDonBan(maHoaDonId);

                ThanhToan tt = new ThanhToan
                {
                    MaHoaDon = maHoaDonId,
                    NgayThanhToan = DateTime.Now,
                    SoTien = tongCanThu,
                    PhuongThuc = phuongThucDb,
                    TrangThai = "ThanhCong"
                };
                thanhToanDao.ThemThanhToan(tt);

                if (tienGiam > 0)
                {
                    GiamGia gg = new GiamGia
                    {
                        MaHoaDon = maHoaDonId,
                        MaNhanVien = maNhanVienId,
                        LoaiGiamGia = "Phần trăm",
                        GiaTriGiam = nudGiamGia.Value,
                        LyDo = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? "Giảm giá khi thanh toán" : txtGhiChu.Text.Trim()
                    };
                    giamGiaDao.ThemGiamGia(gg);
                }

                if (maBanId > 0)
                {
                    banDao.CapNhatTrangThai(maBanId, "Trong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu thanh toán: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        string thongBao = $"Thanh toán thành công!\n" +
                          $"- Bàn: {lblTenBan.Text}\n" +
                          $"- Số HĐ: {lblMaHoaDon.Text}\n" +
                          $"- Tổng tiền: {tongCanThu:N0} đ\n" +
                          $"- Hình thức: {hinhThuc}";

        if (chkInHoaDon.Checked)
        {
            thongBao += "\n\n(Lệnh in hóa đơn đã được gửi tới máy in)";
        }

        MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    // In phiếu tạm tính để khách kiểm tra đối chiếu món
    private void btnInTamTinh_Click(object? sender, EventArgs e)
    {
        string chiTiet = $"====== PHIẾU TẠM TÍNH ======\n" +
                         $"Bàn: {lblTenBan.Text}\n" +
                         $"Mã HĐ: {lblMaHoaDon.Text}\n" +
                         $"Giờ vào: {lblGioVao.Text} | Thu ngân: {lblThuNgan.Text}\n" +
                         $"-----------------------------\n";

        foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
        {
            if (row.Cells[1].Value != null)
            {
                string tenMon = row.Cells[1].Value.ToString() ?? "";
                string sl = row.Cells[2].Value?.ToString() ?? "1";
                string thanhTien = row.Cells[4].Value?.ToString() ?? "0";
                chiTiet += $"{tenMon} x {sl} = {thanhTien} đ\n";
            }
        }

        chiTiet += $"-----------------------------\n" +
                   $"Tổng tiền món: {tongTienMon:N0} đ\n" +
                   $"Giảm giá: {tienGiam:N0} đ ({nudGiamGia.Value}%)\n" +
                   $"TỔNG CẦN THU: {tongCanThu:N0} đ\n" +
                   $"=============================\n" +
                   $"(Phiếu tạm tính dùng để đối chiếu, chưa phải hóa đơn thanh toán)";

        MessageBox.Show(chiTiet, "In phiếu tạm tính", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnHuy_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    // Tải và hiển thị ảnh mã QR chuyển khoản của quán
    private void HienThiAnhQR()
    {
        try
        {
            string duongDan = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "vietqr.jpg");
            if (!File.Exists(duongDan))
            {
                duongDan = Path.Combine(Application.StartupPath, "..", "..", "..", "Resources", "vietqr.jpg");
            }

            if (File.Exists(duongDan))
            {
                picQRCode.Image = Image.FromFile(duongDan);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class ChiTietMonItem
{
    public int STT { get; set; }
    public string TenMon { get; set; } = string.Empty;
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien => SoLuong * DonGia;
}
