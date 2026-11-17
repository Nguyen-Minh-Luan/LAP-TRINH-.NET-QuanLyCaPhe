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
        lblTenNV.Text = _nv.HoTen;
        lblVaiTro.Text = _nv.VaiTro;
        phanCongDao.loadThongTinCaTruc(_nv.MaNhanVien, lblThoiGianTruc, lblTenCa);
    }
    
    private void frmMain_Load(object sender, EventArgs e)
    {
        CanChinhBoCuc();
    }

    private void frmMain_Resize(object sender, EventArgs e)
    {
        CanChinhBoCuc();
    }

    private void CanChinhBoCuc()
    {
        if (WindowState == FormWindowState.Minimized) return;

        const int le = 12;  
        const int khoangCach = 12;  
        int top = menuStrip1.Bottom + 12;
        int chieuCao = ClientSize.Height - top - le;
        int chieuRongConLai = ClientSize.Width - 2 * le - khoangCach;
        if (chieuCao < 100 || chieuRongConLai < 100) return;

        SuspendLayout();
        
        panel1.SetBounds(le, top, chieuRongConLai * 40 / 100, chieuCao);
        panel3.SetBounds(panel1.Right + khoangCach, top, chieuRongConLai - panel1.Width, chieuCao);

        label3.SetBounds(3, panel2.Bottom + 20, panel1.Width - 6, 76);
        int banTop = label3.Bottom + 10;
        int banCao = Math.Max(200, panel1.Height - banTop - 20);
        int banRong = panel1.Width * 85 / 100;
        tableLayoutPanel1.SetBounds((panel1.Width - banRong) / 2, banTop, banRong, banCao);

        panel5.SetBounds(13, panel4.Bottom + 6, panel3.Width - 26, panel3.Height - panel4.Bottom - 19);
        int lePanel = 20;
        label12.SetBounds(lePanel, 20, panel5.Width - 2 * lePanel, 56);

        int khoangNut = 20;
        int nutRong = (panel5.Width - 2 * lePanel - khoangNut) / 2;
        int vungNutTop = label12.Bottom + 20;
        int vungNutCao = panel5.Height - vungNutTop - 20;
        int nutCao = Math.Min(110, (vungNutCao - khoangNut) / 2);
        if (nutCao < 40) nutCao = 40;
        int nutTop = vungNutTop + (vungNutCao - (2 * nutCao + khoangNut)) / 2;
        int cot2 = lePanel + nutRong + khoangNut;

        button2.SetBounds(lePanel, nutTop, nutRong, nutCao);                     
        button3.SetBounds(cot2, nutTop, nutRong, nutCao);                         
        button4.SetBounds(lePanel, nutTop + nutCao + khoangNut, nutRong, nutCao); 
        button5.SetBounds(cot2, nutTop + nutCao + khoangNut, nutRong, nutCao);   

        ResumeLayout(true);
    }
}