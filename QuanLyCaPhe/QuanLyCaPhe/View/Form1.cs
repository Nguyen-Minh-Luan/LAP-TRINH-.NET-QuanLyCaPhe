namespace QuanLyCaPhe;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

private void tsmiLichSuHoaDon_Click(object sender, EventArgs e)
        {
            frmLichSuHoaDon f = new frmLichSuHoaDon();
            f.ShowDialog();
        }

    

  }