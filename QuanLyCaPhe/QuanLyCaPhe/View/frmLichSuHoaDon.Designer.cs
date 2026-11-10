using System.ComponentModel;
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
        panelBody = new System.Windows.Forms.Panel();
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
        lblTienMonVal = new System.Windows.Forms.Label();
        lblTienMonTitle = new System.Windows.Forms.Label();
        panelFooter = new System.Windows.Forms.Panel();
        lblThongKeTong = new System.Windows.Forms.Label();
        btnInLaiHoaDon = new System.Windows.Forms.Button();
        btnDong = new System.Windows.Forms.Button();
        panelHeader.SuspendLayout();
        gbBoLoc.SuspendLayout();
        panelBody.SuspendLayout();
        gbDanhSachHoaDon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
        gbChiTietHoaDon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
        panelTongKetChiTiet.SuspendLayout();
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
        panelHeader.Size = new System.Drawing.Size(1024, 50);
        panelHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTitle.ForeColor = System.Drawing.Color.White;
        lblTitle.Location = new System.Drawing.Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(1024, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "LỊCH SỬ HÓA ĐƠN";
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
        gbBoLoc.Size = new System.Drawing.Size(1000, 96);
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
        dtpTuNgay.Size = new System.Drawing.Size(115, 23);
        dtpTuNgay.TabIndex = 1;
        // 
        // lblDenNgay
        // 
        lblDenNgay.AutoSize = true;
        lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblDenNgay.Location = new System.Drawing.Point(202, 26);
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
        dtpDenNgay.Location = new System.Drawing.Point(268, 22);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(115, 23);
        dtpDenNgay.TabIndex = 3;
        // 
        // lblBan
        // 
        lblBan.AutoSize = true;
        lblBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblBan.Location = new System.Drawing.Point(395, 26);
        lblBan.Name = "lblBan";
        lblBan.Size = new System.Drawing.Size(30, 15);
        lblBan.TabIndex = 4;
        lblBan.Text = "Bàn:";
        // 
        // cboBan
        // 
        cboBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        cboBan.FormattingEnabled = true;
        cboBan.Location = new System.Drawing.Point(432, 22);
        cboBan.Name = "cboBan";
        cboBan.Size = new System.Drawing.Size(170, 23);
        cboBan.TabIndex = 5;
        // 
        // lblNhanVien
        // 
        lblNhanVien.AutoSize = true;
        lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblNhanVien.Location = new System.Drawing.Point(620, 26);
        lblNhanVien.Name = "lblNhanVien";
        lblNhanVien.Size = new System.Drawing.Size(61, 15);
        lblNhanVien.TabIndex = 6;
        lblNhanVien.Text = "Thu ngân:";
        // 
        // cboNhanVien
        // 
        cboNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        cboNhanVien.FormattingEnabled = true;
        cboNhanVien.Location = new System.Drawing.Point(688, 22);
        cboNhanVien.Name = "cboNhanVien";
        cboNhanVien.Size = new System.Drawing.Size(296, 23);
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
        txtTimKiem.PlaceholderText = "Nhập mã hóa đơn, tên bàn hoặc món cần tìm...";
        txtTimKiem.Size = new System.Drawing.Size(620, 23);
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
        btnTraCuu.Location = new System.Drawing.Point(710, 56);
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
        btnLamMoi.Location = new System.Drawing.Point(825, 56);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(105, 27);
        btnLamMoi.TabIndex = 11;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = false;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // panelBody
        // 
        panelBody.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        panelBody.Controls.Add(gbChiTietHoaDon);
        panelBody.Controls.Add(gbDanhSachHoaDon);
        panelBody.Location = new System.Drawing.Point(12, 160);
        panelBody.Name = "panelBody";
        panelBody.Size = new System.Drawing.Size(1000, 420);
        panelBody.TabIndex = 2;
        // 
        // gbDanhSachHoaDon
        // 
        gbDanhSachHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        gbDanhSachHoaDon.BackColor = System.Drawing.Color.White;
        gbDanhSachHoaDon.Controls.Add(dgvHoaDon);
        gbDanhSachHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        gbDanhSachHoaDon.Location = new System.Drawing.Point(0, 0);
        gbDanhSachHoaDon.Name = "gbDanhSachHoaDon";
        gbDanhSachHoaDon.Size = new System.Drawing.Size(565, 420);
        gbDanhSachHoaDon.TabIndex = 0;
        gbDanhSachHoaDon.TabStop = false;
        gbDanhSachHoaDon.Text = "Danh sách hóa đơn";
        // 
        // dgvHoaDon
        // 
        dgvHoaDon.AllowUserToAddRows = false;
        dgvHoaDon.AllowUserToDeleteRows = false;
        dgvHoaDon.AllowUserToResizeRows = false;
        dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
        dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colSTT, colMaHD, colBan, colThoiGian, colThuNgan, colTongTien });
        dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvHoaDon.Location = new System.Drawing.Point(3, 21);
        dgvHoaDon.MultiSelect = false;
        dgvHoaDon.Name = "dgvHoaDon";
        dgvHoaDon.ReadOnly = true;
        dgvHoaDon.RowHeadersVisible = false;
        dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvHoaDon.Size = new System.Drawing.Size(559, 396);
        dgvHoaDon.TabIndex = 0;
        dgvHoaDon.SelectionChanged += dgvHoaDon_SelectionChanged;
        // 
        // colSTT
        // 
        colSTT.FillWeight = 35F;
        colSTT.HeaderText = "#";
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
        colThoiGian.HeaderText = "Thời gian thanh toán";
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
        gbChiTietHoaDon.BackColor = System.Drawing.Color.White;
        gbChiTietHoaDon.Controls.Add(panelTongKetChiTiet);
        gbChiTietHoaDon.Controls.Add(dgvChiTietHoaDon);
        gbChiTietHoaDon.Controls.Add(lblThongTinChiTietHD);
        gbChiTietHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        gbChiTietHoaDon.Location = new System.Drawing.Point(575, 0);
        gbChiTietHoaDon.Name = "gbChiTietHoaDon";
        gbChiTietHoaDon.Size = new System.Drawing.Size(425, 420);
        gbChiTietHoaDon.TabIndex = 1;
        gbChiTietHoaDon.TabStop = false;
        gbChiTietHoaDon.Text = "Chi tiết hóa đơn được chọn";
        // 
        // lblThongTinChiTietHD
        // 
        lblThongTinChiTietHD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        lblThongTinChiTietHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblThongTinChiTietHD.ForeColor = System.Drawing.Color.FromArgb(70, 130, 180);
        lblThongTinChiTietHD.Location = new System.Drawing.Point(8, 22);
        lblThongTinChiTietHD.Name = "lblThongTinChiTietHD";
        lblThongTinChiTietHD.Size = new System.Drawing.Size(409, 23);
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
        dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
        dgvChiTietHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCT_STT, colCT_TenMon, colCT_SoLuong, colCT_DonGia, colCT_ThanhTien });
        dgvChiTietHoaDon.Location = new System.Drawing.Point(8, 48);
        dgvChiTietHoaDon.MultiSelect = false;
        dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
        dgvChiTietHoaDon.ReadOnly = true;
        dgvChiTietHoaDon.RowHeadersVisible = false;
        dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvChiTietHoaDon.Size = new System.Drawing.Size(409, 260);
        dgvChiTietHoaDon.TabIndex = 1;
        // 
        // colCT_STT
        // 
        colCT_STT.FillWeight = 30F;
        colCT_STT.HeaderText = "#";
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
        panelTongKetChiTiet.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
        panelTongKetChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelTongKetChiTiet.Controls.Add(lblTongCongVal);
        panelTongKetChiTiet.Controls.Add(lblTongCongTitle);
        panelTongKetChiTiet.Controls.Add(lblHinhThucVal);
        panelTongKetChiTiet.Controls.Add(lblHinhThucTitle);
        panelTongKetChiTiet.Controls.Add(lblGiamGiaVal);
        panelTongKetChiTiet.Controls.Add(lblGiamGiaTitle);
        panelTongKetChiTiet.Controls.Add(lblTienMonVal);
        panelTongKetChiTiet.Controls.Add(lblTienMonTitle);
        panelTongKetChiTiet.Location = new System.Drawing.Point(8, 314);
        panelTongKetChiTiet.Name = "panelTongKetChiTiet";
        panelTongKetChiTiet.Size = new System.Drawing.Size(409, 98);
        panelTongKetChiTiet.TabIndex = 2;
        // 
        // lblTongCongVal
        // 
        lblTongCongVal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblTongCongVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongCongVal.ForeColor = System.Drawing.Color.Firebrick;
        lblTongCongVal.Location = new System.Drawing.Point(232, 65);
        lblTongCongVal.Name = "lblTongCongVal";
        lblTongCongVal.Size = new System.Drawing.Size(165, 23);
        lblTongCongVal.TabIndex = 7;
        lblTongCongVal.Text = "0 đ";
        lblTongCongVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTongCongTitle
        // 
        lblTongCongTitle.AutoSize = true;
        lblTongCongTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongCongTitle.Location = new System.Drawing.Point(10, 68);
        lblTongCongTitle.Name = "lblTongCongTitle";
        lblTongCongTitle.Size = new System.Drawing.Size(100, 19);
        lblTongCongTitle.TabIndex = 6;
        lblTongCongTitle.Text = "TỔNG CỘNG:";
        // 
        // lblHinhThucVal
        // 
        lblHinhThucVal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblHinhThucVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblHinhThucVal.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblHinhThucVal.Location = new System.Drawing.Point(232, 38);
        lblHinhThucVal.Name = "lblHinhThucVal";
        lblHinhThucVal.Size = new System.Drawing.Size(165, 18);
        lblHinhThucVal.TabIndex = 5;
        lblHinhThucVal.Text = "--";
        lblHinhThucVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblHinhThucTitle
        // 
        lblHinhThucTitle.AutoSize = true;
        lblHinhThucTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblHinhThucTitle.Location = new System.Drawing.Point(10, 39);
        lblHinhThucTitle.Name = "lblHinhThucTitle";
        lblHinhThucTitle.Size = new System.Drawing.Size(63, 15);
        lblHinhThucTitle.TabIndex = 4;
        lblHinhThucTitle.Text = "Hình thức:";
        // 
        // lblGiamGiaVal
        // 
        lblGiamGiaVal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblGiamGiaVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblGiamGiaVal.ForeColor = System.Drawing.Color.Firebrick;
        lblGiamGiaVal.Location = new System.Drawing.Point(232, 12);
        lblGiamGiaVal.Name = "lblGiamGiaVal";
        lblGiamGiaVal.Size = new System.Drawing.Size(165, 18);
        lblGiamGiaVal.TabIndex = 3;
        lblGiamGiaVal.Text = "- 0 đ";
        lblGiamGiaVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblGiamGiaTitle
        // 
        lblGiamGiaTitle.AutoSize = true;
        lblGiamGiaTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblGiamGiaTitle.Location = new System.Drawing.Point(10, 13);
        lblGiamGiaTitle.Name = "lblGiamGiaTitle";
        lblGiamGiaTitle.Size = new System.Drawing.Size(57, 15);
        lblGiamGiaTitle.TabIndex = 2;
        lblGiamGiaTitle.Text = "Giảm giá:";
        // 
        // lblTienMonVal
        // 
        lblTienMonVal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lblTienMonVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTienMonVal.Location = new System.Drawing.Point(232, -12);
        lblTienMonVal.Name = "lblTienMonVal";
        lblTienMonVal.Size = new System.Drawing.Size(165, 18);
        lblTienMonVal.TabIndex = 1;
        lblTienMonVal.Text = "0 đ";
        lblTienMonVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        lblTienMonVal.Visible = false;
        // 
        // lblTienMonTitle
        // 
        lblTienMonTitle.AutoSize = true;
        lblTienMonTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblTienMonTitle.Location = new System.Drawing.Point(10, -12);
        lblTienMonTitle.Name = "lblTienMonTitle";
        lblTienMonTitle.Size = new System.Drawing.Size(59, 15);
        lblTienMonTitle.TabIndex = 0;
        lblTienMonTitle.Text = "Tiền món:";
        lblTienMonTitle.Visible = false;
        // 
        // panelFooter
        // 
        panelFooter.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelFooter.Controls.Add(btnDong);
        panelFooter.Controls.Add(btnInLaiHoaDon);
        panelFooter.Controls.Add(lblThongKeTong);
        panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        panelFooter.Location = new System.Drawing.Point(0, 590);
        panelFooter.Name = "panelFooter";
        panelFooter.Size = new System.Drawing.Size(1024, 50);
        panelFooter.TabIndex = 3;
        // 
        // lblThongKeTong
        // 
        lblThongKeTong.AutoSize = true;
        lblThongKeTong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblThongKeTong.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblThongKeTong.Location = new System.Drawing.Point(16, 16);
        lblThongKeTong.Name = "lblThongKeTong";
        lblThongKeTong.Size = new System.Drawing.Size(262, 17);
        lblThongKeTong.TabIndex = 0;
        lblThongKeTong.Text = "Tổng số: 0 hóa đơn | Tổng doanh thu: 0 đ";
        // 
        // btnInLaiHoaDon
        // 
        btnInLaiHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnInLaiHoaDon.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
        btnInLaiHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
        btnInLaiHoaDon.FlatAppearance.BorderSize = 0;
        btnInLaiHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnInLaiHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnInLaiHoaDon.ForeColor = System.Drawing.Color.White;
        btnInLaiHoaDon.Location = new System.Drawing.Point(750, 10);
        btnInLaiHoaDon.Name = "btnInLaiHoaDon";
        btnInLaiHoaDon.Size = new System.Drawing.Size(140, 30);
        btnInLaiHoaDon.TabIndex = 1;
        btnInLaiHoaDon.Text = "In lại hóa đơn";
        btnInLaiHoaDon.UseVisualStyleBackColor = false;
        btnInLaiHoaDon.Click += btnInLaiHoaDon_Click;
        // 
        // btnDong
        // 
        btnDong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnDong.BackColor = System.Drawing.Color.LightGray;
        btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDong.FlatAppearance.BorderSize = 0;
        btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnDong.Location = new System.Drawing.Point(908, 10);
        btnDong.Name = "btnDong";
        btnDong.Size = new System.Drawing.Size(100, 30);
        btnDong.TabIndex = 2;
        btnDong.Text = "Đóng";
        btnDong.UseVisualStyleBackColor = false;
        btnDong.Click += btnDong_Click;
        // 
        // frmLichSuHoaDon
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
        ClientSize = new System.Drawing.Size(1024, 640);
        Controls.Add(panelFooter);
        Controls.Add(panelBody);
        Controls.Add(gbBoLoc);
        Controls.Add(panelHeader);
        MinimumSize = new System.Drawing.Size(950, 550);
        Name = "frmLichSuHoaDon";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Nhật Ký & Lịch Sử Hóa Đơn";
        Load += frmLichSuHoaDon_Load;
        panelHeader.ResumeLayout(false);
        gbBoLoc.ResumeLayout(false);
        gbBoLoc.PerformLayout();
        panelBody.ResumeLayout(false);
        gbDanhSachHoaDon.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
        gbChiTietHoaDon.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
        panelTongKetChiTiet.ResumeLayout(false);
        panelTongKetChiTiet.PerformLayout();
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
    private System.Windows.Forms.Panel panelBody;
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
    private System.Windows.Forms.Label lblTienMonVal;
    private System.Windows.Forms.Label lblTienMonTitle;
    private System.Windows.Forms.Panel panelFooter;
    private System.Windows.Forms.Label lblThongKeTong;
    private System.Windows.Forms.Button btnInLaiHoaDon;
    private System.Windows.Forms.Button btnDong;
}
