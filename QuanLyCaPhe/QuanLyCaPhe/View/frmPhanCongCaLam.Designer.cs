using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe.View;

partial class frmPhanCongCaLam
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
        DataGridViewCellStyle dgvCellStyleHeader = new DataGridViewCellStyle();
        DataGridViewCellStyle dgvCellStyleCenter = new DataGridViewCellStyle();

        lblTieuDe = new Label();
        gbThongTinPhanCong = new GroupBox();
        lblNgayLam = new Label();
        dtpNgayLam = new DateTimePicker();
        lblNhanVien = new Label();
        cbNhanVien = new ComboBox();
        lblCaLam = new Label();
        cbCaLam = new ComboBox();
        lblTrangThai = new Label();
        cbTrangThai = new ComboBox();
        lblGhiChu = new Label();
        txtGhiChu = new TextBox();
        btnPhanCong = new Button();
        btnSuaLich = new Button();
        btnXoaLich = new Button();
        btnLamMoi = new Button();

        gbDanhSachPhanCong = new GroupBox();
        lblTimKiem = new Label();
        txtTimKiem = new TextBox();
        btnTraCuu = new Button();
        btnTatCa = new Button();
        dgvPhanCong = new DataGridView();
        colSTT = new DataGridViewTextBoxColumn();
        colMaPC = new DataGridViewTextBoxColumn();
        colNgayLam = new DataGridViewTextBoxColumn();
        colNhanVien = new DataGridViewTextBoxColumn();
        colCaLam = new DataGridViewTextBoxColumn();
        colTrangThai = new DataGridViewTextBoxColumn();
        colGhiChu = new DataGridViewTextBoxColumn();

        lblTongSoLich = new Label();
        btnDong = new Button();

        gbThongTinPhanCong.SuspendLayout();
        gbDanhSachPhanCong.SuspendLayout();
        ((ISupportInitialize)dgvPhanCong).BeginInit();
        SuspendLayout();

        // 
        // lblTieuDe
        // 
        lblTieuDe.Dock = DockStyle.Top;
        lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTieuDe.ForeColor = Color.FromArgb(112, 67, 48);
        lblTieuDe.Location = new Point(0, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(1024, 45);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "PHÂN CÔNG CA LÀM VIỆC";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

        // 
        // gbThongTinPhanCong (Cột trái)
        // 
        gbThongTinPhanCong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gbThongTinPhanCong.Controls.Add(btnLamMoi);
        gbThongTinPhanCong.Controls.Add(btnXoaLich);
        gbThongTinPhanCong.Controls.Add(btnSuaLich);
        gbThongTinPhanCong.Controls.Add(btnPhanCong);
        gbThongTinPhanCong.Controls.Add(txtGhiChu);
        gbThongTinPhanCong.Controls.Add(lblGhiChu);
        gbThongTinPhanCong.Controls.Add(cbTrangThai);
        gbThongTinPhanCong.Controls.Add(lblTrangThai);
        gbThongTinPhanCong.Controls.Add(cbCaLam);
        gbThongTinPhanCong.Controls.Add(lblCaLam);
        gbThongTinPhanCong.Controls.Add(cbNhanVien);
        gbThongTinPhanCong.Controls.Add(lblNhanVien);
        gbThongTinPhanCong.Controls.Add(dtpNgayLam);
        gbThongTinPhanCong.Controls.Add(lblNgayLam);
        gbThongTinPhanCong.Location = new Point(12, 50);
        gbThongTinPhanCong.Name = "gbThongTinPhanCong";
        gbThongTinPhanCong.Size = new Size(360, 480);
        gbThongTinPhanCong.TabIndex = 1;
        gbThongTinPhanCong.TabStop = false;
        gbThongTinPhanCong.Text = "Thông tin phân công";

        // lblNgayLam
        lblNgayLam.AutoSize = true;
        lblNgayLam.Location = new Point(16, 25);
        lblNgayLam.Name = "lblNgayLam";
        lblNgayLam.Size = new Size(84, 15);
        lblNgayLam.TabIndex = 0;
        lblNgayLam.Text = "Ngày làm việc:";

        // dtpNgayLam
        dtpNgayLam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dtpNgayLam.CustomFormat = "dd/MM/yyyy";
        dtpNgayLam.Format = DateTimePickerFormat.Custom;
        dtpNgayLam.Location = new Point(16, 45);
        dtpNgayLam.Name = "dtpNgayLam";
        dtpNgayLam.Size = new Size(328, 23);
        dtpNgayLam.TabIndex = 1;

        // lblNhanVien
        lblNhanVien.AutoSize = true;
        lblNhanVien.Location = new Point(16, 77);
        lblNhanVien.Name = "lblNhanVien";
        lblNhanVien.Size = new Size(64, 15);
        lblNhanVien.TabIndex = 2;
        lblNhanVien.Text = "Nhân viên:";

        // cbNhanVien
        cbNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cbNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
        cbNhanVien.FormattingEnabled = true;
        cbNhanVien.Location = new Point(16, 97);
        cbNhanVien.Name = "cbNhanVien";
        cbNhanVien.Size = new Size(328, 23);
        cbNhanVien.TabIndex = 3;

        // lblCaLam
        lblCaLam.AutoSize = true;
        lblCaLam.Location = new Point(16, 130);
        lblCaLam.Name = "lblCaLam";
        lblCaLam.Size = new Size(47, 15);
        lblCaLam.TabIndex = 4;
        lblCaLam.Text = "Ca làm:";

        // cbCaLam
        cbCaLam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cbCaLam.DropDownStyle = ComboBoxStyle.DropDownList;
        cbCaLam.FormattingEnabled = true;
        cbCaLam.Location = new Point(16, 150);
        cbCaLam.Name = "cbCaLam";
        cbCaLam.Size = new Size(328, 23);
        cbCaLam.TabIndex = 5;

        // lblTrangThai
        lblTrangThai.AutoSize = true;
        lblTrangThai.Location = new Point(16, 185);
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new Size(62, 15);
        lblTrangThai.TabIndex = 6;
        lblTrangThai.Text = "Trạng thái:";

        // cbTrangThai
        cbTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        cbTrangThai.FormattingEnabled = true;
        cbTrangThai.Location = new Point(16, 205);
        cbTrangThai.Name = "cbTrangThai";
        cbTrangThai.Size = new Size(328, 23);
        cbTrangThai.TabIndex = 7;

        // lblGhiChu
        lblGhiChu.AutoSize = true;
        lblGhiChu.Location = new Point(16, 238);
        lblGhiChu.Name = "lblGhiChu";
        lblGhiChu.Size = new Size(51, 15);
        lblGhiChu.TabIndex = 8;
        lblGhiChu.Text = "Ghi chú:";

        // txtGhiChu
        txtGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtGhiChu.Location = new Point(16, 258);
        txtGhiChu.Multiline = true;
        txtGhiChu.Name = "txtGhiChu";
        txtGhiChu.PlaceholderText = "Nhập ghi chú phân công ca làm...";
        txtGhiChu.ScrollBars = ScrollBars.Vertical;
        txtGhiChu.Size = new Size(328, 110);
        txtGhiChu.TabIndex = 9;

        // btnPhanCong
        btnPhanCong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnPhanCong.BackColor = Color.FromArgb(139, 54, 48);
        btnPhanCong.FlatStyle = FlatStyle.Flat;
        btnPhanCong.FlatAppearance.BorderSize = 0;
        btnPhanCong.ForeColor = Color.White;
        btnPhanCong.Location = new Point(16, 385);
        btnPhanCong.Name = "btnPhanCong";
        btnPhanCong.Size = new Size(155, 36);
        btnPhanCong.TabIndex = 10;
        btnPhanCong.Text = "Phân công mới";
        btnPhanCong.UseVisualStyleBackColor = false;
        btnPhanCong.Click += btnPhanCong_Click;

        // btnSuaLich
        btnSuaLich.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSuaLich.BackColor = Color.FromArgb(139, 54, 48);
        btnSuaLich.FlatStyle = FlatStyle.Flat;
        btnSuaLich.FlatAppearance.BorderSize = 0;
        btnSuaLich.ForeColor = Color.White;
        btnSuaLich.Location = new Point(189, 385);
        btnSuaLich.Name = "btnSuaLich";
        btnSuaLich.Size = new Size(155, 36);
        btnSuaLich.TabIndex = 11;
        btnSuaLich.Text = "Cập nhật lịch";
        btnSuaLich.UseVisualStyleBackColor = false;
        btnSuaLich.Click += btnSuaLich_Click;

        // btnXoaLich
        btnXoaLich.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnXoaLich.BackColor = Color.FromArgb(160, 60, 50);
        btnXoaLich.FlatStyle = FlatStyle.Flat;
        btnXoaLich.FlatAppearance.BorderSize = 0;
        btnXoaLich.ForeColor = Color.White;
        btnXoaLich.Location = new Point(16, 430);
        btnXoaLich.Name = "btnXoaLich";
        btnXoaLich.Size = new Size(155, 36);
        btnXoaLich.TabIndex = 12;
        btnXoaLich.Text = "Xóa lịch";
        btnXoaLich.UseVisualStyleBackColor = false;
        btnXoaLich.Click += btnXoaLich_Click;

        // btnLamMoi
        btnLamMoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnLamMoi.BackColor = Color.FromArgb(232, 224, 214);
        btnLamMoi.FlatStyle = FlatStyle.Flat;
        btnLamMoi.FlatAppearance.BorderSize = 0;
        btnLamMoi.ForeColor = Color.FromArgb(110, 85, 70);
        btnLamMoi.Location = new Point(189, 430);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(155, 36);
        btnLamMoi.TabIndex = 13;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = false;
        btnLamMoi.Click += btnLamMoi_Click;

        // 
        // gbDanhSachPhanCong (Cột phải)
        // 
        gbDanhSachPhanCong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbDanhSachPhanCong.Controls.Add(dgvPhanCong);
        gbDanhSachPhanCong.Controls.Add(btnTatCa);
        gbDanhSachPhanCong.Controls.Add(btnTraCuu);
        gbDanhSachPhanCong.Controls.Add(txtTimKiem);
        gbDanhSachPhanCong.Controls.Add(lblTimKiem);
        gbDanhSachPhanCong.Location = new Point(382, 50);
        gbDanhSachPhanCong.Name = "gbDanhSachPhanCong";
        gbDanhSachPhanCong.Size = new Size(630, 480);
        gbDanhSachPhanCong.TabIndex = 2;
        gbDanhSachPhanCong.TabStop = false;
        gbDanhSachPhanCong.Text = "Lịch phân công làm việc";

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
        txtTimKiem.PlaceholderText = "Nhập tên nhân viên, ca làm hoặc ngày làm việc...";
        txtTimKiem.Size = new Size(357, 23);
        txtTimKiem.TabIndex = 1;
        txtTimKiem.KeyDown += txtTimKiem_KeyDown;

        // btnTraCuu
        btnTraCuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnTraCuu.BackColor = Color.FromArgb(112, 67, 48);
        btnTraCuu.FlatStyle = FlatStyle.Flat;
        btnTraCuu.FlatAppearance.BorderSize = 0;
        btnTraCuu.ForeColor = Color.White;
        btnTraCuu.Location = new Point(448, 20);
        btnTraCuu.Name = "btnTraCuu";
        btnTraCuu.Size = new Size(86, 27);
        btnTraCuu.TabIndex = 2;
        btnTraCuu.Text = "Tìm kiếm";
        btnTraCuu.UseVisualStyleBackColor = false;
        btnTraCuu.Click += btnTraCuu_Click;

        // btnTatCa
        btnTatCa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnTatCa.BackColor = Color.FromArgb(232, 224, 214);
        btnTatCa.FlatStyle = FlatStyle.Flat;
        btnTatCa.FlatAppearance.BorderSize = 0;
        btnTatCa.ForeColor = Color.FromArgb(110, 85, 70);
        btnTatCa.Location = new Point(540, 20);
        btnTatCa.Name = "btnTatCa";
        btnTatCa.Size = new Size(76, 27);
        btnTatCa.TabIndex = 3;
        btnTatCa.Text = "Tất cả";
        btnTatCa.UseVisualStyleBackColor = false;
        btnTatCa.Click += btnTatCa_Click;

        // dgvPhanCong
        dgvPhanCong.AllowUserToAddRows = false;
        dgvPhanCong.AllowUserToDeleteRows = false;
        dgvPhanCong.AllowUserToResizeRows = false;
        dgvPhanCong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPhanCong.BackgroundColor = SystemColors.ControlLight;

        dgvCellStyleHeader.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvCellStyleHeader.BackColor = SystemColors.Control;
        dgvCellStyleHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dgvCellStyleHeader.ForeColor = SystemColors.WindowText;
        dgvCellStyleHeader.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyleHeader.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyleHeader.WrapMode = DataGridViewTriState.True;
        dgvPhanCong.ColumnHeadersDefaultCellStyle = dgvCellStyleHeader;
        dgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        dgvPhanCong.Columns.AddRange(new DataGridViewColumn[] {
            colSTT,
            colMaPC,
            colNgayLam,
            colNhanVien,
            colCaLam,
            colTrangThai,
            colGhiChu
        });

        dgvPhanCong.GridColor = Color.DarkGray;
        dgvPhanCong.Location = new Point(16, 56);
        dgvPhanCong.MultiSelect = false;
        dgvPhanCong.Name = "dgvPhanCong";
        dgvPhanCong.ReadOnly = true;
        dgvPhanCong.RowHeadersVisible = false;
        dgvPhanCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPhanCong.Size = new Size(600, 410);
        dgvPhanCong.TabIndex = 4;
        dgvPhanCong.CellClick += dgvPhanCong_CellClick;

        dgvCellStyleCenter.Alignment = DataGridViewContentAlignment.MiddleCenter;

        colSTT.DefaultCellStyle = dgvCellStyleCenter;
        colSTT.FillWeight = 35F;
        colSTT.HeaderText = "STT";
        colSTT.Name = "colSTT";
        colSTT.ReadOnly = true;

        colMaPC.DefaultCellStyle = dgvCellStyleCenter;
        colMaPC.FillWeight = 65F;
        colMaPC.HeaderText = "Mã PC";
        colMaPC.Name = "colMaPC";
        colMaPC.ReadOnly = true;

        colNgayLam.DefaultCellStyle = dgvCellStyleCenter;
        colNgayLam.FillWeight = 85F;
        colNgayLam.HeaderText = "Ngày làm";
        colNgayLam.Name = "colNgayLam";
        colNgayLam.ReadOnly = true;

        colNhanVien.FillWeight = 120F;
        colNhanVien.HeaderText = "Nhân viên";
        colNhanVien.Name = "colNhanVien";
        colNhanVien.ReadOnly = true;

        colCaLam.FillWeight = 110F;
        colCaLam.HeaderText = "Ca làm";
        colCaLam.Name = "colCaLam";
        colCaLam.ReadOnly = true;

        colTrangThai.DefaultCellStyle = dgvCellStyleCenter;
        colTrangThai.FillWeight = 85F;
        colTrangThai.HeaderText = "Trạng thái";
        colTrangThai.Name = "colTrangThai";
        colTrangThai.ReadOnly = true;

        colGhiChu.FillWeight = 110F;
        colGhiChu.HeaderText = "Ghi chú";
        colGhiChu.Name = "colGhiChu";
        colGhiChu.ReadOnly = true;

        // 
        // lblTongSoLich
        // 
        lblTongSoLich.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTongSoLich.AutoSize = true;
        lblTongSoLich.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblTongSoLich.ForeColor = Color.DarkSlateGray;
        lblTongSoLich.Location = new Point(382, 542);
        lblTongSoLich.Name = "lblTongSoLich";
        lblTongSoLich.Size = new Size(125, 15);
        lblTongSoLich.TabIndex = 3;
        lblTongSoLich.Text = "Tổng số lịch trực: 0 ca";

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
        // frmPhanCongCaLam
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 575);
        Controls.Add(btnDong);
        Controls.Add(lblTongSoLich);
        Controls.Add(gbDanhSachPhanCong);
        Controls.Add(gbThongTinPhanCong);
        Controls.Add(lblTieuDe);
        MinimumSize = new Size(950, 550);
        Name = "frmPhanCongCaLam";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Phân Công Ca Làm";
        Load += frmPhanCongCaLam_Load;
        gbThongTinPhanCong.ResumeLayout(false);
        gbThongTinPhanCong.PerformLayout();
        gbDanhSachPhanCong.ResumeLayout(false);
        gbDanhSachPhanCong.PerformLayout();
        ((ISupportInitialize)dgvPhanCong).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTieuDe;
    private GroupBox gbThongTinPhanCong;
    private Label lblNgayLam;
    private DateTimePicker dtpNgayLam;
    private Label lblNhanVien;
    private ComboBox cbNhanVien;
    private Label lblCaLam;
    private ComboBox cbCaLam;
    private Label lblTrangThai;
    private ComboBox cbTrangThai;
    private Label lblGhiChu;
    private TextBox txtGhiChu;
    private Button btnPhanCong;
    private Button btnSuaLich;
    private Button btnXoaLich;
    private Button btnLamMoi;

    private GroupBox gbDanhSachPhanCong;
    private Label lblTimKiem;
    private TextBox txtTimKiem;
    private Button btnTraCuu;
    private Button btnTatCa;
    private DataGridView dgvPhanCong;
    private DataGridViewTextBoxColumn colSTT;
    private DataGridViewTextBoxColumn colMaPC;
    private DataGridViewTextBoxColumn colNgayLam;
    private DataGridViewTextBoxColumn colNhanVien;
    private DataGridViewTextBoxColumn colCaLam;
    private DataGridViewTextBoxColumn colTrangThai;
    private DataGridViewTextBoxColumn colGhiChu;

    private Label lblTongSoLich;
    private Button btnDong;
}