using System;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class frmQuanLyKhuVucVaBan : Form
{
    private int maKVDangChon = 0;
    private int maBanDangChon = 0;
 

    
    public frmQuanLyKhuVucVaBan()
    {
        InitializeComponent();
        loadData_DGVKhuVuc();
        loadData_DGVBan();
        loadKhuVuc();
    }

    private void loadData_DGVKhuVuc()
    {
        KhuVucDAO khuVucDao = new KhuVucDAO();
        dgvKhuVuc.AutoGenerateColumns = false;
        idKV.DataPropertyName = "MaKhuVuc";
        nameKV.DataPropertyName = "TenKhuVuc";
        descKV.DataPropertyName = "MoTa";
        dgvKhuVuc.DataSource = khuVucDao.LayDanhSachKhuVuc();
    }
    private void loadData_DGVBan()
    {
        BanDAO banDao = new BanDAO();
        dgvBan.AutoGenerateColumns = false;
        idTable.DataPropertyName = "MaBan";
        nameTable.DataPropertyName = "TenBan";
        nameIdKV.DataPropertyName = "MaKhuVuc";
        seatTable.DataPropertyName = "SoChoNgoi";
        statusTable.DataPropertyName = "TrangThai";
        dgvBan.DataSource = banDao.LayDanhSachBan();
    }

    private void timKiemKV_Click(object sender, EventArgs e)
    {
        KhuVucDAO kvDao = new KhuVucDAO();
        string timKiem = txtTimTenKV.Text.Trim();
        dgvKhuVuc.DataSource = kvDao.timKiemKhuVuc(timKiem);
    }
    private void timKiemBan_Click(object sender, EventArgs e)
    {
        BanDAO banDao = new BanDAO();
        string timKiem = txtTimBan.Text.Trim();
        dgvBan.DataSource = banDao.timKiemTenBan(timKiem);
    }
    private void txtTimKiemKV_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTimTenKV.Text))
        {
            loadData_DGVKhuVuc();
        }
    }
    private void txtTimKiemBan_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTimBan.Text))
        {
            loadData_DGVBan();
        }
    }
    private void loadKhuVuc()
    {
        KhuVucDAO kvDao = new KhuVucDAO();
        cmbKhuVuc.DataSource = kvDao.LayDanhSachKhuVuc();
        cmbKhuVuc.DisplayMember = "TenHienThi";
        cmbKhuVuc.ValueMember = "MaKhuVuc";
    }
    private void dgvKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        DataGridViewRow row = dgvKhuVuc.Rows[e.RowIndex];
        maKVDangChon = Convert.ToInt32(row.Cells["idKV"].Value);
        txtTenKhu.Text = row.Cells["nameKV"].Value?.ToString();
        txtMoTaKV.Text = row.Cells["descKV"].Value?.ToString();
    }
    private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        DataGridViewRow row = dgvBan.Rows[e.RowIndex];
        maBanDangChon = Convert.ToInt32(row.Cells["idTable"].Value);
        txtNameBan.Text = row.Cells["nameTable"].Value?.ToString();
        cmbKhuVuc.SelectedValue = Convert.ToInt32(row.Cells["nameIdKV"].Value);
        txtSoChoBan.Text = row.Cells["seatTable"].Value?.ToString();
        txtStatusTable.Text = row.Cells["statusTable"].Value?.ToString();
    }
    private void refreshFormKV()
    {
        maKVDangChon = 0;
        txtTenKhu.Clear();
        txtMoTaKV.Clear();
    }
    private void refreshFormBan()
    {
        maBanDangChon = 0;
        txtNameBan.Clear();
        txtSoChoBan.Clear();
        if (cmbKhuVuc.Items.Count > 0) cmbKhuVuc.SelectedIndex = 0;
        txtStatusTable.Clear();
    }

    private bool kiemTraKV(string tenKV)
    {
        KhuVucDAO khuVucDao = new KhuVucDAO();
        var dsKV = khuVucDao.LayDanhSachKhuVuc();
        return dsKV.Any(ma => ma.TenKhuVuc.Trim().Equals(tenKV.Trim(),  StringComparison.CurrentCultureIgnoreCase));
    }
    private bool kiemTraKVKhiCapNhat(string tenKV, int MaKV)
    {
        KhuVucDAO khuVucDao = new KhuVucDAO();
        var dsKV = khuVucDao.LayDanhSachKhuVuc();
        return dsKV.Any(ma => ma.TenKhuVuc.Trim().Equals(tenKV.Trim(),  
            StringComparison.CurrentCultureIgnoreCase) && ma.MaKhuVuc != MaKV);
    }
    
    private bool kiemTraBan(string tenBan)
    {
        BanDAO banDao = new BanDAO();
        var dsBan = banDao.LayDanhSachBan();
        return dsBan.Any(ban => ban.TenBan.Trim().Equals(tenBan.Trim(), StringComparison.CurrentCultureIgnoreCase));
    }
    private bool kiemTraBanKhiCapNhat(string tenBan, int MaBan)
    {
        BanDAO banDao = new BanDAO();
        var dsBan = banDao.LayDanhSachBan();
        return dsBan.Any(ban => ban.TenBan.Trim().Equals(tenBan.Trim(),  
            StringComparison.CurrentCultureIgnoreCase) && ban.MaBan != MaBan);
    }
    
    private void btnThemKV_Click(object sender, EventArgs e)
    {
        string tenKV = txtTenKhu.Text.Trim();
        string moTa = txtMoTaKV.Text.Trim();
        KhuVucDAO khuVucDao = new KhuVucDAO();
        
        if (string.IsNullOrWhiteSpace(tenKV) || tenKV.Length < 2)
        {
            MessageBox.Show("Tên khu vực không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenKhu.Focus();
            return;
        }
        if (kiemTraKV(tenKV))
        {
            MessageBox.Show("Tên khu vực đã tồn tại trên hệ thống!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenKhu.Focus();
            return; 
        }
        if (string.IsNullOrWhiteSpace(moTa) || moTa.Length < 8)
        {
            MessageBox.Show("Mô tả không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMoTaKV.Focus();
            return;
        }
        KhuVuc kv = new KhuVuc(0, tenKV, moTa == "" ? null : moTa);
        DialogResult result = MessageBox.Show("Bạn có xác nhận thêm khu vực?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (khuVucDao.ThemKhuVuc(kv))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVKhuVuc();
                loadKhuVuc();
                refreshFormKV();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void btnSuaKV_Click(object sender, EventArgs e)
    {
        string tenKV = txtTenKhu.Text.Trim();
        string moTa = txtMoTaKV.Text.Trim();
        KhuVucDAO khuVucDao = new KhuVucDAO();
        
        if (maKVDangChon == 0)
        {
            MessageBox.Show("Vui lòng chọn khu vực cần sửa!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (string.IsNullOrWhiteSpace(tenKV) || tenKV.Length < 2)
        {
            MessageBox.Show("Tên khu vực không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenKhu.Focus();
            return;
        }
        if (kiemTraKVKhiCapNhat(tenKV, maKVDangChon))
        {
            MessageBox.Show("Tên khu vực đã tồn tại trên hệ thống!", 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenKhu.Focus();
            return; 
        }
        if (string.IsNullOrWhiteSpace(moTa) || moTa.Length < 8)
        {
            MessageBox.Show("Mô tả không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMoTaKV.Focus();
            return;
        }
        KhuVuc kv = new KhuVuc(maKVDangChon, tenKV, moTa == "" ? null : moTa);
        DialogResult result = MessageBox.Show("Bạn có xác nhận cập nhật khu vực?",
            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (khuVucDao.CapNhatKhuVuc(kv))
            {
                MessageBox.Show("Cập nhật thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVKhuVuc();
                loadKhuVuc();
                refreshFormKV();
            }
            else
                MessageBox.Show("Cập nhật thất bại!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnXoaKV_Click(object sender, EventArgs e)
    {
        KhuVucDAO khuVucDao = new KhuVucDAO();
        BanDAO banDao = new BanDAO();

        if (maKVDangChon == 0)
        {
            MessageBox.Show("Vui lòng chọn khu vực cần xoá!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khu vực này?",
            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (khuVucDao.XoaKhuVuc(maKVDangChon))
            {
                MessageBox.Show("Xoá khu vực thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVKhuVuc();
                loadKhuVuc();
                refreshFormKV();
            }
            else
            {
                MessageBox.Show("Xoá thất bại",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
    private void btnThemBan_Click(object sender, EventArgs e)
    {
        string tenBan = txtNameBan.Text.Trim();
        string soChoNgoi = txtSoChoBan.Text;
        string trangThai = txtStatusTable.Text.Trim();
        int maKV = Convert.ToInt32(cmbKhuVuc.SelectedValue);

        BanDAO banDao = new BanDAO();
        
        if (string.IsNullOrWhiteSpace(tenBan) || tenBan.Length < 2)
        {
            MessageBox.Show("Tên bàn không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNameBan.Focus();
            return;
        }

        if (kiemTraBan(tenBan))
        {
            MessageBox.Show("Tên bàn đã tồn tại trên hệ thống!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNameBan.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(trangThai) || trangThai.Length < 2)
        {
            MessageBox.Show("Trạng thái bàn không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtStatusTable.Focus();
            return;
        }
        if (cmbKhuVuc.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn khu vực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!int.TryParse(soChoNgoi, out int soCho) || soCho <= 0)
        {
            MessageBox.Show("Số chỗ ngồi không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoChoBan.Focus();
            return;
        }
        Ban ban = new Ban(0, maKV, tenBan, trangThai , soCho);
        DialogResult result = MessageBox.Show("Bạn có xác nhận thêm bàn?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (banDao.ThemBan(ban))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVBan();
                refreshFormBan();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void btnSuaBan_Click(object sender, EventArgs e)
    {
        string tenBan = txtNameBan.Text.Trim();
        string soChoNgoi = txtSoChoBan.Text;
        string trangThai = txtStatusTable.Text.Trim();
        int maKV = Convert.ToInt32(cmbKhuVuc.SelectedValue);

        BanDAO banDao = new BanDAO();

        if (maBanDangChon == 0)
        {
            MessageBox.Show("Vui lòng chọn bàn cần sửa!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (string.IsNullOrWhiteSpace(tenBan) || tenBan.Length < 2)
        {
            MessageBox.Show("Tên bàn không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNameBan.Focus();
            return;
        }
        if (string.IsNullOrWhiteSpace(trangThai) || trangThai.Length < 2)
        {
            MessageBox.Show("Trạng thái bàn không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtStatusTable.Focus();
            return;
        }
        if (kiemTraBanKhiCapNhat(tenBan, maBanDangChon))
        {
            MessageBox.Show("Tên bàn đã tồn tại trên hệ thống!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNameBan.Focus();
            return;
        }
        if (cmbKhuVuc.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn khu vực!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!int.TryParse(soChoNgoi, out int soCho) || soCho <= 0)
        {
            MessageBox.Show("Số chỗ không hợp lệ!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoChoBan.Focus();
            return;
        }
        
        Ban ban = new Ban(maBanDangChon, maKV, tenBan, trangThai, soCho);
        DialogResult result = MessageBox.Show("Bạn có xác nhận cập nhật bàn?",
            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (banDao.CapNhatBan(ban))
            {
                MessageBox.Show("Cập nhật thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVBan();
                refreshFormBan();
            }
            else
                MessageBox.Show("Cập nhật thất bại!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnXoaBan_Click(object sender, EventArgs e)
    {
        BanDAO banDao = new BanDAO();

        if (maBanDangChon == 0)
        {
            MessageBox.Show("Vui lòng chọn bàn cần xoá!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá bàn này?",
            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (banDao.XoaBan(maBanDangChon))
            {
                MessageBox.Show("Xoá bàn thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData_DGVBan();
                refreshFormBan();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}