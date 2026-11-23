using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.Utils;

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

        dgvDanhSachMon.DataSource = monAnDAO.getDanhSachMonVoiDanhMuc();
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
    private bool kiemTraTenMon(string tenMon)
    {
        MonAnDAO monAnDAO = new MonAnDAO();
        var dsMon = monAnDAO.LayDanhSachMonAn();
        return dsMon.Any(ma => ma.TenMon.Trim().Equals(tenMon.Trim(),  StringComparison.CurrentCultureIgnoreCase));
    }
    private bool kiemTraTenMonKhiCapNhat(string tenMon, int Mamon)
    {
        MonAnDAO monAnDAO = new MonAnDAO();
        var dsMon = monAnDAO.LayDanhSachMonAn();
        return dsMon.Any(ma => ma.TenMon.Trim().Equals(tenMon.Trim(),  
            StringComparison.CurrentCultureIgnoreCase) && ma.MaMon != Mamon);
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

        MonAnDAO monAnDAO = new MonAnDAO();
        MonAn? mon = monAnDAO.LayMonAnTheoMa(maMonDangChon);
        if (mon != null && mon.HinhAnh != null && mon.HinhAnh.Length > 0)
        {
            picHinhAnh.Image = ImageHelper.ChuyenByteArraySangAnh(mon.HinhAnh);
        }
        else
        {
            picHinhAnh.Image = null;
        }
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

        if (kiemTraTenMon(tenMon))
        {
            MessageBox.Show("Tên món đã tồn tại trên hệ thống!", 
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
        byte[]? hinhAnhBytes = picHinhAnh.Image != null ? ImageHelper.ChuyenAnhSangByteArray(picHinhAnh.Image) : null;
        MonAn monAn = new MonAn(0, Convert.ToInt32(cmbDanhMuc.SelectedValue), 
            txtTenMon.Text.Trim(), donGia, txtDonViTinh.Text.Trim(), "Còn bán", hinhAnhBytes);
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
    private void refreshForm()
    {
        maMonDangChon = 0;
        txtTenMon.Clear();
        txtDonGia.Clear();
        txtDonViTinh.Clear();
        picHinhAnh.Image = null;
        if (cmbDanhMuc.Items.Count > 0) cmbDanhMuc.SelectedIndex = 0;
    }
    private void btnSua_Click(object sender, EventArgs e)
    {
        MonAnDAO monAnDAO = new MonAnDAO();
        string tenMon = txtTenMon.Text.Trim();

        if (maMonDangChon == 0)
        {
            MessageBox.Show("Vui lòng chọn món cần sửa!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (string.IsNullOrWhiteSpace(tenMon) || tenMon.Length < 2)
        {
            MessageBox.Show("Tên món không hợp lệ!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenMon.Focus();
            return; 
        }
        if (kiemTraTenMonKhiCapNhat(tenMon, maMonDangChon))
        {
            MessageBox.Show("Tên món đã tồn tại trên hệ thống!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenMon.Focus();
            return; 
        }
        if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
        {
            MessageBox.Show("Đơn giá không hợp lệ!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        if (cmbDanhMuc.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn danh mục!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        byte[]? hinhAnhBytes = picHinhAnh.Image != null ? ImageHelper.ChuyenAnhSangByteArray(picHinhAnh.Image) : null;
        MonAn monAn = new MonAn(maMonDangChon, Convert.ToInt32(cmbDanhMuc.SelectedValue), 
            txtTenMon.Text.Trim(), donGia, txtDonViTinh.Text.Trim(), "Còn bán", hinhAnhBytes);
        
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

    private void btnChonAnh_Click(object? sender, EventArgs e)
    {
        ChonAnh();
    }

    private void picHinhAnh_Click(object? sender, EventArgs e)
    {
        ChonAnh();
    }

    private void btnXoaAnh_Click(object? sender, EventArgs e)
    {
        picHinhAnh.Image = null;
    }

    private void ChonAnh()
    {
        using OpenFileDialog ofd = new OpenFileDialog();
        ofd.Title = "Chọn hình ảnh món ăn";
        ofd.Filter = "Tệp ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            try
            {
                using var stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                using var imgGoc = Image.FromStream(stream);
                picHinhAnh.Image = new Bitmap(imgGoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở tệp ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}