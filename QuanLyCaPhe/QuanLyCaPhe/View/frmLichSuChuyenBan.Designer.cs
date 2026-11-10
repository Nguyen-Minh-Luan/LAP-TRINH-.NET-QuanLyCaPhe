using System.ComponentModel;
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
        panelHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        gbBoLoc = new System.Windows.Forms.GroupBox();
        lblTuNgay = new System.Windows.Forms.Label();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        lblDenNgay = new System.Windows.Forms.Label();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        lblBan = new System.Windows.Forms.Label();
        cboBan = new System.Windows.Forms.ComboBox();
        lblNhanVien = new System.Windows.Forms.Label();
        cboNhanVien = new System.Windows.Forms.ComboBox();
        lblTimKiem = new System.Windows.Forms.Label();
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnTraCuu = new System.Windows.Forms.Button();
        btnLamMoi = new System.Windows.Forms.Button();
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
        panelFooter = new System.Windows.Forms.Panel();
        lblTongLuotChuyen = new System.Windows.Forms.Label();
        btnXemChiTiet = new System.Windows.Forms.Button();
        btnDong = new System.Windows.Forms.Button();
        panelHeader.SuspendLayout();
        gbBoLoc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLichSuChuyenBan).BeginInit();
        panelFooter.SuspendLayout();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
        panelHeader.Controls.Add(lblTitle);
        panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        panelHeader.Location = new System.Drawing.Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new System.Drawing.Size(984, 50);
        panelHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTitle.ForeColor = System.Drawing.Color.White;
        lblTitle.Location = new System.Drawing.Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(984, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "NHẬT KÝ & LỊCH SỬ CHUYỂN BÀN";
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // gbBoLoc
        // 
        gbBoLoc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        gbBoLoc.BackColor = System.Drawing.Color.White;
        gbBoLoc.Controls.Add(btnLamMoi);
        gbBoLoc.Controls.Add(btnTraCuu);
        gbBoLoc.Controls.Add(txtTimKiem);
        gbBoLoc.Controls.Add(lblTimKiem);
        gbBoLoc.Controls.Add(cboNhanVien);
        gbBoLoc.Controls.Add(lblNhanVien);
        gbBoLoc.Controls.Add(cboBan);
        gbBoLoc.Controls.Add(lblBan);
        gbBoLoc.Controls.Add(dtpDenNgay);
        gbBoLoc.Controls.Add(lblDenNgay);
        gbBoLoc.Controls.Add(dtpTuNgay);
        gbBoLoc.Controls.Add(lblTuNgay);
        gbBoLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        gbBoLoc.Location = new System.Drawing.Point(12, 58);
        gbBoLoc.Name = "gbBoLoc";
        gbBoLoc.Size = new System.Drawing.Size(960, 96);
        gbBoLoc.TabIndex = 1;
        gbBoLoc.TabStop = false;
        gbBoLoc.Text = "Bộ lọc tra cứu";
        // 
        // lblTuNgay
        // 
        lblTuNgay.AutoSize = true;
        lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblTuNgay.Location = new System.Drawing.Point(16, 26);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new System.Drawing.Size(52, 15);
        lblTuNgay.TabIndex = 0;
        lblTuNgay.Text = "Từ ngày:";
        // 
        // dtpTuNgay
        // 
        dtpTuNgay.CustomFormat = "dd/MM/yyyy";
        dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpTuNgay.Location = new System.Drawing.Point(74, 22);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(110, 23);
        dtpTuNgay.TabIndex = 1;
        // 
        // lblDenNgay
        // 
        lblDenNgay.AutoSize = true;
        lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblDenNgay.Location = new System.Drawing.Point(198, 26);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(60, 15);
        lblDenNgay.TabIndex = 2;
        lblDenNgay.Text = "Đến ngày:";
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.CustomFormat = "dd/MM/yyyy";
        dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpDenNgay.Location = new System.Drawing.Point(264, 22);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(110, 23);
        dtpDenNgay.TabIndex = 3;
        // 
        // lblBan
        // 
        lblBan.AutoSize = true;
        lblBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblBan.Location = new System.Drawing.Point(390, 26);
        lblBan.Name = "lblBan";
        lblBan.Size = new System.Drawing.Size(83, 15);
        lblBan.TabIndex = 4;
        lblBan.Text = "Bàn liên quan:";
        // 
        // cboBan
        // 
        cboBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        cboBan.FormattingEnabled = true;
        cboBan.Location = new System.Drawing.Point(479, 22);
        cboBan.Name = "cboBan";
        cboBan.Size = new System.Drawing.Size(175, 23);
        cboBan.TabIndex = 5;
        // 
        // lblNhanVien
        // 
        lblNhanVien.AutoSize = true;
        lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblNhanVien.Location = new System.Drawing.Point(670, 26);
        lblNhanVien.Name = "lblNhanVien";
        lblNhanVien.Size = new System.Drawing.Size(64, 15);
        lblNhanVien.TabIndex = 6;
        lblNhanVien.Text = "Nhân viên:";
        // 
        // cboNhanVien
        // 
        cboNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        cboNhanVien.FormattingEnabled = true;
        cboNhanVien.Location = new System.Drawing.Point(740, 22);
        cboNhanVien.Name = "cboNhanVien";
        cboNhanVien.Size = new System.Drawing.Size(204, 23);
        cboNhanVien.TabIndex = 7;
        // 
        // lblTimKiem
        // 
        lblTimKiem.AutoSize = true;
        lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblTimKiem.Location = new System.Drawing.Point(16, 61);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Size = new System.Drawing.Size(53, 15);
        lblTimKiem.TabIndex = 8;
        lblTimKiem.Text = "Từ khóa:";
        // 
        // txtTimKiem
        // 
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        txtTimKiem.Location = new System.Drawing.Point(74, 58);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Nhập mã chuyển bàn, tên bàn hoặc lý do cần tìm...";
        txtTimKiem.Size = new System.Drawing.Size(580, 23);
        txtTimKiem.TabIndex = 9;
        // 
        // btnTraCuu
        // 
        btnTraCuu.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
        btnTraCuu.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTraCuu.FlatAppearance.BorderSize = 0;
        btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTraCuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnTraCuu.ForeColor = System.Drawing.Color.White;
        btnTraCuu.Location = new System.Drawing.Point(670, 56);
        btnTraCuu.Name = "btnTraCuu";
        btnTraCuu.Size = new System.Drawing.Size(105, 27);
        btnTraCuu.TabIndex = 10;
        btnTraCuu.Text = "Tra cứu";
        btnTraCuu.UseVisualStyleBackColor = false;
        btnTraCuu.Click += btnTraCuu_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.BackColor = System.Drawing.Color.LightGray;
        btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLamMoi.FlatAppearance.BorderSize = 0;
        btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnLamMoi.Location = new System.Drawing.Point(785, 56);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(105, 27);
        btnLamMoi.TabIndex = 11;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = false;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // dgvLichSuChuyenBan
        // 
        dgvLichSuChuyenBan.AllowUserToAddRows = false;
        dgvLichSuChuyenBan.AllowUserToDeleteRows = false;
        dgvLichSuChuyenBan.AllowUserToResizeRows = false;
        dgvLichSuChuyenBan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvLichSuChuyenBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvLichSuChuyenBan.BackgroundColor = System.Drawing.Color.White;
        dgvLichSuChuyenBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dgvLichSuChuyenBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLichSuChuyenBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colSTT, colMaChuyen, colBanNguon, colMuiTen, colBanDich, colThoiGian, colNhanVien, colTongTienDon, colGhiChu });
        dgvLichSuChuyenBan.Location = new System.Drawing.Point(12, 162);
        dgvLichSuChuyenBan.MultiSelect = false;
        dgvLichSuChuyenBan.Name = "dgvLichSuChuyenBan";
        dgvLichSuChuyenBan.ReadOnly = true;
        dgvLichSuChuyenBan.RowHeadersVisible = false;
        dgvLichSuChuyenBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvLichSuChuyenBan.Size = new System.Drawing.Size(960, 368);
        dgvLichSuChuyenBan.TabIndex = 2;
        dgvLichSuChuyenBan.CellDoubleClick += dgvLichSuChuyenBan_CellDoubleClick;
        // 
        // colSTT
        // 
        colSTT.FillWeight = 35F;
        colSTT.HeaderText = "#";
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
        colBanNguon.HeaderText = "Bàn ban đầu";
        colBanNguon.Name = "colBanNguon";
        colBanNguon.ReadOnly = true;
        // 
        // colMuiTen
        // 
        colMuiTen.FillWeight = 30F;
        colMuiTen.HeaderText = "➜";
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
        colThoiGian.HeaderText = "Thời gian chuyển";
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
        colTongTienDon.HeaderText = "Tổng tiền đơn";
        colTongTienDon.Name = "colTongTienDon";
        colTongTienDon.ReadOnly = true;
        // 
        // colGhiChu
        // 
        colGhiChu.FillWeight = 160F;
        colGhiChu.HeaderText = "Lý do / Ghi chú";
        colGhiChu.Name = "colGhiChu";
        colGhiChu.ReadOnly = true;
        // 
        // panelFooter
        // 
        panelFooter.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelFooter.Controls.Add(btnDong);
        panelFooter.Controls.Add(btnXemChiTiet);
        panelFooter.Controls.Add(lblTongLuotChuyen);
        panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        panelFooter.Location = new System.Drawing.Point(0, 540);
        panelFooter.Name = "panelFooter";
        panelFooter.Size = new System.Drawing.Size(984, 50);
        panelFooter.TabIndex = 3;
        // 
        // lblTongLuotChuyen
        // 
        lblTongLuotChuyen.AutoSize = true;
        lblTongLuotChuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongLuotChuyen.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblTongLuotChuyen.Location = new System.Drawing.Point(16, 16);
        lblTongLuotChuyen.Name = "lblTongLuotChuyen";
        lblTongLuotChuyen.Size = new System.Drawing.Size(186, 17);
        lblTongLuotChuyen.TabIndex = 0;
        lblTongLuotChuyen.Text = "Tổng số lượt chuyển bàn: 0 lượt";
        // 
        // btnXemChiTiet
        // 
        btnXemChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnXemChiTiet.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
        btnXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
        btnXemChiTiet.FlatAppearance.BorderSize = 0;
        btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnXemChiTiet.ForeColor = System.Drawing.Color.White;
        btnXemChiTiet.Location = new System.Drawing.Point(712, 10);
        btnXemChiTiet.Name = "btnXemChiTiet";
        btnXemChiTiet.Size = new System.Drawing.Size(145, 30);
        btnXemChiTiet.TabIndex = 1;
        btnXemChiTiet.Text = "Xem chi tiết đơn";
        btnXemChiTiet.UseVisualStyleBackColor = false;
        btnXemChiTiet.Click += btnXemChiTiet_Click;
        // 
        // btnDong
        // 
        btnDong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnDong.BackColor = System.Drawing.Color.LightGray;
        btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDong.FlatAppearance.BorderSize = 0;
        btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnDong.Location = new System.Drawing.Point(868, 10);
        btnDong.Name = "btnDong";
        btnDong.Size = new System.Drawing.Size(100, 30);
        btnDong.TabIndex = 2;
        btnDong.Text = "Đóng";
        btnDong.UseVisualStyleBackColor = false;
        btnDong.Click += btnDong_Click;
        // 
        // frmLichSuChuyenBan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
        ClientSize = new System.Drawing.Size(984, 590);
        Controls.Add(panelFooter);
        Controls.Add(dgvLichSuChuyenBan);
        Controls.Add(gbBoLoc);
        Controls.Add(panelHeader);
        MinimumSize = new System.Drawing.Size(900, 500);
        Name = "frmLichSuChuyenBan";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Nhật Ký & Lịch Sử Chuyển Bàn";
        Load += frmLichSuChuyenBan_Load;
        panelHeader.ResumeLayout(false);
        gbBoLoc.ResumeLayout(false);
        gbBoLoc.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLichSuChuyenBan).EndInit();
        panelFooter.ResumeLayout(false);
        panelFooter.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.GroupBox gbBoLoc;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Label lblBan;
    private System.Windows.Forms.ComboBox cboBan;
    private System.Windows.Forms.Label lblNhanVien;
    private System.Windows.Forms.ComboBox cboNhanVien;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Button btnTraCuu;
    private System.Windows.Forms.Button btnLamMoi;
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
    private System.Windows.Forms.Panel panelFooter;
    private System.Windows.Forms.Label lblTongLuotChuyen;
    private System.Windows.Forms.Button btnXemChiTiet;
    private System.Windows.Forms.Button btnDong;
}
