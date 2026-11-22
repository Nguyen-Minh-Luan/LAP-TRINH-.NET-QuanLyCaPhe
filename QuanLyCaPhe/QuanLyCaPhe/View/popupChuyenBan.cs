using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class popupChuyenBan : Form
{
    private BanDAO banDao = new BanDAO();
    private LichSuChuyenBanDAO lichSuDao = new LichSuChuyenBanDAO();
    private int maNhanVien = 1;
    private int maBanNguonChonSan = 0;

    public popupChuyenBan()
    {
        InitializeComponent();
        DangKySuKien();
    }

    public popupChuyenBan(int maBanNguon, int maNv = 1) : this()
    {
        maBanNguonChonSan = maBanNguon;
        maNhanVien = maNv;
    }

    private void DangKySuKien()
    {
        this.Load += popupChuyenBan_Load;
        btnXacNhan.Click += btnXacNhan_Click;
        btnHuy.Click += btnHuy_Click;
    }

    private void popupChuyenBan_Load(object? sender, EventArgs e)
    {
        LoadDanhSachBanNguon();
        LoadDanhSachBanDich();
    }

    private void LoadDanhSachBanNguon()
    {
        try
        {
            List<Ban> danhSachTatCaBan = banDao.LayDanhSachBan();
            List<Ban> danhSachBanCoKhach = danhSachTatCaBan
                .Where(b => b.TrangThai != "Trong")
                .ToList();

            cboBanHienTai.DataSource = null;
            cboBanHienTai.DisplayMember = "TenBan";
            cboBanHienTai.ValueMember = "MaBan";
            cboBanHienTai.DataSource = danhSachBanCoKhach;

            if (maBanNguonChonSan > 0)
            {
                cboBanHienTai.SelectedValue = maBanNguonChonSan;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh sách bàn có khách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadDanhSachBanDich()
    {
        try
        {
            List<Ban> danhSachTatCaBan = banDao.LayDanhSachBan();
            List<Ban> danhSachBanTrong = danhSachTatCaBan
                .Where(b => b.TrangThai == "Trong")
                .ToList();

            cboBanMoi.DataSource = null;
            cboBanMoi.DisplayMember = "TenBan";
            cboBanMoi.ValueMember = "MaBan";
            cboBanMoi.DataSource = danhSachBanTrong;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh sách bàn trống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXacNhan_Click(object? sender, EventArgs e)
    {
        try
        {
            if (cboBanHienTai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần chuyển (bàn đang có khách)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboBanMoi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bàn mới (bàn đang trống) để chuyển đến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maBanNguon = Convert.ToInt32(cboBanHienTai.SelectedValue);
            int maBanDich = Convert.ToInt32(cboBanMoi.SelectedValue);

            if (maBanNguon == maBanDich)
            {
                MessageBox.Show("Bàn chuyển đến không được trùng với bàn hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenBanNguon = cboBanHienTai.Text;
            string tenBanDich = cboBanMoi.Text;
            string lyDo = txtGhiChu.Text.Trim();

            var luaChon = MessageBox.Show(
                $"Bạn có chắc chắn muốn chuyển từ [{tenBanNguon}] sang [{tenBanDich}] không?",
                "Xác nhận chuyển bàn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (luaChon != DialogResult.Yes)
            {
                return;
            }

            bool ketQua = lichSuDao.ChuyenBan(maBanNguon, maBanDich, maNhanVien, lyDo, out string thongBaoLoi);

            if (ketQua)
            {
                MessageBox.Show($"Chuyển từ [{tenBanNguon}] sang [{tenBanDich}] thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(thongBaoLoi, "Không thể chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnHuy_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
