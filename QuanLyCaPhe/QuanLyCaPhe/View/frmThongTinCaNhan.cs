using System.Globalization;
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
    
}