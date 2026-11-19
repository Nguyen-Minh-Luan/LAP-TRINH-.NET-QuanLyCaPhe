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

    public frmTable()
    {
        InitializeComponent();
    }

    private void frmTable_Load(object? sender, EventArgs e)
    {
        LoadDanhSachBan();
    }

    public void LoadDanhSachBan()
    {
        flpTang1.Controls.Clear();
        flpTang2.Controls.Clear();
        flpSanThuong.Controls.Clear();

        List<Ban> dsBan = banDao.LayDanhSachBan();

        foreach (Ban ban in dsBan)
        {
            Button btn = new Button
            {
                Width = 112,
                Height = 87,
                Font = new Font("Segoe UI", 9.75f, FontStyle.Bold),
                TextAlign = ContentAlignment.BottomCenter,
                ImageAlign = ContentAlignment.TopCenter,
                ImageList = imgListBan,
                ImageKey = "coffee-table (1).png",
                Text = $"{ban.TenBan}\n({ban.SoChoNgoi} chỗ)",
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
                frmTableDetail detail = new frmTableDetail(ban);
                detail.ShowDialog();
                LoadDanhSachBan();
            }
        }
    }

    private void btnLamMoi_Click(object? sender, EventArgs e)
    {
        LoadDanhSachBan();
        
    }

    private void button1_Click(object? sender, EventArgs e)
    {
    }

    private void nướcUốngToolStripMenuItem_Click(object? sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
        popupChuyenBan chuyenBanBtn = new popupChuyenBan();
        chuyenBanBtn.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        popupGopBan gopBanBtn = new popupGopBan();
        gopBanBtn.ShowDialog();
    }
}
