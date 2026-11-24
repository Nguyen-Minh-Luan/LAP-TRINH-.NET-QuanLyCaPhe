using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;

namespace QuanLyCaPhe.View;

public partial class popupGopBan : Form
{
    private KhuVucDAO khuVucDao = new KhuVucDAO();
    private BanDAO banDao = new BanDAO();
    private GopBanDAO gopBanDao = new GopBanDAO();
    private int maNhanVien = 1;

    public popupGopBan()
    {
        InitializeComponent();
        DangKySuKien();
    }

    public popupGopBan(int maNv = 1) : this()
    {
        maNhanVien = maNv;
    }

    private void DangKySuKien()
    {
        this.Load += popupGopBan_Load;
        cboChonTang.SelectedIndexChanged += cboChonTang_SelectedIndexChanged;
        btnXacNhan.Click += btnXacNhan_Click;
        btnHuy.Click += btnHuy_Click;
    }

    private void popupGopBan_Load(object? sender, EventArgs e)
    {
        LoadDanhSachKhuVuc();
    }

    private void LoadDanhSachKhuVuc()
    {
        try
        {
            var dsKhuVuc = khuVucDao.LayDanhSachKhuVuc();
            cboChonTang.DataSource = null;
            cboChonTang.DisplayMember = "TenKhuVuc";
            cboChonTang.ValueMember = "MaKhuVuc";
            cboChonTang.DataSource = dsKhuVuc;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh sách khu vực: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cboChonTang_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cboChonTang.SelectedValue != null && int.TryParse(cboChonTang.SelectedValue.ToString(), out int maKhuVuc))
        {
            LoadDanhSachBanTheoKhuVuc(maKhuVuc);
        }
    }

    private void LoadDanhSachBanTheoKhuVuc(int maKhuVuc)
    {
        try
        {
            clbDanhSachBan.Items.Clear();
            var dsBan = banDao.LayDanhSachBanTheoKhuVuc(maKhuVuc);

            foreach (var ban in dsBan)
            {
                var item = new BanItemCheck
                {
                    MaBan = ban.MaBan,
                    TenBan = ban.TenBan,
                    TrangThai = ban.TrangThai
                };

                clbDanhSachBan.Items.Add(item, false);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh sách bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXacNhan_Click(object? sender, EventArgs e)
    {
        try
        {
            var dsBanDuocChon = new List<BanItemCheck>();
            foreach (var item in clbDanhSachBan.CheckedItems)
            {
                if (item is BanItemCheck banCheck)
                {
                    dsBanDuocChon.Add(banCheck);
                }
            }

            if (dsBanDuocChon.Count < 2)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 2 bàn để thực hiện gộp bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenNhom = txtTenNhom.Text.Trim();
            if (string.IsNullOrEmpty(tenNhom))
            {
                tenNhom = "Gộp: " + string.Join(" + ", dsBanDuocChon.Select(b => b.TenBan));
            }

            // Kiểm tra tên nhóm đã có trong cơ sở dữ liệu chưa
            if (gopBanDao.KiemTraTrungTenNhom(tenNhom))
            {
                MessageBox.Show("Tên nhóm bàn này đã tồn tại trong hệ thống, vui lòng đổi tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhom.Focus();
                return;
            }

            var dsMaBan = dsBanDuocChon.Select(b => b.MaBan).ToList();

            string tenCacBan = string.Join(", ", dsBanDuocChon.Select(b => b.TenBan));
            string ghiChu = txtGhiChu.Text.Trim();

            var luaChon = MessageBox.Show(
                $"Bạn có chắc chắn muốn gộp các bàn sau thành một nhóm:\n[{tenCacBan}]?",
                "Xác nhận gộp bàn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (luaChon != DialogResult.Yes)
            {
                return;
            }

            bool thanhCong = gopBanDao.ThucHienGopBan(dsMaBan, maNhanVien, tenNhom, ghiChu, out string thongBaoLoi);

            if (thanhCong)
            {
                MessageBox.Show($"Gộp thành công các bàn: [{tenCacBan}]!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(thongBaoLoi, "Không thể gộp bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

public class BanItemCheck
{
    public int MaBan { get; set; }
    public string TenBan { get; set; } = string.Empty;
    public string TrangThai { get; set; } = string.Empty;

    public override string ToString()
    {
        string moTaTrangThai = TrangThai switch
        {
            "Trong" => "Trống",
            "CoNguoi" => "Có khách",
            "GopBan" => "Đang gộp",
            _ => TrangThai
        };

        return $"{TenBan} [{moTaTrangThai}]";
    }
}
