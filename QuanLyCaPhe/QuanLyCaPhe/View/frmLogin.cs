using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.View;

namespace QuanLyCaPhe;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
        
    }
    
    private bool checkName()
    {
        string textName = txtName.Text.Trim();
        if (string.IsNullOrEmpty(textName))
        {
            MessageBox.Show("Tên đăng nhập không được để trống", "Lỗi đăng nhập", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            return false;
        }

        if (textName.Length < 3 || textName.Length > 30)
        {
            MessageBox.Show("Tên đăng nhập phải từ 3 đến 30 ký tự", "Lỗi đăng nhập", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            return false;
        }
        return true;

    }
    private bool checkPassword()
    {
        string textPassword = txtPassword.Text.Trim();
        string patternPassword = @"^(?=.*[A-Z])(?=.*[0-9]).{7,20}\z";

        if (string.IsNullOrEmpty(textPassword))
        {
            MessageBox.Show("Mật khẩu không được để trống!",
                "Lỗi đăng nhập",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }

        if (!Regex.IsMatch(textPassword, patternPassword))
        {
            MessageBox.Show("Mật khẩu phải ít nhất 7 ký tự, ít nhất 1 chữ in hoa và 1 chữ số!",
                "Lỗi đăng nhập",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }

        return true;
    }
    
    private void btnLogin_Click(object sender, EventArgs e)
    {
        string textName = txtName.Text.Trim();
        string textPassword = txtPassword.Text.Trim();
        NhanVienDAO nvDao = new NhanVienDAO();

        if (!checkName())
        {
            txtName.Focus();
            return;
        }

        if (!checkPassword())
        {
            txtPassword.Focus();
            return;
        }
        NhanVien? nv = nvDao.DangNhap(textName, textPassword);
        if (nv != null)
        {
            MessageBox.Show($"Đăng nhập thành công. Xin chào bạn nhân viên: {textName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMain frm = new frmMain(nv);
            frm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Đăng nhập thất bại do sai mật khẩu hoặc tên đăng nhập","Lỗi đăng nhập", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            txtName.Clear();
            txtPassword.Clear();
        }
    }
    private void lblForgotPass_Click(object? sender, EventArgs e)
    {
        NhanVien nv = new NhanVien();
        var popup = new popupQuenMK(nv);
        popup.ShowDialog(this);
    }
    
}