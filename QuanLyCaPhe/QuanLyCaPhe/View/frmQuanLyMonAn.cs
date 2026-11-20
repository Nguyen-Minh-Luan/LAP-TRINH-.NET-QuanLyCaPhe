using System.Windows.Forms;

namespace QuanLyCaPhe.View;

public partial class frmQuanLyMonAn : Form
{
    public frmQuanLyMonAn()
    {
        InitializeComponent();
        loadData_DGVdsMon();
    }

    private void loadData_DGVdsMon()
    {
        MonAnDAO monAnDAO = new MonAnDAO();
        dgvDanhSachMon.AutoGenerateColumns  = false;
        idCoffee.DataPropertyName = "MaMon";
        nameCoffee.DataPropertyName = "TenMon";
        itemsCoffee.DataPropertyName = "TenDanhMuc";
        priceCoffee.DataPropertyName = "DonGia";
        unitPrice.DataPropertyName = "DonViTinh";
        statusCoffee.DataPropertyName = "TrangThai";

        dgvDanhSachMon.DataSource = monAnDAO.getDanhSachMon();
    }
    private void timKiem_Click(object sender, EventArgs e)
    {
      MonAnDAO monAnDAO = new MonAnDAO();
      string timKiem = txtTimKiemMon.Text;
      dgvDanhSachMon.DataSource = monAnDAO.timKiemMon(timKiem);
    }

    private void txtTimKiemMon_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTimKiemMon.Text))
        {
            loadData_DGVdsMon();
        }
    }
   
}