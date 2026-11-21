using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class frmQuanLyCaLam : Form
{
    private readonly CaLamDAO _caLamDAO = new();
    private int _maCaDangChon = 0;

    public frmQuanLyCaLam()
    {
        InitializeComponent();
    }

    private void frmQuanLyCaLam_Load(object sender, EventArgs e)
    {
        TaiDanhSachCaLam();
        LamMoiForm();
    }

    /// <summary>
    /// Khởi tạo danh sách ca làm mẫu phục vụ kiểm thử và hiển thị
    /// </summary>
    private void TaiDanhSachCaLam(string tuKhoa = "")
    {
        try
        {
            List<CaLam> danhSach = string.IsNullOrWhiteSpace(tuKhoa)
                ? _caLamDAO.LayDanhSachCaLam()
                : _caLamDAO.TimKiemCaLam(tuKhoa);

            dgvCaLam.Rows.Clear();
            int stt = 1;

            foreach (var item in danhSach)
            {
                int rowIndex = dgvCaLam.Rows.Add(
                    stt++,
                    item.MaCa,
                    item.TenCa,
                    item.GioBatDau.ToString(@"hh\:mm"),
                    item.GioKetThuc.ToString(@"hh\:mm"),
                    "0",
                    ""
                );

                dgvCaLam.Rows[rowIndex].Tag = item;
            }

            lblTongSoCa.Text = $"Tổng số ca làm: {danhSach.Count} ca";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh sách ca làm: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    /// Xử lý chọn dòng trên DataGridView để xem/sửa
    private void dgvCaLam_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvCaLam.Rows.Count) return;

        if (dgvCaLam.Rows[e.RowIndex].Tag is CaLam item)
        {
            _maCaDangChon = item.MaCa;
            txtMaCa.Text = item.MaCa.ToString();
            txtMaCa.ReadOnly = true;
            txtTenCa.Text = item.TenCa;

            dtpGioBatDau.Value = DateTime.Today.Add(item.GioBatDau);
            dtpGioKetThuc.Value = DateTime.Today.Add(item.GioKetThuc);

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }

    /// <summary>
    /// Thêm mới một ca làm việc
    /// </summary>
    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!KiemTraDuLieu(maCaBoQua: 0)) return;
        try
        {
            var caMoi = new CaLam
            {
                TenCa = txtTenCa.Text.Trim(),
                GioBatDau = new TimeSpan(dtpGioBatDau.Value.Hour, dtpGioBatDau.Value.Minute, 0),
                GioKetThuc = new TimeSpan(dtpGioKetThuc.Value.Hour, dtpGioKetThuc.Value.Minute, 0)
            };

            if (_caLamDAO.ThemCaLam(caMoi))
            {
                MessageBox.Show("Thêm ca làm việc mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachCaLam(txtTimKiem.Text);
                LamMoiForm();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khi thêm ca làm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Cập nhật thông tin ca làm việc đang chọn
    /// </summary>
    private void btnSua_Click(object sender, EventArgs e)
    {
        if (_maCaDangChon <= 0)
        {
            MessageBox.Show("Vui lòng chọn ca làm việc từ danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!KiemTraDuLieu(maCaBoQua: _maCaDangChon))
            return;
        try
        {
            var caCapNhat = new CaLam
            {
                MaCa = _maCaDangChon,
                TenCa = txtTenCa.Text.Trim(),
                GioBatDau = new TimeSpan(dtpGioBatDau.Value.Hour, dtpGioBatDau.Value.Minute, 0),
                GioKetThuc = new TimeSpan(dtpGioKetThuc.Value.Hour, dtpGioKetThuc.Value.Minute, 0)
            };

            if (_caLamDAO.CapNhatCaLam(caCapNhat))
            {
                MessageBox.Show("Cập nhật ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachCaLam(txtTimKiem.Text);
                LamMoiForm();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khi cập nhật ca làm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Xóa ca làm việc đang chọn
    /// </summary>
    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (_maCaDangChon <= 0)
        {
            MessageBox.Show("Vui lòng chọn ca làm việc cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var dialogResult = MessageBox.Show(
            $"Bạn có chắc chắn muốn xóa ca làm '{txtTenCa.Text}' (Mã: {_maCaDangChon}) không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (dialogResult == DialogResult.Yes)
        {
            try
            {
                if (_caLamDAO.XoaCaLam(_maCaDangChon))
                {
                    MessageBox.Show("Đã xóa ca làm việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachCaLam(txtTimKiem.Text);
                    LamMoiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    /// <summary>
    /// Xóa trắng ô nhập liệu và reset trạng thái nút
    /// </summary>
    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        LamMoiForm();
    }

    private void LamMoiForm()
    {
        _maCaDangChon = 0;
        txtMaCa.ReadOnly = true;
        txtMaCa.Clear();
        txtTenCa.Clear();

        dtpGioBatDau.Value = DateTime.Today.AddHours(7);
        dtpGioKetThuc.Value = DateTime.Today.AddHours(12);

        txtLuongCa.Clear();
        txtGhiChu.Clear();

        btnThem.Enabled = true;
        btnSua.Enabled = false;
        btnXoa.Enabled = false;

        txtMaCa.Focus();
    }

    /// <summary>
    /// Tìm kiếm ca làm theo từ khóa
    /// </summary>
    private void btnTraCuu_Click(object sender, EventArgs e)
    {
       ThucHienTimKiem();
    }

    private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            ThucHienTimKiem();
        }
    }

    private void ThucHienTimKiem()
    {
        TaiDanhSachCaLam(txtTimKiem.Text);
    }
    
    /// Hiển thị lại toàn bộ danh sách ca làm
    private void btnTatCa_Click(object sender, EventArgs e)
    {
        txtTimKiem.Clear();
        TaiDanhSachCaLam();
    }

    /// <summary>
    /// Đóng form quản lý ca làm
    /// </summary>
    private void btnDong_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    /// <summary>
    /// Kiểm tra tính hợp lệ dữ liệu nhập
    /// </summary>
    private bool KiemTraDuLieu(int maCaBoQua)
    {
        string tenCa = txtTenCa.Text.Trim();
        if (string.IsNullOrWhiteSpace(tenCa))
        {
            MessageBox.Show("Mã ca làm việc không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenCa.Focus();
            return false;
        }

        if (_caLamDAO.KiemTraTrungTenCa(tenCa, maCaBoQua))
        {
            MessageBox.Show("Ca đã tồn tại!", "Trùng tên ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenCa.Focus();
            return false;
        }
        
        return true;
    }
}


