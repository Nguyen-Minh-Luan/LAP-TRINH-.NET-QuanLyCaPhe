using System.Globalization;
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
    private void textBox3_TextChanged(object sender, EventArgs e)
    {
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}