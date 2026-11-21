using System;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class frmQuanLyDanhMuc : Form
{
    private int maDMDangChon = 0;

    public frmQuanLyDanhMuc()
    {
        InitializeComponent();
        loadData_DGVdsDanhMuc();
    }

    private void loadData_DGVdsDanhMuc()
    {
        DanhMucDAO danhMucDao = new DanhMucDAO();
        dgvDanhMuc.AutoGenerateColumns = false;

        idItems.DataPropertyName = "MaDanhMuc";
        nameItems.DataPropertyName = "TenDanhMuc";
        descItems.DataPropertyName = "MoTa";

        dgvDanhMuc.DataSource = danhMucDao.LayDanhSachDanhMuc();
    }

    private void btnTimDanhMuc_Click(object sender, EventArgs e)
    {
        DanhMucDAO danhMucDao = new DanhMucDAO();
        string timKiem = txtTimKiemDM.Text.Trim();
        dgvDanhMuc.DataSource = danhMucDao.timKiemDanhMuc(timKiem);
    }

    private void txtTimKiemDM_TextChanged(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtTimKiemDM.Text))
        {
            loadData_DGVdsDanhMuc();
        }
    }

    private void dgvdsDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];
        maDMDangChon = Convert.ToInt32(row.Cells["idItems"].Value);
        txtTenDanhMuc.Text = row.Cells["nameItems"].Value?.ToString();
        txtMoTa.Text = row.Cells["descItems"].Value?.ToString();
    }
    public void refreshForm()
    {
        maDMDangChon = 0;
        txtTenDanhMuc.Clear();
        txtMoTa.Clear();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string tenDM = txtTenDanhMuc.Text.Trim();
        string moTaDM = txtMoTa.Text.Trim();
        DanhMucDAO danhMucDao = new DanhMucDAO();

        if (string.IsNullOrWhiteSpace(tenDM) || tenDM.Length < 2)
        {
            MessageBox.Show("Tên danh mục không hợp lệ!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenDanhMuc.Focus();
            return; 
        }
        if (string.IsNullOrWhiteSpace(moTaDM) || moTaDM.Length < 8)
        {
            MessageBox.Show("Mô tả danh mục không dưới 8 ký tự!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenDanhMuc.Focus();
            return; 
        }
        
        DanhMuc dm = new DanhMuc(0,txtTenDanhMuc.Text.Trim(), txtMoTa.Text.Trim());
        DialogResult result = MessageBox.Show("Bạn có xác nhận thêm danh mục hiện tại?", "Xác nhận", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (danhMucDao.ThemDanhMuc(dm))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVdsDanhMuc();
                refreshForm();

            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void btnXoa_Click(object sender, EventArgs e)
    {
        DanhMucDAO danhMucDao = new DanhMucDAO();
        if (maDMDangChon == 0)
        {
            MessageBox.Show("Vui lòng chọn danh mục cần xoá!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá này?", 
            "Xác nhận", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (danhMucDao.XoaDanhMuc(maDMDangChon))
            {
                MessageBox.Show("Xoá món thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVdsDanhMuc();
                refreshForm();
            }
            else
            {
                MessageBox.Show("Xoá thất bại",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void btnSua_Click(object sender, EventArgs e)
    {
        DanhMucDAO danhMucDao = new DanhMucDAO();
        string tenDM = txtTenDanhMuc.Text.Trim();
        string moTaDM = txtMoTa.Text.Trim();
        if (maDMDangChon == 0)
        {
            MessageBox.Show("Vui lòng chọn món cần sửa!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (string.IsNullOrWhiteSpace(tenDM) || tenDM.Length < 2)
        {
            MessageBox.Show("Tên danh mục không hợp lệ!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenDanhMuc.Focus();
            return; 
        }
        if (string.IsNullOrWhiteSpace(moTaDM) || moTaDM.Length < 8)
        {
            MessageBox.Show("Mô tả danh mục không dưới 8 ký tự!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenDanhMuc.Focus();
            return; 
        }
        
        DanhMuc dm = new DanhMuc(maDMDangChon,txtTenDanhMuc.Text.Trim(), txtMoTa.Text.Trim());
        
        DialogResult result = MessageBox.Show("Bạn có xác nhận cập nhật danh mục?", 
            "Xác nhận", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (danhMucDao.CapNhatDanhMuc(dm))
            {
                MessageBox.Show("Cập nhật thành công!",  
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVdsDanhMuc();
                refreshForm();
            }
            else
                MessageBox.Show("Cập nhật thất bại!", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}