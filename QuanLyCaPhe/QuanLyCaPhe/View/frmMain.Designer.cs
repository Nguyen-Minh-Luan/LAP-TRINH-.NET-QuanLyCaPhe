using System.ComponentModel;

namespace QuanLyCaPhe.View;

partial class frmMain
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
        menuStripHome = new System.Windows.Forms.MenuStrip();
        MenuStripPhucVu = new System.Windows.Forms.ToolStripMenuItem();
        mnuSoDoBan = new System.Windows.Forms.ToolStripMenuItem();
        mnuLichSuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
        mnuLichSuChuyenBan = new System.Windows.Forms.ToolStripMenuItem();
        MenuStripThucDon = new System.Windows.Forms.ToolStripMenuItem();
        mnuQLMonAn = new System.Windows.Forms.ToolStripMenuItem();
        mnuQLDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
        mnuQLKhuVuc = new System.Windows.Forms.ToolStripMenuItem();
        MenuStripCaLam = new System.Windows.Forms.ToolStripMenuItem();
        mnuPCCaLam = new System.Windows.Forms.ToolStripMenuItem();
        MenuStripThongKe = new System.Windows.Forms.ToolStripMenuItem();
        mnuTKDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
        mnuMonBanChay = new System.Windows.Forms.ToolStripMenuItem();
        MenuStripTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
        mnuTTCaNhan = new System.Windows.Forms.ToolStripMenuItem();
        mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        label6 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        lblThoiGianTruc = new System.Windows.Forms.Label();
        label11 = new System.Windows.Forms.Label();
        lblTenCa = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        lblVaiTro = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        lblTenNV = new System.Windows.Forms.Label();
        lblMaNV = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        panel5 = new System.Windows.Forms.Panel();
        btnTKDoanhThu = new System.Windows.Forms.Button();
        btnLichSuHD = new System.Windows.Forms.Button();
        btnLSChuyenBan = new System.Windows.Forms.Button();
        btnSoDoBan = new System.Windows.Forms.Button();
        label12 = new System.Windows.Forms.Label();
        panel4 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        menuStripHome.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripHome
        // 
        menuStripHome.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuStripPhucVu, MenuStripThucDon, MenuStripCaLam, MenuStripThongKe, MenuStripTaiKhoan });
        menuStripHome.Location = new System.Drawing.Point(0, 0);
        menuStripHome.Name = "menuStripHome";
        menuStripHome.Size = new System.Drawing.Size(1148, 33);
        menuStripHome.TabIndex = 0;
        menuStripHome.Text = "menuStrip1";
        // 
        // MenuStripPhucVu
        // 
        MenuStripPhucVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuSoDoBan, mnuLichSuHoaDon, mnuLichSuChuyenBan });
        MenuStripPhucVu.Name = "MenuStripPhucVu";
        MenuStripPhucVu.Size = new System.Drawing.Size(90, 29);
        MenuStripPhucVu.Text = "Phục vụ";
        // 
        // mnuSoDoBan
        // 
        mnuSoDoBan.Name = "mnuSoDoBan";
        mnuSoDoBan.Size = new System.Drawing.Size(264, 34);
        mnuSoDoBan.Text = "Sơ đồ bàn";
        mnuSoDoBan.Click += mnuSoDoBan_Click;
        // 
        // mnuLichSuHoaDon
        // 
        mnuLichSuHoaDon.Name = "mnuLichSuHoaDon";
        mnuLichSuHoaDon.Size = new System.Drawing.Size(264, 34);
        mnuLichSuHoaDon.Text = "Lịch sử hóa đơn";
        mnuLichSuHoaDon.Click += mnuLichSuHD_Click;
        // 
        // mnuLichSuChuyenBan
        // 
        mnuLichSuChuyenBan.Name = "mnuLichSuChuyenBan";
        mnuLichSuChuyenBan.Size = new System.Drawing.Size(264, 34);
        mnuLichSuChuyenBan.Text = "Lịch sử chuyển bàn";
        mnuLichSuChuyenBan.Click += mnuLichSuCB_Click;
        // 
        // MenuStripThucDon
        // 
        MenuStripThucDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuQLMonAn, mnuQLDanhMuc, mnuQLKhuVuc });
        MenuStripThucDon.Name = "MenuStripThucDon";
        MenuStripThucDon.Size = new System.Drawing.Size(103, 29);
        MenuStripThucDon.Text = "Thực đơn";
        // 
        // mnuQLMonAn
        // 
        mnuQLMonAn.Name = "mnuQLMonAn";
        mnuQLMonAn.Size = new System.Drawing.Size(300, 34);
        mnuQLMonAn.Text = "Quản lý món ăn";
        mnuQLMonAn.Click += mnuQLMA_Click;
        // 
        // mnuQLDanhMuc
        // 
        mnuQLDanhMuc.Name = "mnuQLDanhMuc";
        mnuQLDanhMuc.Size = new System.Drawing.Size(300, 34);
        mnuQLDanhMuc.Text = "Quản lý danh mục";
        mnuQLDanhMuc.Click += mnuQLDM_Click;
        // 
        // mnuQLKhuVuc
        // 
        mnuQLKhuVuc.Name = "mnuQLKhuVuc";
        mnuQLKhuVuc.Size = new System.Drawing.Size(300, 34);
        mnuQLKhuVuc.Text = "Quản lý khu vực và bàn";
        mnuQLKhuVuc.Click += mnuQLKhuVuc_Click;
        // 
        // MenuStripCaLam
        // 
        MenuStripCaLam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuPCCaLam });
        MenuStripCaLam.Name = "MenuStripCaLam";
        MenuStripCaLam.Size = new System.Drawing.Size(82, 29);
        MenuStripCaLam.Text = "Ca làm";
        // 
        // mnuPCCaLam
        // 
        mnuPCCaLam.Name = "mnuPCCaLam";
        mnuPCCaLam.Size = new System.Drawing.Size(254, 34);
        mnuPCCaLam.Text = "Phân công ca làm";
        mnuPCCaLam.Click += mnuPCCaLam_Click;
        // 
        // MenuStripThongKe
        // 
        MenuStripThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuTKDoanhThu, mnuMonBanChay });
        MenuStripThongKe.Name = "MenuStripThongKe";
        MenuStripThongKe.Size = new System.Drawing.Size(102, 29);
        MenuStripThongKe.Text = "Thống kê";
        // 
        // mnuTKDoanhThu
        // 
        mnuTKDoanhThu.Name = "mnuTKDoanhThu";
        mnuTKDoanhThu.Size = new System.Drawing.Size(275, 34);
        mnuTKDoanhThu.Text = "Thống kê doanh thu";
        mnuTKDoanhThu.Click += mnuTKDoanhThu_Click;
        // 
        // mnuMonBanChay
        // 
        mnuMonBanChay.Name = "mnuMonBanChay";
        mnuMonBanChay.Size = new System.Drawing.Size(275, 34);
        mnuMonBanChay.Text = "Món bán chạy";
        mnuMonBanChay.Click += mnuMonBanChay_Click;
        // 
        // MenuStripTaiKhoan
        // 
        MenuStripTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuTTCaNhan, mnuDangXuat });
        MenuStripTaiKhoan.Name = "MenuStripTaiKhoan";
        MenuStripTaiKhoan.Size = new System.Drawing.Size(102, 29);
        MenuStripTaiKhoan.Text = "Tài khoản";
        // 
        // mnuTTCaNhan
        // 
        mnuTTCaNhan.Name = "mnuTTCaNhan";
        mnuTTCaNhan.Size = new System.Drawing.Size(270, 34);
        mnuTTCaNhan.Text = "Thông tin cá nhân";
        mnuTTCaNhan.Click += mnuTTCaNhan_Click;
        // 
        // mnuDangXuat
        // 
        mnuDangXuat.Name = "mnuDangXuat";
        mnuDangXuat.Size = new System.Drawing.Size(270, 34);
        mnuDangXuat.Text = "Đăng xuất";
        mnuDangXuat.Click += mnuDangXuat_Click;
        // 
        // panel1
        // 
        panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)245)), ((int)((byte)240)));
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(panel2);
        panel1.Location = new System.Drawing.Point(12, 48);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(484, 494);
        panel1.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
        tableLayoutPanel1.Controls.Add(label6, 0, 1);
        tableLayoutPanel1.Controls.Add(label4, 0, 0);
        tableLayoutPanel1.Controls.Add(lblThoiGianTruc, 1, 4);
        tableLayoutPanel1.Controls.Add(label11, 0, 4);
        tableLayoutPanel1.Controls.Add(lblTenCa, 1, 3);
        tableLayoutPanel1.Controls.Add(label7, 0, 2);
        tableLayoutPanel1.Controls.Add(lblVaiTro, 1, 2);
        tableLayoutPanel1.Controls.Add(label9, 0, 3);
        tableLayoutPanel1.Controls.Add(lblTenNV, 1, 1);
        tableLayoutPanel1.Controls.Add(lblMaNV, 1, 0);
        tableLayoutPanel1.Location = new System.Drawing.Point(24, 170);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.Size = new System.Drawing.Size(436, 260);
        tableLayoutPanel1.TabIndex = 14;
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(3, 52);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(185, 52);
        label6.TabIndex = 5;
        label6.Text = "Họ tên:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(3, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(185, 52);
        label4.TabIndex = 3;
        label4.Text = "Mã nhân viên:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblThoiGianTruc
        // 
        lblThoiGianTruc.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblThoiGianTruc.Location = new System.Drawing.Point(194, 218);
        lblThoiGianTruc.Name = "lblThoiGianTruc";
        lblThoiGianTruc.Size = new System.Drawing.Size(239, 32);
        lblThoiGianTruc.TabIndex = 12;
        lblThoiGianTruc.Text = "7h00 - 10h00";
        lblThoiGianTruc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label11
        // 
        label11.Dock = System.Windows.Forms.DockStyle.Fill;
        label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.Location = new System.Drawing.Point(3, 208);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(185, 52);
        label11.TabIndex = 11;
        label11.Text = "Thời gian:";
        label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTenCa
        // 
        lblTenCa.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblTenCa.Location = new System.Drawing.Point(194, 166);
        lblTenCa.Name = "lblTenCa";
        lblTenCa.Size = new System.Drawing.Size(239, 32);
        lblTenCa.TabIndex = 9;
        lblTenCa.Text = "Ca sáng";
        lblTenCa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label7
        // 
        label7.Dock = System.Windows.Forms.DockStyle.Fill;
        label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(3, 104);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(185, 52);
        label7.TabIndex = 6;
        label7.Text = "Vai trò:";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblVaiTro
        // 
        lblVaiTro.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblVaiTro.Location = new System.Drawing.Point(194, 114);
        lblVaiTro.Name = "lblVaiTro";
        lblVaiTro.Size = new System.Drawing.Size(239, 32);
        lblVaiTro.TabIndex = 7;
        lblVaiTro.Text = "Nhân viên";
        lblVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label9
        // 
        label9.Dock = System.Windows.Forms.DockStyle.Fill;
        label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(3, 156);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(185, 52);
        label9.TabIndex = 8;
        label9.Text = "Tên ca:";
        label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTenNV
        // 
        lblTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblTenNV.Location = new System.Drawing.Point(194, 62);
        lblTenNV.Name = "lblTenNV";
        lblTenNV.Size = new System.Drawing.Size(239, 32);
        lblTenNV.TabIndex = 5;
        lblTenNV.Text = "Name user";
        lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblMaNV
        // 
        lblMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblMaNV.Location = new System.Drawing.Point(194, 10);
        lblMaNV.Name = "lblMaNV";
        lblMaNV.Size = new System.Drawing.Size(239, 32);
        lblMaNV.TabIndex = 3;
        lblMaNV.Text = "NV01";
        lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)112)), ((int)((byte)67)), ((int)((byte)48)));
        label3.Location = new System.Drawing.Point(16, 60);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(450, 66);
        label3.TabIndex = 13;
        label3.Text = "CHÀO BẠN ĐẾN HỆ THỐNG POS BÁN CÀ PHÊ";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)112)), ((int)((byte)67)), ((int)((byte)48)));
        panel2.Controls.Add(label1);
        panel2.Dock = System.Windows.Forms.DockStyle.Top;
        panel2.Location = new System.Drawing.Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(482, 52);
        panel2.TabIndex = 0;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(482, 52);
        label1.TabIndex = 0;
        label1.Text = "Nhân viên";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel3
        // 
        panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
        panel3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)245)), ((int)((byte)240)));
        panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel3.Controls.Add(panel5);
        panel3.Controls.Add(panel4);
        panel3.Location = new System.Drawing.Point(514, 48);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(624, 494);
        panel3.TabIndex = 2;
        // 
        // panel5
        // 
        panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        panel5.BackColor = System.Drawing.Color.White;
        panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel5.Controls.Add(btnTKDoanhThu);
        panel5.Controls.Add(btnLichSuHD);
        panel5.Controls.Add(btnLSChuyenBan);
        panel5.Controls.Add(btnSoDoBan);
        panel5.Controls.Add(label12);
        panel5.Location = new System.Drawing.Point(14, 75);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(594, 405);
        panel5.TabIndex = 1;
        // 
        // btnTKDoanhThu
        // 
        btnTKDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)((byte)139)), ((int)((byte)54)), ((int)((byte)48)));
        btnTKDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTKDoanhThu.FlatAppearance.BorderSize = 0;
        btnTKDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnTKDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTKDoanhThu.ForeColor = System.Drawing.Color.White;
        btnTKDoanhThu.Location = new System.Drawing.Point(358, 320);
        btnTKDoanhThu.Name = "btnTKDoanhThu";
        btnTKDoanhThu.Size = new System.Drawing.Size(208, 73);
        btnTKDoanhThu.TabIndex = 5;
        btnTKDoanhThu.Text = "Thống kê doanh thu";
        btnTKDoanhThu.UseVisualStyleBackColor = false;
        btnTKDoanhThu.Click += mnuTKDoanhThu_Click;
        // 
        // btnLichSuHD
        // 
        btnLichSuHD.BackColor = System.Drawing.Color.FromArgb(((int)((byte)139)), ((int)((byte)54)), ((int)((byte)48)));
        btnLichSuHD.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLichSuHD.FlatAppearance.BorderSize = 0;
        btnLichSuHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLichSuHD.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLichSuHD.ForeColor = System.Drawing.Color.White;
        btnLichSuHD.Location = new System.Drawing.Point(35, 319);
        btnLichSuHD.Name = "btnLichSuHD";
        btnLichSuHD.Size = new System.Drawing.Size(214, 73);
        btnLichSuHD.TabIndex = 4;
        btnLichSuHD.Text = "Lịch sử hoá đơn";
        btnLichSuHD.UseVisualStyleBackColor = false;
        btnLichSuHD.Click += mnuLichSuHD_Click;
        // 
        // btnLSChuyenBan
        // 
        btnLSChuyenBan.BackColor = System.Drawing.Color.FromArgb(((int)((byte)139)), ((int)((byte)54)), ((int)((byte)48)));
        btnLSChuyenBan.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLSChuyenBan.FlatAppearance.BorderSize = 0;
        btnLSChuyenBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLSChuyenBan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLSChuyenBan.ForeColor = System.Drawing.Color.White;
        btnLSChuyenBan.Location = new System.Drawing.Point(358, 161);
        btnLSChuyenBan.Name = "btnLSChuyenBan";
        btnLSChuyenBan.Size = new System.Drawing.Size(208, 73);
        btnLSChuyenBan.TabIndex = 3;
        btnLSChuyenBan.Text = "Lịch sử chuyển bàn";
        btnLSChuyenBan.UseVisualStyleBackColor = false;
        btnLSChuyenBan.Click += mnuLichSuCB_Click;
        // 
        // btnSoDoBan
        // 
        btnSoDoBan.BackColor = System.Drawing.Color.FromArgb(((int)((byte)139)), ((int)((byte)54)), ((int)((byte)48)));
        btnSoDoBan.Cursor = System.Windows.Forms.Cursors.Hand;
        btnSoDoBan.FlatAppearance.BorderSize = 0;
        btnSoDoBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSoDoBan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSoDoBan.ForeColor = System.Drawing.Color.White;
        btnSoDoBan.Location = new System.Drawing.Point(35, 161);
        btnSoDoBan.Name = "btnSoDoBan";
        btnSoDoBan.Size = new System.Drawing.Size(214, 73);
        btnSoDoBan.TabIndex = 2;
        btnSoDoBan.Text = "Sơ đồ bàn";
        btnSoDoBan.UseVisualStyleBackColor = false;
        btnSoDoBan.Click += mnuSoDoBan_Click;
        // 
        // label12
        // 
        label12.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(16, 12);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(564, 48);
        label12.TabIndex = 1;
        label12.Text = "Chọn chức năng ở thanh menu hoặc các ô dưới để bắt đầu";
        label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel4
        // 
        panel4.BackColor = System.Drawing.Color.FromArgb(((int)((byte)112)), ((int)((byte)67)), ((int)((byte)48)));
        panel4.Controls.Add(label2);
        panel4.Dock = System.Windows.Forms.DockStyle.Top;
        panel4.Location = new System.Drawing.Point(0, 0);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(622, 52);
        panel4.TabIndex = 0;
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(622, 52);
        label2.TabIndex = 0;
        label2.Text = "Khu vực làm việc";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)238)), ((int)((byte)233)), ((int)((byte)225)));
        ClientSize = new System.Drawing.Size(1148, 594);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Controls.Add(menuStripHome);
        MainMenuStrip = menuStripHome;
        MinimumSize = new System.Drawing.Size(1000, 650);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Trang chủ";
        Load += frmMain_Load;
        Resize += frmMain_Resize;
        menuStripHome.ResumeLayout(false);
        menuStripHome.PerformLayout();
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel5.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;

    private System.Windows.Forms.ToolStripMenuItem mnuTTCaNhan;

    private System.Windows.Forms.ToolStripMenuItem mnuMonBanChay;

    private System.Windows.Forms.ToolStripMenuItem mnuTKDoanhThu;

    private System.Windows.Forms.ToolStripMenuItem mnuPCCaLam;

    private System.Windows.Forms.ToolStripMenuItem mnuQLKhuVuc;

    private System.Windows.Forms.ToolStripMenuItem mnuQLDanhMuc;

    private System.Windows.Forms.ToolStripMenuItem mnuQLMonAn;

    private System.Windows.Forms.ToolStripMenuItem mnuLichSuChuyenBan;

    private System.Windows.Forms.ToolStripMenuItem mnuLichSuHoaDon;

    private System.Windows.Forms.ToolStripMenuItem mnuSoDoBan;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lblThoiGianTruc;

    private System.Windows.Forms.Button btnSoDoBan;
    private System.Windows.Forms.Button btnLSChuyenBan;
    private System.Windows.Forms.Button btnLichSuHD;
    private System.Windows.Forms.Button btnTKDoanhThu;

    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.ToolStripMenuItem MenuStripTaiKhoan;

    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblTenCa;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblVaiTro;

    private System.Windows.Forms.Label lblTenNV;
    private System.Windows.Forms.Label lblMaNV;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Panel panel5;

    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.ToolStripMenuItem MenuStripCaLam;
    private System.Windows.Forms.ToolStripMenuItem MenuStripThongKe;

    private System.Windows.Forms.ToolStripMenuItem MenuStripThucDon;

    private System.Windows.Forms.ToolStripMenuItem MenuStripPhucVu;

    private System.Windows.Forms.MenuStrip menuStripHome;

    #endregion
}