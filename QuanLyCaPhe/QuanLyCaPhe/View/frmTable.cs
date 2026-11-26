using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;
using QuanLyCaPhe.Model;
using QuanLyCaPhe.View;

namespace QuanLyCaPhe;

public partial class frmTable : Form
{
    private readonly BanDAO banDao = new();
    private NhanVien? nhanVienHienTai;

    public frmTable()
    {
        InitializeComponent();
    }

    public frmTable(NhanVien? nv) : this()
    {
        nhanVienHienTai = nv;
    }

    private void frmTable_Load(object? sender, EventArgs e)
    {
        PhanQuyenTheoVaiTro();
        LoadDanhSachBan();
    }

    private void PhanQuyenTheoVaiTro()
    {
        if (nhanVienHienTai != null && nhanVienHienTai.VaiTro.Trim().Equals("Pha chế", StringComparison.OrdinalIgnoreCase))
        {
            button2.Visible = false;
            button3.Visible = false;
        }
    }

    public void LoadDanhSachBan()
    {
        flpTang1.Controls.Clear();
        flpTang2.Controls.Clear();
        flpSanThuong.Controls.Clear();

        List<Ban> dsBan = banDao.LayDanhSachBan();

        foreach (Ban ban in dsBan)
        {
            string thongTinHienThi = (ban.TrangThai == "GopBan" && !string.IsNullOrWhiteSpace(ban.TenNhom))
                ? $"{ban.TenBan}\n[{ban.TenNhom}]\n({ban.SoChoNgoi} chỗ)"
                : $"{ban.TenBan}\n({ban.SoChoNgoi} chỗ)";

            Button btn = new Button
            {
                Width = 118,
                Height = 96,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                TextAlign = ContentAlignment.BottomCenter,
                ImageAlign = ContentAlignment.TopCenter,
                ImageList = imgListBan,
                ImageKey = "coffee-table (1).png",
                Text = thongTinHienThi,
                BackColor = LayMauTheoTrangThai(ban.TrangThai),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Tag = ban
            };
            btn.FlatAppearance.BorderSize = 0;

            btn.Click += BtnBan_Click;

            if (ban.MaKhuVuc == 1)
            {
                flpTang1.Controls.Add(btn);
            }
            else if (ban.MaKhuVuc == 2)
            {
                flpTang2.Controls.Add(btn);
            }
            else
            {
                flpSanThuong.Controls.Add(btn);
            }
        }
    }

    private Color LayMauTheoTrangThai(string trangThai)
    {
        return trangThai switch
        {
            "Trong" => Color.DarkSeaGreen,
            "CoNguoi" => Color.RosyBrown,
            "GopBan" => Color.LightSteelBlue,
            _ => Color.DarkSeaGreen
        };
    }

    private void BtnBan_Click(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            Button btn = (Button)sender;
            if (btn.Tag != null)
            {
                Ban ban = (Ban)btn.Tag;
                frmTableDetail detail = new frmTableDetail(ban, nhanVienHienTai);
                detail.ShowDialog();
                LoadDanhSachBan();
            }
        }
    }

    private void btnLamMoi_Click(object? sender, EventArgs e)
    {
        LoadDanhSachBan();
        
    }

    private void btnQuayLai_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        popupChuyenBan chuyenBanBtn = new popupChuyenBan();
        if (chuyenBanBtn.ShowDialog() == DialogResult.OK)
        {
            LoadDanhSachBan();
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        popupGopBan gopBanBtn = new popupGopBan();
        if (gopBanBtn.ShowDialog() == DialogResult.OK)
        {
            LoadDanhSachBan();
        }
    }
}
