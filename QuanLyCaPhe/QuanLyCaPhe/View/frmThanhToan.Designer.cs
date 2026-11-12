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
        lblTieuDe = new System.Windows.Forms.Label();
        gbDanhSachMon = new System.Windows.Forms.GroupBox();
        txtGhiChu = new System.Windows.Forms.TextBox();
        lblGhiChuTitle = new System.Windows.Forms.Label();
        lblTongSoMon = new System.Windows.Forms.Label();
        dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
        colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        lblGioVao = new System.Windows.Forms.Label();
        lblGioVaoTitle = new System.Windows.Forms.Label();
        lblThuNgan = new System.Windows.Forms.Label();
        lblThuNganTitle = new System.Windows.Forms.Label();
        lblMaHoaDon = new System.Windows.Forms.Label();
        lblMaHoaDonTitle = new System.Windows.Forms.Label();
        lblTenBan = new System.Windows.Forms.Label();
        lblTenBanTitle = new System.Windows.Forms.Label();
        gbThanhToan = new System.Windows.Forms.GroupBox();
        lblHinhThucTitle = new System.Windows.Forms.Label();
        tabHinhThuc = new System.Windows.Forms.TabControl();
        tabTienMat = new System.Windows.Forms.TabPage();
        lblTienThoi = new System.Windows.Forms.Label();
        lblTienThoiTitle = new System.Windows.Forms.Label();
        txtTienKhachDua = new System.Windows.Forms.TextBox();
        lblTienKhachDuaTitle = new System.Windows.Forms.Label();
        tabChuyenKhoan = new System.Windows.Forms.TabPage();
        lblHuongDanQR = new System.Windows.Forms.Label();
        lblSoTienQR = new System.Windows.Forms.Label();
        picQRCode = new System.Windows.Forms.PictureBox();
        lblTongCanThu = new System.Windows.Forms.Label();
        lblTongCanThuTitle = new System.Windows.Forms.Label();
        lblDivider = new System.Windows.Forms.Label();
        lblTienGiam = new System.Windows.Forms.Label();
        nudGiamGia = new System.Windows.Forms.NumericUpDown();
        lblGiamGiaTitle = new System.Windows.Forms.Label();
        lblTongTienMon = new System.Windows.Forms.Label();
        lblTongTienMonTitle = new System.Windows.Forms.Label();
        chkInHoaDon = new System.Windows.Forms.CheckBox();
        btnThanhToan = new System.Windows.Forms.Button();
        btnInTamTinh = new System.Windows.Forms.Button();
        btnHuy = new System.Windows.Forms.Button();
        gbDanhSachMon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
        gbThanhToan.SuspendLayout();
        tabHinhThuc.SuspendLayout();
        tabTienMat.SuspendLayout();
        tabChuyenKhoan.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picQRCode).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGia).BeginInit();
        SuspendLayout();
        // 
        // lblTieuDe
        // 
        lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTieuDe.ForeColor = System.Drawing.Color.Black;
        lblTieuDe.Location = new System.Drawing.Point(0, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(884, 45);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "THANH TOÁN HÓA ĐƠN";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // gbDanhSachMon
        // 
        gbDanhSachMon.Controls.Add(txtGhiChu);
        gbDanhSachMon.Controls.Add(lblGhiChuTitle);
        gbDanhSachMon.Controls.Add(lblTongSoMon);
        gbDanhSachMon.Controls.Add(dgvChiTietHoaDon);
        gbDanhSachMon.Controls.Add(lblGioVao);
        gbDanhSachMon.Controls.Add(lblGioVaoTitle);
        gbDanhSachMon.Controls.Add(lblThuNgan);
        gbDanhSachMon.Controls.Add(lblThuNganTitle);
        gbDanhSachMon.Controls.Add(lblMaHoaDon);
        gbDanhSachMon.Controls.Add(lblMaHoaDonTitle);
        gbDanhSachMon.Controls.Add(lblTenBan);
        gbDanhSachMon.Controls.Add(lblTenBanTitle);
        gbDanhSachMon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        gbDanhSachMon.Location = new System.Drawing.Point(12, 48);
        gbDanhSachMon.Name = "gbDanhSachMon";
        gbDanhSachMon.Size = new System.Drawing.Size(465, 465);
        gbDanhSachMon.TabIndex = 1;
        gbDanhSachMon.TabStop = false;
        gbDanhSachMon.Text = "Thông tin đơn hàng";
        // 
        // txtGhiChu
        // 
        txtGhiChu.Location = new System.Drawing.Point(72, 377);
        txtGhiChu.Multiline = true;
        txtGhiChu.Name = "txtGhiChu";
        txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtGhiChu.Size = new System.Drawing.Size(378, 75);
        txtGhiChu.TabIndex = 11;
        // 
        // lblGhiChuTitle
        // 
        lblGhiChuTitle.AutoSize = true;
        lblGhiChuTitle.Location = new System.Drawing.Point(15, 380);
        lblGhiChuTitle.Name = "lblGhiChuTitle";
        lblGhiChuTitle.Size = new System.Drawing.Size(51, 15);
        lblGhiChuTitle.TabIndex = 10;
        lblGhiChuTitle.Text = "Ghi chú:";
        // 
        // lblTongSoMon
        // 
        lblTongSoMon.AutoSize = true;
        lblTongSoMon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
        lblTongSoMon.ForeColor = System.Drawing.Color.DimGray;
        lblTongSoMon.Location = new System.Drawing.Point(15, 355);
        lblTongSoMon.Name = "lblTongSoMon";
        lblTongSoMon.Size = new System.Drawing.Size(124, 15);
        lblTongSoMon.TabIndex = 9;
        lblTongSoMon.Text = "Tổng số lượng món: 0";
        // 
        // dgvChiTietHoaDon
        // 
        dgvChiTietHoaDon.AllowUserToAddRows = false;
        dgvChiTietHoaDon.AllowUserToDeleteRows = false;
        dgvChiTietHoaDon.AllowUserToResizeRows = false;
        dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvChiTietHoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
        dgvChiTietHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        dgvChiTietHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
        dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colSTT, colTenMon, colSoLuong, colDonGia, colThanhTien });
        dgvChiTietHoaDon.EnableHeadersVisualStyles = true;
        dgvChiTietHoaDon.Location = new System.Drawing.Point(15, 72);
        dgvChiTietHoaDon.MultiSelect = false;
        dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
        dgvChiTietHoaDon.ReadOnly = true;
        dgvChiTietHoaDon.RowHeadersVisible = false;
        dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvChiTietHoaDon.Size = new System.Drawing.Size(435, 275);
        dgvChiTietHoaDon.TabIndex = 8;
        // 
        // colSTT
        // 
        colSTT.FillWeight = 35F;
        colSTT.HeaderText = "STT";
        colSTT.Name = "colSTT";
        colSTT.ReadOnly = true;
        // 
        // colTenMon
        // 
        colTenMon.FillWeight = 145F;
        colTenMon.HeaderText = "Tên món";
        colTenMon.Name = "colTenMon";
        colTenMon.ReadOnly = true;
        // 
        // colSoLuong
        // 
        colSoLuong.FillWeight = 40F;
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
        // lblGioVao
        // 
        lblGioVao.AutoSize = true;
        lblGioVao.Location = new System.Drawing.Point(299, 46);
        lblGioVao.Name = "lblGioVao";
        lblGioVao.Size = new System.Drawing.Size(34, 15);
        lblGioVao.TabIndex = 7;
        lblGioVao.Text = "14:30";
        // 
        // lblGioVaoTitle
        // 
        lblGioVaoTitle.AutoSize = true;
        lblGioVaoTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblGioVaoTitle.Location = new System.Drawing.Point(240, 46);
        lblGioVaoTitle.Name = "lblGioVaoTitle";
        lblGioVaoTitle.Size = new System.Drawing.Size(53, 15);
        lblGioVaoTitle.TabIndex = 6;
        lblGioVaoTitle.Text = "Giờ vào:";
        // 
        // lblThuNgan
        // 
        lblThuNgan.AutoSize = true;
        lblThuNgan.Location = new System.Drawing.Point(84, 46);
        lblThuNgan.Name = "lblThuNgan";
        lblThuNgan.Size = new System.Drawing.Size(43, 15);
        lblThuNgan.TabIndex = 5;
        lblThuNgan.Text = "Admin";
        // 
        // lblThuNganTitle
        // 
        lblThuNganTitle.AutoSize = true;
        lblThuNganTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblThuNganTitle.Location = new System.Drawing.Point(15, 46);
        lblThuNganTitle.Name = "lblThuNganTitle";
        lblThuNganTitle.Size = new System.Drawing.Size(63, 15);
        lblThuNganTitle.TabIndex = 4;
        lblThuNganTitle.Text = "Thu ngân:";
        // 
        // lblMaHoaDon
        // 
        lblMaHoaDon.AutoSize = true;
        lblMaHoaDon.Location = new System.Drawing.Point(294, 22);
        lblMaHoaDon.Name = "lblMaHoaDon";
        lblMaHoaDon.Size = new System.Drawing.Size(59, 15);
        lblMaHoaDon.TabIndex = 3;
        lblMaHoaDon.Text = "HD-00012";
        // 
        // lblMaHoaDonTitle
        // 
        lblMaHoaDonTitle.AutoSize = true;
        lblMaHoaDonTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblMaHoaDonTitle.Location = new System.Drawing.Point(240, 22);
        lblMaHoaDonTitle.Name = "lblMaHoaDonTitle";
        lblMaHoaDonTitle.Size = new System.Drawing.Size(48, 15);
        lblMaHoaDonTitle.TabIndex = 2;
        lblMaHoaDonTitle.Text = "Số HĐ:";
        // 
        // lblTenBan
        // 
        lblTenBan.AutoSize = true;
        lblTenBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTenBan.ForeColor = System.Drawing.Color.Navy;
        lblTenBan.Location = new System.Drawing.Point(52, 22);
        lblTenBan.Name = "lblTenBan";
        lblTenBan.Size = new System.Drawing.Size(73, 15);
        lblTenBan.TabIndex = 1;
        lblTenBan.Text = "BÀN 01 (T1)";
        // 
        // lblTenBanTitle
        // 
        lblTenBanTitle.AutoSize = true;
        lblTenBanTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTenBanTitle.Location = new System.Drawing.Point(15, 22);
        lblTenBanTitle.Name = "lblTenBanTitle";
        lblTenBanTitle.Size = new System.Drawing.Size(31, 15);
        lblTenBanTitle.TabIndex = 0;
        lblTenBanTitle.Text = "Bàn:";
        // 
        // gbThanhToan
        // 
        gbThanhToan.Controls.Add(lblHinhThucTitle);
        gbThanhToan.Controls.Add(tabHinhThuc);
        gbThanhToan.Controls.Add(lblTongCanThu);
        gbThanhToan.Controls.Add(lblTongCanThuTitle);
        gbThanhToan.Controls.Add(lblDivider);
        gbThanhToan.Controls.Add(lblTienGiam);
        gbThanhToan.Controls.Add(nudGiamGia);
        gbThanhToan.Controls.Add(lblGiamGiaTitle);
        gbThanhToan.Controls.Add(lblTongTienMon);
        gbThanhToan.Controls.Add(lblTongTienMonTitle);
        gbThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        gbThanhToan.Location = new System.Drawing.Point(487, 48);
        gbThanhToan.Name = "gbThanhToan";
        gbThanhToan.Size = new System.Drawing.Size(385, 465);
        gbThanhToan.TabIndex = 2;
        gbThanhToan.TabStop = false;
        gbThanhToan.Text = "Chi tiết thanh toán";
        // 
        // lblHinhThucTitle
        // 
        lblHinhThucTitle.AutoSize = true;
        lblHinhThucTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblHinhThucTitle.Location = new System.Drawing.Point(18, 150);
        lblHinhThucTitle.Name = "lblHinhThucTitle";
        lblHinhThucTitle.Size = new System.Drawing.Size(147, 17);
        lblHinhThucTitle.TabIndex = 8;
        lblHinhThucTitle.Text = "Hình thức thanh toán:";
        // 
        // tabHinhThuc
        // 
        tabHinhThuc.Controls.Add(tabTienMat);
        tabHinhThuc.Controls.Add(tabChuyenKhoan);
        tabHinhThuc.Location = new System.Drawing.Point(18, 172);
        tabHinhThuc.Name = "tabHinhThuc";
        tabHinhThuc.SelectedIndex = 0;
        tabHinhThuc.Size = new System.Drawing.Size(350, 283);
        tabHinhThuc.TabIndex = 9;
        tabHinhThuc.SelectedIndexChanged += tabHinhThuc_SelectedIndexChanged;
        // 
        // tabTienMat
        // 
        tabTienMat.BackColor = System.Drawing.SystemColors.Control;
        tabTienMat.Controls.Add(lblTienThoi);
        tabTienMat.Controls.Add(lblTienThoiTitle);
        tabTienMat.Controls.Add(txtTienKhachDua);
        tabTienMat.Controls.Add(lblTienKhachDuaTitle);
        tabTienMat.Location = new System.Drawing.Point(4, 24);
        tabTienMat.Name = "tabTienMat";
        tabTienMat.Padding = new System.Windows.Forms.Padding(3);
        tabTienMat.Size = new System.Drawing.Size(342, 277);
        tabTienMat.TabIndex = 0;
        tabTienMat.Text = "Tiền mặt";
        // 
        // lblTienThoi
        // 
        lblTienThoi.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTienThoi.ForeColor = System.Drawing.Color.ForestGreen;
        lblTienThoi.Location = new System.Drawing.Point(115, 75);
        lblTienThoi.Name = "lblTienThoi";
        lblTienThoi.Size = new System.Drawing.Size(205, 28);
        lblTienThoi.TabIndex = 3;
        lblTienThoi.Text = "0 đ";
        lblTienThoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTienThoiTitle
        // 
        lblTienThoiTitle.AutoSize = true;
        lblTienThoiTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTienThoiTitle.Location = new System.Drawing.Point(20, 80);
        lblTienThoiTitle.Name = "lblTienThoiTitle";
        lblTienThoiTitle.Size = new System.Drawing.Size(79, 17);
        lblTienThoiTitle.TabIndex = 2;
        lblTienThoiTitle.Text = "Tiền trả lại:";
        // 
        // txtTienKhachDua
        // 
        txtTienKhachDua.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        txtTienKhachDua.Location = new System.Drawing.Point(125, 30);
        txtTienKhachDua.Name = "txtTienKhachDua";
        txtTienKhachDua.Size = new System.Drawing.Size(195, 26);
        txtTienKhachDua.TabIndex = 1;
        txtTienKhachDua.Text = "0";
        txtTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
        // 
        // lblTienKhachDuaTitle
        // 
        lblTienKhachDuaTitle.AutoSize = true;
        lblTienKhachDuaTitle.Location = new System.Drawing.Point(20, 35);
        lblTienKhachDuaTitle.Name = "lblTienKhachDuaTitle";
        lblTienKhachDuaTitle.Size = new System.Drawing.Size(91, 15);
        lblTienKhachDuaTitle.TabIndex = 0;
        lblTienKhachDuaTitle.Text = "Tiền khách đưa:";
        // 
        // tabChuyenKhoan
        // 
        tabChuyenKhoan.BackColor = System.Drawing.SystemColors.Control;
        tabChuyenKhoan.Controls.Add(lblHuongDanQR);
        tabChuyenKhoan.Controls.Add(lblSoTienQR);
        tabChuyenKhoan.Controls.Add(picQRCode);
        tabChuyenKhoan.Location = new System.Drawing.Point(4, 24);
        tabChuyenKhoan.Name = "tabChuyenKhoan";
        tabChuyenKhoan.Padding = new System.Windows.Forms.Padding(3);
        tabChuyenKhoan.Size = new System.Drawing.Size(342, 255);
        tabChuyenKhoan.TabIndex = 1;
        tabChuyenKhoan.Text = "Chuyển khoản (QR)";
        // 
        // lblHuongDanQR
        // 
        lblHuongDanQR.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
        lblHuongDanQR.ForeColor = System.Drawing.Color.DimGray;
        lblHuongDanQR.Location = new System.Drawing.Point(10, 166);
        lblHuongDanQR.Name = "lblHuongDanQR";
        lblHuongDanQR.Size = new System.Drawing.Size(320, 80);
        lblHuongDanQR.TabIndex = 2;
        lblHuongDanQR.Text = "Khách hàng mở ứng dụng Ngân hàng (Vietcombank, MB, Techcombank...) hoặc Ví điện tử (Momo, ZaloPay) để quét mã VietQR chuyển khoản chính xác số tiền.";
        lblHuongDanQR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblSoTienQR
        // 
        lblSoTienQR.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblSoTienQR.ForeColor = System.Drawing.Color.Red;
        lblSoTienQR.Location = new System.Drawing.Point(10, 142);
        lblSoTienQR.Name = "lblSoTienQR";
        lblSoTienQR.Size = new System.Drawing.Size(320, 22);
        lblSoTienQR.TabIndex = 1;
        lblSoTienQR.Text = "Số tiền cần chuyển: 0 đ";
        lblSoTienQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // picQRCode
        // 
        picQRCode.BackColor = System.Drawing.Color.White;
        picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        picQRCode.Location = new System.Drawing.Point(106, 8);
        picQRCode.Name = "picQRCode";
        picQRCode.Size = new System.Drawing.Size(130, 130);
        picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picQRCode.TabIndex = 0;
        picQRCode.TabStop = false;
        // 
        // lblTongCanThu
        // 
        lblTongCanThu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongCanThu.ForeColor = System.Drawing.Color.Red;
        lblTongCanThu.Location = new System.Drawing.Point(145, 112);
        lblTongCanThu.Name = "lblTongCanThu";
        lblTongCanThu.Size = new System.Drawing.Size(220, 30);
        lblTongCanThu.TabIndex = 7;
        lblTongCanThu.Text = "0 đ";
        lblTongCanThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTongCanThuTitle
        // 
        lblTongCanThuTitle.AutoSize = true;
        lblTongCanThuTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongCanThuTitle.Location = new System.Drawing.Point(18, 118);
        lblTongCanThuTitle.Name = "lblTongCanThuTitle";
        lblTongCanThuTitle.Size = new System.Drawing.Size(120, 19);
        lblTongCanThuTitle.TabIndex = 6;
        lblTongCanThuTitle.Text = "TỔNG CẦN THU:";
        // 
        // lblDivider
        // 
        lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        lblDivider.Location = new System.Drawing.Point(18, 98);
        lblDivider.Name = "lblDivider";
        lblDivider.Size = new System.Drawing.Size(347, 2);
        lblDivider.TabIndex = 5;
        // 
        // lblTienGiam
        // 
        lblTienGiam.ForeColor = System.Drawing.Color.DarkRed;
        lblTienGiam.Location = new System.Drawing.Point(195, 63);
        lblTienGiam.Name = "lblTienGiam";
        lblTienGiam.Size = new System.Drawing.Size(170, 20);
        lblTienGiam.TabIndex = 4;
        lblTienGiam.Text = "- 0 đ";
        lblTienGiam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // nudGiamGia
        // 
        nudGiamGia.Location = new System.Drawing.Point(105, 62);
        nudGiamGia.Name = "nudGiamGia";
        nudGiamGia.Size = new System.Drawing.Size(65, 23);
        nudGiamGia.TabIndex = 3;
        nudGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        nudGiamGia.ValueChanged += nudGiamGia_ValueChanged;
        // 
        // lblGiamGiaTitle
        // 
        lblGiamGiaTitle.AutoSize = true;
        lblGiamGiaTitle.Location = new System.Drawing.Point(18, 65);
        lblGiamGiaTitle.Name = "lblGiamGiaTitle";
        lblGiamGiaTitle.Size = new System.Drawing.Size(78, 15);
        lblGiamGiaTitle.TabIndex = 2;
        lblGiamGiaTitle.Text = "Giảm giá (%):";
        // 
        // lblTongTienMon
        // 
        lblTongTienMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTongTienMon.Location = new System.Drawing.Point(195, 27);
        lblTongTienMon.Name = "lblTongTienMon";
        lblTongTienMon.Size = new System.Drawing.Size(170, 20);
        lblTongTienMon.TabIndex = 1;
        lblTongTienMon.Text = "0 đ";
        lblTongTienMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTongTienMonTitle
        // 
        lblTongTienMonTitle.AutoSize = true;
        lblTongTienMonTitle.Location = new System.Drawing.Point(18, 30);
        lblTongTienMonTitle.Name = "lblTongTienMonTitle";
        lblTongTienMonTitle.Size = new System.Drawing.Size(117, 15);
        lblTongTienMonTitle.TabIndex = 0;
        lblTongTienMonTitle.Text = "Tiền món (tạm tính):";
        // 
        // chkInHoaDon
        // 
        chkInHoaDon.AutoSize = true;
        chkInHoaDon.Checked = true;
        chkInHoaDon.CheckState = System.Windows.Forms.CheckState.Checked;
        chkInHoaDon.Location = new System.Drawing.Point(22, 532);
        chkInHoaDon.Name = "chkInHoaDon";
        chkInHoaDon.Size = new System.Drawing.Size(109, 19);
        chkInHoaDon.TabIndex = 3;
        chkInHoaDon.Text = "In kèm hóa đơn";
        chkInHoaDon.UseVisualStyleBackColor = true;
        // 
        // btnThanhToan
        // 
        btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnThanhToan.Location = new System.Drawing.Point(525, 524);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new System.Drawing.Size(110, 35);
        btnThanhToan.TabIndex = 4;
        btnThanhToan.Text = "Thanh toán";
        btnThanhToan.UseVisualStyleBackColor = true;
        btnThanhToan.Click += btnThanhToan_Click;
        // 
        // btnInTamTinh
        // 
        btnInTamTinh.Location = new System.Drawing.Point(645, 524);
        btnInTamTinh.Name = "btnInTamTinh";
        btnInTamTinh.Size = new System.Drawing.Size(110, 35);
        btnInTamTinh.TabIndex = 5;
        btnInTamTinh.Text = "In tạm tính";
        btnInTamTinh.UseVisualStyleBackColor = true;
        btnInTamTinh.Click += btnInTamTinh_Click;
        // 
        // btnHuy
        // 
        btnHuy.Location = new System.Drawing.Point(765, 524);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new System.Drawing.Size(105, 35);
        btnHuy.TabIndex = 6;
        btnHuy.Text = "Đóng";
        btnHuy.UseVisualStyleBackColor = true;
        btnHuy.Click += btnHuy_Click;
        // 
        // frmThanhToan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(884, 571);
        Controls.Add(btnHuy);
        Controls.Add(btnInTamTinh);
        Controls.Add(btnThanhToan);
        Controls.Add(chkInHoaDon);
        Controls.Add(gbThanhToan);
        Controls.Add(gbDanhSachMon);
        Controls.Add(lblTieuDe);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "frmThanhToan";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Thanh toán hóa đơn";
        Load += frmThanhToan_Load;
        gbDanhSachMon.ResumeLayout(false);
        gbDanhSachMon.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
        gbThanhToan.ResumeLayout(false);
        gbThanhToan.PerformLayout();
        tabHinhThuc.ResumeLayout(false);
        tabTienMat.ResumeLayout(false);
        tabTienMat.PerformLayout();
        tabChuyenKhoan.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picQRCode).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGia).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox gbDanhSachMon;
    private System.Windows.Forms.Label lblTenBanTitle;
    private System.Windows.Forms.Label lblTenBan;
    private System.Windows.Forms.Label lblMaHoaDonTitle;
    private System.Windows.Forms.Label lblMaHoaDon;
    private System.Windows.Forms.Label lblThuNganTitle;
    private System.Windows.Forms.Label lblThuNgan;
    private System.Windows.Forms.Label lblGioVaoTitle;
    private System.Windows.Forms.Label lblGioVao;
    private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    private System.Windows.Forms.Label lblTongSoMon;
    private System.Windows.Forms.Label lblGhiChuTitle;
    private System.Windows.Forms.TextBox txtGhiChu;
    private System.Windows.Forms.GroupBox gbThanhToan;
    private System.Windows.Forms.Label lblTongTienMonTitle;
    private System.Windows.Forms.Label lblTongTienMon;
    private System.Windows.Forms.Label lblGiamGiaTitle;
    private System.Windows.Forms.NumericUpDown nudGiamGia;
    private System.Windows.Forms.Label lblTienGiam;
    private System.Windows.Forms.Label lblDivider;
    private System.Windows.Forms.Label lblTongCanThuTitle;
    private System.Windows.Forms.Label lblTongCanThu;
    private System.Windows.Forms.Label lblHinhThucTitle;
    private System.Windows.Forms.TabControl tabHinhThuc;
    private System.Windows.Forms.TabPage tabTienMat;
    private System.Windows.Forms.Label lblTienKhachDuaTitle;
    private System.Windows.Forms.TextBox txtTienKhachDua;
    private System.Windows.Forms.Label lblTienThoiTitle;
    private System.Windows.Forms.Label lblTienThoi;
    private System.Windows.Forms.TabPage tabChuyenKhoan;
    private System.Windows.Forms.PictureBox picQRCode;
    private System.Windows.Forms.Label lblSoTienQR;
    private System.Windows.Forms.Label lblHuongDanQR;
    private System.Windows.Forms.CheckBox chkInHoaDon;
    private System.Windows.Forms.Button btnThanhToan;
    private System.Windows.Forms.Button btnInTamTinh;
    private System.Windows.Forms.Button btnHuy;
}
