using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyCaPhe.View
{
    public partial class frmQuanLyNhanVien : Form
    {
        private readonly NhanVienDAO _nhanVienDAO = new NhanVienDAO();
        private List<NhanVien> _danhSachHienTai = new List<NhanVien>();

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object? sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            ResetForm();
        }

        private void LoadDanhSachNhanVien()
        {
            try
            {
                _danhSachHienTai = _nhanVienDAO.LayDanhSachNhanVien();
                HienThiLenGrid(_danhSachHienTai);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThucHienTimKiem()
        {
            try
            {
                string kw = txtTimKiem.Text;
                string vaiTro = cboLocVaiTro.SelectedItem?.ToString() ?? "Tất cả";
                _danhSachHienTai = _nhanVienDAO.TimKiemNhanVien(kw, vaiTro);
                HienThiLenGrid(_danhSachHienTai);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object? sender, EventArgs e) => ThucHienTimKiem();
        private void cboLocVaiTro_SelectedIndexChanged(object? sender, EventArgs e) => ThucHienTimKiem();
        private void btnTimKiem_Click(object? sender, EventArgs e) => ThucHienTimKiem();

        private void HienThiLenGrid(List<NhanVien> list)
        {
            var viewData = list.Select(nv => new
            {
                nv.MaNhanVien,
                nv.HoTen,
                nv.TenDangNhap,
                nv.VaiTro,
                nv.SoDienThoai,
                nv.TrangThai
            }).ToList();

            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = viewData;

            if (dgvNhanVien.Columns.Count > 0)
            {
                dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["MaNhanVien"].FillWeight = 50;
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và tên";
                dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                dgvNhanVien.Columns["VaiTro"].HeaderText = "Vai trò";
                dgvNhanVien.Columns["VaiTro"].FillWeight = 75;
                dgvNhanVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                dgvNhanVien.Columns["SoDienThoai"].FillWeight = 85;
                dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvNhanVien.Columns["TrangThai"].FillWeight = 90;
            }
        }

        private void dgvNhanVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _danhSachHienTai.Count) return;

            var nv = _danhSachHienTai[e.RowIndex];
            txtMaNV.Text = nv.MaNhanVien.ToString();
            txtHoTen.Text = nv.HoTen;
            txtTenDangNhap.Text = nv.TenDangNhap;
            txtMatKhau.Text = "********";
            txtMatKhau.Enabled = false;
            txtSoDienThoai.Text = nv.SoDienThoai;
            cboVaiTro.SelectedItem = nv.VaiTro;
            cboTrangThai.SelectedItem = nv.TrangThai;

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDatLaiMK.Enabled = true;
        }

        private bool ValidateInput(bool isInsert, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorMessage = "Vui lòng nhập họ và tên nhân viên.";
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                errorMessage = "Vui lòng nhập tên đăng nhập.";
                txtTenDangNhap.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtTenDangNhap.Text.Trim(), @"^[a-zA-Z0-9_]{4,30}$"))
            {
                errorMessage = "Tên đăng nhập chỉ chứa chữ cái, số, dấu gạch dưới (4-30 ký tự).";
                txtTenDangNhap.Focus();
                return false;
            }

            int currentId = string.IsNullOrEmpty(txtMaNV.Text) ? 0 : int.Parse(txtMaNV.Text);
            if (_nhanVienDAO.KiemTraTrungTenDangNhap(txtTenDangNhap.Text, currentId))
            {
                errorMessage = "Tên đăng nhập này đã tồn tại trong hệ thống.";
                txtTenDangNhap.Focus();
                return false;
            }

            if (isInsert && (string.IsNullOrWhiteSpace(txtMatKhau.Text) || txtMatKhau.Text.Length < 6))
            {
                errorMessage = "Mật khẩu phải có ít nhất 6 ký tự.";
                txtMatKhau.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) &&
                !Regex.IsMatch(txtSoDienThoai.Text.Trim(), @"^0\d{9,10}$"))
            {
                errorMessage = "Số điện thoại không hợp lệ (phải bắt đầu bằng 0 và gồm 10-11 chữ số).";
                txtSoDienThoai.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput(isInsert: true, out string err))
            {
                MessageBox.Show(err, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var nv = new NhanVien
                {
                    HoTen = txtHoTen.Text.Trim(),
                    TenDangNhap = txtTenDangNhap.Text.Trim(),
                    MatKhau = txtMatKhau.Text,
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    VaiTro = cboVaiTro.SelectedItem?.ToString() ?? "Thu ngân",
                    TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang làm việc"
                };

                if (_nhanVienDAO.ThemNhanVien(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isInsert: false, out string err))
            {
                MessageBox.Show(err, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maNV = int.Parse(txtMaNV.Text);
                var nv = new NhanVien
                {
                    MaNhanVien = maNV,
                    HoTen = txtHoTen.Text.Trim(),
                    TenDangNhap = txtTenDangNhap.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    VaiTro = cboVaiTro.SelectedItem?.ToString() ?? "Thu ngân",
                    TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang làm việc"
                };

                if (_nhanVienDAO.CapNhatNV(maNV, nv))
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;

            int maNV = int.Parse(txtMaNV.Text);
            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa nhân viên '{txtHoTen.Text}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                if (_nhanVienDAO.XoaNhanVien(maNV))
                {
                    MessageBox.Show("Đã xóa nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                    ResetForm();
                }
            }
            catch (InvalidOperationException bizEx)
            {
                MessageBox.Show(bizEx.Message, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDatLaiMK_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;

            string? matKhauMoi = HienThiHopThoaiNhapMatKhau($"Đặt lại mật khẩu cho: {txtHoTen.Text}");
            if (string.IsNullOrEmpty(matKhauMoi)) return;

            if (matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maNV = int.Parse(txtMaNV.Text);
                if (_nhanVienDAO.capNhatMKNV(maNV, matKhauMoi))
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đặt lại mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object? sender, EventArgs e) => ResetForm();

        private void ResetForm()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtMatKhau.Enabled = true;
            txtSoDienThoai.Clear();
            cboVaiTro.SelectedIndex = 1;
            cboTrangThai.SelectedIndex = 0;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDatLaiMK.Enabled = false;
            txtHoTen.Focus();
        }

        private static string? HienThiHopThoaiNhapMatKhau(string title)
        {
            using Form prompt = new Form()
            {
                Width = 360,
                Height = 175,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lbl = new Label() { Left = 20, Top = 18, Text = "Nhập mật khẩu mới (tối thiểu 6 ký tự):", AutoSize = true };
            TextBox txtPass = new TextBox() { Left = 20, Top = 45, Width = 300, UseSystemPasswordChar = true };
            Button btnOk = new Button() { Text = "Xác nhận", Left = 145, Width = 85, Top = 85, DialogResult = DialogResult.OK };
            Button btnCancel = new Button() { Text = "Hủy", Left = 235, Width = 85, Top = 85, DialogResult = DialogResult.Cancel };

            prompt.Controls.AddRange(new Control[] { lbl, txtPass, btnOk, btnCancel });
            prompt.AcceptButton = btnOk;
            prompt.CancelButton = btnCancel;

            return prompt.ShowDialog() == DialogResult.OK ? txtPass.Text : null;
        }
    }
}