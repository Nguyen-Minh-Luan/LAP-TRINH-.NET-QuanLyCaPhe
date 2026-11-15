using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe.View;

partial class frmThongKeMonBanChay
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

    private void InitializeComponent()
    {
        DataGridViewCellStyle dgvHeaderStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvCenterStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvRightStyle = new DataGridViewCellStyle();

        lblTieuDe = new Label();
        gbBoLoc = new GroupBox();
        lblTuNgay = new Label();
        dtpTuNgay = new DateTimePicker();
        lblDenNgay = new Label();
        dtpDenNgay = new DateTimePicker();
        lblDanhMuc = new Label();
        cbDanhMuc = new ComboBox();
        btnXemBaoCao = new Button();
        btnLamMoi = new Button();

        gbDanhSachMon = new GroupBox();
        dgvMonBanChay = new DataGridView();
        colSTT = new DataGridViewTextBoxColumn();
        colMaMon = new DataGridViewTextBoxColumn();
        colTenMon = new DataGridViewTextBoxColumn();
        colDanhMuc = new DataGridViewTextBoxColumn();
        colDonGia = new DataGridViewTextBoxColumn();
        colSoLuongBan = new DataGridViewTextBoxColumn();
        colDoanhThu = new DataGridViewTextBoxColumn();

        lblTongKet = new Label();
        btnDong = new Button();

        gbBoLoc.SuspendLayout();
        gbDanhSachMon.SuspendLayout();
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
        lblTieuDe.Text = "THỐNG KÊ TOP MÓN BÁN CHẠY";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

        // 
        // gbBoLoc
        // 
        gbBoLoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        gbBoLoc.Controls.Add(btnLamMoi);
        gbBoLoc.Controls.Add(btnXemBaoCao);
        gbBoLoc.Controls.Add(cbDanhMuc);
        gbBoLoc.Controls.Add(lblDanhMuc);
        gbBoLoc.Controls.Add(dtpDenNgay);
        gbBoLoc.Controls.Add(lblDenNgay);
        gbBoLoc.Controls.Add(dtpTuNgay);
        gbBoLoc.Controls.Add(lblTuNgay);
        gbBoLoc.Location = new Point(12, 50);
        gbBoLoc.Name = "gbBoLoc";
        gbBoLoc.Size = new Size(1000, 68);
        gbBoLoc.TabIndex = 1;
        gbBoLoc.TabStop = false;
        gbBoLoc.Text = "Điều kiện lọc thống kê";

        lblTuNgay.AutoSize = true;
        lblTuNgay.Location = new Point(16, 30);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new Size(52, 15);
        lblTuNgay.TabIndex = 0;
        lblTuNgay.Text = "Từ ngày:";

        dtpTuNgay.CustomFormat = "dd/MM/yyyy";
        dtpTuNgay.Format = DateTimePickerFormat.Custom;
        dtpTuNgay.Location = new Point(74, 26);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new Size(130, 23);
        dtpTuNgay.TabIndex = 1;

        lblDenNgay.AutoSize = true;
        lblDenNgay.Location = new Point(224, 30);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new Size(60, 15);
        lblDenNgay.TabIndex = 2;
        lblDenNgay.Text = "Đến ngày:";

        dtpDenNgay.CustomFormat = "dd/MM/yyyy";
        dtpDenNgay.Format = DateTimePickerFormat.Custom;
        dtpDenNgay.Location = new Point(290, 26);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new Size(130, 23);
        dtpDenNgay.TabIndex = 3;

        lblDanhMuc.AutoSize = true;
        lblDanhMuc.Location = new Point(445, 30);
        lblDanhMuc.Name = "lblDanhMuc";
        lblDanhMuc.Size = new Size(65, 15);
        lblDanhMuc.TabIndex = 4;
        lblDanhMuc.Text = "Danh mục:";

        cbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
        cbDanhMuc.FormattingEnabled = true;
        cbDanhMuc.Location = new Point(516, 26);
        cbDanhMuc.Name = "cbDanhMuc";
        cbDanhMuc.Size = new Size(180, 23);
        cbDanhMuc.TabIndex = 5;
        cbDanhMuc.SelectedIndexChanged += cbDanhMuc_SelectedIndexChanged;

        btnXemBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnXemBaoCao.Location = new Point(775, 24);
        btnXemBaoCao.Name = "btnXemBaoCao";
        btnXemBaoCao.Size = new Size(110, 28);
        btnXemBaoCao.TabIndex = 6;
        btnXemBaoCao.Text = "Xem thống kê";
        btnXemBaoCao.UseVisualStyleBackColor = true;
        btnXemBaoCao.Click += btnXemBaoCao_Click;

        btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnLamMoi.Location = new Point(895, 24);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(90, 28);
        btnLamMoi.TabIndex = 7;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        btnLamMoi.Click += btnLamMoi_Click;

        // 
        // gbDanhSachMon
        // 
        gbDanhSachMon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbDanhSachMon.Controls.Add(dgvMonBanChay);
        gbDanhSachMon.Location = new Point(12, 128);
        gbDanhSachMon.Name = "gbDanhSachMon";
        gbDanhSachMon.Size = new Size(1000, 400);
        gbDanhSachMon.TabIndex = 2;
        gbDanhSachMon.TabStop = false;
        gbDanhSachMon.Text = "Bảng xếp hạng món bán chạy";

        dgvMonBanChay.AllowUserToAddRows = false;
        dgvMonBanChay.AllowUserToDeleteRows = false;
        dgvMonBanChay.AllowUserToResizeRows = false;
        dgvMonBanChay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvMonBanChay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvMonBanChay.BackgroundColor = SystemColors.ControlLight;

        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvHeaderStyle.BackColor = SystemColors.Control;
        dgvHeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dgvHeaderStyle.ForeColor = SystemColors.WindowText;
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight;
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
        dgvMonBanChay.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
        dgvMonBanChay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        dgvMonBanChay.Columns.AddRange(new DataGridViewColumn[] {
            colSTT,
            colMaMon,
            colTenMon,
            colDanhMuc,
            colDonGia,
            colSoLuongBan,
            colDoanhThu
        });

        dgvMonBanChay.GridColor = Color.DarkGray;
        dgvMonBanChay.Location = new Point(16, 25);
        dgvMonBanChay.MultiSelect = false;
        dgvMonBanChay.Name = "dgvMonBanChay";
        dgvMonBanChay.ReadOnly = true;
        dgvMonBanChay.RowHeadersVisible = false;
        dgvMonBanChay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMonBanChay.Size = new Size(968, 362);
        dgvMonBanChay.TabIndex = 0;
        dgvMonBanChay.CellClick += dgvMonBanChay_CellClick;

        dgvCenterStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvRightStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        colSTT.DefaultCellStyle = dgvCenterStyle;
        colSTT.FillWeight = 35F;
        colSTT.HeaderText = "Hạng";
        colSTT.Name = "colSTT";
        colSTT.ReadOnly = true;

        colMaMon.DefaultCellStyle = dgvCenterStyle;
        colMaMon.FillWeight = 65F;
        colMaMon.HeaderText = "Mã món";
        colMaMon.Name = "colMaMon";
        colMaMon.ReadOnly = true;

        colTenMon.FillWeight = 140F;
        colTenMon.HeaderText = "Tên thức uống / món ăn";
        colTenMon.Name = "colTenMon";
        colTenMon.ReadOnly = true;

        colDanhMuc.FillWeight = 90F;
        colDanhMuc.HeaderText = "Danh mục";
        colDanhMuc.Name = "colDanhMuc";
        colDanhMuc.ReadOnly = true;

        colDonGia.DefaultCellStyle = dgvRightStyle;
        colDonGia.FillWeight = 85F;
        colDonGia.HeaderText = "Đơn giá (VNĐ)";
        colDonGia.Name = "colDonGia";
        colDonGia.ReadOnly = true;

        colSoLuongBan.DefaultCellStyle = dgvCenterStyle;
        colSoLuongBan.FillWeight = 75F;
        colSoLuongBan.HeaderText = "Số lượng bán";
        colSoLuongBan.Name = "colSoLuongBan";
        colSoLuongBan.ReadOnly = true;

        colDoanhThu.DefaultCellStyle = dgvRightStyle;
        colDoanhThu.FillWeight = 105F;
        colDoanhThu.HeaderText = "Tổng doanh thu (VNĐ)";
        colDoanhThu.Name = "colDoanhThu";
        colDoanhThu.ReadOnly = true;

        // 
        // lblTongKet
        // 
        lblTongKet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTongKet.AutoSize = true;
        lblTongKet.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblTongKet.ForeColor = Color.DarkSlateGray;
        lblTongKet.Location = new Point(12, 542);
        lblTongKet.Name = "lblTongKet";
        lblTongKet.Size = new Size(210, 15);
        lblTongKet.TabIndex = 3;
        lblTongKet.Text = "Tổng số lượng bán: 0 | Doanh thu: 0 đ";

        // 
        // btnDong
        // 
        btnDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnDong.Location = new Point(912, 537);
        btnDong.Name = "btnDong";
        btnDong.Size = new Size(100, 28);
        btnDong.TabIndex = 4;
        btnDong.Text = "Đóng";
        btnDong.UseVisualStyleBackColor = true;
        btnDong.Click += btnDong_Click;

        // 
        // frmThongKeMonBanChay
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 575);
        Controls.Add(btnDong);
        Controls.Add(lblTongKet);
        Controls.Add(gbDanhSachMon);
        Controls.Add(gbBoLoc);
        Controls.Add(lblTieuDe);
        MinimumSize = new Size(950, 550);
        Name = "frmThongKeMonBanChay";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Thống Kê Món Bán Chạy";
        Load += frmThongKeMonBanChay_Load;
        gbBoLoc.ResumeLayout(false);
        gbBoLoc.PerformLayout();
        gbDanhSachMon.ResumeLayout(false);
        ((ISupportInitialize)dgvMonBanChay).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTieuDe;
    private GroupBox gbBoLoc;
    private Label lblTuNgay;
    private DateTimePicker dtpTuNgay;
    private Label lblDenNgay;
    private DateTimePicker dtpDenNgay;
    private Label lblDanhMuc;
    private ComboBox cbDanhMuc;
    private Button btnXemBaoCao;
    private Button btnLamMoi;

    private GroupBox gbDanhSachMon;
    private DataGridView dgvMonBanChay;
    private DataGridViewTextBoxColumn colSTT;
    private DataGridViewTextBoxColumn colMaMon;
    private DataGridViewTextBoxColumn colTenMon;
    private DataGridViewTextBoxColumn colDanhMuc;
    private DataGridViewTextBoxColumn colDonGia;
    private DataGridViewTextBoxColumn colSoLuongBan;
    private DataGridViewTextBoxColumn colDoanhThu;

    private Label lblTongKet;
    private Button btnDong;
}