using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe.View;

partial class frmThongKeDoanhThu
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dgvDoanhThuHeaderStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvDoanhThuSTTStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvDoanhThuThangStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvDoanhThuSoHDStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvDoanhThuTienStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvMonHeaderStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvMonSTTStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvMonSoLuongStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvMonTienStyle = new DataGridViewCellStyle();

        lblTieuDe = new Label();
        tabControlMain = new TabControl();
        tabDoanhThu = new TabPage();
        lblNam = new Label();
        cbNam = new ComboBox();
        gbBangDoanhThu = new GroupBox();
        dgvDoanhThu = new DataGridView();
        colDTSTT = new DataGridViewTextBoxColumn();
        colDTThang = new DataGridViewTextBoxColumn();
        colDTSoHoaDon = new DataGridViewTextBoxColumn();
        colDTDoanhThu = new DataGridViewTextBoxColumn();
        gbBieuDo = new GroupBox();
        panelChartContainer = new Panel();
        tabMon = new TabPage();
        gbMonBanChay = new GroupBox();
        dgvMonBanChay = new DataGridView();
        colMonSTT = new DataGridViewTextBoxColumn();
        colMonTen = new DataGridViewTextBoxColumn();
        colMonSoLuong = new DataGridViewTextBoxColumn();
        colMonDoanhThu = new DataGridViewTextBoxColumn();
        lblTongKet = new Label();
        btnDong = new Button();

        tabControlMain.SuspendLayout();
        tabDoanhThu.SuspendLayout();
        gbBangDoanhThu.SuspendLayout();
        ((ISupportInitialize)dgvDoanhThu).BeginInit();
        gbBieuDo.SuspendLayout();
        tabMon.SuspendLayout();
        gbMonBanChay.SuspendLayout();
        ((ISupportInitialize)dgvMonBanChay).BeginInit();
        SuspendLayout();

        // 
        // lblTieuDe
        // 
        lblTieuDe.Dock = DockStyle.Top;
        lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTieuDe.ForeColor = Color.Blue;
        lblTieuDe.Location = new Point(0, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(1024, 45);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "THỐNG KÊ DOANH THU";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

        // 
        // tabControlMain
        // 
        tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabControlMain.Controls.Add(tabDoanhThu);
        tabControlMain.Controls.Add(tabMon);
        tabControlMain.Location = new Point(12, 50);
        tabControlMain.Name = "tabControlMain";
        tabControlMain.SelectedIndex = 0;
        tabControlMain.Size = new Size(1000, 480);
        tabControlMain.TabIndex = 1;

        // 
        // tabDoanhThu
        // 
        tabDoanhThu.Controls.Add(gbBieuDo);
        tabDoanhThu.Controls.Add(gbBangDoanhThu);
        tabDoanhThu.Controls.Add(cbNam);
        tabDoanhThu.Controls.Add(lblNam);
        tabDoanhThu.Location = new Point(4, 24);
        tabDoanhThu.Name = "tabDoanhThu";
        tabDoanhThu.Padding = new Padding(3);
        tabDoanhThu.Size = new Size(992, 452);
        tabDoanhThu.TabIndex = 0;
        tabDoanhThu.Text = "Doanh thu";
        tabDoanhThu.UseVisualStyleBackColor = true;

        // lblNam
        lblNam.AutoSize = true;
        lblNam.Location = new Point(16, 18);
        lblNam.Name = "lblNam";
        lblNam.Size = new Size(36, 15);
        lblNam.TabIndex = 0;
        lblNam.Text = "Năm:";

        // cbNam
        cbNam.DropDownStyle = ComboBoxStyle.DropDownList;
        cbNam.FormattingEnabled = true;
        cbNam.Location = new Point(58, 14);
        cbNam.Name = "cbNam";
        cbNam.Size = new Size(120, 23);
        cbNam.TabIndex = 1;
        cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;

        // 
        // gbBangDoanhThu
        // 
        gbBangDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gbBangDoanhThu.Controls.Add(dgvDoanhThu);
        gbBangDoanhThu.Location = new Point(10, 45);
        gbBangDoanhThu.Name = "gbBangDoanhThu";
        gbBangDoanhThu.Size = new Size(400, 397);
        gbBangDoanhThu.TabIndex = 2;
        gbBangDoanhThu.TabStop = false;
        gbBangDoanhThu.Text = "Doanh thu theo tháng";

        // dgvDoanhThu
        dgvDoanhThu.AllowUserToAddRows = false;
        dgvDoanhThu.AllowUserToDeleteRows = false;
        dgvDoanhThu.AllowUserToResizeRows = false;
        dgvDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDoanhThu.BackgroundColor = SystemColors.ControlLight;
        dgvDoanhThuHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvDoanhThuHeaderStyle.BackColor = SystemColors.Control;
        dgvDoanhThuHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dgvDoanhThuHeaderStyle.ForeColor = SystemColors.WindowText;
        dgvDoanhThuHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvDoanhThuHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvDoanhThuHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvDoanhThu.ColumnHeadersDefaultCellStyle = dgvDoanhThuHeaderStyle;
        dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDoanhThu.Columns.AddRange(new DataGridViewColumn[] {
            colDTSTT,
            colDTThang,
            colDTSoHoaDon,
            colDTDoanhThu
        });
        dgvDoanhThu.GridColor = Color.DarkGray;
        dgvDoanhThu.Location = new Point(16, 25);
        dgvDoanhThu.MultiSelect = false;
        dgvDoanhThu.Name = "dgvDoanhThu";
        dgvDoanhThu.ReadOnly = true;
        dgvDoanhThu.RowHeadersVisible = false;
        dgvDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDoanhThu.Size = new Size(368, 360);
        dgvDoanhThu.TabIndex = 0;
        dgvDoanhThu.CellClick += dgvDoanhThu_CellClick;

        // colDTSTT
        dgvDoanhThuSTTStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colDTSTT.DefaultCellStyle = dgvDoanhThuSTTStyle;
        colDTSTT.FillWeight = 35F;
        colDTSTT.HeaderText = "STT";
        colDTSTT.Name = "colDTSTT";
        colDTSTT.ReadOnly = true;

        // colDTThang
        dgvDoanhThuThangStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colDTThang.DefaultCellStyle = dgvDoanhThuThangStyle;
        colDTThang.FillWeight = 60F;
        colDTThang.HeaderText = "Tháng";
        colDTThang.Name = "colDTThang";
        colDTThang.ReadOnly = true;

        // colDTSoHoaDon
        dgvDoanhThuSoHDStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colDTSoHoaDon.DefaultCellStyle = dgvDoanhThuSoHDStyle;
        colDTSoHoaDon.FillWeight = 70F;
        colDTSoHoaDon.HeaderText = "Số hóa đơn";
        colDTSoHoaDon.Name = "colDTSoHoaDon";
        colDTSoHoaDon.ReadOnly = true;

        // colDTDoanhThu
        dgvDoanhThuTienStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        colDTDoanhThu.DefaultCellStyle = dgvDoanhThuTienStyle;
        colDTDoanhThu.FillWeight = 100F;
        colDTDoanhThu.HeaderText = "Doanh thu (VNĐ)";
        colDTDoanhThu.Name = "colDTDoanhThu";
        colDTDoanhThu.ReadOnly = true;

        // 
        // gbBieuDo
        // 
        gbBieuDo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbBieuDo.Controls.Add(panelChartContainer);
        gbBieuDo.Location = new Point(420, 45);
        gbBieuDo.Name = "gbBieuDo";
        gbBieuDo.Size = new Size(562, 397);
        gbBieuDo.TabIndex = 3;
        gbBieuDo.TabStop = false;
        gbBieuDo.Text = "Biểu đồ doanh thu";

        // panelChartContainer
        panelChartContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelChartContainer.BackColor = Color.White;
        panelChartContainer.BorderStyle = BorderStyle.FixedSingle;
        panelChartContainer.Location = new Point(16, 25);
        panelChartContainer.Name = "panelChartContainer";
        panelChartContainer.Size = new Size(530, 360);
        panelChartContainer.TabIndex = 0;
        panelChartContainer.Paint += panelChartContainer_Paint;

        // 
        // tabMon
        // 
        tabMon.Controls.Add(gbMonBanChay);
        tabMon.Location = new Point(4, 24);
        tabMon.Name = "tabMon";
        tabMon.Padding = new Padding(3);
        tabMon.Size = new Size(992, 452);
        tabMon.TabIndex = 1;
        tabMon.Text = "Món bán chạy";
        tabMon.UseVisualStyleBackColor = true;

        // 
        // gbMonBanChay
        // 
        gbMonBanChay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbMonBanChay.Controls.Add(dgvMonBanChay);
        gbMonBanChay.Location = new Point(10, 10);
        gbMonBanChay.Name = "gbMonBanChay";
        gbMonBanChay.Size = new Size(972, 432);
        gbMonBanChay.TabIndex = 0;
        gbMonBanChay.TabStop = false;
        gbMonBanChay.Text = "Danh sách món bán chạy";

        // dgvMonBanChay
        dgvMonBanChay.AllowUserToAddRows = false;
        dgvMonBanChay.AllowUserToDeleteRows = false;
        dgvMonBanChay.AllowUserToResizeRows = false;
        dgvMonBanChay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvMonBanChay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvMonBanChay.BackgroundColor = SystemColors.ControlLight;
        dgvMonHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvMonHeaderStyle.BackColor = SystemColors.Control;
        dgvMonHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dgvMonHeaderStyle.ForeColor = SystemColors.WindowText;
        dgvMonHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvMonHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvMonHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvMonBanChay.ColumnHeadersDefaultCellStyle = dgvMonHeaderStyle;
        dgvMonBanChay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMonBanChay.Columns.AddRange(new DataGridViewColumn[] {
            colMonSTT,
            colMonTen,
            colMonSoLuong,
            colMonDoanhThu
        });
        dgvMonBanChay.GridColor = Color.DarkGray;
        dgvMonBanChay.Location = new Point(16, 25);
        dgvMonBanChay.MultiSelect = false;
        dgvMonBanChay.Name = "dgvMonBanChay";
        dgvMonBanChay.ReadOnly = true;
        dgvMonBanChay.RowHeadersVisible = false;
        dgvMonBanChay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMonBanChay.Size = new Size(940, 395);
        dgvMonBanChay.TabIndex = 0;
        dgvMonBanChay.CellClick += dgvMonBanChay_CellClick;

        // colMonSTT
        dgvMonSTTStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colMonSTT.DefaultCellStyle = dgvMonSTTStyle;
        colMonSTT.FillWeight = 35F;
        colMonSTT.HeaderText = "STT";
        colMonSTT.Name = "colMonSTT";
        colMonSTT.ReadOnly = true;

        // colMonTen
        colMonTen.FillWeight = 160F;
        colMonTen.HeaderText = "Tên món";
        colMonTen.Name = "colMonTen";
        colMonTen.ReadOnly = true;

        // colMonSoLuong
        dgvMonSoLuongStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colMonSoLuong.DefaultCellStyle = dgvMonSoLuongStyle;
        colMonSoLuong.FillWeight = 70F;
        colMonSoLuong.HeaderText = "Số lượng bán";
        colMonSoLuong.Name = "colMonSoLuong";
        colMonSoLuong.ReadOnly = true;

        // colMonDoanhThu
        dgvMonTienStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        colMonDoanhThu.DefaultCellStyle = dgvMonTienStyle;
        colMonDoanhThu.FillWeight = 100F;
        colMonDoanhThu.HeaderText = "Doanh thu (VNĐ)";
        colMonDoanhThu.Name = "colMonDoanhThu";
        colMonDoanhThu.ReadOnly = true;

        // 
        // lblTongKet
        // 
        lblTongKet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTongKet.AutoSize = true;
        lblTongKet.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblTongKet.ForeColor = Color.DarkSlateGray;
        lblTongKet.Location = new Point(12, 542);
        lblTongKet.Name = "lblTongKet";
        lblTongKet.Size = new Size(133, 15);
        lblTongKet.TabIndex = 2;
        lblTongKet.Text = "Tổng doanh thu: 0 đ";

        // 
        // btnDong
        // 
        btnDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnDong.Location = new Point(912, 537);
        btnDong.Name = "btnDong";
        btnDong.Size = new Size(100, 28);
        btnDong.TabIndex = 3;
        btnDong.Text = "Đóng";
        btnDong.UseVisualStyleBackColor = true;
        btnDong.Click += btnDong_Click;

        // 
        // frmThongKeDoanhThu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 575);
        Controls.Add(btnDong);
        Controls.Add(lblTongKet);
        Controls.Add(tabControlMain);
        Controls.Add(lblTieuDe);
        MinimumSize = new Size(950, 550);
        Name = "frmThongKeDoanhThu";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Thống Kê Doanh Thu";
        tabControlMain.ResumeLayout(false);
        tabDoanhThu.ResumeLayout(false);
        tabDoanhThu.PerformLayout();
        gbBangDoanhThu.ResumeLayout(false);
        ((ISupportInitialize)dgvDoanhThu).EndInit();
        gbBieuDo.ResumeLayout(false);
        tabMon.ResumeLayout(false);
        gbMonBanChay.ResumeLayout(false);
        ((ISupportInitialize)dgvMonBanChay).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTieuDe;
    private TabControl tabControlMain;
    private TabPage tabDoanhThu;
    private Label lblNam;
    private ComboBox cbNam;
    private GroupBox gbBangDoanhThu;
    private DataGridView dgvDoanhThu;
    private DataGridViewTextBoxColumn colDTSTT;
    private DataGridViewTextBoxColumn colDTThang;
    private DataGridViewTextBoxColumn colDTSoHoaDon;
    private DataGridViewTextBoxColumn colDTDoanhThu;
    private GroupBox gbBieuDo;
    private Panel panelChartContainer;
    private TabPage tabMon;
    private GroupBox gbMonBanChay;
    private DataGridView dgvMonBanChay;
    private DataGridViewTextBoxColumn colMonSTT;
    private DataGridViewTextBoxColumn colMonTen;
    private DataGridViewTextBoxColumn colMonSoLuong;
    private DataGridViewTextBoxColumn colMonDoanhThu;
    private Label lblTongKet;
    private Button btnDong;
}
