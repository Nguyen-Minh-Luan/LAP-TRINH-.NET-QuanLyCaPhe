using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe.View;

partial class frmLichSuChuyenBan
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTieuDe = new System.Windows.Forms.Label();
        gbBoLoc = new System.Windows.Forms.GroupBox();
        lblTuNgay = new System.Windows.Forms.Label();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        lblDenNgay = new System.Windows.Forms.Label();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        lblTimKiem = new System.Windows.Forms.Label();
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnTraCuu = new System.Windows.Forms.Button();
        btnLamMoi = new System.Windows.Forms.Button();
        gbDanhSach = new System.Windows.Forms.GroupBox();
        dgvLichSuChuyenBan = new System.Windows.Forms.DataGridView();
        colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colMaChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colBanNguon = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colMuiTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colBanDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colTongTienDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btnXemChiTiet = new System.Windows.Forms.Button();
        btnDong = new System.Windows.Forms.Button();
        gbBoLoc.SuspendLayout();
        gbDanhSach.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLichSuChuyenBan).BeginInit();
        SuspendLayout();
        // 
        // lblTieuDe
        // 
        lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTieuDe.ForeColor = System.Drawing.Color.Blue;
        lblTieuDe.Location = new System.Drawing.Point(0, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(950, 45);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "LỊCH SỬ CHUYỂN BÀN";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // gbBoLoc
        // 
        gbBoLoc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        gbBoLoc.Controls.Add(btnLamMoi);
        gbBoLoc.Controls.Add(btnTraCuu);
        gbBoLoc.Controls.Add(txtTimKiem);
        gbBoLoc.Controls.Add(lblTimKiem);
        gbBoLoc.Controls.Add(dtpDenNgay);
        gbBoLoc.Controls.Add(lblDenNgay);
        gbBoLoc.Controls.Add(dtpTuNgay);
        gbBoLoc.Controls.Add(lblTuNgay);
        gbBoLoc.Location = new System.Drawing.Point(12, 48);
        gbBoLoc.Name = "gbBoLoc";
        gbBoLoc.Size = new System.Drawing.Size(926, 62);
        gbBoLoc.TabIndex = 1;
        gbBoLoc.TabStop = false;
        gbBoLoc.Text = "Thông tin tìm kiếm";
        // 
        // lblTuNgay
        // 
        lblTuNgay.AutoSize = true;
        lblTuNgay.Location = new System.Drawing.Point(16, 26);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new System.Drawing.Size(52, 15);
        lblTuNgay.TabIndex = 0;
        lblTuNgay.Text = "Từ ngày:";
        // 
        // dtpTuNgay
        // 
        dtpTuNgay.CustomFormat = "dd/MM/yyyy";
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpTuNgay.Location = new System.Drawing.Point(74, 22);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(110, 23);
        dtpTuNgay.TabIndex = 1;
        // 
        // lblDenNgay
        // 
        lblDenNgay.AutoSize = true;
        lblDenNgay.Location = new System.Drawing.Point(198, 26);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(60, 15);
        lblDenNgay.TabIndex = 2;
        lblDenNgay.Text = "Đến ngày:";
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.CustomFormat = "dd/MM/yyyy";
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpDenNgay.Location = new System.Drawing.Point(264, 22);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(110, 23);
        dtpDenNgay.TabIndex = 3;
        // 
        // lblTimKiem
        // 
        lblTimKiem.AutoSize = true;
        lblTimKiem.Location = new System.Drawing.Point(392, 26);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Size = new System.Drawing.Size(53, 15);
        lblTimKiem.TabIndex = 4;
        lblTimKiem.Text = "Từ khóa:";
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtTimKiem.Location = new System.Drawing.Point(451, 22);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Nhập mã chuyển, tên bàn, nhân viên, ghi chú...";
        txtTimKiem.Size = new System.Drawing.Size(270, 23);
        txtTimKiem.TabIndex = 5;
        // 
        // btnTraCuu
        // 
        btnTraCuu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnTraCuu.Location = new System.Drawing.Point(732, 20);
        btnTraCuu.Name = "btnTraCuu";
        btnTraCuu.Size = new System.Drawing.Size(88, 27);
        btnTraCuu.TabIndex = 6;
        btnTraCuu.Text = "Tra cứu";
        btnTraCuu.UseVisualStyleBackColor = true;
        btnTraCuu.Click += btnTraCuu_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnLamMoi.Location = new System.Drawing.Point(826, 20);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(88, 27);
        btnLamMoi.TabIndex = 7;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // gbDanhSach
        // 
        gbDanhSach.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        gbDanhSach.Controls.Add(dgvLichSuChuyenBan);
        gbDanhSach.Location = new System.Drawing.Point(12, 116);
        gbDanhSach.Name = "gbDanhSach";
        gbDanhSach.Size = new System.Drawing.Size(926, 394);
        gbDanhSach.TabIndex = 2;
        gbDanhSach.TabStop = false;
        gbDanhSach.Text = "Danh sách chuyển bàn";
        // 
        // dgvLichSuChuyenBan
        // 
        dgvLichSuChuyenBan.AllowUserToAddRows = false;
        dgvLichSuChuyenBan.AllowUserToDeleteRows = false;
        dgvLichSuChuyenBan.AllowUserToResizeRows = false;
        dgvLichSuChuyenBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvLichSuChuyenBan.BackgroundColor = System.Drawing.SystemColors.ControlLight;
        dgvLichSuChuyenBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLichSuChuyenBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colSTT, colMaChuyen, colBanNguon, colMuiTen, colBanDich, colThoiGian, colNhanVien, colTongTienDon, colGhiChu });
        dgvLichSuChuyenBan.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvLichSuChuyenBan.GridColor = System.Drawing.Color.DarkGray;
        dgvLichSuChuyenBan.Location = new System.Drawing.Point(3, 19);
        dgvLichSuChuyenBan.MultiSelect = false;
        dgvLichSuChuyenBan.Name = "dgvLichSuChuyenBan";
        dgvLichSuChuyenBan.ReadOnly = true;
        dgvLichSuChuyenBan.RowHeadersVisible = false;
        dgvLichSuChuyenBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvLichSuChuyenBan.Size = new System.Drawing.Size(920, 372);
        dgvLichSuChuyenBan.TabIndex = 0;
        dgvLichSuChuyenBan.CellDoubleClick += dgvLichSuChuyenBan_CellDoubleClick;
        // 
        // colSTT
        // 
        colSTT.FillWeight = 35F;
        colSTT.HeaderText = "STT";
        colSTT.Name = "colSTT";
        colSTT.ReadOnly = true;
        // 
        // colMaChuyen
        // 
        colMaChuyen.FillWeight = 75F;
        colMaChuyen.HeaderText = "Mã chuyển";
        colMaChuyen.Name = "colMaChuyen";
        colMaChuyen.ReadOnly = true;
        // 
        // colBanNguon
        // 
        colBanNguon.FillWeight = 95F;
        colBanNguon.HeaderText = "Bàn chuyển đi";
        colBanNguon.Name = "colBanNguon";
        colBanNguon.ReadOnly = true;
        // 
        // colMuiTen
        // 
        colMuiTen.FillWeight = 25F;
        colMuiTen.HeaderText = "->";
        colMuiTen.Name = "colMuiTen";
        colMuiTen.ReadOnly = true;
        // 
        // colBanDich
        // 
        colBanDich.FillWeight = 95F;
        colBanDich.HeaderText = "Bàn chuyển đến";
        colBanDich.Name = "colBanDich";
        colBanDich.ReadOnly = true;
        // 
        // colThoiGian
        // 
        colThoiGian.FillWeight = 110F;
        colThoiGian.HeaderText = "Thời gian";
        colThoiGian.Name = "colThoiGian";
        colThoiGian.ReadOnly = true;
        // 
        // colNhanVien
        // 
        colNhanVien.FillWeight = 100F;
        colNhanVien.HeaderText = "Nhân viên";
        colNhanVien.Name = "colNhanVien";
        colNhanVien.ReadOnly = true;
        // 
        // colTongTienDon
        // 
        colTongTienDon.FillWeight = 85F;
        colTongTienDon.HeaderText = "Tổng tiền";
        colTongTienDon.Name = "colTongTienDon";
        colTongTienDon.ReadOnly = true;
        // 
        // colGhiChu
        // 
        colGhiChu.FillWeight = 160F;
        colGhiChu.HeaderText = "Ghi chú";
        colGhiChu.Name = "colGhiChu";
        colGhiChu.ReadOnly = true;
        // 
        // btnXemChiTiet
        // 
        btnXemChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnXemChiTiet.Location = new System.Drawing.Point(718, 517);
        btnXemChiTiet.Name = "btnXemChiTiet";
        btnXemChiTiet.Size = new System.Drawing.Size(110, 28);
        btnXemChiTiet.TabIndex = 3;
        btnXemChiTiet.Text = "Xem chi tiết";
        btnXemChiTiet.UseVisualStyleBackColor = true;
        btnXemChiTiet.Click += btnXemChiTiet_Click;
        // 
        // btnDong
        // 
        btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnDong.Location = new System.Drawing.Point(838, 517);
        btnDong.Name = "btnDong";
        btnDong.Size = new System.Drawing.Size(100, 28);
        btnDong.TabIndex = 4;
        btnDong.Text = "Đóng";
        btnDong.UseVisualStyleBackColor = true;
        btnDong.Click += btnDong_Click;
        // 
        // frmLichSuChuyenBan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(950, 555);
        Controls.Add(btnDong);
        Controls.Add(btnXemChiTiet);
        Controls.Add(gbDanhSach);
        Controls.Add(gbBoLoc);
        Controls.Add(lblTieuDe);
        MinimumSize = new System.Drawing.Size(900, 500);
        Name = "frmLichSuChuyenBan";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Lịch Sử Chuyển Bàn";
        Load += frmLichSuChuyenBan_Load;
        gbBoLoc.ResumeLayout(false);
        gbBoLoc.PerformLayout();
        gbDanhSach.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvLichSuChuyenBan).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox gbBoLoc;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Button btnTraCuu;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.GroupBox gbDanhSach;
    private System.Windows.Forms.DataGridView dgvLichSuChuyenBan;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaChuyen;
    private System.Windows.Forms.DataGridViewTextBoxColumn colBanNguon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMuiTen;
    private System.Windows.Forms.DataGridViewTextBoxColumn colBanDich;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVien;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTongTienDon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    private System.Windows.Forms.Button btnXemChiTiet;
    private System.Windows.Forms.Button btnDong;
}
