using System.Globalization;
using System.Text.RegularExpressions;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe;

public partial class frmThongTinCaNhan : Form
{
    private NhanVien nhanVien;
    private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

    public frmThongTinCaNhan(NhanVien nv)
    {
        InitializeComponent();
        nhanVien = nv;
        lblDateToday.Text = DateToday();
        timer.Interval = 1000;
        timer.Tick += (s, e) =>
        {
            lblTimeToday.Text = timeToday();

        };
        timer.Start();
        lblStatus.Text = nhanVien.TrangThai;
        txtTenDN.Text = nhanVien.TenDangNhap;
        txtHoTenNV.Text = nhanVien.HoTen;
        txtSDT.Text = nhanVien.SoDienThoai;
        loadData_DGVCaLam();
    }

    private string DateToday()
    {
        DateTime now = DateTime.Now;
        return now.ToString("dd/MM/yyyy", new CultureInfo("vi-VN"));
    }

    private string timeToday()
    {
        DateTime now = DateTime.Now;
        return now.ToString("HH:mm:ss");
    }

    private void loadData_DGVCaLam()
    { 
        CaLamDAO caLamDAO = new CaLamDAO();
        DGVCaLam.AutoGenerateColumns = false;
        
        datework.DataPropertyName = "NgayLam";
        shift.DataPropertyName = "TenCa";
        startdate.DataPropertyName = "GioBatDau";
        enddate.DataPropertyName = "GioKetThuc";
        
        DGVCaLam.DataSource = caLamDAO.getCaLam(nhanVien.MaNhanVien);
    }

    private void btnCapNhatNV_Click(object sender, EventArgs e)
    {
        try
        {
            string hoTenMoi = txtHoTenNV.Text.Trim();
            string soDienThoaiMoi = txtSDT.Text.Trim();
            string tenDangNhapMoi = txtTenDN.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTenMoi))
            {
                MessageBox.Show("Họ và tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tenDangNhapMoi))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                return;
            }

            NhanVienDAO nvDAO = new NhanVienDAO();

            if (nvDAO.KiemTraTrungTenDangNhap(tenDangNhapMoi, nhanVien.MaNhanVien))
            {
                MessageBox.Show("Tên đăng nhập này đã được sử dụng bởi tài khoản khác. Vui lòng chọn tên đăng nhập khác!", "Trùng tên đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có xác nhận cập nhật thông tin mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                NhanVien nvCapNhat = new NhanVien
                {
                    MaNhanVien = nhanVien.MaNhanVien,
                    HoTen = hoTenMoi,
                    SoDienThoai = soDienThoaiMoi,
                    TenDangNhap = tenDangNhapMoi,
                    VaiTro = nhanVien.VaiTro,
                    TrangThai = nhanVien.TrangThai
                };

                if (nvDAO.CapNhatNV(nhanVien.MaNhanVien, nvCapNhat))
                {
                    nhanVien.HoTen = hoTenMoi;
                    nhanVien.SoDienThoai = soDienThoaiMoi;
                    nhanVien.TenDangNhap = tenDangNhapMoi;

                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Đã xảy ra lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private bool checkPassword()
    {
        string newTextPassword = txtMKMoi.Text.Trim();
        string oldTextPassword = txtMKHienTai.Text.Trim();
        string confirmPassword = txtXacNhanMK.Text.Trim();
        string patternPassword = @"^(?=.*[A-Z])(?=.*[0-9]).{7,20}\z";
        
        if (string.IsNullOrEmpty(oldTextPassword) ||
            string.IsNullOrEmpty(newTextPassword) ||
            string.IsNullOrEmpty(confirmPassword))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!","Lỗi mật khẩu ", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            return false;
        }

        if (!BCrypt.Net.BCrypt.Verify(oldTextPassword, nhanVien.MatKhau))
        {
            MessageBox.Show("Mật khẩu hiện tại không chính xác!",
                "Lỗi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);       
            return false;
        }
        if (!Regex.IsMatch(newTextPassword, patternPassword))
        {
            MessageBox.Show("Mật khẩu mới phải có ít nhất 7 ký tự, 1 chữ in hoa và 1 chữ số!", "Lỗi mật khẩu ", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            return false;
        }
        if (newTextPassword != confirmPassword)
        {
            MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Lỗi mật khẩu ", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

     private void btnCapNhatPassword_Click(object sender, EventArgs e)
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            if (!checkPassword()) return;
            string newPassword = txtMKMoi.Text.Trim();
            
            DialogResult result = MessageBox.Show("Bạn có xác nhận cập nhật mật khẩu mới?", "Xác nhận", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (nvDAO.capNhatMKNV(nhanVien.MaNhanVien, newPassword))
                {
                    nhanVien.MatKhau = newPassword;
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    txtMKHienTai.Clear();
                    txtMKMoi.Clear();
                    txtXacNhanMK.Clear();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi mật khẩu ", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
            }
        }
}