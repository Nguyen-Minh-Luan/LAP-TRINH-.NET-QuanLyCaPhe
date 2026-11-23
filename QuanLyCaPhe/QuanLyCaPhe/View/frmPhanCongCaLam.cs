using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class frmPhanCongCaLam : Form
{
    private readonly PhanCongDAO _phanCongDAO = new();
    private readonly NhanVienDAO _nhanVienDAO = new();
    private readonly CaLamDAO _caLamDAO = new();
    private int _maPhanCongDangChon = 0;
    public frmPhanCongCaLam()
    {
        InitializeComponent();
    }
    private void frmPhanCongCaLam_Load(object? sender, EventArgs e)
    {
        TaiDuLieuComboBox();
        TaiDanhSachPhanCong();
        LamMoiForm();
    }
    private void TaiDuLieuComboBox()
    {
        try
        {
            var dsNhanVien = _nhanVienDAO.LayDanhSachNhanVien()
                .Where(nv => nv.TrangThai == "Đang làm việc")
                .ToList();
            cbNhanVien.DataSource = dsNhanVien;
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "MaNhanVien";
            var dsCaLam = _caLamDAO.LayDanhSachCaLam()
                .Select(c => new
                {
                    c.MaCa,
                    TenHienThi = $"{c.TenCa} ({c.GioBatDau:hh\\:mm} - {c.GioKetThuc:hh\\:mm})"
                })
                .ToList();
            cbCaLam.DataSource = dsCaLam;
            cbCaLam.DisplayMember = "TenHienThi";
            cbCaLam.ValueMember = "MaCa";
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.AddRange(new object[] { "Đã phân công", "Đang trực", "Hoàn thành", "Nghỉ phép" });
            cbTrangThai.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải dữ liệu danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void TaiDanhSachPhanCong(string tuKhoa = "")
    {
        try
        {
            DataTable dt = _phanCongDAO.LayDanhSachPhanCong(tuKhoa);
            dgvPhanCong.Rows.Clear();
            int stt = 1;
            foreach (DataRow row in dt.Rows)
            {
                DateTime ngayLam = Convert.ToDateTime(row["NgayLam"]);
                string trangThai = ngayLam.Date < DateTime.Today ? "Hoàn thành" :
                                   ngayLam.Date == DateTime.Today ? "Đang trực" : "Đã phân công";
                int rowIndex = dgvPhanCong.Rows.Add(
                    stt++,
                    row["MaPhanCong"],
                    ngayLam.ToString("dd/MM/yyyy"),
                    row["TenNhanVien"],
                    row["TenCaHienThi"],
                    trangThai,
                    ""
                );
                dgvPhanCong.Rows[rowIndex].Tag = new PhanCong
                {
                    MaPhanCong = Convert.ToInt32(row["MaPhanCong"]),
                    MaNhanVien = Convert.ToInt32(row["MaNhanVien"]),
                    MaCa = Convert.ToInt32(row["MaCa"]),
                    NgayLam = ngayLam
                };
            }
            lblTongSoLich.Text = $"Tổng số lịch trực: {dt.Rows.Count} ca";
        }
        catch (Exception ex){
            MessageBox.Show($"Lỗi tải danh sách phân công: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void dgvPhanCong_CellClick(object? sender, DataGridViewCellEventArgs e){
        if (e.RowIndex < 0 || e.RowIndex >= dgvPhanCong.Rows.Count) return;
        if (dgvPhanCong.Rows[e.RowIndex].Tag is PhanCong pc){
            _maPhanCongDangChon = pc.MaPhanCong;
            dtpNgayLam.Value = pc.NgayLam;
            cbNhanVien.SelectedValue = pc.MaNhanVien;
            cbCaLam.SelectedValue = pc.MaCa;
            string trangThaiCell = dgvPhanCong.Rows[e.RowIndex].Cells["colTrangThai"].Value?.ToString() ?? "";
            if (cbTrangThai.Items.Contains(trangThaiCell))
                cbTrangThai.SelectedItem = trangThaiCell;
            btnPhanCong.Enabled = false;
            btnSuaLich.Enabled = true;
            btnXoaLich.Enabled = true;
        }
    }
    private void btnPhanCong_Click(object? sender, EventArgs e){
        if (!KiemTraHopLe(maPhanCongBoQua: 0)) return;
        try{
            var pcMoi = new PhanCong {
                MaNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue),
                MaCa = Convert.ToInt32(cbCaLam.SelectedValue),
                NgayLam = dtpNgayLam.Value.Date
            };

            if (_phanCongDAO.ThemPhanCong(pcMoi)) {
                MessageBox.Show("Phân công ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachPhanCong(txtTimKiem.Text);
                LamMoiForm();
            }
        }
        catch (Exception ex) {
            MessageBox.Show($"Lỗi khi phân công ca làm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSuaLich_Click(object? sender, EventArgs e) {
        if (_maPhanCongDangChon <= 0) {
            MessageBox.Show("Vui lòng chọn lịch trực cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!KiemTraHopLe(maPhanCongBoQua: _maPhanCongDangChon)) return;
        try {
            var pcCapNhat = new PhanCong {
                MaPhanCong = _maPhanCongDangChon,
                MaNhanVien = Convert.ToInt32(cbNhanVien.SelectedValue),
                MaCa = Convert.ToInt32(cbCaLam.SelectedValue),
                NgayLam = dtpNgayLam.Value.Date
            };
            if (_phanCongDAO.CapNhatPhanCong(pcCapNhat)) {
                MessageBox.Show("Cập nhật lịch trực thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachPhanCong(txtTimKiem.Text);
                LamMoiForm(); }
        }
        catch (Exception ex) {
            MessageBox.Show($"Lỗi khi cập nhật lịch trực: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
    private void btnXoaLich_Click(object? sender, EventArgs e) {
        if (_maPhanCongDangChon <= 0) {
            MessageBox.Show("Vui lòng chọn lịch trực cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; }
        var confirm = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa lịch trực của '{cbNhanVien.Text}' vào ngày {dtpNgayLam.Value:dd/MM/yyyy} không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (confirm == DialogResult.Yes) {
            try {
                if (_phanCongDAO.XoaPhanCong(_maPhanCongDangChon)) {
                    MessageBox.Show("Đã xóa lịch phân công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachPhanCong(txtTimKiem.Text);
                    LamMoiForm(); }
            }
            catch (Exception ex) {
                MessageBox.Show($"Lỗi khi xóa lịch trực: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void btnLamMoi_Click(object? sender, EventArgs e) {
        LamMoiForm();
    }
    private void LamMoiForm() {
        _maPhanCongDangChon = 0;
        dtpNgayLam.Value = DateTime.Today;
        if (cbNhanVien.Items.Count > 0) cbNhanVien.SelectedIndex = 0;
        if (cbCaLam.Items.Count > 0) cbCaLam.SelectedIndex = 0;
        if (cbTrangThai.Items.Count > 0) cbTrangThai.SelectedIndex = 0;
        txtGhiChu.Clear();
        dgvPhanCong.ClearSelection();

        btnPhanCong.Enabled = true;
        btnSuaLich.Enabled = false;
        btnXoaLich.Enabled = false;
    }

    private void btnTraCuu_Click(object? sender, EventArgs e)
    {
        TaiDanhSachPhanCong(txtTimKiem.Text);
    }

    private void txtTimKiem_KeyDown(object? sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
            e.SuppressKeyPress = true;
            TaiDanhSachPhanCong(txtTimKiem.Text);
        }
    }
    private void btnTatCa_Click(object? sender, EventArgs e) {
        txtTimKiem.Clear();
        TaiDanhSachPhanCong();
    }

    private void btnDong_Click(object? sender, EventArgs e) {
        this.Close();
    }

    private bool KiemTraHopLe(int maPhanCongBoQua) {
        if (cbNhanVien.SelectedValue == null) {
            MessageBox.Show("Vui lòng chọn nhân viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (cbCaLam.SelectedValue == null) {
            MessageBox.Show("Vui lòng chọn ca làm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        int maNV = Convert.ToInt32(cbNhanVien.SelectedValue);
        int maCa = Convert.ToInt32(cbCaLam.SelectedValue);
        DateTime ngayLam = dtpNgayLam.Value.Date;
        if (_phanCongDAO.KiemTraTrungLich(maNV, maCa, ngayLam, maPhanCongBoQua)) {
            MessageBox.Show("Nhân viên này đã được phân công vào ca này trong ngày đã chọn!", "Trùng lịch trực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false; }
        return true;
    }
}