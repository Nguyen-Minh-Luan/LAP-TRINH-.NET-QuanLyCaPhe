namespace QuanLyCaPhe;

partial class frmQuanLyCaLam
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
        gbThongTinCa = new System.Windows.Forms.GroupBox();
        lblMaCa = new System.Windows.Forms.Label();
        txtMaCa = new System.Windows.Forms.TextBox();
        lblTenCa = new System.Windows.Forms.Label();
        txtTenCa = new System.Windows.Forms.TextBox();
        lblGioBatDau = new System.Windows.Forms.Label();
        dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
        lblGioKetThuc = new System.Windows.Forms.Label();
        dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
        lblLuongCa = new System.Windows.Forms.Label();
        txtLuongCa = new System.Windows.Forms.TextBox();
        btnThem = new System.Windows.Forms.Button();
        btnSua = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        btnLamMoi = new System.Windows.Forms.Button();
        dgvCaLam = new System.Windows.Forms.DataGridView();
        gbThongTinCa.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCaLam).BeginInit();
        SuspendLayout();
        // 
        // gbThongTinCa
        // 
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
        gbThongTinCa.Location = new System.Drawing.Point(12, 12);
        gbThongTinCa.Name = "gbThongTinCa";
        gbThongTinCa.Size = new System.Drawing.Size(776, 120);
        gbThongTinCa.TabIndex = 0;
        gbThongTinCa.TabStop = false;
        gbThongTinCa.Text = "Thông tin ca làm";
        // 
        // lblMaCa
        // 
        lblMaCa.AutoSize = true;
        lblMaCa.Location = new System.Drawing.Point(20, 30);
        lblMaCa.Name = "lblMaCa";
        lblMaCa.Size = new System.Drawing.Size(42, 15);
        lblMaCa.TabIndex = 0;
        lblMaCa.Text = "Mã ca:";
        // 
        // txtMaCa
        // 
        txtMaCa.Location = new System.Drawing.Point(75, 27);
        txtMaCa.Name = "txtMaCa";
        txtMaCa.Size = new System.Drawing.Size(150, 23);
        txtMaCa.TabIndex = 1;
        // 
        // lblTenCa
        // 
        lblTenCa.AutoSize = true;
        lblTenCa.Location = new System.Drawing.Point(260, 30);
        lblTenCa.Name = "lblTenCa";
        lblTenCa.Size = new System.Drawing.Size(44, 15);
        lblTenCa.TabIndex = 2;
        lblTenCa.Text = "Tên ca:";
        // 
        // txtTenCa
        // 
        txtTenCa.Location = new System.Drawing.Point(320, 27);
        txtTenCa.Name = "txtTenCa";
        txtTenCa.Size = new System.Drawing.Size(160, 23);
        txtTenCa.TabIndex = 3;
        // 
        // lblGioBatDau
        // 
        lblGioBatDau.AutoSize = true;
        lblGioBatDau.Location = new System.Drawing.Point(510, 30);
        lblGioBatDau.Name = "lblGioBatDau";
        lblGioBatDau.Size = new System.Drawing.Size(71, 15);
        lblGioBatDau.TabIndex = 4;
        lblGioBatDau.Text = "Giờ bắt đầu:";
        // 
        // dtpGioBatDau
        // 
        dtpGioBatDau.CustomFormat = "HH:mm";
        dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpGioBatDau.ShowUpDown = true;
        dtpGioBatDau.Location = new System.Drawing.Point(595, 27);
        dtpGioBatDau.Name = "dtpGioBatDau";
        dtpGioBatDau.Size = new System.Drawing.Size(150, 23);
        dtpGioBatDau.TabIndex = 5;
        // 
        // lblGioKetThuc
        // 
        lblGioKetThuc.AutoSize = true;
        lblGioKetThuc.Location = new System.Drawing.Point(20, 75);
        lblGioKetThuc.Name = "lblGioKetThuc";
        lblGioKetThuc.Size = new System.Drawing.Size(74, 15);
        lblGioKetThuc.TabIndex = 6;
        lblGioKetThuc.Text = "Giờ kết thúc:";
        // 
        // dtpGioKetThuc
        // 
        dtpGioKetThuc.CustomFormat = "HH:mm";
        dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpGioKetThuc.ShowUpDown = true;
        dtpGioKetThuc.Location = new System.Drawing.Point(100, 72);
        dtpGioKetThuc.Name = "dtpGioKetThuc";
        dtpGioKetThuc.Size = new System.Drawing.Size(125, 23);
        dtpGioKetThuc.TabIndex = 7;
        // 
        // lblLuongCa
        // 
        lblLuongCa.AutoSize = true;
        lblLuongCa.Location = new System.Drawing.Point(260, 75);
        lblLuongCa.Name = "lblLuongCa";
        lblLuongCa.Size = new System.Drawing.Size(60, 15);
        lblLuongCa.TabIndex = 8;
        lblLuongCa.Text = "Lương/ca:";
        // 
        // txtLuongCa
        // 
        txtLuongCa.Location = new System.Drawing.Point(320, 72);
        txtLuongCa.Name = "txtLuongCa";
        txtLuongCa.Size = new System.Drawing.Size(160, 23);
        txtLuongCa.TabIndex = 9;
        // 
        // btnThem
        // 
        btnThem.Location = new System.Drawing.Point(220, 145);
        btnThem.Name = "btnThem";
        btnThem.Size = new System.Drawing.Size(90, 30);
        btnThem.TabIndex = 1;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        // 
        // btnSua
        // 
        btnSua.Location = new System.Drawing.Point(330, 145);
        btnSua.Name = "btnSua";
        btnSua.Size = new System.Drawing.Size(90, 30);
        btnSua.TabIndex = 2;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        // 
        // btnXoa
        // 
        btnXoa.Location = new System.Drawing.Point(440, 145);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(90, 30);
        btnXoa.TabIndex = 3;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.Location = new System.Drawing.Point(550, 145);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(90, 30);
        btnLamMoi.TabIndex = 4;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // dgvCaLam
        // 
        dgvCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCaLam.Location = new System.Drawing.Point(12, 190);
        dgvCaLam.Name = "dgvCaLam";
        dgvCaLam.Size = new System.Drawing.Size(776, 250);
        dgvCaLam.TabIndex = 5;
        dgvCaLam.CellClick += dgvCaLam_CellClick;
        // 
        // frmQuanLyCaLam
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(dgvCaLam);
        Controls.Add(btnLamMoi);
        Controls.Add(btnXoa);
        Controls.Add(btnSua);
        Controls.Add(btnThem);
        Controls.Add(gbThongTinCa);
        Name = "frmQuanLyCaLam";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Quản Lý Ca Làm";
        gbThongTinCa.ResumeLayout(false);
        gbThongTinCa.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCaLam).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox gbThongTinCa;
    private System.Windows.Forms.Label lblMaCa;
    private System.Windows.Forms.TextBox txtMaCa;
    private System.Windows.Forms.Label lblTenCa;
    private System.Windows.Forms.TextBox txtTenCa;
    private System.Windows.Forms.Label lblGioBatDau;
    private System.Windows.Forms.DateTimePicker dtpGioBatDau;
    private System.Windows.Forms.Label lblGioKetThuc;
    private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
    private System.Windows.Forms.Label lblLuongCa;
    private System.Windows.Forms.TextBox txtLuongCa;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.DataGridView dgvCaLam;
}