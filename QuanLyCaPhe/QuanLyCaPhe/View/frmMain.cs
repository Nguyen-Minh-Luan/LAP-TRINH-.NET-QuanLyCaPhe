using System;
using System.Windows.Forms;
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
    private void MoForm(Form frm)
    {
        try
        {
            frm.ShowDialog(this);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void mnuSoDoBan_Click(object sender, EventArgs e)
    {
        MoForm(new frmTable());
    }
    private void mnuLichSuHD_Click(object sender, EventArgs e)
    {
        MoForm(new frmLichSuHoaDon());
    }
    private void mnuLichSuCB_Click(object sender, EventArgs e)
    {
        MoForm(new frmLichSuChuyenBan());
    }
    private void mnuQLMA_Click(object sender, EventArgs e)
    {
        MoForm(new frmQuanLyMonAn());
    }
    private void mnuQLDM_Click(object sender, EventArgs e)
    {
        MoForm(new frmQuanLyDanhMuc());
    }
    private void mnuQLKhuVuc_Click(object sender, EventArgs e)
    {
        MoForm(new frmQuanLyKhuVucVaBan());
    }
    private void mnuPCCaLam_Click(object sender, EventArgs e)
    {
        MoForm(new frmPhanCongCaLam());
    }
    private void mnuTKDoanhThu_Click(object sender, EventArgs e)
    {
        MoForm(new frmThongKeDoanhThu());
    }
    private void mnuMonBanChay_Click(object sender, EventArgs e)
    {
        MoForm(new frmThongKeMonBanChay());
    }
    private void mnuTTCaNhan_Click(object sender, EventArgs e)
    {
        frmThongTinCaNhan frmTTCN = new frmThongTinCaNhan(_nv);
        MoForm(frmTTCN);
    }
    private void frmMain_Load(object sender, EventArgs e)
    {
        CanChinhBoCuc();
    }

    private void frmMain_Resize(object sender, EventArgs e)
    {
        CanChinhBoCuc();
    }

    private void mnuDangXuat_Click(object? sender, EventArgs e)
    {
        DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (kq == DialogResult.Yes)
        {
            frmLogin? login = Application.OpenForms.OfType<frmLogin>().FirstOrDefault();
            if (login == null)
            {
                login = new frmLogin();
            }
            login.LamMoiForm();
            login.Show();
            this.Close();
        }
    }
    private void CanChinhBoCuc()
    {
        if (WindowState == FormWindowState.Minimized) return;

        const int le = 16;
        const int khoangCach = 16;
        int top = menuStripHome.Bottom + 16;
        int chieuCao = ClientSize.Height - top - le;
        int chieuRongConLai = ClientSize.Width - 2 * le - khoangCach;
        if (chieuCao < 100 || chieuRongConLai < 100) return;

        SuspendLayout();

        // Chia khu vực theo tỷ lệ cân đối, ưu tiên không gian làm việc.
        int rongTrai = chieuRongConLai * 40 / 100;
        panel1.SetBounds(le, top, rongTrai, chieuCao);
        panel3.SetBounds(panel1.Right + khoangCach, top,
            chieuRongConLai - rongTrai, chieuCao);

        // Thông tin nhân viên được gom gọn ngay dưới lời chào.
        label3.SetBounds(16, panel2.Bottom + 8, panel1.Width - 32, 66);
        int thongTinTop = label3.Bottom + 8;
        int thongTinCao = Math.Max(150, panel1.Height - thongTinTop - 16);
        int thongTinRong = panel1.Width - 48;
        tableLayoutPanel1.SetBounds((panel1.Width - thongTinRong) / 2,
            thongTinTop, thongTinRong, thongTinCao);

        // Các nút chức năng chia đều thành hai cột, hai hàng.
        int lePanel = 16;
        panel5.SetBounds(lePanel, panel4.Bottom + 10,
            panel3.Width - 2 * lePanel,
            panel3.Height - panel4.Bottom - 26);
        label12.SetBounds(lePanel, 12, panel5.Width - 2 * lePanel, 48);

        int khoangNut = 16;
        int nutRong = (panel5.Width - 2 * lePanel - khoangNut) / 2;
        int vungNutTop = label12.Bottom + 10;
        int vungNutCao = panel5.Height - vungNutTop - 16;
        int nutCao = Math.Min(132, (vungNutCao - khoangNut) / 2);
        nutCao = Math.Max(58, nutCao);
        int nutTop = vungNutTop + Math.Max(0,
            (vungNutCao - (2 * nutCao + khoangNut)) / 2);
        int cot2 = lePanel + nutRong + khoangNut;

        btnSoDoBan.SetBounds(lePanel, nutTop, nutRong, nutCao);
        btnLSChuyenBan.SetBounds(cot2, nutTop, nutRong, nutCao);
        btnLichSuHD.SetBounds(lePanel, nutTop + nutCao + khoangNut, nutRong, nutCao);
        btnTKDoanhThu.SetBounds(cot2, nutTop + nutCao + khoangNut, nutRong, nutCao);

        ResumeLayout(true);
    }
}