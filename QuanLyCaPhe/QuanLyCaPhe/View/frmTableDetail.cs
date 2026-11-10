namespace QuanLyCaPhe;

public partial class frmTableDetail : Form
{
    public frmTableDetail()
    {
        InitializeComponent();
    }

    private void btnThemMon_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        frmThanhToan thanhToanForm = new frmThanhToan();
        thanhToanForm.ShowDialog();
    }
}