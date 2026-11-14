using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe.View;

partial class frmQuanLyCaLam
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
        DataGridViewCellStyle dgvCellStyleHeader = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvCellStyleSTT = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvCellStyleMaCa = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvCellStyleGioBatDau = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvCellStyleGioKetThuc = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvCellStyleLuong = new DataGridViewCellStyle();

        lblTieuDe = new Label();
        gbThongTinCa = new GroupBox();
        lblMaCa = new Label();
        txtMaCa = new TextBox();
        lblTenCa = new Label();
        txtTenCa = new TextBox();
        lblGioBatDau = new Label();
        dtpGioBatDau = new DateTimePicker();
        lblGioKetThuc = new Label();
        dtpGioKetThuc = new DateTimePicker();
        lblLuongCa = new Label();
        txtLuongCa = new TextBox();
        lblDonViTien = new Label();
        lblGhiChu = new Label();
        txtGhiChu = new TextBox();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnLamMoi = new Button();

        gbDanhSachCa = new GroupBox();
        lblTimKiem = new Label();
        txtTimKiem = new TextBox();
        btnTraCuu = new Button();
        btnTatCa = new Button();
        dgvCaLam = new DataGridView();
        colSTT = new DataGridViewTextBoxColumn();
        colMaCa = new DataGridViewTextBoxColumn();
        colTenCa = new DataGridViewTextBoxColumn();
        colGioBatDau = new DataGridViewTextBoxColumn();
        colGioKetThuc = new DataGridViewTextBoxColumn();
        colLuongCa = new DataGridViewTextBoxColumn();
        colGhiChu = new DataGridViewTextBoxColumn();

        lblTongSoCa = new Label();
        btnDong = new Button();

        gbThongTinCa.SuspendLayout();
        gbDanhSachCa.SuspendLayout();
        ((ISupportInitialize)dgvCaLam).BeginInit();
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
        lblTieuDe.Text = "QUẢN LÝ CA LÀM VIỆC";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

        // 
        // gbThongTinCa (Cột trái: Thông tin ca làm)
        // 
        gbThongTinCa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gbThongTinCa.Controls.Add(btnLamMoi);
        gbThongTinCa.Controls.Add(btnXoa);
        gbThongTinCa.Controls.Add(btnSua);
        gbThongTinCa.Controls.Add(btnThem);
        gbThongTinCa.Controls.Add(txtGhiChu);
        gbThongTinCa.Controls.Add(lblGhiChu);
        gbThongTinCa.Controls.Add(lblDonViTien);
        gbThongTinCa.Controls.Add(txtLuongCa);
        gbThongTinCa.Controls.Add(lblLuongCa);
        gbThongTinCa.Controls.Add(dtpGioKetThuc);
        gbThongTinCa.Controls.Add(lblGioKetThuc);
        gbThongTinCa.Controls.Add(dtpGioBatDau);
        gbThongTinCa.Controls.Add(lblGioBatDau);
        gbThongTinCa.Controls.Add(txtTenCa);
        gbThongTinCa.Controls.Add(lblTenCa);
        gbThongTinCa.Controls.Add(txtMaCa);
        gbThongTinCa.Controls.Add(lblMaCa);
        gbThongTinCa.Location = new Point(12, 50);
        gbThongTinCa.Name = "gbThongTinCa";
        gbThongTinCa.Size = new Size(360, 480);
        gbThongTinCa.TabIndex = 1;
        gbThongTinCa.TabStop = false;
        gbThongTinCa.Text = "Thông tin ca làm việc";

        // lblMaCa
        lblMaCa.AutoSize = true;
        lblMaCa.Location = new Point(16, 25);
        lblMaCa.Name = "lblMaCa";
        lblMaCa.Size = new Size(42, 15);
        lblMaCa.TabIndex = 0;
        lblMaCa.Text = "Mã ca:";

        // txtMaCa
        txtMaCa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtMaCa.Location = new Point(16, 45);
        txtMaCa.Name = "txtMaCa";
        txtMaCa.PlaceholderText = "Nhập mã ca (VD: CA01)...";
        txtMaCa.Size = new Size(328, 23);
        txtMaCa.TabIndex = 1;

        // lblTenCa
        lblTenCa.AutoSize = true;
        lblTenCa.Location = new Point(16, 77);
        lblTenCa.Name = "lblTenCa";
        lblTenCa.Size = new Size(66, 15);
        lblTenCa.TabIndex = 2;
        lblTenCa.Text = "Tên ca làm:";

        // txtTenCa
        txtTenCa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtTenCa.Location = new Point(16, 97);
        txtTenCa.Name = "txtTenCa";
        txtTenCa.PlaceholderText = "VD: Ca sáng, Ca chiều, Ca tối...";
        txtTenCa.Size = new Size(328, 23);
        txtTenCa.TabIndex = 3;

        // lblGioBatDau
        lblGioBatDau.AutoSize = true;
        lblGioBatDau.Location = new Point(16, 130);
        lblGioBatDau.Name = "lblGioBatDau";
        lblGioBatDau.Size = new Size(71, 15);
        lblGioBatDau.TabIndex = 4;
        lblGioBatDau.Text = "Giờ bắt đầu:";

        // dtpGioBatDau
        dtpGioBatDau.CustomFormat = "HH:mm";
        dtpGioBatDau.Format = DateTimePickerFormat.Custom;
        dtpGioBatDau.Location = new Point(16, 150);
        dtpGioBatDau.Name = "dtpGioBatDau";
        dtpGioBatDau.ShowUpDown = true;
        dtpGioBatDau.Size = new Size(155, 23);
        dtpGioBatDau.TabIndex = 5;

        // lblGioKetThuc
        lblGioKetThuc.AutoSize = true;
        lblGioKetThuc.Location = new Point(189, 130);
        lblGioKetThuc.Name = "lblGioKetThuc";
        lblGioKetThuc.Size = new Size(74, 15);
        lblGioKetThuc.TabIndex = 6;
        lblGioKetThuc.Text = "Giờ kết thúc:";

        // dtpGioKetThuc
        dtpGioKetThuc.CustomFormat = "HH:mm";
        dtpGioKetThuc.Format = DateTimePickerFormat.Custom;
        dtpGioKetThuc.Location = new Point(189, 150);
        dtpGioKetThuc.Name = "dtpGioKetThuc";
        dtpGioKetThuc.ShowUpDown = true;
        dtpGioKetThuc.Size = new Size(155, 23);
        dtpGioKetThuc.TabIndex = 7;

        // lblLuongCa
        lblLuongCa.AutoSize = true;
        lblLuongCa.Location = new Point(16, 185);
        lblLuongCa.Name = "lblLuongCa";
        lblLuongCa.Size = new Size(116, 15);
        lblLuongCa.TabIndex = 8;
        lblLuongCa.Text = "Mức lương/ca (VNĐ):";

        // txtLuongCa
        txtLuongCa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtLuongCa.Location = new Point(16, 205);
        txtLuongCa.Name = "txtLuongCa";
        txtLuongCa.PlaceholderText = "VD: 150000";
        txtLuongCa.Size = new Size(278, 23);
        txtLuongCa.TabIndex = 9;

        // lblDonViTien
        lblDonViTien.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblDonViTien.AutoSize = true;
        lblDonViTien.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblDonViTien.ForeColor = Color.DimGray;
        lblDonViTien.Location = new Point(300, 208);
        lblDonViTien.Name = "lblDonViTien";
        lblDonViTien.Size = new Size(31, 15);
        lblDonViTien.TabIndex = 10;
        lblDonViTien.Text = "VNĐ";

        // lblGhiChu
        lblGhiChu.AutoSize = true;
        lblGhiChu.Location = new Point(16, 238);
        lblGhiChu.Name = "lblGhiChu";
        lblGhiChu.Size = new Size(51, 15);
        lblGhiChu.TabIndex = 11;
        lblGhiChu.Text = "Ghi chú:";

        // txtGhiChu
        txtGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtGhiChu.Location = new Point(16, 258);
        txtGhiChu.Multiline = true;
        txtGhiChu.Name = "txtGhiChu";
        txtGhiChu.PlaceholderText = "Nhập ghi chú thêm cho ca làm...";
        txtGhiChu.ScrollBars = ScrollBars.Vertical;
        txtGhiChu.Size = new Size(328, 110);
        txtGhiChu.TabIndex = 12;

        // btnThem
        btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnThem.Location = new Point(16, 385);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(155, 36);
        btnThem.TabIndex = 13;
        btnThem.Text = "Thêm ca mới";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;

        // btnSua
        btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSua.Location = new Point(189, 385);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(155, 36);
        btnSua.TabIndex = 14;
        btnSua.Text = "Cập nhật";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;

        // btnXoa
        btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnXoa.Location = new Point(16, 430);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(155, 36);
        btnXoa.TabIndex = 15;
        btnXoa.Text = "Xóa ca";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;

        // btnLamMoi
        btnLamMoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnLamMoi.Location = new Point(189, 430);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(155, 36);
        btnLamMoi.TabIndex = 16;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        btnLamMoi.Click += btnLamMoi_Click;

        // 
        // gbDanhSachCa (Cột phải: Bảng danh sách ca làm)
        // 
        gbDanhSachCa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbDanhSachCa.Controls.Add(dgvCaLam);
        gbDanhSachCa.Controls.Add(btnTatCa);
        gbDanhSachCa.Controls.Add(btnTraCuu);
        gbDanhSachCa.Controls.Add(txtTimKiem);
        gbDanhSachCa.Controls.Add(lblTimKiem);
        gbDanhSachCa.Location = new Point(382, 50);
        gbDanhSachCa.Name = "gbDanhSachCa";
        gbDanhSachCa.Size = new Size(630, 480);
        gbDanhSachCa.TabIndex = 2;
        gbDanhSachCa.TabStop = false;
        gbDanhSachCa.Text = "Danh sách ca làm việc";

        // lblTimKiem
        lblTimKiem.AutoSize = true;
        lblTimKiem.Location = new Point(16, 26);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Size = new Size(59, 15);
        lblTimKiem.TabIndex = 0;
        lblTimKiem.Text = "Tìm kiếm:";

        // txtTimKiem
        txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtTimKiem.Location = new Point(81, 22);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Nhập mã ca, tên ca làm việc để tìm kiếm...";
        txtTimKiem.Size = new Size(357, 23);
        txtTimKiem.TabIndex = 1;
        txtTimKiem.KeyDown += txtTimKiem_KeyDown;

        // btnTraCuu
        btnTraCuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnTraCuu.Location = new Point(448, 20);
        btnTraCuu.Name = "btnTraCuu";
        btnTraCuu.Size = new Size(86, 27);
        btnTraCuu.TabIndex = 2;
        btnTraCuu.Text = "Tìm kiếm";
        btnTraCuu.UseVisualStyleBackColor = true;
        btnTraCuu.Click += btnTraCuu_Click;

        // btnTatCa
        btnTatCa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnTatCa.Location = new Point(540, 20);
        btnTatCa.Name = "btnTatCa";
        btnTatCa.Size = new Size(76, 27);
        btnTatCa.TabIndex = 3;
        btnTatCa.Text = "Tất cả";
        btnTatCa.UseVisualStyleBackColor = true;
        btnTatCa.Click += btnTatCa_Click;

        // dgvCaLam
        dgvCaLam.AllowUserToAddRows = false;
        dgvCaLam.AllowUserToDeleteRows = false;
        dgvCaLam.AllowUserToResizeRows = false;
        dgvCaLam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvCaLam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCaLam.BackgroundColor = SystemColors.ControlLight;

        dgvCellStyleHeader.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvCellStyleHeader.BackColor = SystemColors.Control;
        dgvCellStyleHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dgvCellStyleHeader.ForeColor = SystemColors.WindowText;
        dgvCellStyleHeader.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyleHeader.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyleHeader.WrapMode = DataGridViewTriState.True;
        dgvCaLam.ColumnHeadersDefaultCellStyle = dgvCellStyleHeader;
        dgvCaLam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        dgvCaLam.Columns.AddRange(new DataGridViewColumn[] {
            colSTT,
            colMaCa,
            colTenCa,
            colGioBatDau,
            colGioKetThuc,
            colLuongCa,
            colGhiChu
        });

        dgvCaLam.GridColor = Color.DarkGray;
        dgvCaLam.Location = new Point(16, 56);
        dgvCaLam.MultiSelect = false;
        dgvCaLam.Name = "dgvCaLam";
        dgvCaLam.ReadOnly = true;
        dgvCaLam.RowHeadersVisible = false;
        dgvCaLam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCaLam.Size = new Size(600, 410);
        dgvCaLam.TabIndex = 4;
        dgvCaLam.CellClick += dgvCaLam_CellClick;

        // colSTT
        dgvCellStyleSTT.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colSTT.DefaultCellStyle = dgvCellStyleSTT;
        colSTT.FillWeight = 35F;
        colSTT.HeaderText = "STT";
        colSTT.Name = "colSTT";
        colSTT.ReadOnly = true;

        // colMaCa
        dgvCellStyleMaCa.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colMaCa.DefaultCellStyle = dgvCellStyleMaCa;
        colMaCa.FillWeight = 65F;
        colMaCa.HeaderText = "Mã ca";
        colMaCa.Name = "colMaCa";
        colMaCa.ReadOnly = true;

        // colTenCa
        colTenCa.FillWeight = 110F;
        colTenCa.HeaderText = "Tên ca làm việc";
        colTenCa.Name = "colTenCa";
        colTenCa.ReadOnly = true;

        // colGioBatDau
        dgvCellStyleGioBatDau.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colGioBatDau.DefaultCellStyle = dgvCellStyleGioBatDau;
        colGioBatDau.FillWeight = 75F;
        colGioBatDau.HeaderText = "Bắt đầu";
        colGioBatDau.Name = "colGioBatDau";
        colGioBatDau.ReadOnly = true;

        // colGioKetThuc
        dgvCellStyleGioKetThuc.Alignment = DataGridViewContentAlignment.MiddleCenter;
        colGioKetThuc.DefaultCellStyle = dgvCellStyleGioKetThuc;
        colGioKetThuc.FillWeight = 75F;
        colGioKetThuc.HeaderText = "Kết thúc";
        colGioKetThuc.Name = "colGioKetThuc";
        colGioKetThuc.ReadOnly = true;

        // colLuongCa
        dgvCellStyleLuong.Alignment = DataGridViewContentAlignment.MiddleRight;
        colLuongCa.DefaultCellStyle = dgvCellStyleLuong;
        colLuongCa.FillWeight = 95F;
        colLuongCa.HeaderText = "Lương/ca (VNĐ)";
        colLuongCa.Name = "colLuongCa";
        colLuongCa.ReadOnly = true;

        // colGhiChu
        colGhiChu.FillWeight = 110F;
        colGhiChu.HeaderText = "Ghi chú";
        colGhiChu.Name = "colGhiChu";
        colGhiChu.ReadOnly = true;

        // 
        // lblTongSoCa (Chân trang)
        // 
        lblTongSoCa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTongSoCa.AutoSize = true;
        lblTongSoCa.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblTongSoCa.ForeColor = Color.DarkSlateGray;
        lblTongSoCa.Location = new Point(382, 542);
        lblTongSoCa.Name = "lblTongSoCa";
        lblTongSoCa.Size = new Size(110, 15);
        lblTongSoCa.TabIndex = 3;
        lblTongSoCa.Text = "Tổng số ca làm: 0 ca";

        // 
        // btnDong (Chân trang)
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
        // frmQuanLyCaLam
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 575);
        Controls.Add(btnDong);
        Controls.Add(lblTongSoCa);
        Controls.Add(gbDanhSachCa);
        Controls.Add(gbThongTinCa);
        Controls.Add(lblTieuDe);
        MinimumSize = new Size(950, 550);
        Name = "frmQuanLyCaLam";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản Lý Ca Làm Việc";
        Load += frmQuanLyCaLam_Load;
        gbThongTinCa.ResumeLayout(false);
        gbThongTinCa.PerformLayout();
        gbDanhSachCa.ResumeLayout(false);
        gbDanhSachCa.PerformLayout();
        ((ISupportInitialize)dgvCaLam).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTieuDe;
    private GroupBox gbThongTinCa;
    private Label lblMaCa;
    private TextBox txtMaCa;
    private Label lblTenCa;
    private TextBox txtTenCa;
    private Label lblGioBatDau;
    private DateTimePicker dtpGioBatDau;
    private Label lblGioKetThuc;
    private DateTimePicker dtpGioKetThuc;
    private Label lblLuongCa;
    private TextBox txtLuongCa;
    private Label lblDonViTien;
    private Label lblGhiChu;
    private TextBox txtGhiChu;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnLamMoi;

    private GroupBox gbDanhSachCa;
    private Label lblTimKiem;
    private TextBox txtTimKiem;
    private Button btnTraCuu;
    private Button btnTatCa;
    private DataGridView dgvCaLam;
    private DataGridViewTextBoxColumn colSTT;
    private DataGridViewTextBoxColumn colMaCa;
    private DataGridViewTextBoxColumn colTenCa;
    private DataGridViewTextBoxColumn colGioBatDau;
    private DataGridViewTextBoxColumn colGioKetThuc;
    private DataGridViewTextBoxColumn colLuongCa;
    private DataGridViewTextBoxColumn colGhiChu;

    private Label lblTongSoCa;
    private Button btnDong;
}
