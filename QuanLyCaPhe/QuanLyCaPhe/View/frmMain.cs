using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class frmMain : Form
{
    private PhanCongDAO phanCongDao = new PhanCongDAO();
    private NhanVien _nv;
    public frmMain(NhanVien nv)
    {
        InitializeComponent();
        _nv = nv;
        lblMaNV.Text = _nv.MaNhanVien.ToString();
        lblTenNV.Text = _nv.TenDangNhap;
        lblVaiTro.Text = _nv.VaiTro;
        phanCongDao.loadThongTinCaTruc(_nv.MaNhanVien, lblThoiGianTruc, lblTenCa);
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void label2_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void label4_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void label10_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}