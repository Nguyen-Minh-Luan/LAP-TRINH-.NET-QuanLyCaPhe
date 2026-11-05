namespace QuanLyCaPhe;

partial class frmLichSuHoaDon
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
        lblTuNgay = new System.Windows.Forms.Label();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        lblDenNgay = new System.Windows.Forms.Label();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        btnTimKiem = new System.Windows.Forms.Button();
        lblDanhSachHD = new System.Windows.Forms.Label();
        dgvHoaDon = new System.Windows.Forms.DataGridView();
        lblChiTietHD = new System.Windows.Forms.Label();
        dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
        SuspendLayout();
        
        // lblTuNgay
        lblTuNgay.AutoSize = true;
        lblTuNgay.Location = new System.Drawing.Point(20, 20);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new System.Drawing.Size(52, 15);
        lblTuNgay.TabIndex = 0;
        lblTuNgay.Text = "Từ ngày:";
        
        // dtpTuNgay
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpTuNgay.Location = new System.Drawing.Point(80, 17);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(120, 23);
        dtpTuNgay.TabIndex = 1;
        dtpTuNgay.ValueChanged += dtpTuNgay_ValueChanged;
        // lblDenNgay
        lblDenNgay.AutoSize = true;
        lblDenNgay.Location = new System.Drawing.Point(220, 20);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(60, 15);
        lblDenNgay.TabIndex = 2;
        lblDenNgay.Text = "Đến ngày:";
        
        // dtpDenNgay
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDenNgay.Location = new System.Drawing.Point(290, 17);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(120, 23);
        dtpDenNgay.TabIndex = 3;
        dtpDenNgay.ValueChanged += dtpDenNgay_ValueChanged;
        
        // btnTimKiem
        btnTimKiem.Location = new System.Drawing.Point(430, 15);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(90, 26);
        btnTimKiem.TabIndex = 4;
        btnTimKiem.Text = "Tra cứu";
        btnTimKiem.UseVisualStyleBackColor = true;
        btnTimKiem.Click += btnTimKiem_Click;
        // lblDanhSachHD
        lblDanhSachHD.AutoSize = true;
        lblDanhSachHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblDanhSachHD.Location = new System.Drawing.Point(20, 55);
        lblDanhSachHD.Name = "lblDanhSachHD";
        lblDanhSachHD.Size = new System.Drawing.Size(113, 15);
        lblDanhSachHD.TabIndex = 5;
        lblDanhSachHD.Text = "Danh sách hóa đơn";
        
        // dgvHoaDon
        dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvHoaDon.Location = new System.Drawing.Point(20, 80);
        dgvHoaDon.Name = "dgvHoaDon";
        dgvHoaDon.Size = new System.Drawing.Size(430, 370);
        dgvHoaDon.TabIndex = 6;
        dgvHoaDon.CellClick += dgvHoaDon_CellClick;
        
        // lblChiTietHD
        lblChiTietHD.AutoSize = true;
        lblChiTietHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblChiTietHD.Location = new System.Drawing.Point(470, 55);
        lblChiTietHD.Name = "lblChiTietHD";
        lblChiTietHD.Size = new System.Drawing.Size(155, 15);
        lblChiTietHD.TabIndex = 7;
        lblChiTietHD.Text = "Chi tiết hóa đơn được chọn";
        
        // dgvChiTietHoaDon
        dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTietHoaDon.Location = new System.Drawing.Point(470, 80);
        dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
        dgvChiTietHoaDon.Size = new System.Drawing.Size(390, 370);
        dgvChiTietHoaDon.TabIndex = 8;
        
        // frmLichSuHoaDon
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(880, 470);
        Controls.Add(dgvChiTietHoaDon);
        Controls.Add(lblChiTietHD);
        Controls.Add(dgvHoaDon);
        Controls.Add(lblDanhSachHD);
        Controls.Add(btnTimKiem);
        Controls.Add(dtpDenNgay);
        Controls.Add(lblDenNgay);
        Controls.Add(dtpTuNgay);
        Controls.Add(lblTuNgay);
        Name = "frmLichSuHoaDon";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Lịch Sử Hóa Đơn";
        ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Label lblDanhSachHD;
    private System.Windows.Forms.DataGridView dgvHoaDon;
    private System.Windows.Forms.Label lblChiTietHD;
    private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
}