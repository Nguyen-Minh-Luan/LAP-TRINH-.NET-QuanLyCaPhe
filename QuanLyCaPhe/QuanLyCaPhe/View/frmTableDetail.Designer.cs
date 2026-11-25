using System.ComponentModel;

namespace QuanLyCaPhe;

partial class frmTableDetail
{
    private IContainer components = null;

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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        nướcUốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        lịchSửHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        pnlMenu = new System.Windows.Forms.Panel();
        flpMenu = new System.Windows.Forms.FlowLayoutPanel();
        pnlItemMon = new System.Windows.Forms.Panel();
        lblTenMon = new System.Windows.Forms.Label();
        picMonAn = new System.Windows.Forms.PictureBox();
        cboDanhMuc = new System.Windows.Forms.ComboBox();
        lblDanhMuc = new System.Windows.Forms.Label();
        lblTitleMenu = new System.Windows.Forms.Label();
        pnlBill = new System.Windows.Forms.Panel();
        btnQuayLai = new System.Windows.Forms.Button();
        btnThanhToan = new System.Windows.Forms.Button();
        btnHuyDatBan = new System.Windows.Forms.Button();
        btnDatBan = new System.Windows.Forms.Button();
        lblTongTien = new System.Windows.Forms.Label();
        lblTongTienTitle = new System.Windows.Forms.Label();
        lblTongSoMon = new System.Windows.Forms.Label();
        txtGhiChuMon = new System.Windows.Forms.TextBox();
        btnXoaMon = new System.Windows.Forms.Button();
        btnGiamSL = new System.Windows.Forms.Button();
        btnTangSL = new System.Windows.Forms.Button();
        dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
        colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        lblThongTinBan = new System.Windows.Forms.Label();
        lblTenBan = new System.Windows.Forms.Label();
        menuStrip1.SuspendLayout();
        pnlMenu.SuspendLayout();
        flpMenu.SuspendLayout();
        pnlItemMon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picMonAn).BeginInit();
        pnlBill.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { quảnLýToolStripMenuItem, profileToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(890, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // quảnLýToolStripMenuItem
        // 
        quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { nướcUốngToolStripMenuItem, lịchSửHoáĐơnToolStripMenuItem, thốngKêDoanhThuToolStripMenuItem });
        quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
        quảnLýToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
        quảnLýToolStripMenuItem.Text = "Quản Lý";
        // 
        // nướcUốngToolStripMenuItem
        // 
        nướcUốngToolStripMenuItem.Name = "nướcUốngToolStripMenuItem";
        nướcUốngToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
        nướcUốngToolStripMenuItem.Text = "Thức uống & món ăn";
        // 
        // lịchSửHoáĐơnToolStripMenuItem
        // 
        lịchSửHoáĐơnToolStripMenuItem.Name = "lịchSửHoáĐơnToolStripMenuItem";
        lịchSửHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
        lịchSửHoáĐơnToolStripMenuItem.Text = "Lịch sử hoá đơn";
        // 
        // thốngKêDoanhThuToolStripMenuItem
        // 
        thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
        thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
        thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu";
        // 
        // profileToolStripMenuItem
        // 
        profileToolStripMenuItem.Name = "profileToolStripMenuItem";
        profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
        profileToolStripMenuItem.Text = "Profile";
        // 
        // pnlMenu
        // 
        pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlMenu.Controls.Add(flpMenu);
        pnlMenu.Controls.Add(cboDanhMuc);
        pnlMenu.Controls.Add(lblDanhMuc);
        pnlMenu.Controls.Add(lblTitleMenu);
        pnlMenu.Location = new System.Drawing.Point(12, 32);
        pnlMenu.Name = "pnlMenu";
        pnlMenu.Size = new System.Drawing.Size(425, 475);
        pnlMenu.TabIndex = 1;
        // 
        // flpMenu
        // 
        flpMenu.AutoScroll = true;
        flpMenu.BackColor = System.Drawing.Color.White;
        flpMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        flpMenu.Controls.Add(pnlItemMon);
        flpMenu.Location = new System.Drawing.Point(8, 80);
        flpMenu.Name = "flpMenu";
        flpMenu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
        flpMenu.Size = new System.Drawing.Size(407, 380);
        flpMenu.TabIndex = 3;
        // 
        // pnlItemMon
        // 
        pnlItemMon.BackColor = System.Drawing.Color.White;
        pnlItemMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlItemMon.Controls.Add(lblTenMon);
        pnlItemMon.Controls.Add(picMonAn);
        pnlItemMon.Cursor = System.Windows.Forms.Cursors.Hand;
        pnlItemMon.Location = new System.Drawing.Point(9, 9);
        pnlItemMon.Name = "pnlItemMon";
        pnlItemMon.Size = new System.Drawing.Size(116, 140);
        pnlItemMon.TabIndex = 0;
        // 
        // lblTenMon
        // 
        lblTenMon.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        lblTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)40)), ((int)((byte)40)));
        lblTenMon.Location = new System.Drawing.Point(2, 78);
        lblTenMon.Name = "lblTenMon";
        lblTenMon.Size = new System.Drawing.Size(110, 36);
        lblTenMon.TabIndex = 1;
        lblTenMon.Text = "Cà phê sữa đá";
        lblTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // picMonAn
        // 
        picMonAn.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)245)), ((int)((byte)245)));
        picMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
        picMonAn.Location = new System.Drawing.Point(5, 5);
        picMonAn.Name = "picMonAn";
        picMonAn.Size = new System.Drawing.Size(104, 70);
        picMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picMonAn.TabIndex = 0;
        picMonAn.TabStop = false;
        picMonAn.Click += picMonAn_Click;
        // 
        // cboDanhMuc
        // 
        cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        cboDanhMuc.FormattingEnabled = true;
        cboDanhMuc.Location = new System.Drawing.Point(85, 45);
        cboDanhMuc.Name = "cboDanhMuc";
        cboDanhMuc.Size = new System.Drawing.Size(330, 25);
        cboDanhMuc.TabIndex = 2;
        // 
        // lblDanhMuc
        // 
        lblDanhMuc.AutoSize = true;
        lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        lblDanhMuc.Location = new System.Drawing.Point(12, 48);
        lblDanhMuc.Name = "lblDanhMuc";
        lblDanhMuc.Size = new System.Drawing.Size(69, 17);
        lblDanhMuc.TabIndex = 1;
        lblDanhMuc.Text = "Danh mục:";
        // 
        // lblTitleMenu
        // 
        lblTitleMenu.AutoSize = true;
        lblTitleMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTitleMenu.ForeColor = System.Drawing.Color.FromArgb(112, 67, 48);
        lblTitleMenu.Location = new System.Drawing.Point(12, 12);
        lblTitleMenu.Name = "lblTitleMenu";
        lblTitleMenu.Size = new System.Drawing.Size(271, 21);
        lblTitleMenu.TabIndex = 0;
        lblTitleMenu.Text = "THỰC ĐƠN THỨC UỐNG & MÓN ĂN";
        // 
        // pnlBill
        // 
        pnlBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlBill.Controls.Add(btnQuayLai);
        pnlBill.Controls.Add(btnThanhToan);
        pnlBill.Controls.Add(btnHuyDatBan);
        pnlBill.Controls.Add(btnDatBan);
        pnlBill.Controls.Add(lblTongTien);
        pnlBill.Controls.Add(lblTongTienTitle);
        pnlBill.Controls.Add(lblTongSoMon);
        pnlBill.Controls.Add(txtGhiChuMon);
        pnlBill.Controls.Add(btnXoaMon);
        pnlBill.Controls.Add(btnGiamSL);
        pnlBill.Controls.Add(btnTangSL);
        pnlBill.Controls.Add(dgvChiTietHoaDon);
        pnlBill.Controls.Add(lblThongTinBan);
        pnlBill.Controls.Add(lblTenBan);
        pnlBill.Location = new System.Drawing.Point(445, 32);
        pnlBill.Name = "pnlBill";
        pnlBill.Size = new System.Drawing.Size(430, 475);
        pnlBill.TabIndex = 2;
        // 
        // btnQuayLai
        // 
        btnQuayLai.BackColor = System.Drawing.Color.FromArgb(232, 224, 214);
        btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
        btnQuayLai.FlatAppearance.BorderSize = 0;
        btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnQuayLai.ForeColor = System.Drawing.Color.FromArgb(110, 85, 70);
        btnQuayLai.Location = new System.Drawing.Point(322, 412);
        btnQuayLai.Name = "btnQuayLai";
        btnQuayLai.Size = new System.Drawing.Size(96, 42);
        btnQuayLai.TabIndex = 13;
        btnQuayLai.Text = "Quay lại";
        btnQuayLai.UseVisualStyleBackColor = false;
        // 
        // btnThanhToan
        // 
        btnThanhToan.BackColor = System.Drawing.Color.FromArgb(139, 54, 48);
        btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
        btnThanhToan.FlatAppearance.BorderSize = 0;
        btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnThanhToan.ForeColor = System.Drawing.Color.White;
        btnThanhToan.Location = new System.Drawing.Point(218, 412);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new System.Drawing.Size(96, 42);
        btnThanhToan.TabIndex = 12;
        btnThanhToan.Text = "Thanh toán";
        btnThanhToan.UseVisualStyleBackColor = false;
        btnThanhToan.Click += btnThanhToan_Click;
        // 
        // btnHuyDatBan
        // 
        btnHuyDatBan.BackColor = System.Drawing.Color.FromArgb(175, 50, 45);
        btnHuyDatBan.Cursor = System.Windows.Forms.Cursors.Hand;
        btnHuyDatBan.FlatAppearance.BorderSize = 0;
        btnHuyDatBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnHuyDatBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnHuyDatBan.ForeColor = System.Drawing.Color.White;
        btnHuyDatBan.Location = new System.Drawing.Point(114, 412);
        btnHuyDatBan.Name = "btnHuyDatBan";
        btnHuyDatBan.Size = new System.Drawing.Size(96, 42);
        btnHuyDatBan.TabIndex = 11;
        btnHuyDatBan.Text = "Hủy bàn";
        btnHuyDatBan.UseVisualStyleBackColor = false;
        // 
        // btnDatBan
        // 
        btnDatBan.BackColor = System.Drawing.Color.FromArgb(112, 67, 48);
        btnDatBan.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDatBan.FlatAppearance.BorderSize = 0;
        btnDatBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDatBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnDatBan.ForeColor = System.Drawing.Color.White;
        btnDatBan.Location = new System.Drawing.Point(10, 412);
        btnDatBan.Name = "btnDatBan";
        btnDatBan.Size = new System.Drawing.Size(96, 42);
        btnDatBan.TabIndex = 10;
        btnDatBan.Text = "Lưu món";
        btnDatBan.UseVisualStyleBackColor = false;
        // 
        // lblTongTien
        // 
        lblTongTien.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongTien.ForeColor = System.Drawing.Color.FromArgb(139, 54, 48);
        lblTongTien.Location = new System.Drawing.Point(110, 365);
        lblTongTien.Name = "lblTongTien";
        lblTongTien.Size = new System.Drawing.Size(306, 27);
        lblTongTien.TabIndex = 9;
        lblTongTien.Text = "0 VNĐ";
        lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblTongTienTitle
        // 
        lblTongTienTitle.AutoSize = true;
        lblTongTienTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongTienTitle.Location = new System.Drawing.Point(12, 368);
        lblTongTienTitle.Name = "lblTongTienTitle";
        lblTongTienTitle.Size = new System.Drawing.Size(94, 20);
        lblTongTienTitle.TabIndex = 8;
        lblTongTienTitle.Text = "TỔNG TIỀN:";
        // 
        // lblTongSoMon
        // 
        lblTongSoMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongSoMon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        lblTongSoMon.Location = new System.Drawing.Point(12, 337);
        lblTongSoMon.Name = "lblTongSoMon";
        lblTongSoMon.Size = new System.Drawing.Size(404, 22);
        lblTongSoMon.TabIndex = 7;
        lblTongSoMon.Text = "Tổng số món: 0 món (0 phần)";
        // 
        // txtGhiChuMon
        // 
        txtGhiChuMon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtGhiChuMon.Location = new System.Drawing.Point(174, 303);
        txtGhiChuMon.Name = "txtGhiChuMon";
        txtGhiChuMon.PlaceholderText = "Ghi chú món (ít ngọt, không đá...)";
        txtGhiChuMon.Size = new System.Drawing.Size(242, 23);
        txtGhiChuMon.TabIndex = 6;
        // 
        // btnXoaMon
        // 
        btnXoaMon.Cursor = System.Windows.Forms.Cursors.Hand;
        btnXoaMon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoaMon.ForeColor = System.Drawing.Color.DarkRed;
        btnXoaMon.Location = new System.Drawing.Point(92, 301);
        btnXoaMon.Name = "btnXoaMon";
        btnXoaMon.Size = new System.Drawing.Size(78, 28);
        btnXoaMon.TabIndex = 5;
        btnXoaMon.Text = "Xóa món";
        btnXoaMon.UseVisualStyleBackColor = true;
        // 
        // btnGiamSL
        // 
        btnGiamSL.Cursor = System.Windows.Forms.Cursors.Hand;
        btnGiamSL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnGiamSL.Location = new System.Drawing.Point(52, 301);
        btnGiamSL.Name = "btnGiamSL";
        btnGiamSL.Size = new System.Drawing.Size(36, 28);
        btnGiamSL.TabIndex = 4;
        btnGiamSL.Text = "-";
        btnGiamSL.UseVisualStyleBackColor = true;
        // 
        // btnTangSL
        // 
        btnTangSL.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTangSL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTangSL.Location = new System.Drawing.Point(12, 301);
        btnTangSL.Name = "btnTangSL";
        btnTangSL.Size = new System.Drawing.Size(36, 28);
        btnTangSL.TabIndex = 3;
        btnTangSL.Text = "+";
        btnTangSL.UseVisualStyleBackColor = true;
        // 
        // dgvChiTietHoaDon
        // 
        dgvChiTietHoaDon.AllowUserToAddRows = false;
        dgvChiTietHoaDon.AllowUserToDeleteRows = false;
        dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
        dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colTenMon, colSoLuong, colDonGia, colThanhTien });
        dgvChiTietHoaDon.Location = new System.Drawing.Point(12, 69);
        dgvChiTietHoaDon.MultiSelect = false;
        dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
        dgvChiTietHoaDon.ReadOnly = true;
        dgvChiTietHoaDon.RowHeadersVisible = false;
        dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvChiTietHoaDon.Size = new System.Drawing.Size(404, 226);
        dgvChiTietHoaDon.TabIndex = 2;
        // 
        // colTenMon
        // 
        colTenMon.FillWeight = 46F;
        colTenMon.HeaderText = "Tên món";
        colTenMon.Name = "colTenMon";
        colTenMon.ReadOnly = true;
        // 
        // colSoLuong
        // 
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        colSoLuong.DefaultCellStyle = dataGridViewCellStyle1;
        colSoLuong.FillWeight = 14F;
        colSoLuong.HeaderText = "SL";
        colSoLuong.Name = "colSoLuong";
        colSoLuong.ReadOnly = true;
        // 
        // colDonGia
        // 
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle2.Format = "N0";
        colDonGia.DefaultCellStyle = dataGridViewCellStyle2;
        colDonGia.FillWeight = 20F;
        colDonGia.HeaderText = "Đơn giá";
        colDonGia.Name = "colDonGia";
        colDonGia.ReadOnly = true;
        // 
        // colThanhTien
        // 
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle3.Format = "N0";
        colThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
        colThanhTien.FillWeight = 20F;
        colThanhTien.HeaderText = "Thành tiền";
        colThanhTien.Name = "colThanhTien";
        colThanhTien.ReadOnly = true;
        // 
        // lblThongTinBan
        // 
        lblThongTinBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblThongTinBan.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        lblThongTinBan.Location = new System.Drawing.Point(12, 46);
        lblThongTinBan.Name = "lblThongTinBan";
        lblThongTinBan.Size = new System.Drawing.Size(404, 20);
        lblThongTinBan.TabIndex = 1;
        lblThongTinBan.Text = "Giờ vào: --:--   |   Mã HĐ: --   |   Trạng thái: Trống";
        lblThongTinBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTenBan
        // 
        lblTenBan.BackColor = System.Drawing.Color.FromArgb(112, 67, 48);
        lblTenBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTenBan.ForeColor = System.Drawing.Color.White;
        lblTenBan.Location = new System.Drawing.Point(12, 10);
        lblTenBan.Name = "lblTenBan";
        lblTenBan.Size = new System.Drawing.Size(404, 34);
        lblTenBan.TabIndex = 0;
        lblTenBan.Text = "CHI TIẾT HÓA ĐƠN - BÀN 1";
        lblTenBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // frmTableDetail
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(890, 520);
        Controls.Add(pnlBill);
        Controls.Add(pnlMenu);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Chi Tiết Đặt Bàn & Gọi Món";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        pnlMenu.ResumeLayout(false);
        pnlMenu.PerformLayout();
        flpMenu.ResumeLayout(false);
        pnlItemMon.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picMonAn).EndInit();
        pnlBill.ResumeLayout(false);
        pnlBill.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nướcUốngToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem lịchSửHoáĐơnToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    private System.Windows.Forms.Panel pnlMenu;
    private System.Windows.Forms.Label lblTitleMenu;
    private System.Windows.Forms.Label lblDanhMuc;
    private System.Windows.Forms.ComboBox cboDanhMuc;
    private System.Windows.Forms.FlowLayoutPanel flpMenu;
    private System.Windows.Forms.Panel pnlItemMon;
    private System.Windows.Forms.PictureBox picMonAn;
    private System.Windows.Forms.Label lblTenMon;
    private System.Windows.Forms.Panel pnlBill;
    public System.Windows.Forms.Label lblTenBan;
    public System.Windows.Forms.Label lblThongTinBan;
    public System.Windows.Forms.DataGridView dgvChiTietHoaDon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    public System.Windows.Forms.Button btnTangSL;
    public System.Windows.Forms.Button btnGiamSL;
    public System.Windows.Forms.Button btnXoaMon;
    public System.Windows.Forms.TextBox txtGhiChuMon;
    public System.Windows.Forms.Label lblTongSoMon;
    private System.Windows.Forms.Label lblTongTienTitle;
    public System.Windows.Forms.Label lblTongTien;
    public System.Windows.Forms.Button btnDatBan;
    public System.Windows.Forms.Button btnHuyDatBan;
    public System.Windows.Forms.Button btnThanhToan;
    public System.Windows.Forms.Button btnQuayLai;
}
