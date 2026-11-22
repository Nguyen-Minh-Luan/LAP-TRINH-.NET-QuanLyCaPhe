using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class frmThongKeMonBanChay : Form {
    private readonly ThongKeDAO _thongKeDAO = new();
    private readonly DanhMucDAO _danhMucDAO = new();
    private bool _dangTaiCombo = false;
    public frmThongKeMonBanChay() {
        InitializeComponent();
    }
    private void frmThongKeMonBanChay_Load(object sender, EventArgs e) {
        TaiDanhSachDanhMuc();
        ThietLapMacDinh();
        ThucHienThongKe();
    }
    private void TaiDanhSachDanhMuc() {
        try {
            _dangTaiCombo = true;
            var dsDanhMuc = new List<DanhMuc> {
                new DanhMuc { MaDanhMuc = 0, TenDanhMuc = "-- Tất cả danh mục --" }
            };
            dsDanhMuc.AddRange(_danhMucDAO.LayDanhSachDanhMuc());

            cbDanhMuc.DataSource = dsDanhMuc;
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "MaDanhMuc";
            cbDanhMuc.SelectedIndex = 0;
        }
        catch (Exception ex) {
            MessageBox.Show($"Lỗi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally {
            _dangTaiCombo = false;
        }
    }
    private void ThietLapMacDinh() {
        dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        dtpDenNgay.Value = DateTime.Today;
        if (cbDanhMuc.Items.Count > 0)
            cbDanhMuc.SelectedIndex = 0;
    }
    private void ThucHienThongKe() {
        DateTime tuNgay = dtpTuNgay.Value.Date;
        DateTime denNgay = dtpDenNgay.Value.Date;

        if (tuNgay > denNgay) {
            MessageBox.Show("Từ ngày không được lớn hơn đến ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int maDanhMuc = 0;
        if (cbDanhMuc.SelectedValue != null && int.TryParse(cbDanhMuc.SelectedValue.ToString(), out int id)) {
            maDanhMuc = id;
        }

        try {
            DataTable dt = _thongKeDAO.ThongKeTopMonBanChay(tuNgay, denNgay, maDanhMuc);
            dgvMonBanChay.Rows.Clear();

            int hang = 1;
            long tongSoLuong = 0;
            decimal tongDoanhThu = 0;

            foreach (DataRow row in dt.Rows) {
                int soLuong = Convert.ToInt32(row["SoLuongBan"]);
                decimal doanhThu = Convert.ToDecimal(row["TongDoanhThu"]);
                decimal donGia = Convert.ToDecimal(row["DonGia"]);

                tongSoLuong += soLuong;
                tongDoanhThu += doanhThu;

                int rowIdx = dgvMonBanChay.Rows.Add(
                    hang,
                    row["MaMon"],
                    row["TenMon"],
                    row["TenDanhMuc"],
                    donGia.ToString("N0"),
                    soLuong.ToString("N0"),
                    doanhThu.ToString("N0")
                );
                if (hang == 1) {
                    dgvMonBanChay.Rows[rowIdx].DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 225);
                    dgvMonBanChay.Rows[rowIdx].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (hang == 2) {
                    dgvMonBanChay.Rows[rowIdx].DefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);
                }
                else if (hang == 3) {
                    dgvMonBanChay.Rows[rowIdx].DefaultCellStyle.BackColor = Color.FromArgb(245, 255, 248);
                }
                hang++;
            }
            dgvMonBanChay.ClearSelection();
            gbDanhSachMon.Text = $"Bảng xếp hạng món bán chạy ({dt.Rows.Count} món)";
            lblTongKet.Text = $"Tổng số lượng bán: {tongSoLuong:N0} | Tổng doanh thu: {tongDoanhThu:N0} đ";
        }
        catch (Exception ex) {
            MessageBox.Show($"Lỗi thống kê món bán chạy: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e) {
        if (_dangTaiCombo) return;
        ThucHienThongKe();
    }

    private void btnXemBaoCao_Click(object sender, EventArgs e) {
        ThucHienThongKe();
    }
    private void btnLamMoi_Click(object sender, EventArgs e) {
        _dangTaiCombo = true;
        ThietLapMacDinh();
        _dangTaiCombo = false;
        ThucHienThongKe();
    }
    private void dgvMonBanChay_CellClick(object sender, DataGridViewCellEventArgs e) { }
    private void btnDong_Click(object sender, EventArgs e) {
        this.Close();
    }
}