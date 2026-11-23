using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;
using QuanLyCaPhe.View;

namespace QuanLyCaPhe;

public partial class frmTableDetail : Form
{
    private readonly MonAnDAO monAnDao = new();
    private readonly DanhMucDAO danhMucDao = new();
    private readonly HoaDonDAO hoaDonDao = new();
    private readonly ChiTietHoaDonDAO chiTietDao = new();
    private readonly BanDAO banDao = new();

    private Ban? banHienTai;
    private HoaDon? hoaDonHienTai;

    public frmTableDetail()
    {
        InitializeComponent();
        btnQuayLai.Click += btnQuayLai_Click;
        btnDatBan.Click += btnDatBan_Click;
        Load += frmTableDetail_Load;

        btnTangSL.Click += btnTangSL_Click;
        btnGiamSL.Click += btnGiamSL_Click;
        btnXoaMon.Click += btnXoaMon_Click;
    }

    public frmTableDetail(Ban ban) : this()
    {
        banHienTai = ban;
    }

    private void frmTableDetail_Load(object? sender, EventArgs e)
    {
        if (banHienTai != null)
        {
            string tenBanHienThi = (banHienTai.TrangThai == "GopBan" && !string.IsNullOrWhiteSpace(banHienTai.TenNhom))
                ? banHienTai.TenNhom
                : banHienTai.TenBan;
            lblTenBan.Text = "CHI TIẾT HÓA ĐƠN - " + tenBanHienThi.ToUpper();
        }

        LoadDanhMuc();
        loadMonAn();
        KiemTraVaLoadHoaDonCuaBan();
    }

    public void KiemTraVaLoadHoaDonCuaBan()
    {
        try
        {
            dgvChiTietHoaDon.Rows.Clear();

            if (banHienTai == null)
            {
                lblThongTinBan.Text = "Giờ vào: --:--   |   Mã HĐ: --   |   Trạng thái: Trống";
                CapNhatTongTien();
                return;
            }

            hoaDonHienTai = hoaDonDao.LayHoaDonChuaThanhToanTheoBan(banHienTai.MaBan);

            if (hoaDonHienTai != null)
            {
                lblThongTinBan.Text = $"Giờ vào: {hoaDonHienTai.NgayTao:HH:mm}   |   Mã HĐ: #{hoaDonHienTai.MaHoaDon}   |   Trạng thái: Có khách";

                List<ChiTietHoaDon> dsChiTiet = chiTietDao.LayDanhSachChiTietTheoHoaDon(hoaDonHienTai.MaHoaDon);
                foreach (ChiTietHoaDon ct in dsChiTiet)
                {
                    MonAn? mon = monAnDao.LayMonAnTheoMa(ct.MaMon);
                    string tenMon = mon != null ? mon.TenMon : $"Món #{ct.MaMon}";
                    int rowIndex = dgvChiTietHoaDon.Rows.Add(tenMon, ct.SoLuong, ct.DonGia, ct.ThanhTien);
                    dgvChiTietHoaDon.Rows[rowIndex].Tag = mon ?? new MonAn { MaMon = ct.MaMon, TenMon = tenMon, DonGia = ct.DonGia };
                }
            }
            else
            {
                lblThongTinBan.Text = "Giờ vào: --:--   |   Mã HĐ: --   |   Trạng thái: Trống";
            }

            CapNhatTongTien();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải thông tin hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void LoadDanhMuc()
    {
        try
        {
            var dsDanhMuc = danhMucDao.LayDanhSachDanhMuc();
            cboDanhMuc.Items.Clear();
            cboDanhMuc.Items.Add(new DanhMuc { MaDanhMuc = 0, TenDanhMuc = "-- Tất cả danh mục --" });
            foreach (var dm in dsDanhMuc)
            {
                cboDanhMuc.Items.Add(dm);
            }
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.SelectedIndex = 0;
            cboDanhMuc.SelectedIndexChanged += cboDanhMuc_SelectedIndexChanged;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cboDanhMuc_SelectedIndexChanged(object? sender, EventArgs e)
    {
        loadMonAn();
    }

    public void loadMonAn()
    {
        try
        {
            flpMenu.Controls.Clear();

            int maDanhMuc = 0;
            if (cboDanhMuc.SelectedItem != null)
            {
                DanhMuc dm = (DanhMuc)cboDanhMuc.SelectedItem;
                maDanhMuc = dm.MaDanhMuc;
            }

            List<MonAn> dsMon;
            if (maDanhMuc == 0)
            {
                dsMon = monAnDao.LayDanhSachMonAn();
            }
            else
            {
                dsMon = monAnDao.LayMonAnTheoDanhMuc(maDanhMuc);
            }

            foreach (MonAn mon in dsMon)
            {
                Panel pnlItem = new Panel
                {
                    Width = 116,
                    Height = 140,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Tag = mon,
                    Margin = new Padding(3, 4, 3, 4)
                };

                PictureBox picMon = new PictureBox
                {
                    Location = new Point(5, 5),
                    Size = new Size(104, 70),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.FromArgb(245, 245, 245),
                    Tag = mon,
                    Cursor = Cursors.Hand
                };

                if (mon.HinhAnh != null && mon.HinhAnh.Length > 0)
                {
                    picMon.Image = ImageHelper.ChuyenByteArraySangAnh(mon.HinhAnh);
                }

                Label lblTen = new Label
                {
                    Text = mon.TenMon,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(40, 40, 40),
                    Location = new Point(2, 78),
                    Size = new Size(110, 36),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = mon
                };

                Label lblGia = new Label
                {
                    Text = $"{mon.DonGia:N0} đ",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(139, 54, 48),
                    Location = new Point(2, 115),
                    Size = new Size(110, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = mon
                };

                pnlItem.Controls.Add(picMon);
                pnlItem.Controls.Add(lblTen);
                pnlItem.Controls.Add(lblGia);

                pnlItem.Click += ItemMon_Click;
                picMon.Click += ItemMon_Click;
                lblTen.Click += ItemMon_Click;
                lblGia.Click += ItemMon_Click;

                flpMenu.Controls.Add(pnlItem);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh sách món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ItemMon_Click(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Tag != null)
            {
                MonAn mon = (MonAn)ctrl.Tag;
                frmThemMon frm = new frmThemMon(mon.TenMon);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ThemMonVaoHoaDon(mon, frm.LaySoLuong());
                    loadMonAn();
                }
            }
        }
    }

    private void ThemMonVaoHoaDon(MonAn mon, int soLuong)
    {
        foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
        {
            if (row.Tag != null)
            {
                MonAn m = (MonAn)row.Tag;
                if (m.MaMon == mon.MaMon)
                {
                    int slHienTai = Convert.ToInt32(row.Cells["colSoLuong"].Value);
                    int slMoi = slHienTai + soLuong;
                    decimal thanhTienMoi = slMoi * mon.DonGia;

                    row.Cells["colSoLuong"].Value = slMoi;
                    row.Cells["colThanhTien"].Value = thanhTienMoi;
                    CapNhatTongTien();
                    return;
                }
            }
        }

        int rowIndex = dgvChiTietHoaDon.Rows.Add(mon.TenMon, soLuong, mon.DonGia, soLuong * mon.DonGia);
        dgvChiTietHoaDon.Rows[rowIndex].Tag = mon;
        CapNhatTongTien();
    }

    private void CapNhatTongTien()
    {
        decimal tongTien = 0;
        int tongSoLuong = 0;

        foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
        {
            if (row.Cells["colThanhTien"].Value != null)
            {
                tongTien += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
            }
            if (row.Cells["colSoLuong"].Value != null)
            {
                tongSoLuong += Convert.ToInt32(row.Cells["colSoLuong"].Value);
            }
        }

        lblTongTien.Text = $"{tongTien:N0} VNĐ";
        lblTongSoMon.Text = $"Tổng số món: {dgvChiTietHoaDon.Rows.Count} món ({tongSoLuong} phần)";
    }

    private void btnDatBan_Click(object? sender, EventArgs e)
    {
        try
        {
            if (banHienTai == null)
            {
                MessageBox.Show("Chưa xác định được thông tin bàn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvChiTietHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một món ăn trước khi lưu hóa đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                if (row.Cells["colThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
                }
            }

            if (hoaDonHienTai == null)
            {
                HoaDon hdMoi = new HoaDon
                {
                    MaNhanVien = 1,
                    NgayTao = DateTime.Now,
                    TongTien = tongTien,
                    TienGiam = 0,
                    ThanhTien = tongTien,
                    TrangThai = "ChuaThanhToan"
                };

                int maHdMoi = hoaDonDao.ThemHoaDon(hdMoi);
                if (maHdMoi <= 0)
                {
                    MessageBox.Show("Không thể tạo hóa đơn mới trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hdMoi.MaHoaDon = maHdMoi;
                hoaDonHienTai = hdMoi;

                hoaDonDao.LienKetHoaDonBan(maHdMoi, banHienTai.MaBan);
                banDao.CapNhatTrangThai(banHienTai.MaBan, "CoNguoi");
                banHienTai.TrangThai = "CoNguoi";
            }
            else
            {
                hoaDonHienTai.TongTien = tongTien;
                hoaDonHienTai.ThanhTien = tongTien;
                hoaDonDao.CapNhatHoaDon(hoaDonHienTai);
                chiTietDao.XoaChiTietTheoHoaDon(hoaDonHienTai.MaHoaDon);
            }

            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                if (row.Tag != null)
                {
                    MonAn mon = (MonAn)row.Tag;
                    int soLuong = Convert.ToInt32(row.Cells["colSoLuong"].Value);
                    decimal donGia = Convert.ToDecimal(row.Cells["colDonGia"].Value);
                    decimal thanhTien = Convert.ToDecimal(row.Cells["colThanhTien"].Value);

                    ChiTietHoaDon ct = new ChiTietHoaDon
                    {
                        MaHoaDon = hoaDonHienTai.MaHoaDon,
                        MaMon = mon.MaMon,
                        SoLuong = soLuong,
                        DonGia = donGia,
                        ThanhTien = thanhTien,
                        GhiChu = txtGhiChuMon.Text
                    };

                    chiTietDao.ThemChiTietHoaDon(ct);
                }
            }

            lblThongTinBan.Text = $"Giờ vào: {hoaDonHienTai.NgayTao:HH:mm}   |   Mã HĐ: #{hoaDonHienTai.MaHoaDon}   |   Trạng thái: Có khách";
            MessageBox.Show("Lưu hóa đơn và đặt món vào cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khi lưu hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnTangSL_Click(object? sender, EventArgs e)
    {
        if (dgvChiTietHoaDon.CurrentRow != null && dgvChiTietHoaDon.CurrentRow.Tag != null)
        {
            MonAn mon = (MonAn)dgvChiTietHoaDon.CurrentRow.Tag;
            int sl = Convert.ToInt32(dgvChiTietHoaDon.CurrentRow.Cells["colSoLuong"].Value) + 1;
            dgvChiTietHoaDon.CurrentRow.Cells["colSoLuong"].Value = sl;
            dgvChiTietHoaDon.CurrentRow.Cells["colThanhTien"].Value = sl * mon.DonGia;
            CapNhatTongTien();
        }
    }

    private void btnGiamSL_Click(object? sender, EventArgs e)
    {
        if (dgvChiTietHoaDon.CurrentRow != null && dgvChiTietHoaDon.CurrentRow.Tag != null)
        {
            MonAn mon = (MonAn)dgvChiTietHoaDon.CurrentRow.Tag;
            int sl = Convert.ToInt32(dgvChiTietHoaDon.CurrentRow.Cells["colSoLuong"].Value) - 1;
            if (sl <= 0)
            {
                dgvChiTietHoaDon.Rows.Remove(dgvChiTietHoaDon.CurrentRow);
            }
            else
            {
                dgvChiTietHoaDon.CurrentRow.Cells["colSoLuong"].Value = sl;
                dgvChiTietHoaDon.CurrentRow.Cells["colThanhTien"].Value = sl * mon.DonGia;
            }
            CapNhatTongTien();
        }
    }

    private void btnXoaMon_Click(object? sender, EventArgs e)
    {
        if (dgvChiTietHoaDon.CurrentRow != null)
        {
            dgvChiTietHoaDon.Rows.Remove(dgvChiTietHoaDon.CurrentRow);
            CapNhatTongTien();
        }
    }

    private void btnThemMon_Click(object sender, EventArgs e)
    {
        loadMonAn();
    }

    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        try
        {
            if (hoaDonHienTai == null)
            {
                MessageBox.Show("Bàn này chưa có hóa đơn được lưu! Vui lòng bấm 'Lưu / Đặt món' trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ChiTietMonItem> dsItem = new List<ChiTietMonItem>();
            int stt = 1;
            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                string tenMon = row.Cells["colTenMon"].Value?.ToString() ?? "";
                int soLuong = Convert.ToInt32(row.Cells["colSoLuong"].Value);
                decimal donGia = Convert.ToDecimal(row.Cells["colDonGia"].Value);

                dsItem.Add(new ChiTietMonItem
                {
                    STT = stt++,
                    TenMon = tenMon,
                    SoLuong = soLuong,
                    DonGia = donGia
                });
            }

            string tenBan = banHienTai != null
                ? ((banHienTai.TrangThai == "GopBan" && !string.IsNullOrWhiteSpace(banHienTai.TenNhom)) ? banHienTai.TenNhom : banHienTai.TenBan)
                : "Bàn";
            string maHdStr = $"HD-{hoaDonHienTai.MaHoaDon:D5}";
            decimal tongTien = hoaDonHienTai.TongTien;
            int maBan = banHienTai != null ? banHienTai.MaBan : 0;
            int maNv = hoaDonHienTai.MaNhanVien;

            frmThanhToan thanhToanForm = new frmThanhToan(hoaDonHienTai.MaHoaDon, maBan, tenBan, maHdStr, "Thu ngân", tongTien, dsItem, maNv);
            if (thanhToanForm.ShowDialog() == DialogResult.OK)
            {
                hoaDonHienTai = null;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                KiemTraVaLoadHoaDonCuaBan();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi mở thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnQuayLai_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void picMonAn_Click(object sender, EventArgs e)
    {
        frmThemMon frmThemMon = new frmThemMon();
        frmThemMon.ShowDialog();
    }
}
