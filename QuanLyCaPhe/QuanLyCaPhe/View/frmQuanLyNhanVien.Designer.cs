using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe.View;

partial class frmQuanLyNhanVien
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
        gbThongTinNV = new GroupBox();
        lblMaNV = new Label();
        txtMaNV = new TextBox();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblGioiTinh = new Label();
        cbGioiTinh = new ComboBox();
        lblNgaySinh = new Label();
        dtpNgaySinh = new DateTimePicker();
        lblSDT = new Label();
        txtSDT = new TextBox();
        lblChucVu = new Label();
        cbChucVu = new ComboBox();
        lblDiaChi = new Label();
        txtDiaChi = new TextBox();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnLamMoi = new Button();

        gbDanhSachNV = new GroupBox();
        lblTimKiem = new Label();
        txtTimKiem = new TextBox();
        btnTraCuu = new Button();
        btnTatCa = new Button();
        dgvNhanVien = new DataGridView();
        colSTT = new DataGridViewTextBoxColumn();
        colMaNV = new DataGridViewTextBoxColumn();
        colHoTen = new DataGridViewTextBoxColumn();
        colGioiTinh = new DataGridViewTextBoxColumn();
        colNgaySinh = new DataGridViewTextBoxColumn();
        colSDT = new DataGridViewTextBoxColumn();
        colChucVu = new DataGridViewTextBoxColumn();
        colDiaChi = new DataGridViewTextBoxColumn();

        lblTongSoNV = new Label();
        btnDong = new Button();

        gbThongTinNV.SuspendLayout();
        gbDanhSachNV.SuspendLayout();
        ((ISupportInitialize)dgvNhanVien).BeginInit();
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
        lblTieuDe.Text = "QUẢN LÝ NHÂN VIÊN";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

        // 
        // gbThongTinNV (Cột trái: Thông tin nhân viên)
        // 
        gbThongTinNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gbThongTinNV.Controls.Add(btnLamMoi);
        gbThongTinNV.Controls.Add(btnXoa);
        gbThongTinNV.Controls.Add(btnSua);
        gbThongTinNV.Controls.Add(btnThem);
        gbThongTinNV.Controls.Add(txtDiaChi);
        gbThongTinNV.Controls.Add(lblDiaChi);
        gbThongTinNV.Controls.Add(cbChucVu);
        gbThongTinNV.Controls.Add(lblChucVu);
        gbThongTinNV.Controls.Add(txtSDT);
        gbThongTinNV.Controls.Add(lblSDT);
        gbThongTinNV.Controls.Add(dtpNgaySinh);
        gbThongTinNV.Controls.Add(lblNgaySinh);
        gbThongTinNV.Controls.Add(cbGioiTinh);
        gbThongTinNV.Controls.Add(lblGioiTinh);
        gbThongTinNV.Controls.Add(txtHoTen);
        gbThongTinNV.Controls.Add(lblHoTen);
        gbThongTinNV.Controls.Add(txtMaNV);
        gbThongTinNV.Controls.Add(lblMaNV);
        gbThongTinNV.Location = new Point(12, 50);
        gbThongTinNV.Name = "gbThongTinNV";
        gbThongTinNV.Size = new Size(360, 480);
        gbThongTinNV.TabIndex = 1;
        gbThongTinNV.TabStop = false;
        gbThongTinNV.Text = "Thông tin nhân viên";

        // lblMaNV
        lblMaNV.AutoSize = true;
        lblMaNV.Location = new Point(16, 25);
        lblMaNV.Name = "lblMaNV";
        lblMaNV.Size = new Size(46, 15);
        lblMaNV.TabIndex = 0;
        lblMaNV.Text = "Mã NV:";

        // txtMaNV
        txtMaNV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtMaNV.Location = new Point(16, 45);
        txtMaNV.Name = "txtMaNV";
        txtMaNV.PlaceholderText = "Nhập mã nhân viên (VD: NV01)...";
        txtMaNV.Size = new Size(328, 23);
        txtMaNV.TabIndex = 1;

        // lblHoTen
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new Point(16, 77);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(46, 15);
        lblHoTen.TabIndex = 2;
        lblHoTen.Text = "Họ tên:";

        // txtHoTen
        txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtHoTen.Location = new Point(16, 97);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.PlaceholderText = "Nhập họ và tên nhân viên...";
        txtHoTen.Size = new Size(328, 23);
        txtHoTen.TabIndex = 3;

        // lblGioiTinh
        lblGioiTinh.AutoSize = true;
        lblGioiTinh.Location = new Point(16, 130);
        lblGioiTinh.Name = "lblGioiTinh";
        lblGioiTinh.Size = new Size(55, 15);
        lblGioiTinh.TabIndex = 4;
        lblGioiTinh.Text = "Giới tính:";

        // cbGioiTinh
        cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
        cbGioiTinh.FormattingEnabled = true;
        cbGioiTinh.Location = new Point(16, 150);
        cbGioiTinh.Name = "cbGioiTinh";
        cbGioiTinh.Size = new Size(155, 23);
        cbGioiTinh.TabIndex = 5;

        // lblNgaySinh
        lblNgaySinh.AutoSize = true;
        lblNgaySinh.Location = new Point(189, 130);
        lblNgaySinh.Name = "lblNgaySinh";
        lblNgaySinh.Size = new Size(63, 15);
        lblNgaySinh.TabIndex = 6;
        lblNgaySinh.Text = "Ngày sinh:";

        // dtpNgaySinh
        dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        dtpNgaySinh.Format = DateTimePickerFormat.Custom;
        dtpNgaySinh.Location = new Point(189, 150);
        dtpNgaySinh.Name = "dtpNgaySinh";
        dtpNgaySinh.Size = new Size(155, 23);
        dtpNgaySinh.TabIndex = 7;

        // lblSDT
        lblSDT.AutoSize = true;
        lblSDT.Location = new Point(16, 185);
        lblSDT.Name = "lblSDT";
        lblSDT.Size = new Size(81, 15);
        lblSDT.TabIndex = 8;
        lblSDT.Text = "Số điện thoại:";

        // txtSDT
        txtSDT.Location = new Point(16, 205);
        txtSDT.Name = "txtSDT";
        txtSDT.PlaceholderText = "VD: 0901234567";
        txtSDT.Size = new Size(155, 23);
        txtSDT.TabIndex = 9;

        // lblChucVu
        lblChucVu.AutoSize = true;
        lblChucVu.Location = new Point(189, 185);
        lblChucVu.Name = "lblChucVu";
        lblChucVu.Size = new Size(54, 15);
        lblChucVu.TabIndex = 10;
        lblChucVu.Text = "Chức vụ:";

        // cbChucVu
        cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
        cbChucVu.FormattingEnabled = true;
        cbChucVu.Location = new Point(189, 205);
        cbChucVu.Name = "cbChucVu";
        cbChucVu.Size = new Size(155, 23);
        cbChucVu.TabIndex = 11;

        // lblDiaChi
        lblDiaChi.AutoSize = true;
        lblDiaChi.Location = new Point(16, 238);
        lblDiaChi.Name = "lblDiaChi";
        lblDiaChi.Size = new Size(47, 15);
        lblDiaChi.TabIndex = 12;
        lblDiaChi.Text = "Địa chỉ:";

        // txtDiaChi
        txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtDiaChi.Location = new Point(16, 258);
        txtDiaChi.Multiline = true;
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.PlaceholderText = "Nhập địa chỉ liên hệ...";
        txtDiaChi.ScrollBars = ScrollBars.Vertical;
        txtDiaChi.Size = new Size(328, 110);
        txtDiaChi.TabIndex = 13;

        // btnThem
        btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnThem.Location = new Point(16, 385);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(155, 36);
        btnThem.TabIndex = 14;
        btnThem.Text = "Thêm nhân viên";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;

        // btnSua
        btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSua.Location = new Point(189, 385);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(155, 36);
        btnSua.TabIndex = 15;
        btnSua.Text = "Cập nhật";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;

        // btnXoa
        btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnXoa.Location = new Point(16, 430);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(155, 36);
        btnXoa.TabIndex = 16;
        btnXoa.Text = "Xóa nhân viên";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;

        // btnLamMoi
        btnLamMoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnLamMoi.Location = new Point(189, 430);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(155, 36);
        btnLamMoi.TabIndex = 17;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        btnLamMoi.Click += btnLamMoi_Click;

        // 
        // gbDanhSachNV (Cột phải: Bảng danh sách nhân viên)
        // 
        gbDanhSachNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbDanhSachNV.Controls.Add(dgvNhanVien);
        gbDanhSachNV.Controls.Add(btnTatCa);
        gbDanhSachNV.Controls.Add(btnTraCuu);
        gbDanhSachNV.Controls.Add(txtTimKiem);
        gbDanhSachNV.Controls.Add(lblTimKiem);
        gbDanhSachNV.Location = new Point(382, 50);
        gbDanhSachNV.Name = "gbDanhSachNV";
        gbDanhSachNV.Size = new Size(630, 480);
        gbDanhSachNV.TabIndex = 2;
        gbDanhSachNV.TabStop = false;
        gbDanhSachNV.Text = "Danh sách nhân viên";

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
        txtTimKiem.PlaceholderText = "Nhập mã NV, họ tên hoặc số điện thoại để tìm kiếm...";
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

        // dgvNhanVien
        dgvNhanVien.AllowUserToAddRows = false;
        dgvNhanVien.AllowUserToDeleteRows = false;
        dgvNhanVien.AllowUserToResizeRows = false;
        dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvNhanVien.BackgroundColor = SystemColors.ControlLight;

        dgvCellStyleHeader.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgvCellStyleHeader.BackColor = SystemColors.Control;
        dgvCellStyleHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dgvCellStyleHeader.ForeColor = SystemColors.WindowText;
        dgvCellStyleHeader.SelectionBackColor = SystemColors.Highlight;
        dgvCellStyleHeader.SelectionForeColor = SystemColors.HighlightText;
        dgvCellStyleHeader.WrapMode = DataGridViewTriState.True;
        dgvNhanVien.ColumnHeadersDefaultCellStyle = dgvCellStyleHeader;
        dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] {
            colSTT,
            colMaNV,
            colHoTen,
            colGioiTinh,
            colNgaySinh,
            colSDT,
            colChucVu,
            colDiaChi
        });

        dgvNhanVien.GridColor = Color.DarkGray;
        dgvNhanVien.Location = new Point(16, 56);
        dgvNhanVien.MultiSelect = false;
        dgvNhanVien.Name = "dgvNhanVien";
        dgvNhanVien.ReadOnly = true;
        dgvNhanVien.RowHeadersVisible = false;
        dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvNhanVien.Size = new Size(600, 410);
        dgvNhanVien.TabIndex = 4;
        dgvNhanVien.CellClick += dgvNhanVien_CellClick;

        dgvCellStyleCenter.Alignment = DataGridViewContentAlignment.MiddleCenter;

        colSTT.DefaultCellStyle = dgvCellStyleCenter;
        colSTT.FillWeight = 35F;
        colSTT.HeaderText = "STT";
        colSTT.Name = "colSTT";
        colSTT.ReadOnly = true;

        colMaNV.DefaultCellStyle = dgvCellStyleCenter;
        colMaNV.FillWeight = 60F;
        colMaNV.HeaderText = "Mã NV";
        colMaNV.Name = "colMaNV";
        colMaNV.ReadOnly = true;

        colHoTen.FillWeight = 120F;
        colHoTen.HeaderText = "Họ tên";
        colHoTen.Name = "colHoTen";
        colHoTen.ReadOnly = true;

        colGioiTinh.DefaultCellStyle = dgvCellStyleCenter;
        colGioiTinh.FillWeight = 60F;
        colGioiTinh.HeaderText = "Giới tính";
        colGioiTinh.Name = "colGioiTinh";
        colGioiTinh.ReadOnly = true;

        colNgaySinh.DefaultCellStyle = dgvCellStyleCenter;
        colNgaySinh.FillWeight = 80F;
        colNgaySinh.HeaderText = "Ngày sinh";
        colNgaySinh.Name = "colNgaySinh";
        colNgaySinh.ReadOnly = true;

        colSDT.DefaultCellStyle = dgvCellStyleCenter;
        colSDT.FillWeight = 85F;
        colSDT.HeaderText = "Số ĐT";
        colSDT.Name = "colSDT";
        colSDT.ReadOnly = true;

        colChucVu.FillWeight = 80F;
        colChucVu.HeaderText = "Chức vụ";
        colChucVu.Name = "colChucVu";
        colChucVu.ReadOnly = true;

        colDiaChi.FillWeight = 110F;
        colDiaChi.HeaderText = "Địa chỉ";
        colDiaChi.Name = "colDiaChi";
        colDiaChi.ReadOnly = true;

        // 
        // lblTongSoNV (Chân trang)
        // 
        lblTongSoNV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTongSoNV.AutoSize = true;
        lblTongSoNV.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblTongSoNV.ForeColor = Color.DarkSlateGray;
        lblTongSoNV.Location = new Point(382, 542);
        lblTongSoNV.Name = "lblTongSoNV";
        lblTongSoNV.Size = new Size(141, 15);
        lblTongSoNV.TabIndex = 3;
        lblTongSoNV.Text = "Tổng số nhân viên: 0 người";

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
        // frmQuanLyNhanVien
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 575);
        Controls.Add(btnDong);
        Controls.Add(lblTongSoNV);
        Controls.Add(gbDanhSachNV);
        Controls.Add(gbThongTinNV);
        Controls.Add(lblTieuDe);
        MinimumSize = new Size(950, 550);
        Name = "frmQuanLyNhanVien";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản Lý Nhân Viên";
        Load += frmQuanLyNhanVien_Load;
        gbThongTinNV.ResumeLayout(false);
        gbThongTinNV.PerformLayout();
        gbDanhSachNV.ResumeLayout(false);
        gbDanhSachNV.PerformLayout();
        ((ISupportInitialize)dgvNhanVien).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTieuDe;
    private GroupBox gbThongTinNV;
    private Label lblMaNV;
    private TextBox txtMaNV;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblGioiTinh;
    private ComboBox cbGioiTinh;
    private Label lblNgaySinh;
    private DateTimePicker dtpNgaySinh;
    private Label lblSDT;
    private TextBox txtSDT;
    private Label lblChucVu;
    private ComboBox cbChucVu;
    private Label lblDiaChi;
    private TextBox txtDiaChi;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnLamMoi;

    private GroupBox gbDanhSachNV;
    private Label lblTimKiem;
    private TextBox txtTimKiem;
    private Button btnTraCuu;
    private Button btnTatCa;
    private DataGridView dgvNhanVien;
    private DataGridViewTextBoxColumn colSTT;
    private DataGridViewTextBoxColumn colMaNV;
    private DataGridViewTextBoxColumn colHoTen;
    private DataGridViewTextBoxColumn colGioiTinh;
    private DataGridViewTextBoxColumn colNgaySinh;
    private DataGridViewTextBoxColumn colSDT;
    private DataGridViewTextBoxColumn colChucVu;
    private DataGridViewTextBoxColumn colDiaChi;

    private Label lblTongSoNV;
    private Button btnDong;
}