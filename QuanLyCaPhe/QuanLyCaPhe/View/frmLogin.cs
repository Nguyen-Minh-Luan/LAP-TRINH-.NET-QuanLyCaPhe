using System.Text.RegularExpressions;

namespace QuanLyCaPhe;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void label4_Click(object sender, EventArgs e)
    {
    }

    private bool checkPassword()
    {
        string textPassword = txtPassword.Text.Trim();
        string pattern = @"^(?=.*[A-Z]).{6,}\z";
        if (string.IsNullOrEmpty(textPassword))
        {
            MessageBox.Show("Mật khẩu không được để trống");
            return false;
        }
        
        if (!Regex.IsMatch(textPassword, pattern))
        {
            MessageBox.Show("Mật khẩu dài hơn 5 ký tự và ít nhất 1 chữ hoa thường");
            return false;
        }
        
        return true;
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (checkPassword())
        {
            MessageBox.Show("Đăng nhập thành công");
        }
    }
}