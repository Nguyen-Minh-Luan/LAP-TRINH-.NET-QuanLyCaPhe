using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe;

partial class frmLichSuHoaDon
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
        lblNhanVien = new System.Windows.Forms.Label();
        cboNhanVien = new System.Windows.Forms.ComboBox();
        lblTimKiem = new System.Windows.Forms.Label();
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnTraCuu = new System.Windows.Forms.Button();
        btnLamMoi = new System.Windows.Forms.Button();
        gbDanhSachHoaDon = new System.Windows.Forms.GroupBox();
        dgvHoaDon = new System.Windows.Forms.DataGridView();
        colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colThuNgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        gbChiTietHoaDon = new System.Windows.Forms.GroupBox();
        lblThongTinChiTietHD = new System.Windows.Forms.Label();
        dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
        colCT_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colCT_TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colCT_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colCT_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colCT_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        panelTongKetChiTiet = new System.Windows.Forms.Panel();
        lblTongCongVal = new System.Windows.Forms.Label();
        lblTongCongTitle = new System.Windows.Forms.Label();
        lblHinhThucVal = new System.Windows.Forms.Label();
        lblHinhThucTitle = new System.Windows.Forms.Label();
        lblGiamGiaVal = new System.Windows.Forms.Label();
        lblGiamGiaTitle = new System.Windows.Forms.Label();
        btnDong = new System.Windows.Forms.Button();
        gbBoLoc.SuspendLayout();
        gbDanhSachHoaDon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
        gbChiTietHoaDon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
        panelTongKetChiTiet.SuspendLayout();
        SuspendLayout();
        // 
        // lblTieuDe
        // 
        lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTieuDe.ForeColor = System.Drawing.Color.Blue;
        lblTieuDe.Location = new System.Drawing.Point(0, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(984, 45);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "LỊCH SỬ HÓA ĐƠN";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // gbBoLoc
        // 
        gbBoLoc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        gbBoLoc.Controls.Add(btnLamMoi);
        gbBoLoc.Controls.Add(btnTraCuu);
        gbBoLoc.Controls.Add(txtTimKiem);
        gbBoLoc.Controls.Add(lblTimKiem);
        gbBoLoc.Controls.Add(cboNhanVien);
        gbBoLoc.Controls.Add(lblNhanVien);
        gbBoLoc.Controls.Add(dtpDenNgay);
        gbBoLoc.Controls.Add(lblDenNgay);
        gbBoLoc.Controls.Add(dtpTuNgay);
        gbBoLoc.Controls.Add(lblTuNgay);
        gbBoLoc.Location = new System.Drawing.Point(12, 48);
        gbBoLoc.Name = "gbBoLoc";
        gbBoLoc.Size = new System.Drawing.Size(960, 95);
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
        dtpTuNgay.Size = new System.Drawing.Size(115, 23);
        dtpTuNgay.TabIndex = 1;
        // 
        // lblDenNgay
        // 
        lblDenNgay.AutoSize = true;
        lblDenNgay.Location = new System.Drawing.Point(205, 26);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(60, 15);
        lblDenNgay.TabIndex = 2;
        lblDenNgay.Text = "Đến ngày:";
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.CustomFormat = "dd/MM/yyyy";
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpDenNgay.Location = new System.Drawing.Point(271, 22);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(115, 23);
        dtpDenNgay.TabIndex = 3;
        // 
        // lblNhanVien
        // 
        lblNhanVien.AutoSize = true;
        lblNhanVien.Location = new System.Drawing.Point(405, 26);
        lblNhanVien.Name = "lblNhanVien";
        lblNhanVien.Size = new System.Drawing.Size(61, 15);
        lblNhanVien.TabIndex = 4;
        lblNhanVien.Text = "Thu ngân:";
        // 
        // cboNhanVien
        // 
        cboNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboNhanVien.FormattingEnabled = true;
        cboNhanVien.Location = new System.Drawing.Point(472, 22);
        cboNhanVien.Name = "cboNhanVien";
        cboNhanVien.Size = new System.Drawing.Size(468, 23);
        cboNhanVien.TabIndex = 5;
        // 
        // lblTimKiem
        // 
        lblTimKiem.AutoSize = true;
        lblTimKiem.Location = new System.Drawing.Point(16, 61);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Size = new System.Drawing.Size(53, 15);
        lblTimKiem.TabIndex = 6;
        lblTimKiem.Text = "Từ khóa:";
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtTimKiem.Location = new System.Drawing.Point(74, 58);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Nhập mã hóa đơn, tên bàn hoặc món cần tìm...";
        txtTimKiem.Size = new System.Drawing.Size(685, 23);
        txtTimKiem.TabIndex = 7;
        // 
        // btnTraCuu
        // 
        btnTraCuu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnTraCuu.Location = new System.Drawing.Point(770, 56);
        btnTraCuu.Name = "btnTraCuu";
        btnTraCuu.Size = new System.Drawing.Size(85, 26);
        btnTraCuu.TabIndex = 8;
        btnTraCuu.Text = "Tra cứu";
        btnTraCuu.UseVisualStyleBackColor = true;
        btnTraCuu.Click += btnTraCuu_Click;
        // 
        // btnLamMoi
        // 
        btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnLamMoi.Location = new System.Drawing.Point(862, 56);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(85, 26);
        btnLamMoi.TabIndex = 9;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // gbDanhSachHoaDon
        // 
        gbDanhSachHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        gbDanhSachHoaDon.Controls.Add(dgvHoaDon);
        gbDanhSachHoaDon.Location = new System.Drawing.Point(12, 149);
        gbDanhSachHoaDon.Name = "gbDanhSachHoaDon";
        gbDanhSachHoaDon.Size = new System.Drawing.Size(540, 385);
        gbDanhSachHoaDon.TabIndex = 2;
        gbDanhSachHoaDon.TabStop = false;
        gbDanhSachHoaDon.Text = "Danh sách hóa đơn";
        // 
        // dgvHoaDon
        // 
        dgvHoaDon.AllowUserToAddRows = false;
        dgvHoaDon.AllowUserToDeleteRows = false;
        dgvHoaDon.AllowUserToResizeRows = false;
        dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
        dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colSTT, colMaHD, colBan, colThoiGian, colThuNgan, colTongTien });
        dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvHoaDon.GridColor = System.Drawing.Color.DarkGray;
        dgvHoaDon.Location = new System.Drawing.Point(3, 19);
        dgvHoaDon.MultiSelect = false;
        dgvHoaDon.Name = "dgvHoaDon";
        dgvHoaDon.ReadOnly = true;
        dgvHoaDon.RowHeadersVisible = false;
        dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvHoaDon.Size = new System.Drawing.Size(534, 363);
        dgvHoaDon.TabIndex = 0;
        dgvHoaDon.SelectionChanged += dgvHoaDon_SelectionChanged;
        // 
        // colSTT
        // 
        colSTT.FillWeight = 35F;
        colSTT.HeaderText = "STT";
        colSTT.Name = "colSTT";
        colSTT.ReadOnly = true;
        // 
        // colMaHD
        // 
        colMaHD.FillWeight = 85F;
        colMaHD.HeaderText = "Mã HĐ";
        colMaHD.Name = "colMaHD";
        colMaHD.ReadOnly = true;
        // 
        // colBan
        // 
        colBan.FillWeight = 100F;
        colBan.HeaderText = "Bàn";
        colBan.Name = "colBan";
        colBan.ReadOnly = true;
        // 
        // colThoiGian
        // 
        colThoiGian.FillWeight = 125F;
        colThoiGian.HeaderText = "Thời gian";
        colThoiGian.Name = "colThoiGian";
        colThoiGian.ReadOnly = true;
        // 
        // colThuNgan
        // 
        colThuNgan.FillWeight = 95F;
        colThuNgan.HeaderText = "Thu ngân";
        colThuNgan.Name = "colThuNgan";
        colThuNgan.ReadOnly = true;
        // 
        // colTongTien
        // 
        colTongTien.FillWeight = 95F;
        colTongTien.HeaderText = "Tổng tiền";
        colTongTien.Name = "colTongTien";
        colTongTien.ReadOnly = true;
        // 
        // gbChiTietHoaDon
        // 
        gbChiTietHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        gbChiTietHoaDon.Controls.Add(panelTongKetChiTiet);
        gbChiTietHoaDon.Controls.Add(dgvChiTietHoaDon);
        gbChiTietHoaDon.Controls.Add(lblThongTinChiTietHD);
        gbChiTietHoaDon.Location = new System.Drawing.Point(558, 149);
        gbChiTietHoaDon.Name = "gbChiTietHoaDon";
        gbChiTietHoaDon.Size = new System.Drawing.Size(414, 385);
        gbChiTietHoaDon.TabIndex = 3;
        gbChiTietHoaDon.TabStop = false;
        gbChiTietHoaDon.Text = "Chi tiết hóa đơn được chọn";
        // 
        // lblThongTinChiTietHD
        // 
        lblThongTinChiTietHD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        lblThongTinChiTietHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblThongTinChiTietHD.ForeColor = System.Drawing.Color.DarkBlue;
        lblThongTinChiTietHD.Location = new System.Drawing.Point(8, 20);
        lblThongTinChiTietHD.Name = "lblThongTinChiTietHD";
        lblThongTinChiTietHD.Size = new System.Drawing.Size(398, 20);
        lblThongTinChiTietHD.TabIndex = 0;
        lblThongTinChiTietHD.Text = "Hóa đơn: Chưa chọn";
        // 
        // dgvChiTietHoaDon
        // 
        dgvChiTietHoaDon.AllowUserToAddRows = false;
        dgvChiTietHoaDon.AllowUserToDeleteRows = false;
        dgvChiTietHoaDon.AllowUserToResizeRows = false;
        dgvChiTietHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvChiTietHoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
        dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCT_STT, colCT_TenMon, colCT_SoLuong, colCT_DonGia, colCT_ThanhTien });
        dgvChiTietHoaDon.GridColor = System.Drawing.Color.DarkGray;
        dgvChiTietHoaDon.Location = new System.Drawing.Point(8, 43);
        dgvChiTietHoaDon.MultiSelect = false;
        dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
        dgvChiTietHoaDon.ReadOnly = true;
        dgvChiTietHoaDon.RowHeadersVisible = false;
        dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvChiTietHoaDon.Size = new System.Drawing.Size(398, 240);
        dgvChiTietHoaDon.TabIndex = 1;
        // 
        // colCT_STT
        // 
        colCT_STT.FillWeight = 30F;
        colCT_STT.HeaderText = "STT";
        colCT_STT.Name = "colCT_STT";
        colCT_STT.ReadOnly = true;
        // 
        // colCT_TenMon
        // 
        colCT_TenMon.FillWeight = 135F;
        colCT_TenMon.HeaderText = "Tên món";
        colCT_TenMon.Name = "colCT_TenMon";
        colCT_TenMon.ReadOnly = true;
        // 
        // colCT_SoLuong
        // 
        colCT_SoLuong.FillWeight = 45F;
        colCT_SoLuong.HeaderText = "SL";
        colCT_SoLuong.Name = "colCT_SoLuong";
        colCT_SoLuong.ReadOnly = true;
        // 
        // colCT_DonGia
        // 
        colCT_DonGia.FillWeight = 75F;
        colCT_DonGia.HeaderText = "Đơn giá";
        colCT_DonGia.Name = "colCT_DonGia";
        colCT_DonGia.ReadOnly = true;
        // 
        // colCT_ThanhTien
        // 
        colCT_ThanhTien.FillWeight = 85F;
        colCT_ThanhTien.HeaderText = "Thành tiền";
        colCT_ThanhTien.Name = "colCT_ThanhTien";
        colCT_ThanhTien.ReadOnly = true;
        // 
        // panelTongKetChiTiet
        // 
        panelTongKetChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        panelTongKetChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelTongKetChiTiet.Controls.Add(lblTongCongVal);
        panelTongKetChiTiet.Controls.Add(lblTongCongTitle);
        panelTongKetChiTiet.Controls.Add(lblHinhThucVal);
        panelTongKetChiTiet.Controls.Add(lblHinhThucTitle);
        panelTongKetChiTiet.Controls.Add(lblGiamGiaVal);
        panelTongKetChiTiet.Controls.Add(lblGiamGiaTitle);
        panelTongKetChiTiet.Location = new System.Drawing.Point(8, 290);
        panelTongKetChiTiet.Name = "panelTongKetChiTiet";
        panelTongKetChiTiet.Size = new System.Drawing.Size(398, 88);
        panelTongKetChiTiet.TabIndex = 2;
        // 
        // lblTongCongVal
        // 
        lblTongCongVal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblTongCongVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongCongVal.ForeColor = System.Drawing.Color.Red;
        lblTongCongVal.Location = new System.Drawing.Point(220, 58);
        lblTongCongVal.Name = "lblTongCongVal";
        lblTongCongVal.Size = new System.Drawing.Size(168, 20);
        lblTongCongVal.TabIndex = 5;
        lblTongCongVal.Text = "0 đ";
        lblTongCongVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTongCongTitle
        // 
        lblTongCongTitle.AutoSize = true;
        lblTongCongTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongCongTitle.Location = new System.Drawing.Point(10, 60);
        lblTongCongTitle.Name = "lblTongCongTitle";
        lblTongCongTitle.Size = new System.Drawing.Size(78, 17);
        lblTongCongTitle.TabIndex = 4;
        lblTongCongTitle.Text = "Tổng cộng:";
        // 
        // lblHinhThucVal
        // 
        lblHinhThucVal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblHinhThucVal.Location = new System.Drawing.Point(220, 33);
        lblHinhThucVal.Name = "lblHinhThucVal";
        lblHinhThucVal.Size = new System.Drawing.Size(168, 18);
        lblHinhThucVal.TabIndex = 3;
        lblHinhThucVal.Text = "--";
        lblHinhThucVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblHinhThucTitle
        // 
        lblHinhThucTitle.AutoSize = true;
        lblHinhThucTitle.Location = new System.Drawing.Point(10, 35);
        lblHinhThucTitle.Name = "lblHinhThucTitle";
        lblHinhThucTitle.Size = new System.Drawing.Size(63, 15);
        lblHinhThucTitle.TabIndex = 2;
        lblHinhThucTitle.Text = "Hình thức:";
        // 
        // lblGiamGiaVal
        // 
        lblGiamGiaVal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblGiamGiaVal.ForeColor = System.Drawing.Color.DarkRed;
        lblGiamGiaVal.Location = new System.Drawing.Point(220, 8);
        lblGiamGiaVal.Name = "lblGiamGiaVal";
        lblGiamGiaVal.Size = new System.Drawing.Size(168, 18);
        lblGiamGiaVal.TabIndex = 1;
        lblGiamGiaVal.Text = "- 0 đ";
        lblGiamGiaVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblGiamGiaTitle
        // 
        lblGiamGiaTitle.AutoSize = true;
        lblGiamGiaTitle.Location = new System.Drawing.Point(10, 10);
        lblGiamGiaTitle.Name = "lblGiamGiaTitle";
        lblGiamGiaTitle.Size = new System.Drawing.Size(57, 15);
        lblGiamGiaTitle.TabIndex = 0;
        lblGiamGiaTitle.Text = "Giảm giá:";
        // 
        // btnDong
        // 
        btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnDong.Location = new System.Drawing.Point(872, 540);
        btnDong.Name = "btnDong";
        btnDong.Size = new System.Drawing.Size(100, 28);
        btnDong.TabIndex = 4;
        btnDong.Text = "Đóng";
        btnDong.UseVisualStyleBackColor = true;
        btnDong.Click += btnDong_Click;
        // 
        // frmLichSuHoaDon
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(984, 578);
        Controls.Add(btnDong);
        Controls.Add(gbChiTietHoaDon);
        Controls.Add(gbDanhSachHoaDon);
        Controls.Add(gbBoLoc);
        Controls.Add(lblTieuDe);
        MinimumSize = new System.Drawing.Size(900, 520);
        Name = "frmLichSuHoaDon";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Lịch Sử Hóa Đơn";
        Load += frmLichSuHoaDon_Load;
        gbBoLoc.ResumeLayout(false);
        gbBoLoc.PerformLayout();
        gbDanhSachHoaDon.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
        gbChiTietHoaDon.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
        panelTongKetChiTiet.ResumeLayout(false);
        panelTongKetChiTiet.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox gbBoLoc;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Label lblNhanVien;
    private System.Windows.Forms.ComboBox cboNhanVien;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Button btnTraCuu;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.GroupBox gbDanhSachHoaDon;
    private System.Windows.Forms.DataGridView dgvHoaDon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
    private System.Windows.Forms.DataGridViewTextBoxColumn colBan;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThuNgan;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
    private System.Windows.Forms.GroupBox gbChiTietHoaDon;
    private System.Windows.Forms.Label lblThongTinChiTietHD;
    private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCT_STT;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCT_TenMon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCT_SoLuong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCT_DonGia;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCT_ThanhTien;
    private System.Windows.Forms.Panel panelTongKetChiTiet;
    private System.Windows.Forms.Label lblTongCongVal;
    private System.Windows.Forms.Label lblTongCongTitle;
    private System.Windows.Forms.Label lblHinhThucVal;
    private System.Windows.Forms.Label lblHinhThucTitle;
    private System.Windows.Forms.Label lblGiamGiaVal;
    private System.Windows.Forms.Label lblGiamGiaTitle;
    private System.Windows.Forms.Button btnDong;
}
