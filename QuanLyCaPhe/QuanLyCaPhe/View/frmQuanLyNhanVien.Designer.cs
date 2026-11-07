namespace QuanLyCaPhe;

partial class frmQuanLyNhanVien
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        gbThongTin = new System.Windows.Forms.GroupBox();
        lblMaNV = new System.Windows.Forms.Label();
        txtMaNV = new System.Windows.Forms.TextBox();
        lblHoTen = new System.Windows.Forms.Label();
        txtHoTen = new System.Windows.Forms.TextBox();
        lblGioiTinh = new System.Windows.Forms.Label();
        cbGioiTinh = new System.Windows.Forms.ComboBox();
        lblNgaySinh = new System.Windows.Forms.Label();
        dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
        lblSDT = new System.Windows.Forms.Label();
        txtSDT = new System.Windows.Forms.TextBox();
        lblChucVu = new System.Windows.Forms.Label();
        cbChucVu = new System.Windows.Forms.ComboBox();
        btnThem = new System.Windows.Forms.Button();
        btnSua = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        btnLamMoi = new System.Windows.Forms.Button();
        dgvNhanVien = new System.Windows.Forms.DataGridView();
        gbThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
        SuspendLayout();
        // 
        // gbThongTin
        // 
        gbThongTin.Controls.Add(cbChucVu);
        gbThongTin.Controls.Add(lblChucVu);
        gbThongTin.Controls.Add(txtSDT);
        gbThongTin.Controls.Add(lblSDT);
        gbThongTin.Controls.Add(dtpNgaySinh);
        gbThongTin.Controls.Add(lblNgaySinh);
        gbThongTin.Controls.Add(cbGioiTinh);
        gbThongTin.Controls.Add(lblGioiTinh);
        gbThongTin.Controls.Add(txtHoTen);
        gbThongTin.Controls.Add(lblHoTen);
        gbThongTin.Controls.Add(txtMaNV);
        gbThongTin.Controls.Add(lblMaNV);
        gbThongTin.Location = new System.Drawing.Point(12, 12);
        gbThongTin.Name = "gbThongTin";
        gbThongTin.Size = new System.Drawing.Size(776, 130);
        gbThongTin.TabIndex = 0;
        gbThongTin.TabStop = false;
        gbThongTin.Text = "Thông tin nhân viên";
        // 
        // lblMaNV
        // 
        lblMaNV.AutoSize = true;
        lblMaNV.Location = new System.Drawing.Point(20, 30);
        lblMaNV.Name = "lblMaNV";
        lblMaNV.Size = new System.Drawing.Size(46, 15);
        lblMaNV.TabIndex = 0;
        lblMaNV.Text = "Mã NV:";
        // 
        // txtMaNV
        // 
        txtMaNV.Location = new System.Drawing.Point(80, 27);
        txtMaNV.Name = "txtMaNV";
        txtMaNV.Size = new System.Drawing.Size(160, 23);
        txtMaNV.TabIndex = 1;
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new System.Drawing.Point(270, 30);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new System.Drawing.Size(46, 15);
        lblHoTen.TabIndex = 2;
        lblHoTen.Text = "Họ tên:";
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new System.Drawing.Point(330, 27);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new System.Drawing.Size(170, 23);
        txtHoTen.TabIndex = 3;
        // 
        // lblGioiTinh
        // 
        lblGioiTinh.AutoSize = true;
        lblGioiTinh.Location = new System.Drawing.Point(530, 30);
        lblGioiTinh.Name = "lblGioiTinh";
        lblGioiTinh.Size = new System.Drawing.Size(55, 15);
        lblGioiTinh.TabIndex = 4;
        lblGioiTinh.Text = "Giới tính:";
        // 
        // cbGioiTinh
        // 
        cbGioiTinh.FormattingEnabled = true;
        cbGioiTinh.Location = new System.Drawing.Point(595, 27);
        cbGioiTinh.Name = "cbGioiTinh";
        cbGioiTinh.Size = new System.Drawing.Size(155, 23);
        cbGioiTinh.TabIndex = 5;
        // 
        // lblNgaySinh
        // 
        lblNgaySinh.AutoSize = true;
        lblNgaySinh.Location = new System.Drawing.Point(20, 75);
        lblNgaySinh.Name = "lblNgaySinh";
        lblNgaySinh.Size = new System.Drawing.Size(63, 15);
        lblNgaySinh.TabIndex = 6;
        lblNgaySinh.Text = "Ngày sinh:";
        // 
        // dtpNgaySinh
        // 
        dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpNgaySinh.Location = new System.Drawing.Point(80, 72);
        dtpNgaySinh.Name = "dtpNgaySinh";
        dtpNgaySinh.Size = new System.Drawing.Size(160, 23);
        dtpNgaySinh.TabIndex = 7;
        // 
        // lblSDT
        // 
        lblSDT.AutoSize = true;
        lblSDT.Location = new System.Drawing.Point(270, 75);
        lblSDT.Name = "lblSDT";
        lblSDT.Size = new System.Drawing.Size(40, 15);
        lblSDT.TabIndex = 8;
        lblSDT.Text = "Số ĐT:";
        // 
        // txtSDT
        // 
        txtSDT.Location = new System.Drawing.Point(330, 72);
        txtSDT.Name = "txtSDT";
        txtSDT.Size = new System.Drawing.Size(170, 23);
        txtSDT.TabIndex = 9;
        // 
        // lblChucVu
        // 
        lblChucVu.AutoSize = true;
        lblChucVu.Location = new System.Drawing.Point(530, 75);
        lblChucVu.Name = "lblChucVu";
        lblChucVu.Size = new System.Drawing.Size(54, 15);
        lblChucVu.TabIndex = 10;
        lblChucVu.Text = "Chức vụ:";
        // 
        // cbChucVu
        // 
        cbChucVu.FormattingEnabled = true;
        cbChucVu.Location = new System.Drawing.Point(595, 72);
        cbChucVu.Name = "cbChucVu";
        cbChucVu.Size = new System.Drawing.Size(155, 23);
        cbChucVu.TabIndex = 11;
        // 
        // btnThem
        // 
        btnThem.Location = new System.Drawing.Point(220, 155);
        btnThem.Name = "btnThem";
        btnThem.Size = new System.Drawing.Size(90, 30);
        btnThem.TabIndex = 1;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        // 
        // btnSua
        // 
        btnSua.Location = new System.Drawing.Point(330, 155);
        btnSua.Name = "btnSua";
        btnSua.Size = new System.Drawing.Size(90, 30);
        btnSua.TabIndex = 2;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        // 
        // btnXoa
        // 
        btnXoa.Location = new System.Drawing.Point(440, 155);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(90, 30);
        btnXoa.TabIndex = 3;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.Location = new System.Drawing.Point(550, 155);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(90, 30);
        btnLamMoi.TabIndex = 4;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // dgvNhanVien
        // 
        dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvNhanVien.Location = new System.Drawing.Point(12, 200);
        dgvNhanVien.Name = "dgvNhanVien";
        dgvNhanVien.Size = new System.Drawing.Size(776, 240);
        dgvNhanVien.TabIndex = 5;
        dgvNhanVien.CellClick += dgvNhanVien_CellClick;
        // 
        // frmQuanLyNhanVien
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 455);
        Controls.Add(dgvNhanVien);
        Controls.Add(btnLamMoi);
        Controls.Add(btnXoa);
        Controls.Add(btnSua);
        Controls.Add(btnThem);
        Controls.Add(gbThongTin);
        Name = "frmQuanLyNhanVien";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Quản Lý Nhân Viên";
        gbThongTin.ResumeLayout(false);
        gbThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox gbThongTin;
    private System.Windows.Forms.Label lblMaNV;
    private System.Windows.Forms.TextBox txtMaNV;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblGioiTinh;
    private System.Windows.Forms.ComboBox cbGioiTinh;
    private System.Windows.Forms.Label lblNgaySinh;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.Label lblSDT;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Label lblChucVu;
    private System.Windows.Forms.ComboBox cbChucVu;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.DataGridView dgvNhanVien;
}