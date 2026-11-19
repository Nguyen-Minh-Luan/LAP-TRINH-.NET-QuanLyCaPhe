using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class popupQuenMK : Form
{
    private NhanVien _nv;
    public popupQuenMK(NhanVien nv)
    {
        InitializeComponent();
        _nv = nv;
        btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
    }

    private void btnDoiMK_Click(object sender, EventArgs e)
    {
        NhanVienDAO nvDAO = new NhanVienDAO();
        string textName = txtTenDNMK.Text.Trim();
        string mkMoi = txtNhanMKMoi.Text.Trim();
        string xacNhanMK = txtXacNhanMKMoi.Text.Trim();
        
        if (string.IsNullOrEmpty(textName) || string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(xacNhanMK))
        {
            MessageBox.Show("Thành phần nhập không để trống!", "Lỗi", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            return;
        }

        if (!nvDAO.KiemTraTrungTenDangNhap(textName))
        {
            MessageBox.Show("Tên đăng nhập không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTenDNMK.Focus();
            return;
        }
        if (textName.Length < 3 || textName.Length > 30)
        {
            MessageBox.Show("Tên đăng nhập phải từ 3 đến 30 ký tự!", "Lỗi", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            txtTenDNMK.Focus();
            return;
        }
        if (mkMoi != xacNhanMK)
        {
            MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            txtXacNhanMKMoi.Focus();
            return;
        }

        if (nvDAO.quenMatKhau(textName, xacNhanMK))
        {
            MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            this.Close();
        }
        else
        {
            MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK ,MessageBoxIcon.Error);
        }
    }
}