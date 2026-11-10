namespace QuanLyCaPhe;

partial class frmThanhToan
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        lblHeaderTitle = new System.Windows.Forms.Label();
        panelFooter = new System.Windows.Forms.Panel();
        chkInHoaDon = new System.Windows.Forms.CheckBox();
        btnHuy = new System.Windows.Forms.Button();
        btnInTamTinh = new System.Windows.Forms.Button();
        btnThanhToan = new System.Windows.Forms.Button();
        panelBody = new System.Windows.Forms.Panel();
        panelLeft = new System.Windows.Forms.Panel();
        gbThongTinBan = new System.Windows.Forms.GroupBox();
        lblTenBan = new System.Windows.Forms.Label();
        lblMaHoaDon = new System.Windows.Forms.Label();
        lblGioVao = new System.Windows.Forms.Label();
        lblThuNgan = new System.Windows.Forms.Label();
        lblDanhSachMonTitle = new System.Windows.Forms.Label();
        dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
        colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        lblTongSoMon = new System.Windows.Forms.Label();
        lblGhiChuTitle = new System.Windows.Forms.Label();
        txtGhiChu = new System.Windows.Forms.TextBox();
        panelRight = new System.Windows.Forms.Panel();
        gbTinhTien = new System.Windows.Forms.GroupBox();
        lblTongTienMonTitle = new System.Windows.Forms.Label();
        lblTongTienMon = new System.Windows.Forms.Label();
        lblGiamGiaTitle = new System.Windows.Forms.Label();
        nudGiamGia = new System.Windows.Forms.NumericUpDown();
        lblTienGiam = new System.Windows.Forms.Label();
        lblDivider = new System.Windows.Forms.Label();
        lblTongCanThuTitle = new System.Windows.Forms.Label();
        lblTongCanThu = new System.Windows.Forms.Label();
        gbPhuongThucTT = new System.Windows.Forms.GroupBox();
        radTienMat = new System.Windows.Forms.RadioButton();
        radChuyenKhoan = new System.Windows.Forms.RadioButton();
        radThe = new System.Windows.Forms.RadioButton();
        pnlTienMat = new System.Windows.Forms.Panel();
        lblTienKhachDuaTitle = new System.Windows.Forms.Label();
        txtTienKhachDua = new System.Windows.Forms.TextBox();
        lblGoiYMenhGia = new System.Windows.Forms.Label();
        btnTienDu = new System.Windows.Forms.Button();
        btn20k = new System.Windows.Forms.Button();
        btn50k = new System.Windows.Forms.Button();
        btn100k = new System.Windows.Forms.Button();
        btn200k = new System.Windows.Forms.Button();
        btn500k = new System.Windows.Forms.Button();
        lblTienThoiTitle = new System.Windows.Forms.Label();
        lblTienThoi = new System.Windows.Forms.Label();
        pnlChuyenKhoan = new System.Windows.Forms.Panel();
        picQRCode = new System.Windows.Forms.PictureBox();
        lblHuongDanQR = new System.Windows.Forms.Label();
        panelHeader.SuspendLayout();
        panelFooter.SuspendLayout();
        panelBody.SuspendLayout();
        panelLeft.SuspendLayout();
        gbThongTinBan.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
        panelRight.SuspendLayout();
        gbTinhTien.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiamGia).BeginInit();
        gbPhuongThucTT.SuspendLayout();
        pnlTienMat.SuspendLayout();
        pnlChuyenKhoan.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picQRCode).BeginInit();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
        panelHeader.Controls.Add(lblHeaderTitle);
        panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        panelHeader.Location = new System.Drawing.Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new System.Drawing.Size(940, 50);
        panelHeader.TabIndex = 0;
        // 
        // lblHeaderTitle
        // 
        lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblHeaderTitle.ForeColor = System.Drawing.Color.White;
        lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
        lblHeaderTitle.Name = "lblHeaderTitle";
        lblHeaderTitle.Size = new System.Drawing.Size(940, 50);
        lblHeaderTitle.TabIndex = 0;
        lblHeaderTitle.Text = "THANH TOÁN HÓA ĐƠN";
        lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panelFooter
        // 
        panelFooter.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelFooter.Controls.Add(chkInHoaDon);
        panelFooter.Controls.Add(btnHuy);
        panelFooter.Controls.Add(btnInTamTinh);
        panelFooter.Controls.Add(btnThanhToan);
        panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        panelFooter.Location = new System.Drawing.Point(0, 580);
        panelFooter.Name = "panelFooter";
        panelFooter.Size = new System.Drawing.Size(940, 60);
        panelFooter.TabIndex = 2;
        // 
        // chkInHoaDon
        // 
        chkInHoaDon.AutoSize = true;
        chkInHoaDon.Checked = true;
        chkInHoaDon.CheckState = System.Windows.Forms.CheckState.Checked;
        chkInHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        chkInHoaDon.Location = new System.Drawing.Point(20, 20);
        chkInHoaDon.Name = "chkInHoaDon";
        chkInHoaDon.Size = new System.Drawing.Size(209, 21);
        chkInHoaDon.TabIndex = 0;
        chkInHoaDon.Text = "In hóa đơn sau khi thanh toán";
        chkInHoaDon.UseVisualStyleBackColor = true;
        // 
        // btnHuy
        // 
        btnHuy.BackColor = System.Drawing.Color.LightGray;
        btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
        btnHuy.FlatAppearance.BorderSize = 0;
        btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnHuy.Location = new System.Drawing.Point(490, 12);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new System.Drawing.Size(110, 36);
        btnHuy.TabIndex = 1;
        btnHuy.Text = "Hủy bỏ";
        btnHuy.UseVisualStyleBackColor = false;
        btnHuy.Click += btnHuy_Click;
        // 
        // btnInTamTinh
        // 
        btnInTamTinh.BackColor = System.Drawing.Color.RosyBrown;
        btnInTamTinh.Cursor = System.Windows.Forms.Cursors.Hand;
        btnInTamTinh.FlatAppearance.BorderSize = 0;
        btnInTamTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnInTamTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnInTamTinh.ForeColor = System.Drawing.Color.White;
        btnInTamTinh.Location = new System.Drawing.Point(610, 12);
        btnInTamTinh.Name = "btnInTamTinh";
        btnInTamTinh.Size = new System.Drawing.Size(130, 36);
        btnInTamTinh.TabIndex = 2;
        btnInTamTinh.Text = "In tạm tính";
        btnInTamTinh.UseVisualStyleBackColor = false;
        btnInTamTinh.Click += btnInTamTinh_Click;
        // 
        // btnThanhToan
        // 
        btnThanhToan.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
        btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
        btnThanhToan.FlatAppearance.BorderSize = 0;
        btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnThanhToan.ForeColor = System.Drawing.Color.White;
        btnThanhToan.Location = new System.Drawing.Point(750, 12);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new System.Drawing.Size(170, 36);
        btnThanhToan.TabIndex = 3;
        btnThanhToan.Text = "THANH TOÁN";
        btnThanhToan.UseVisualStyleBackColor = false;
        btnThanhToan.Click += btnThanhToan_Click;
        // 
        // panelBody
        // 
        panelBody.Controls.Add(panelRight);
        panelBody.Controls.Add(panelLeft);
        panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
        panelBody.Location = new System.Drawing.Point(0, 50);
        panelBody.Name = "panelBody";
        panelBody.Size = new System.Drawing.Size(940, 530);
        panelBody.TabIndex = 1;
        // 
        // panelLeft
        // 
        panelLeft.BackColor = System.Drawing.Color.White;
        panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelLeft.Controls.Add(txtGhiChu);
        panelLeft.Controls.Add(lblGhiChuTitle);
        panelLeft.Controls.Add(lblTongSoMon);
        panelLeft.Controls.Add(dgvChiTietHoaDon);
        panelLeft.Controls.Add(lblDanhSachMonTitle);
        panelLeft.Controls.Add(gbThongTinBan);
        panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
        panelLeft.Location = new System.Drawing.Point(0, 0);
        panelLeft.Name = "panelLeft";
        panelLeft.Size = new System.Drawing.Size(480, 530);
        panelLeft.TabIndex = 0;
        // 
        // gbThongTinBan
        // 
        gbThongTinBan.Controls.Add(lblThuNgan);
        gbThongTinBan.Controls.Add(lblGioVao);
        gbThongTinBan.Controls.Add(lblMaHoaDon);
        gbThongTinBan.Controls.Add(lblTenBan);
        gbThongTinBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        gbThongTinBan.Location = new System.Drawing.Point(12, 10);
        gbThongTinBan.Name = "gbThongTinBan";
        gbThongTinBan.Size = new System.Drawing.Size(454, 75);
        gbThongTinBan.TabIndex = 0;
        gbThongTinBan.TabStop = false;
        gbThongTinBan.Text = "Thông tin bàn";
        // 
        // lblTenBan
        // 
        lblTenBan.AutoSize = true;
        lblTenBan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTenBan.ForeColor = System.Drawing.Color.FromArgb(70, 130, 180);
        lblTenBan.Location = new System.Drawing.Point(12, 22);
        lblTenBan.Name = "lblTenBan";
        lblTenBan.Size = new System.Drawing.Size(126, 19);
        lblTenBan.TabIndex = 0;
        lblTenBan.Text = "BÀN: BÀN 01 (T1)";
        // 
        // lblMaHoaDon
        // 
        lblMaHoaDon.AutoSize = true;
        lblMaHoaDon.ForeColor = System.Drawing.Color.DimGray;
        lblMaHoaDon.Location = new System.Drawing.Point(12, 48);
        lblMaHoaDon.Name = "lblMaHoaDon";
        lblMaHoaDon.Size = new System.Drawing.Size(103, 15);
        lblMaHoaDon.TabIndex = 1;
        lblMaHoaDon.Text = "Mã HĐ: HD-00012";
        // 
        // lblGioVao
        // 
        lblGioVao.AutoSize = true;
        lblGioVao.ForeColor = System.Drawing.Color.DimGray;
        lblGioVao.Location = new System.Drawing.Point(240, 22);
        lblGioVao.Name = "lblGioVao";
        lblGioVao.Size = new System.Drawing.Size(83, 15);
        lblGioVao.TabIndex = 2;
        lblGioVao.Text = "Giờ vào: 14:30";
        // 
        // lblThuNgan
        // 
        lblThuNgan.AutoSize = true;
        lblThuNgan.ForeColor = System.Drawing.Color.DimGray;
        lblThuNgan.Location = new System.Drawing.Point(240, 48);
        lblThuNgan.Name = "lblThuNgan";
        lblThuNgan.Size = new System.Drawing.Size(99, 15);
        lblThuNgan.TabIndex = 3;
        lblThuNgan.Text = "Thu ngân: Admin";
        // 
        // lblDanhSachMonTitle
        // 
        lblDanhSachMonTitle.AutoSize = true;
        lblDanhSachMonTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblDanhSachMonTitle.Location = new System.Drawing.Point(12, 94);
        lblDanhSachMonTitle.Name = "lblDanhSachMonTitle";
        lblDanhSachMonTitle.Size = new System.Drawing.Size(150, 17);
        lblDanhSachMonTitle.TabIndex = 1;
        lblDanhSachMonTitle.Text = "Danh sách món đã dùng:";
        // 
        // dgvChiTietHoaDon
        // 
        dgvChiTietHoaDon.AllowUserToAddRows = false;
        dgvChiTietHoaDon.AllowUserToDeleteRows = false;
        dgvChiTietHoaDon.AllowUserToResizeRows = false;
        dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
        dgvChiTietHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colSTT, colTenMon, colSoLuong, colDonGia, colThanhTien });
        dgvChiTietHoaDon.Location = new System.Drawing.Point(12, 118);
        dgvChiTietHoaDon.MultiSelect = false;
        dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
        dgvChiTietHoaDon.ReadOnly = true;
        dgvChiTietHoaDon.RowHeadersVisible = false;
        dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvChiTietHoaDon.Size = new System.Drawing.Size(454, 280);
        dgvChiTietHoaDon.TabIndex = 2;
        // 
        // colSTT
        // 
        colSTT.FillWeight = 30F;
        colSTT.HeaderText = "#";
        colSTT.Name = "colSTT";
        colSTT.ReadOnly = true;
        // 
        // colTenMon
        // 
        colTenMon.FillWeight = 140F;
        colTenMon.HeaderText = "Tên món";
        colTenMon.Name = "colTenMon";
        colTenMon.ReadOnly = true;
        // 
        // colSoLuong
        // 
        colSoLuong.FillWeight = 45F;
        colSoLuong.HeaderText = "SL";
        colSoLuong.Name = "colSoLuong";
        colSoLuong.ReadOnly = true;
        // 
        // colDonGia
        // 
        colDonGia.FillWeight = 75F;
        colDonGia.HeaderText = "Đơn giá";
        colDonGia.Name = "colDonGia";
        colDonGia.ReadOnly = true;
        // 
        // colThanhTien
        // 
        colThanhTien.FillWeight = 85F;
        colThanhTien.HeaderText = "Thành tiền";
        colThanhTien.Name = "colThanhTien";
        colThanhTien.ReadOnly = true;
        // 
        // lblTongSoMon
        // 
        lblTongSoMon.AutoSize = true;
        lblTongSoMon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
        lblTongSoMon.ForeColor = System.Drawing.Color.DimGray;
        lblTongSoMon.Location = new System.Drawing.Point(12, 404);
        lblTongSoMon.Name = "lblTongSoMon";
        lblTongSoMon.Size = new System.Drawing.Size(117, 15);
        lblTongSoMon.TabIndex = 3;
        lblTongSoMon.Text = "Tổng số lượng món: 0";
        // 
        // lblGhiChuTitle
        // 
        lblGhiChuTitle.AutoSize = true;
        lblGhiChuTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblGhiChuTitle.Location = new System.Drawing.Point(12, 428);
        lblGhiChuTitle.Name = "lblGhiChuTitle";
        lblGhiChuTitle.Size = new System.Drawing.Size(102, 15);
        lblGhiChuTitle.TabIndex = 4;
        lblGhiChuTitle.Text = "Ghi chú hóa đơn:";
        // 
        // txtGhiChu
        // 
        txtGhiChu.Location = new System.Drawing.Point(12, 448);
        txtGhiChu.Multiline = true;
        txtGhiChu.Name = "txtGhiChu";
        txtGhiChu.PlaceholderText = "Nhập ghi chú cho đơn hàng này (nếu có)...";
        txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtGhiChu.Size = new System.Drawing.Size(454, 68);
        txtGhiChu.TabIndex = 5;
        // 
        // panelRight
        // 
        panelRight.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
        panelRight.Controls.Add(pnlChuyenKhoan);
        panelRight.Controls.Add(pnlTienMat);
        panelRight.Controls.Add(gbPhuongThucTT);
        panelRight.Controls.Add(gbTinhTien);
        panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
        panelRight.Location = new System.Drawing.Point(480, 0);
        panelRight.Name = "panelRight";
        panelRight.Size = new System.Drawing.Size(460, 530);
        panelRight.TabIndex = 1;
        // 
        // gbTinhTien
        // 
        gbTinhTien.BackColor = System.Drawing.Color.White;
        gbTinhTien.Controls.Add(lblTongCanThu);
        gbTinhTien.Controls.Add(lblTongCanThuTitle);
        gbTinhTien.Controls.Add(lblDivider);
        gbTinhTien.Controls.Add(lblTienGiam);
        gbTinhTien.Controls.Add(nudGiamGia);
        gbTinhTien.Controls.Add(lblGiamGiaTitle);
        gbTinhTien.Controls.Add(lblTongTienMon);
        gbTinhTien.Controls.Add(lblTongTienMonTitle);
        gbTinhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        gbTinhTien.Location = new System.Drawing.Point(12, 10);
        gbTinhTien.Name = "gbTinhTien";
        gbTinhTien.Size = new System.Drawing.Size(436, 175);
        gbTinhTien.TabIndex = 0;
        gbTinhTien.TabStop = false;
        gbTinhTien.Text = "Chiết tính hóa đơn";
        // 
        // lblTongTienMonTitle
        // 
        lblTongTienMonTitle.AutoSize = true;
        lblTongTienMonTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblTongTienMonTitle.Location = new System.Drawing.Point(16, 28);
        lblTongTienMonTitle.Name = "lblTongTienMonTitle";
        lblTongTienMonTitle.Size = new System.Drawing.Size(130, 19);
        lblTongTienMonTitle.TabIndex = 0;
        lblTongTienMonTitle.Text = "Tiền món (tạm tính):";
        // 
        // lblTongTienMon
        // 
        lblTongTienMon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongTienMon.Location = new System.Drawing.Point(220, 26);
        lblTongTienMon.Name = "lblTongTienMon";
        lblTongTienMon.Size = new System.Drawing.Size(200, 22);
        lblTongTienMon.TabIndex = 1;
        lblTongTienMon.Text = "0 đ";
        lblTongTienMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblGiamGiaTitle
        // 
        lblGiamGiaTitle.AutoSize = true;
        lblGiamGiaTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblGiamGiaTitle.Location = new System.Drawing.Point(16, 62);
        lblGiamGiaTitle.Name = "lblGiamGiaTitle";
        lblGiamGiaTitle.Size = new System.Drawing.Size(89, 19);
        lblGiamGiaTitle.TabIndex = 2;
        lblGiamGiaTitle.Text = "Giảm giá (%):";
        // 
        // nudGiamGia
        // 
        nudGiamGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        nudGiamGia.Location = new System.Drawing.Point(115, 60);
        nudGiamGia.Name = "nudGiamGia";
        nudGiamGia.Size = new System.Drawing.Size(65, 25);
        nudGiamGia.TabIndex = 3;
        nudGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        nudGiamGia.ValueChanged += nudGiamGia_ValueChanged;
        // 
        // lblTienGiam
        // 
        lblTienGiam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        lblTienGiam.ForeColor = System.Drawing.Color.Firebrick;
        lblTienGiam.Location = new System.Drawing.Point(220, 60);
        lblTienGiam.Name = "lblTienGiam";
        lblTienGiam.Size = new System.Drawing.Size(200, 22);
        lblTienGiam.TabIndex = 4;
        lblTienGiam.Text = "- 0 đ";
        lblTienGiam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblDivider
        // 
        lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lblDivider.Location = new System.Drawing.Point(16, 96);
        lblDivider.Name = "lblDivider";
        lblDivider.Size = new System.Drawing.Size(404, 2);
        lblDivider.TabIndex = 5;
        // 
        // lblTongCanThuTitle
        // 
        lblTongCanThuTitle.AutoSize = true;
        lblTongCanThuTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongCanThuTitle.Location = new System.Drawing.Point(16, 120);
        lblTongCanThuTitle.Name = "lblTongCanThuTitle";
        lblTongCanThuTitle.Size = new System.Drawing.Size(125, 20);
        lblTongCanThuTitle.TabIndex = 6;
        lblTongCanThuTitle.Text = "TỔNG CẦN THU:";
        // 
        // lblTongCanThu
        // 
        lblTongCanThu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongCanThu.ForeColor = System.Drawing.Color.Firebrick;
        lblTongCanThu.Location = new System.Drawing.Point(160, 112);
        lblTongCanThu.Name = "lblTongCanThu";
        lblTongCanThu.Size = new System.Drawing.Size(260, 35);
        lblTongCanThu.TabIndex = 7;
        lblTongCanThu.Text = "0 đ";
        lblTongCanThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // gbPhuongThucTT
        // 
        gbPhuongThucTT.BackColor = System.Drawing.Color.White;
        gbPhuongThucTT.Controls.Add(radThe);
        gbPhuongThucTT.Controls.Add(radChuyenKhoan);
        gbPhuongThucTT.Controls.Add(radTienMat);
        gbPhuongThucTT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        gbPhuongThucTT.Location = new System.Drawing.Point(12, 195);
        gbPhuongThucTT.Name = "gbPhuongThucTT";
        gbPhuongThucTT.Size = new System.Drawing.Size(436, 68);
        gbPhuongThucTT.TabIndex = 1;
        gbPhuongThucTT.TabStop = false;
        gbPhuongThucTT.Text = "Hình thức thanh toán";
        // 
        // radTienMat
        // 
        radTienMat.AutoSize = true;
        radTienMat.Checked = true;
        radTienMat.Cursor = System.Windows.Forms.Cursors.Hand;
        radTienMat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        radTienMat.Location = new System.Drawing.Point(20, 28);
        radTienMat.Name = "radTienMat";
        radTienMat.Size = new System.Drawing.Size(76, 21);
        radTienMat.TabIndex = 0;
        radTienMat.TabStop = true;
        radTienMat.Text = "Tiền mặt";
        radTienMat.UseVisualStyleBackColor = true;
        radTienMat.CheckedChanged += radPaymentMethod_CheckedChanged;
        // 
        // radChuyenKhoan
        // 
        radChuyenKhoan.AutoSize = true;
        radChuyenKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
        radChuyenKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        radChuyenKhoan.Location = new System.Drawing.Point(140, 28);
        radChuyenKhoan.Name = "radChuyenKhoan";
        radChuyenKhoan.Size = new System.Drawing.Size(134, 21);
        radChuyenKhoan.TabIndex = 1;
        radChuyenKhoan.Text = "Chuyển khoản (QR)";
        radChuyenKhoan.UseVisualStyleBackColor = true;
        radChuyenKhoan.CheckedChanged += radPaymentMethod_CheckedChanged;
        // 
        // radThe
        // 
        radThe.AutoSize = true;
        radThe.Cursor = System.Windows.Forms.Cursors.Hand;
        radThe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        radThe.Location = new System.Drawing.Point(310, 28);
        radThe.Name = "radThe";
        radThe.Size = new System.Drawing.Size(107, 21);
        radThe.TabIndex = 2;
        radThe.Text = "Thẻ ngân hàng";
        radThe.UseVisualStyleBackColor = true;
        radThe.CheckedChanged += radPaymentMethod_CheckedChanged;
        // 
        // pnlTienMat
        // 
        pnlTienMat.BackColor = System.Drawing.Color.White;
        pnlTienMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlTienMat.Controls.Add(lblTienThoi);
        pnlTienMat.Controls.Add(lblTienThoiTitle);
        pnlTienMat.Controls.Add(btn500k);
        pnlTienMat.Controls.Add(btn200k);
        pnlTienMat.Controls.Add(btn100k);
        pnlTienMat.Controls.Add(btn50k);
        pnlTienMat.Controls.Add(btn20k);
        pnlTienMat.Controls.Add(btnTienDu);
        pnlTienMat.Controls.Add(lblGoiYMenhGia);
        pnlTienMat.Controls.Add(txtTienKhachDua);
        pnlTienMat.Controls.Add(lblTienKhachDuaTitle);
        pnlTienMat.Location = new System.Drawing.Point(12, 273);
        pnlTienMat.Name = "pnlTienMat";
        pnlTienMat.Size = new System.Drawing.Size(436, 245);
        pnlTienMat.TabIndex = 2;
        // 
        // lblTienKhachDuaTitle
        // 
        lblTienKhachDuaTitle.AutoSize = true;
        lblTienKhachDuaTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTienKhachDuaTitle.Location = new System.Drawing.Point(16, 15);
        lblTienKhachDuaTitle.Name = "lblTienKhachDuaTitle";
        lblTienKhachDuaTitle.Size = new System.Drawing.Size(107, 19);
        lblTienKhachDuaTitle.TabIndex = 0;
        lblTienKhachDuaTitle.Text = "Tiền khách đưa:";
        // 
        // txtTienKhachDua
        // 
        txtTienKhachDua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        txtTienKhachDua.Location = new System.Drawing.Point(145, 10);
        txtTienKhachDua.Name = "txtTienKhachDua";
        txtTienKhachDua.Size = new System.Drawing.Size(273, 29);
        txtTienKhachDua.TabIndex = 1;
        txtTienKhachDua.Text = "0";
        txtTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
        // 
        // lblGoiYMenhGia
        // 
        lblGoiYMenhGia.AutoSize = true;
        lblGoiYMenhGia.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
        lblGoiYMenhGia.ForeColor = System.Drawing.Color.DimGray;
        lblGoiYMenhGia.Location = new System.Drawing.Point(16, 52);
        lblGoiYMenhGia.Name = "lblGoiYMenhGia";
        lblGoiYMenhGia.Size = new System.Drawing.Size(147, 15);
        lblGoiYMenhGia.TabIndex = 2;
        lblGoiYMenhGia.Text = "Gợi ý chọn tiền mặt nhanh:";
        // 
        // btnTienDu
        // 
        btnTienDu.BackColor = System.Drawing.Color.FromArgb(230, 242, 250);
        btnTienDu.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTienDu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 130, 180);
        btnTienDu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTienDu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnTienDu.ForeColor = System.Drawing.Color.FromArgb(70, 130, 180);
        btnTienDu.Location = new System.Drawing.Point(16, 75);
        btnTienDu.Name = "btnTienDu";
        btnTienDu.Size = new System.Drawing.Size(94, 32);
        btnTienDu.TabIndex = 3;
        btnTienDu.Text = "Đúng tiền";
        btnTienDu.UseVisualStyleBackColor = false;
        btnTienDu.Click += btnTienDu_Click;
        // 
        // btn20k
        // 
        btn20k.BackColor = System.Drawing.Color.White;
        btn20k.Cursor = System.Windows.Forms.Cursors.Hand;
        btn20k.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
        btn20k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn20k.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        btn20k.Location = new System.Drawing.Point(120, 75);
        btn20k.Name = "btn20k";
        btn20k.Size = new System.Drawing.Size(94, 32);
        btn20k.TabIndex = 4;
        btn20k.Text = "20.000";
        btn20k.UseVisualStyleBackColor = false;
        btn20k.Click += btnMenhGia_Click;
        // 
        // btn50k
        // 
        btn50k.BackColor = System.Drawing.Color.White;
        btn50k.Cursor = System.Windows.Forms.Cursors.Hand;
        btn50k.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
        btn50k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn50k.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        btn50k.Location = new System.Drawing.Point(224, 75);
        btn50k.Name = "btn50k";
        btn50k.Size = new System.Drawing.Size(94, 32);
        btn50k.TabIndex = 5;
        btn50k.Text = "50.000";
        btn50k.UseVisualStyleBackColor = false;
        btn50k.Click += btnMenhGia_Click;
        // 
        // btn100k
        // 
        btn100k.BackColor = System.Drawing.Color.White;
        btn100k.Cursor = System.Windows.Forms.Cursors.Hand;
        btn100k.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
        btn100k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn100k.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        btn100k.Location = new System.Drawing.Point(328, 75);
        btn100k.Name = "btn100k";
        btn100k.Size = new System.Drawing.Size(90, 32);
        btn100k.TabIndex = 6;
        btn100k.Text = "100.000";
        btn100k.UseVisualStyleBackColor = false;
        btn100k.Click += btnMenhGia_Click;
        // 
        // btn200k
        // 
        btn200k.BackColor = System.Drawing.Color.White;
        btn200k.Cursor = System.Windows.Forms.Cursors.Hand;
        btn200k.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
        btn200k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn200k.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        btn200k.Location = new System.Drawing.Point(120, 115);
        btn200k.Name = "btn200k";
        btn200k.Size = new System.Drawing.Size(94, 32);
        btn200k.TabIndex = 7;
        btn200k.Text = "200.000";
        btn200k.UseVisualStyleBackColor = false;
        btn200k.Click += btnMenhGia_Click;
        // 
        // btn500k
        // 
        btn500k.BackColor = System.Drawing.Color.White;
        btn500k.Cursor = System.Windows.Forms.Cursors.Hand;
        btn500k.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
        btn500k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn500k.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        btn500k.Location = new System.Drawing.Point(224, 115);
        btn500k.Name = "btn500k";
        btn500k.Size = new System.Drawing.Size(94, 32);
        btn500k.TabIndex = 8;
        btn500k.Text = "500.000";
        btn500k.UseVisualStyleBackColor = false;
        btn500k.Click += btnMenhGia_Click;
        // 
        // lblTienThoiTitle
        // 
        lblTienThoiTitle.AutoSize = true;
        lblTienThoiTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTienThoiTitle.Location = new System.Drawing.Point(16, 190);
        lblTienThoiTitle.Name = "lblTienThoiTitle";
        lblTienThoiTitle.Size = new System.Drawing.Size(99, 20);
        lblTienThoiTitle.TabIndex = 9;
        lblTienThoiTitle.Text = "Tiền thối lại:";
        // 
        // lblTienThoi
        // 
        lblTienThoi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTienThoi.ForeColor = System.Drawing.Color.ForestGreen;
        lblTienThoi.Location = new System.Drawing.Point(145, 185);
        lblTienThoi.Name = "lblTienThoi";
        lblTienThoi.Size = new System.Drawing.Size(273, 30);
        lblTienThoi.TabIndex = 10;
        lblTienThoi.Text = "0 đ";
        lblTienThoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // pnlChuyenKhoan
        // 
        pnlChuyenKhoan.BackColor = System.Drawing.Color.White;
        pnlChuyenKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlChuyenKhoan.Controls.Add(lblHuongDanQR);
        pnlChuyenKhoan.Controls.Add(picQRCode);
        pnlChuyenKhoan.Location = new System.Drawing.Point(12, 273);
        pnlChuyenKhoan.Name = "pnlChuyenKhoan";
        pnlChuyenKhoan.Size = new System.Drawing.Size(436, 245);
        pnlChuyenKhoan.TabIndex = 3;
        pnlChuyenKhoan.Visible = false;
        // 
        // picQRCode
        // 
        picQRCode.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        picQRCode.Location = new System.Drawing.Point(140, 10);
        picQRCode.Name = "picQRCode";
        picQRCode.Size = new System.Drawing.Size(160, 160);
        picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picQRCode.TabIndex = 0;
        picQRCode.TabStop = false;
        // 
        // lblHuongDanQR
        // 
        lblHuongDanQR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
        lblHuongDanQR.ForeColor = System.Drawing.Color.DimGray;
        lblHuongDanQR.Location = new System.Drawing.Point(20, 180);
        lblHuongDanQR.Name = "lblHuongDanQR";
        lblHuongDanQR.Size = new System.Drawing.Size(396, 50);
        lblHuongDanQR.TabIndex = 1;
        lblHuongDanQR.Text = "Khách hàng quét mã VietQR qua ứng dụng ngân hàng hoặc ví điện tử để chuyển khoản chính xác số tiền.";
        lblHuongDanQR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // frmThanhToan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
        ClientSize = new System.Drawing.Size(940, 640);
        Controls.Add(panelBody);
        Controls.Add(panelFooter);
        Controls.Add(panelHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "frmThanhToan";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thanh Toán Hóa Đơn";
        Load += frmThanhToan_Load;
        panelHeader.ResumeLayout(false);
        panelFooter.ResumeLayout(false);
        panelFooter.PerformLayout();
        panelBody.ResumeLayout(false);
        panelLeft.ResumeLayout(false);
        panelLeft.PerformLayout();
        gbThongTinBan.ResumeLayout(false);
        gbThongTinBan.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
        panelRight.ResumeLayout(false);
        gbTinhTien.ResumeLayout(false);
        gbTinhTien.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiamGia).EndInit();
        gbPhuongThucTT.ResumeLayout(false);
        gbPhuongThucTT.PerformLayout();
        pnlTienMat.ResumeLayout(false);
        pnlTienMat.PerformLayout();
        pnlChuyenKhoan.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picQRCode).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblHeaderTitle;
    private System.Windows.Forms.Panel panelFooter;
    private System.Windows.Forms.CheckBox chkInHoaDon;
    private System.Windows.Forms.Button btnHuy;
    private System.Windows.Forms.Button btnInTamTinh;
    private System.Windows.Forms.Button btnThanhToan;
    private System.Windows.Forms.Panel panelBody;
    private System.Windows.Forms.Panel panelLeft;
    private System.Windows.Forms.GroupBox gbThongTinBan;
    private System.Windows.Forms.Label lblTenBan;
    private System.Windows.Forms.Label lblMaHoaDon;
    private System.Windows.Forms.Label lblGioVao;
    private System.Windows.Forms.Label lblThuNgan;
    private System.Windows.Forms.Label lblDanhSachMonTitle;
    private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    private System.Windows.Forms.Label lblTongSoMon;
    private System.Windows.Forms.Label lblGhiChuTitle;
    private System.Windows.Forms.TextBox txtGhiChu;
    private System.Windows.Forms.Panel panelRight;
    private System.Windows.Forms.GroupBox gbTinhTien;
    private System.Windows.Forms.Label lblTongTienMonTitle;
    private System.Windows.Forms.Label lblTongTienMon;
    private System.Windows.Forms.Label lblGiamGiaTitle;
    private System.Windows.Forms.NumericUpDown nudGiamGia;
    private System.Windows.Forms.Label lblTienGiam;
    private System.Windows.Forms.Label lblDivider;
    private System.Windows.Forms.Label lblTongCanThuTitle;
    private System.Windows.Forms.Label lblTongCanThu;
    private System.Windows.Forms.GroupBox gbPhuongThucTT;
    private System.Windows.Forms.RadioButton radTienMat;
    private System.Windows.Forms.RadioButton radChuyenKhoan;
    private System.Windows.Forms.RadioButton radThe;
    private System.Windows.Forms.Panel pnlTienMat;
    private System.Windows.Forms.Label lblTienKhachDuaTitle;
    private System.Windows.Forms.TextBox txtTienKhachDua;
    private System.Windows.Forms.Label lblGoiYMenhGia;
    private System.Windows.Forms.Button btnTienDu;
    private System.Windows.Forms.Button btn20k;
    private System.Windows.Forms.Button btn50k;
    private System.Windows.Forms.Button btn100k;
    private System.Windows.Forms.Button btn200k;
    private System.Windows.Forms.Button btn500k;
    private System.Windows.Forms.Label lblTienThoiTitle;
    private System.Windows.Forms.Label lblTienThoi;
    private System.Windows.Forms.Panel pnlChuyenKhoan;
    private System.Windows.Forms.PictureBox picQRCode;
    private System.Windows.Forms.Label lblHuongDanQR;
}

