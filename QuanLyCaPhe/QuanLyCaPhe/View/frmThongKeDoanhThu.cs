using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using QuanLyCaPhe.Dao;

namespace QuanLyCaPhe.View;

public partial class frmThongKeDoanhThu : Form
{
    private readonly ThongKeDAO _thongKeDAO = new();
    private readonly decimal[] _doanhThu12Thang = new decimal[12];
    private readonly int[] _soHoaDon12Thang = new int[12];
    private int _thangDangChon = -1;

    public frmThongKeDoanhThu()
    {
        InitializeComponent();
        this.Load += frmThongKeDoanhThu_Load;
        panelChartContainer.Resize += (s, e) => panelChartContainer.Invalidate();
    }

    private void frmThongKeDoanhThu_Load(object? sender, EventArgs e)
    {
        var dsNam = _thongKeDAO.LayDanhSachNam();
        cbNam.DataSource = dsNam;
        if (cbNam.Items.Count > 0)
        {
            cbNam.SelectedIndex = 0;
        }
    }

    private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbNam.SelectedItem == null) return;
        if (!int.TryParse(cbNam.SelectedItem.ToString(), out int nam)) return;

        _thangDangChon = -1;
        TaiDuLieuDoanhThu(nam);
        TaiDuLieuMonBanChay(nam);
    }

    private void TaiDuLieuDoanhThu(int nam)
    {
        try
        {
            Array.Clear(_doanhThu12Thang, 0, _doanhThu12Thang.Length);
            Array.Clear(_soHoaDon12Thang, 0, _soHoaDon12Thang.Length);

            DataTable dt = _thongKeDAO.ThongKeDoanhThuTheoNam(nam);
            foreach (DataRow row in dt.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                if (thang >= 1 && thang <= 12)
                {
                    _soHoaDon12Thang[thang - 1] = Convert.ToInt32(row["SoHoaDon"]);
                    _doanhThu12Thang[thang - 1] = Convert.ToDecimal(row["DoanhThu"]);
                }
            }

            dgvDoanhThu.Rows.Clear();
            decimal tongDoanhThuNam = 0;
            int tongHoaDonNam = 0;

            for (int i = 0; i < 12; i++)
            {
                int thang = i + 1;
                int soHD = _soHoaDon12Thang[i];
                decimal doanhThu = _doanhThu12Thang[i];

                tongHoaDonNam += soHD;
                tongDoanhThuNam += doanhThu;

                dgvDoanhThu.Rows.Add(
                    thang,
                    $"Tháng {thang:00}",
                    soHD,
                    doanhThu.ToString("N0")
                );
            }

            dgvDoanhThu.ClearSelection();
            gbBangDoanhThu.Text = $"Doanh thu theo tháng - Năm {nam}";
            gbBieuDo.Text = $"Biểu đồ doanh thu năm {nam}";
            lblTongKet.Text = $"Năm {nam} | Tổng số hóa đơn: {tongHoaDonNam:N0} | Tổng doanh thu: {tongDoanhThuNam:N0} đ";

            panelChartContainer.Invalidate();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải thống kê doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void TaiDuLieuMonBanChay(int nam)
    {
        try
        {
            DataTable dt = _thongKeDAO.ThongKeMonBanChay(nam);
            dgvMonBanChay.Rows.Clear();

            int stt = 1;
            foreach (DataRow row in dt.Rows)
            {
                dgvMonBanChay.Rows.Add(
                    stt++,
                    row["TenMon"].ToString(),
                    Convert.ToInt32(row["TongSoLuong"]),
                    Convert.ToDecimal(row["TongDoanhThu"]).ToString("N0")
                );
            }

            gbMonBanChay.Text = $"Danh sách món bán chạy - Năm {nam} ({dt.Rows.Count} món)";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải thống kê món bán chạy: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= 12) return;

        _thangDangChon = e.RowIndex + 1;
        panelChartContainer.Invalidate();
    }

    private void dgvMonBanChay_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void panelChartContainer_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Color.White);

        int w = panelChartContainer.Width;
        int h = panelChartContainer.Height;
        if (w < 120 || h < 120) return;

        int marginLeft = 75;
        int marginRight = 20;
        int marginTop = 32;
        int marginBottom = 42;

        int chartWidth = w - marginLeft - marginRight;
        int chartHeight = h - marginTop - marginBottom;
        if (chartWidth <= 20 || chartHeight <= 20) return;

        decimal maxVal = _doanhThu12Thang.Max();
        if (maxVal <= 0) maxVal = 1_000_000;

        double magnitude = Math.Pow(10, Math.Floor(Math.Log10((double)maxVal)));
        decimal niceMax = (decimal)(Math.Ceiling((double)maxVal / magnitude) * magnitude);

        using Pen penGrid = new Pen(Color.FromArgb(232, 232, 232), 1) { DashStyle = DashStyle.Dash };
        using Pen penAxis = new Pen(Color.FromArgb(110, 110, 110), 1.5f);
        using Font fontAxis = new Font("Segoe UI", 8.5f);
        using Font fontVal = new Font("Segoe UI", 7.5f, FontStyle.Bold);

        int gridSteps = 5;
        for (int i = 0; i <= gridSteps; i++)
        {
            float y = marginTop + chartHeight - (chartHeight * i / (float)gridSteps);
            decimal val = niceMax * i / gridSteps;
            string yLabel = val >= 1_000_000 ? $"{val / 1_000_000:0.#}M" :
                            val >= 1_000 ? $"{val / 1_000:0}K" : $"{val:0}";

            g.DrawLine(penGrid, marginLeft, y, marginLeft + chartWidth, y);
            SizeF sz = g.MeasureString(yLabel, fontAxis);
            g.DrawString(yLabel, fontAxis, Brushes.DimGray, marginLeft - sz.Width - 6, y - sz.Height / 2);
        }

        g.DrawLine(penAxis, marginLeft, marginTop, marginLeft, marginTop + chartHeight);
        g.DrawLine(penAxis, marginLeft, marginTop + chartHeight, marginLeft + chartWidth, marginTop + chartHeight);

        float slotWidth = chartWidth / 12f;
        float barWidth = Math.Min(36f, slotWidth * 0.6f);

        for (int i = 0; i < 12; i++)
        {
            decimal val = _doanhThu12Thang[i];
            float barHeight = (float)(val / niceMax) * chartHeight;
            float x = marginLeft + i * slotWidth + (slotWidth - barWidth) / 2;
            float y = marginTop + chartHeight - barHeight;

            bool isSelected = (_thangDangChon == i + 1);
            Color barColor = isSelected
                ? Color.FromArgb(211, 84, 0)
                : Color.FromArgb(41, 128, 185);

            if (barHeight > 0)
            {
                using SolidBrush brushBar = new SolidBrush(barColor);
                g.FillRectangle(brushBar, x, y, barWidth, barHeight);

                string valText = val >= 1_000_000 ? $"{val / 1_000_000:0.#}M" : $"{val / 1_000:0}K";
                SizeF valSize = g.MeasureString(valText, fontVal);
                g.DrawString(valText, fontVal, isSelected ? Brushes.DarkRed : Brushes.Black,
                    x + (barWidth - valSize.Width) / 2, y - valSize.Height - 2);
            }

            string monthLabel = $"T{i + 1}";
            SizeF mSize = g.MeasureString(monthLabel, fontAxis);
            g.DrawString(monthLabel, fontAxis, isSelected ? Brushes.DarkRed : Brushes.Black,
                x + (barWidth - mSize.Width) / 2, marginTop + chartHeight + 6);
        }
    }

    private void btnDong_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}