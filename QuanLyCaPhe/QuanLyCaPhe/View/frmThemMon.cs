using System;
using System.Windows.Forms;

namespace QuanLyCaPhe.View;

public partial class frmThemMon : Form
{
    public int LaySoLuong()
    {
        return (int)nudSoLuong.Value;
    }

    public frmThemMon()
    {
        InitializeComponent();
    }

    public frmThemMon(string tenMon, int soLuongMacDinh = 1) : this()
    {
        if (!string.IsNullOrWhiteSpace(tenMon))
        {
            lblTenMon.Text = tenMon;
        }

        if (soLuongMacDinh >= nudSoLuong.Minimum && soLuongMacDinh <= nudSoLuong.Maximum)
        {
            nudSoLuong.Value = soLuongMacDinh;
        }
    }

    private void btnThemMon_Click(object sender, EventArgs e)
    {
        try
        {
            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng món ăn phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoLuong.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnHuyBo_Click(object sender, EventArgs e)
    {
        try
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
