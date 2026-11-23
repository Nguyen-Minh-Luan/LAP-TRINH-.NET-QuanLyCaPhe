using System.Globalization;
using System.Text.RegularExpressions;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe;

public partial class frmThongTinCaNhan : Form
{
    private NhanVien _nv;
    private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

    public frmThongTinCaNhan(NhanVien nv)
    {
        InitializeComponent();
        _nv = nv;
        lblDateToday.Text = DateToday();
        timer.Interval = 1000;
        timer.Tick += (s, e) =>
        {
            lblTimeToday.Text = timeToday();

        };
        timer.Start();
        lblStatus.Text = _nv.TrangThai;
        txtTenDN.Text = _nv.TenDangNhap;
        txtHoTenNV.Text = _nv.HoTen;
        txtSDT.Text = _nv.SoDienThoai;
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
        
        DGVCaLam.DataSource = caLamDAO.getCaLam(_nv.MaNhanVien);
    }

    private void btnCapNhatNV_Click(object sender, EventArgs e)
    {
        NhanVienDAO nvDAO = new NhanVienDAO();
        _nv.HoTen = txtHoTenNV.Text.Trim();
        _nv.SoDienThoai = txtSDT.Text.Trim();
        _nv.TenDangNhap = txtTenDN.Text.Trim();

        DialogResult result = MessageBox.Show("Bạn có xác nhận cập nhật thông tin mới?", "Xác nhận", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (nvDAO.CapNhatNV(_nv.MaNhanVien,_nv))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu được cập nhật!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        if (!BCrypt.Net.BCrypt.Verify(oldTextPassword, _nv.MatKhau))
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
                if (nvDAO.capNhatMKNV(_nv.MaNhanVien, newPassword))
                {
                    _nv.MatKhau = newPassword;
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