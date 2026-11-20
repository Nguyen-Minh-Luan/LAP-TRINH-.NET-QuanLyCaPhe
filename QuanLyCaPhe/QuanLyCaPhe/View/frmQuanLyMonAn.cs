using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class frmQuanLyMonAn : Form
{
    private int maMonDangChon = 0;
    public frmQuanLyMonAn()
    {
        InitializeComponent();
        loadDanhMuc();
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
    private void loadDanhMuc()
    {
        DanhMucDAO dmDAO = new DanhMucDAO();
        cmbDanhMuc.DataSource = dmDAO.LayDanhSachDanhMuc();
        cmbDanhMuc.DisplayMember = "TenDanhMuc";
        cmbDanhMuc.ValueMember = "MaDanhMuc";
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

    private void dgvDanhSachMon_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        DataGridViewRow row = dgvDanhSachMon.Rows[e.RowIndex];
        maMonDangChon = Convert.ToInt32(row.Cells["idCoffee"].Value);
        txtTenMon.Text = row.Cells["nameCoffee"].Value?.ToString();
        txtDonGia.Text = row.Cells["priceCoffee"].Value?.ToString();
        cmbDanhMuc.Text = row.Cells["itemsCoffee"].Value?.ToString();
        txtDonViTinh.Text = row.Cells["unitPrice"].Value?.ToString();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string tenMon = txtTenMon.Text.Trim();
        string donViTinh = txtDonViTinh.Text.Trim();
        MonAnDAO monAnDAO = new MonAnDAO();
        if (string.IsNullOrWhiteSpace(tenMon) || tenMon.Length < 2)
        {
            MessageBox.Show("Tên món không hợp lệ!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenMon.Focus();
            return; 
        }
        if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
        {
            MessageBox.Show("Đơn giá không hợp lệ!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDonGia.Focus();
            return;
        }
        if (cmbDanhMuc.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(donViTinh) || donViTinh.Length < 2)
        {
            MessageBox.Show(" Đơn vị tính không hợp lệ!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDonViTinh.Focus();
            return; 
        }
        MonAn monAn = new MonAn(0, Convert.ToInt32(cmbDanhMuc.SelectedValue), 
            txtTenMon.Text.Trim(), donGia, txtDonViTinh.Text.Trim(), "Còn bán");
        DialogResult result = MessageBox.Show("Bạn có xác nhận thêm món?", "Xác nhận", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (monAnDAO.ThemMonAn(monAn))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVdsMon();
                refreshForm();

            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public void refreshForm()
    {
        maMonDangChon = 0;
        txtTenMon.Clear();
        txtDonGia.Clear();
        txtDonViTinh.Clear();
        if (cmbDanhMuc.Items.Count > 0) cmbDanhMuc.SelectedIndex = 0;
    }
    private void btnSua_Click(object sender, EventArgs e)
    {
        MonAnDAO monAnDAO = new MonAnDAO();

        if (maMonDangChon == 0)
        {
            MessageBox.Show("Vui lòng chọn món cần sửa!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (string.IsNullOrWhiteSpace(txtTenMon.Text) || 
            !decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
        {
            MessageBox.Show("Tên món và đơn giá không hợp lệ!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (cmbDanhMuc.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn danh mục!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        MonAn monAn = new MonAn(maMonDangChon, Convert.ToInt32(cmbDanhMuc.SelectedValue), 
            txtTenMon.Text.Trim(), donGia, txtDonViTinh.Text.Trim(), "Còn bán");
        
        DialogResult result = MessageBox.Show("Bạn có xác nhận cập nhật món?", 
            "Xác nhận", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (monAnDAO.CapNhatMonAn(monAn))
            {
                MessageBox.Show("Cập nhật thành công!",  
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVdsMon();
                refreshForm();
            }
            else
                MessageBox.Show("Cập nhật thất bại!", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        MonAnDAO monAnDAO = new MonAnDAO();
        if (maMonDangChon == 0)
        {
            MessageBox.Show("Vui lòng chọn món cần xoá!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá món này?", 
            "Xác nhận", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (monAnDAO.XoaMonAn(maMonDangChon))
            {
                MessageBox.Show("Xoá món thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVdsMon();
                refreshForm();
            }
            else
            {
                MessageBox.Show("Xoá thất bại",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}