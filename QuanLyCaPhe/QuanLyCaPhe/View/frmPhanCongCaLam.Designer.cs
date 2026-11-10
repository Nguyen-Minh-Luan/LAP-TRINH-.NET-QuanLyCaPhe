namespace QuanLyCaPhe;

partial class frmPhanCongCaLam
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
        gbThongTinPhanCong = new System.Windows.Forms.GroupBox();
        lblNgayLam = new System.Windows.Forms.Label();
        dtpNgayLam = new System.Windows.Forms.DateTimePicker();
        lblNhanVien = new System.Windows.Forms.Label();
        cbNhanVien = new System.Windows.Forms.ComboBox();
        lblCaLam = new System.Windows.Forms.Label();
        cbCaLam = new System.Windows.Forms.ComboBox();
        lblGhiChu = new System.Windows.Forms.Label();
        txtGhiChu = new System.Windows.Forms.TextBox();
        btnPhanCong = new System.Windows.Forms.Button();
        btnSuaLich = new System.Windows.Forms.Button();
        btnXoaLich = new System.Windows.Forms.Button();
        btnLamMoi = new System.Windows.Forms.Button();
        dgvPhanCong = new System.Windows.Forms.DataGridView();
        gbThongTinPhanCong.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPhanCong).BeginInit();
        SuspendLayout();
        // 
        // gbThongTinPhanCong
        // 
        gbThongTinPhanCong.Controls.Add(txtGhiChu);
        gbThongTinPhanCong.Controls.Add(lblGhiChu);
        gbThongTinPhanCong.Controls.Add(cbCaLam);
        gbThongTinPhanCong.Controls.Add(lblCaLam);
        gbThongTinPhanCong.Controls.Add(cbNhanVien);
        gbThongTinPhanCong.Controls.Add(lblNhanVien);
        gbThongTinPhanCong.Controls.Add(dtpNgayLam);
        gbThongTinPhanCong.Controls.Add(lblNgayLam);
        gbThongTinPhanCong.Location = new System.Drawing.Point(12, 12);
        gbThongTinPhanCong.Name = "gbThongTinPhanCong";
        gbThongTinPhanCong.Size = new System.Drawing.Size(776, 120);
        gbThongTinPhanCong.TabIndex = 0;
        gbThongTinPhanCong.TabStop = false;
        gbThongTinPhanCong.Text = "Thông tin phân công ca làm";
        // 
        // lblNgayLam
        // 
        lblNgayLam.AutoSize = true;
        lblNgayLam.Location = new System.Drawing.Point(20, 30);
        lblNgayLam.Name = "lblNgayLam";
        lblNgayLam.Size = new System.Drawing.Size(61, 15);
        lblNgayLam.TabIndex = 0;
        lblNgayLam.Text = "Ngày làm:";
        // 
        // dtpNgayLam
        // 
        dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpNgayLam.Location = new System.Drawing.Point(90, 27);
        dtpNgayLam.Name = "dtpNgayLam";
        dtpNgayLam.Size = new System.Drawing.Size(150, 23);
        dtpNgayLam.TabIndex = 1;
        // 
        // lblNhanVien
        // 
        lblNhanVien.AutoSize = true;
        lblNhanVien.Location = new System.Drawing.Point(270, 30);
        lblNhanVien.Name = "lblNhanVien";
        lblNhanVien.Size = new System.Drawing.Size(64, 15);
        lblNhanVien.TabIndex = 2;
        lblNhanVien.Text = "Nhân viên:";
        // 
        // cbNhanVien
        // 
        cbNhanVien.FormattingEnabled = true;
        cbNhanVien.Location = new System.Drawing.Point(340, 27);
        cbNhanVien.Name = "cbNhanVien";
        cbNhanVien.Size = new System.Drawing.Size(160, 23);
        cbNhanVien.TabIndex = 3;
        // 
        // lblCaLam
        // 
        lblCaLam.AutoSize = true;
        lblCaLam.Location = new System.Drawing.Point(530, 30);
        lblCaLam.Name = "lblCaLam";
        lblCaLam.Size = new System.Drawing.Size(47, 15);
        lblCaLam.TabIndex = 4;
        lblCaLam.Text = "Ca làm:";
        // 
        // cbCaLam
        // 
        cbCaLam.FormattingEnabled = true;
        cbCaLam.Location = new System.Drawing.Point(585, 27);
        cbCaLam.Name = "cbCaLam";
        cbCaLam.Size = new System.Drawing.Size(160, 23);
        cbCaLam.TabIndex = 5;
        // 
        // lblGhiChu
        // 
        lblGhiChu.AutoSize = true;
        lblGhiChu.Location = new System.Drawing.Point(20, 75);
        lblGhiChu.Name = "lblGhiChu";
        lblGhiChu.Size = new System.Drawing.Size(51, 15);
        lblGhiChu.TabIndex = 6;
        lblGhiChu.Text = "Ghi chú:";
        // 
        // txtGhiChu
        // 
        txtGhiChu.Location = new System.Drawing.Point(90, 72);
        txtGhiChu.Name = "txtGhiChu";
        txtGhiChu.Size = new System.Drawing.Size(655, 23);
        txtGhiChu.TabIndex = 7;
        // 
        // btnPhanCong
        // 
        btnPhanCong.Location = new System.Drawing.Point(210, 145);
        btnPhanCong.Name = "btnPhanCong";
        btnPhanCong.Size = new System.Drawing.Size(100, 30);
        btnPhanCong.TabIndex = 1;
        btnPhanCong.Text = "Phân công";
        btnPhanCong.UseVisualStyleBackColor = true;
        btnPhanCong.Click += btnPhanCong_Click;
        // 
        // btnSuaLich
        // 
        btnSuaLich.Location = new System.Drawing.Point(325, 145);
        btnSuaLich.Name = "btnSuaLich";
        btnSuaLich.Size = new System.Drawing.Size(90, 30);
        btnSuaLich.TabIndex = 2;
        btnSuaLich.Text = "Sửa lịch";
        btnSuaLich.UseVisualStyleBackColor = true;
        btnSuaLich.Click += btnSuaLich_Click;
        // 
        // btnXoaLich
        // 
        btnXoaLich.Location = new System.Drawing.Point(430, 145);
        btnXoaLich.Name = "btnXoaLich";
        btnXoaLich.Size = new System.Drawing.Size(90, 30);
        btnXoaLich.TabIndex = 3;
        btnXoaLich.Text = "Xóa lịch";
        btnXoaLich.UseVisualStyleBackColor = true;
        btnXoaLich.Click += btnXoaLich_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.Location = new System.Drawing.Point(535, 145);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(90, 30);
        btnLamMoi.TabIndex = 4;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // dgvPhanCong
        // 
        dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPhanCong.Location = new System.Drawing.Point(12, 190);
        dgvPhanCong.Name = "dgvPhanCong";
        dgvPhanCong.Size = new System.Drawing.Size(776, 250);
        dgvPhanCong.TabIndex = 5;
        dgvPhanCong.CellClick += dgvPhanCong_CellClick;
        // 
        // frmPhanCongCaLam
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(dgvPhanCong);
        Controls.Add(btnLamMoi);
        Controls.Add(btnXoaLich);
        Controls.Add(btnSuaLich);
        Controls.Add(btnPhanCong);
        Controls.Add(gbThongTinPhanCong);
        Name = "frmPhanCongCaLam";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Phân Công Ca Làm";
        gbThongTinPhanCong.ResumeLayout(false);
        gbThongTinPhanCong.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPhanCong).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox gbThongTinPhanCong;
    private System.Windows.Forms.Label lblNgayLam;
    private System.Windows.Forms.DateTimePicker dtpNgayLam;
    private System.Windows.Forms.Label lblNhanVien;
    private System.Windows.Forms.ComboBox cbNhanVien;
    private System.Windows.Forms.Label lblCaLam;
    private System.Windows.Forms.ComboBox cbCaLam;
    private System.Windows.Forms.Label lblGhiChu;
    private System.Windows.Forms.TextBox txtGhiChu;
    private System.Windows.Forms.Button btnPhanCong;
    private System.Windows.Forms.Button btnSuaLich;
    private System.Windows.Forms.Button btnXoaLich;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.DataGridView dgvPhanCong;
}