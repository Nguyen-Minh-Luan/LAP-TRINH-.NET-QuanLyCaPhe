using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCaPhe.View;

public partial class frmQuanLyCaLam : Form
{
    private List<CaLamItem> _danhSachCaLam = new();
    private string _maCaDangChon = string.Empty;

    public frmQuanLyCaLam()
    {
        InitializeComponent();
    }

    private void frmQuanLyCaLam_Load(object sender, EventArgs e)
    {
        KhoiTaoDuLieuMau();
        HienThiDanhSach(_danhSachCaLam);
        LamMoiForm();
    }

    /// <summary>
    /// Khởi tạo danh sách ca làm mẫu phục vụ kiểm thử và hiển thị
    /// </summary>
    private void KhoiTaoDuLieuMau()
    {
        _danhSachCaLam = new List<CaLamItem>
        {
            new CaLamItem
            {
                MaCa = "CA01",
                TenCa = "Ca Sáng (Full-time)",
                GioBatDau = new TimeSpan(6, 30, 0),
                GioKetThuc = new TimeSpan(12, 0, 0),
                LuongCa = 150000,
                GhiChu = "Phục vụ ca mở cửa và khách ăn sáng"
            },
            new CaLamItem
            {
                MaCa = "CA02",
                TenCa = "Ca Chiều (Full-time)",
                GioBatDau = new TimeSpan(12, 0, 0),
                GioKetThuc = new TimeSpan(17, 30, 0),
                LuongCa = 150000,
                GhiChu = "Phục vụ khách văn phòng và giờ cao điểm chiều"
            },
            new CaLamItem
            {
                MaCa = "CA03",
                TenCa = "Ca Tối (Full-time)",
                GioBatDau = new TimeSpan(17, 30, 0),
                GioKetThuc = new TimeSpan(22, 30, 0),
                LuongCa = 160000,
                GhiChu = "Ca đóng cửa, dọn dẹp và kiểm kê cuối ngày"
            },
            new CaLamItem
            {
                MaCa = "CA04",
                TenCa = "Ca Đêm / Part-time",
                GioBatDau = new TimeSpan(21, 0, 0),
                GioKetThuc = new TimeSpan(1, 0, 0),
                LuongCa = 180000,
                GhiChu = "Phụ cấp thêm ca đêm đặc biệt"
            }
        };
    }

    /// <summary>
    /// Nạp danh sách ca làm lên DataGridView
    /// </summary>
    private void HienThiDanhSach(List<CaLamItem> danhSach)
    {
        dgvCaLam.Rows.Clear();

        var viCulture = new CultureInfo("vi-VN");
        int stt = 1;

        foreach (var item in danhSach)
        {
            int rowIndex = dgvCaLam.Rows.Add(
                stt++,
                item.MaCa,
                item.TenCa,
                item.GioBatDau.ToString(@"hh\:mm"),
                item.GioKetThuc.ToString(@"hh\:mm"),
                item.LuongCa.ToString("#,##0", viCulture),
                item.GhiChu
            );

            dgvCaLam.Rows[rowIndex].Tag = item;
        }

        lblTongSoCa.Text = $"Tổng số ca làm: {danhSach.Count} ca";
    }

    /// <summary>
    /// Xử lý chọn dòng trên DataGridView để xem/sửa
    /// </summary>
    private void dgvCaLam_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= dgvCaLam.Rows.Count)
        {
            return;
        }

        var row = dgvCaLam.Rows[e.RowIndex];
        if (row.Tag is CaLamItem item)
        {
            _maCaDangChon = item.MaCa;
            txtMaCa.Text = item.MaCa;
            txtMaCa.ReadOnly = true; // Không cho sửa mã ca khi đang chọn
            txtTenCa.Text = item.TenCa;

            dtpGioBatDau.Value = DateTime.Today.Add(item.GioBatDau);
            dtpGioKetThuc.Value = DateTime.Today.Add(item.GioKetThuc);

            txtLuongCa.Text = item.LuongCa.ToString("0");
            txtGhiChu.Text = item.GhiChu;

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
        if (!KiemTraDuLieu(isThemMoi: true))
        {
            return;
        }

        string maCa = txtMaCa.Text.Trim().ToUpper();
        if (_danhSachCaLam.Any(c => c.MaCa.Equals(maCa, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show($"Mã ca '{maCa}' đã tồn tại! Vui lòng chọn mã khác.", "Trùng mã ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaCa.Focus();
            return;
        }

        decimal.TryParse(txtLuongCa.Text.Trim(), out decimal luongCa);

        var caMoi = new CaLamItem
        {
            MaCa = maCa,
            TenCa = txtTenCa.Text.Trim(),
            GioBatDau = dtpGioBatDau.Value.TimeOfDay,
            GioKetThuc = dtpGioKetThuc.Value.TimeOfDay,
            LuongCa = luongCa,
            GhiChu = txtGhiChu.Text.Trim()
        };

        _danhSachCaLam.Add(caMoi);
        HienThiDanhSach(_danhSachCaLam);
        LamMoiForm();

        MessageBox.Show("Thêm ca làm việc mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Cập nhật thông tin ca làm việc đang chọn
    /// </summary>
    private void btnSua_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_maCaDangChon))
        {
            MessageBox.Show("Vui lòng chọn ca làm việc từ danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!KiemTraDuLieu(isThemMoi: false))
        {
            return;
        }

        var caLam = _danhSachCaLam.FirstOrDefault(c => c.MaCa.Equals(_maCaDangChon, StringComparison.OrdinalIgnoreCase));
        if (caLam == null)
        {
            MessageBox.Show("Không tìm thấy thông tin ca làm việc này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        decimal.TryParse(txtLuongCa.Text.Trim(), out decimal luongCa);

        caLam.TenCa = txtTenCa.Text.Trim();
        caLam.GioBatDau = dtpGioBatDau.Value.TimeOfDay;
        caLam.GioKetThuc = dtpGioKetThuc.Value.TimeOfDay;
        caLam.LuongCa = luongCa;
        caLam.GhiChu = txtGhiChu.Text.Trim();

        HienThiDanhSach(_danhSachCaLam);
        LamMoiForm();

        MessageBox.Show("Cập nhật ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Xóa ca làm việc đang chọn
    /// </summary>
    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_maCaDangChon))
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
            _danhSachCaLam.RemoveAll(c => c.MaCa.Equals(_maCaDangChon, StringComparison.OrdinalIgnoreCase));
            HienThiDanhSach(_danhSachCaLam);
            LamMoiForm();
            MessageBox.Show("Đã xóa ca làm việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        _maCaDangChon = string.Empty;
        txtMaCa.ReadOnly = false;
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
        string tuKhoa = txtTimKiem.Text.Trim().ToLower();

        if (string.IsNullOrEmpty(tuKhoa))
        {
            HienThiDanhSach(_danhSachCaLam);
            return;
        }

        var ketQua = _danhSachCaLam.Where(c =>
            c.MaCa.ToLower().Contains(tuKhoa) ||
            c.TenCa.ToLower().Contains(tuKhoa) ||
            c.GhiChu.ToLower().Contains(tuKhoa)
        ).ToList();

        HienThiDanhSach(ketQua);
    }

    /// <summary>
    /// Hiển thị lại toàn bộ danh sách ca làm
    /// </summary>
    private void btnTatCa_Click(object sender, EventArgs e)
    {
        txtTimKiem.Clear();
        HienThiDanhSach(_danhSachCaLam);
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
    private bool KiemTraDuLieu(bool isThemMoi)
    {
        if (string.IsNullOrWhiteSpace(txtMaCa.Text))
        {
            MessageBox.Show("Mã ca làm việc không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaCa.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtTenCa.Text))
        {
            MessageBox.Show("Tên ca làm việc không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenCa.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtLuongCa.Text) || !decimal.TryParse(txtLuongCa.Text.Trim(), out decimal luong) || luong < 0)
        {
            MessageBox.Show("Mức lương/ca phải là một số hợp lệ lớn hơn hoặc bằng 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtLuongCa.Focus();
            return false;
        }

        return true;
    }
}

/// <summary>
/// Model hiển thị thông tin ca làm việc
/// </summary>
public class CaLamItem
{
    public string MaCa { get; set; } = string.Empty;
    public string TenCa { get; set; } = string.Empty;
    public TimeSpan GioBatDau { get; set; }
    public TimeSpan GioKetThuc { get; set; }
    public decimal LuongCa { get; set; }
    public string GhiChu { get; set; } = string.Empty;
}
