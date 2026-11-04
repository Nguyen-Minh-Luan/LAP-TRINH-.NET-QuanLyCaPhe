using System.ComponentModel;

namespace QuanLyCaPhe;

partial class frmTableDetail
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
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.nướcUốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.lịchSửHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.pnlMenu = new System.Windows.Forms.Panel();
        this.lblTitleMenu = new System.Windows.Forms.Label();
        this.lblDanhMuc = new System.Windows.Forms.Label();
        this.cboDanhMuc = new System.Windows.Forms.ComboBox();
        this.dgvMenu = new System.Windows.Forms.DataGridView();
        this.lblSoLuong = new System.Windows.Forms.Label();
        this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
        this.btnThemMon = new System.Windows.Forms.Button();
        this.pnlBill = new System.Windows.Forms.Panel();
        this.lblTenBan = new System.Windows.Forms.Label();
        this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
        this.lblTongTienTitle = new System.Windows.Forms.Label();
        this.lblTongTien = new System.Windows.Forms.Label();
        this.btnDatBan = new System.Windows.Forms.Button();
        this.btnThanhToan = new System.Windows.Forms.Button();
        this.btnQuayLai = new System.Windows.Forms.Button();
        this.menuStrip1.SuspendLayout();
        this.pnlMenu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
        this.pnlBill.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.profileToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(890, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // quảnLýToolStripMenuItem
        // 
        this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nướcUốngToolStripMenuItem,
            this.lịchSửHoáĐơnToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem});
        this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
        this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
        this.quảnLýToolStripMenuItem.Text = "Quản Lý";
        // 
        // nướcUốngToolStripMenuItem
        // 
        this.nướcUốngToolStripMenuItem.Name = "nướcUốngToolStripMenuItem";
        this.nướcUốngToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
        this.nướcUốngToolStripMenuItem.Text = "Thức uống & món ăn";
        // 
        // lịchSửHoáĐơnToolStripMenuItem
        // 
        this.lịchSửHoáĐơnToolStripMenuItem.Name = "lịchSửHoáĐơnToolStripMenuItem";
        this.lịchSửHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
        this.lịchSửHoáĐơnToolStripMenuItem.Text = "Lịch sử hoá đơn";
        // 
        // thốngKêDoanhThuToolStripMenuItem
        // 
        this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
        this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
        this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu";
        // 
        // profileToolStripMenuItem
        // 
        this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
        this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
        this.profileToolStripMenuItem.Text = "Profile";
        // 
        // pnlMenu (Panel Bên Trái - Thực đơn)
        // 
        this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlMenu.Controls.Add(this.btnThemMon);
        this.pnlMenu.Controls.Add(this.nmSoLuong);
        this.pnlMenu.Controls.Add(this.lblSoLuong);
        this.pnlMenu.Controls.Add(this.dgvMenu);
        this.pnlMenu.Controls.Add(this.cboDanhMuc);
        this.pnlMenu.Controls.Add(this.lblDanhMuc);
        this.pnlMenu.Controls.Add(this.lblTitleMenu);
        this.pnlMenu.Location = new System.Drawing.Point(12, 32);
        this.pnlMenu.Name = "pnlMenu";
        this.pnlMenu.Size = new System.Drawing.Size(420, 475);
        this.pnlMenu.TabIndex = 1;
        // 
        // lblTitleMenu
        // 
        this.lblTitleMenu.AutoSize = true;
        this.lblTitleMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitleMenu.Location = new System.Drawing.Point(12, 12);
        this.lblTitleMenu.Name = "lblTitleMenu";
        this.lblTitleMenu.Size = new System.Drawing.Size(225, 21);
        this.lblTitleMenu.TabIndex = 0;
        this.lblTitleMenu.Text = "THỰC ĐƠN THỨC UỐNG & MÓN ĂN";
        // 
        // lblDanhMuc
        // 
        this.lblDanhMuc.AutoSize = true;
        this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblDanhMuc.Location = new System.Drawing.Point(12, 48);
        this.lblDanhMuc.Name = "lblDanhMuc";
        this.lblDanhMuc.Size = new System.Drawing.Size(70, 17);
        this.lblDanhMuc.TabIndex = 1;
        this.lblDanhMuc.Text = "Danh mục:";
        // 
        // cboDanhMuc
        // 
        this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.cboDanhMuc.FormattingEnabled = true;
        this.cboDanhMuc.Location = new System.Drawing.Point(90, 45);
        this.cboDanhMuc.Name = "cboDanhMuc";
        this.cboDanhMuc.Size = new System.Drawing.Size(315, 25);
        this.cboDanhMuc.TabIndex = 2;
        // 
        // dgvMenu
        // 
        this.dgvMenu.AllowUserToAddRows = false;
        this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
        this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvMenu.Location = new System.Drawing.Point(12, 80);
        this.dgvMenu.MultiSelect = false;
        this.dgvMenu.Name = "dgvMenu";
        this.dgvMenu.ReadOnly = true;
        this.dgvMenu.RowHeadersVisible = false;
        this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvMenu.Size = new System.Drawing.Size(393, 330);
        this.dgvMenu.TabIndex = 3;
        // 
        // lblSoLuong
        // 
        this.lblSoLuong.AutoSize = true;
        this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblSoLuong.Location = new System.Drawing.Point(12, 428);
        this.lblSoLuong.Name = "lblSoLuong";
        this.lblSoLuong.Size = new System.Drawing.Size(67, 17);
        this.lblSoLuong.TabIndex = 4;
        this.lblSoLuong.Text = "Số lượng:";
        // 
        // nmSoLuong
        // 
        this.nmSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.nmSoLuong.Location = new System.Drawing.Point(85, 425);
        this.nmSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nmSoLuong.Name = "nmSoLuong";
        this.nmSoLuong.Size = new System.Drawing.Size(80, 25);
        this.nmSoLuong.TabIndex = 5;
        this.nmSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.nmSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnThemMon
        // 
        this.btnThemMon.BackColor = System.Drawing.Color.DarkSeaGreen;
        this.btnThemMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnThemMon.Location = new System.Drawing.Point(255, 420);
        this.btnThemMon.Name = "btnThemMon";
        this.btnThemMon.Size = new System.Drawing.Size(150, 35);
        this.btnThemMon.TabIndex = 6;
        this.btnThemMon.Text = "Thêm món >>";
        this.btnThemMon.UseVisualStyleBackColor = false;
        this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
        // 
        // pnlBill
        // 
        this.pnlBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlBill.Controls.Add(this.btnQuayLai);
        this.pnlBill.Controls.Add(this.btnThanhToan);
        this.pnlBill.Controls.Add(this.btnDatBan);
        this.pnlBill.Controls.Add(this.lblTongTien);
        this.pnlBill.Controls.Add(this.lblTongTienTitle);
        this.pnlBill.Controls.Add(this.dgvChiTietHoaDon);
        this.pnlBill.Controls.Add(this.lblTenBan);
        this.pnlBill.Location = new System.Drawing.Point(445, 32);
        this.pnlBill.Name = "pnlBill";
        this.pnlBill.Size = new System.Drawing.Size(430, 475);
        this.pnlBill.TabIndex = 2;
        // 
        // lblTenBan
        // 
        this.lblTenBan.BackColor = System.Drawing.Color.LightSteelBlue;
        this.lblTenBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTenBan.Location = new System.Drawing.Point(12, 12);
        this.lblTenBan.Name = "lblTenBan";
        this.lblTenBan.Size = new System.Drawing.Size(403, 45);
        this.lblTenBan.TabIndex = 0;
        this.lblTenBan.Text = "CHI TIẾT HÓA ĐƠN - BÀN 1";
        this.lblTenBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dgvChiTietHoaDon
        // 
        this.dgvChiTietHoaDon.AllowUserToAddRows = false;
        this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
        this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvChiTietHoaDon.Location = new System.Drawing.Point(12, 80);
        this.dgvChiTietHoaDon.MultiSelect = false;
        this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
        this.dgvChiTietHoaDon.ReadOnly = true;
        this.dgvChiTietHoaDon.RowHeadersVisible = false;
        this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvChiTietHoaDon.Size = new System.Drawing.Size(403, 290);
        this.dgvChiTietHoaDon.TabIndex = 1;
        // 
        // lblTongTienTitle
        // 
        this.lblTongTienTitle.AutoSize = true;
        this.lblTongTienTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTongTienTitle.Location = new System.Drawing.Point(12, 385);
        this.lblTongTienTitle.Name = "lblTongTienTitle";
        this.lblTongTienTitle.Size = new System.Drawing.Size(82, 20);
        this.lblTongTienTitle.TabIndex = 2;
        this.lblTongTienTitle.Text = "Tổng tiền:";
        // 
        // lblTongTien
        // 
        this.lblTongTien.AutoSize = true;
        this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTongTien.ForeColor = System.Drawing.Color.Firebrick;
        this.lblTongTien.Location = new System.Drawing.Point(105, 384);
        this.lblTongTien.Name = "lblTongTien";
        this.lblTongTien.Size = new System.Drawing.Size(85, 21);
        this.lblTongTien.TabIndex = 3;
        this.lblTongTien.Text = "0 VNĐ";
        // 
        // btnDatBan
        // 
        this.btnDatBan.BackColor = System.Drawing.Color.RosyBrown;
        this.btnDatBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnDatBan.Location = new System.Drawing.Point(12, 420);
        this.btnDatBan.Name = "btnDatBan";
        this.btnDatBan.Size = new System.Drawing.Size(128, 35);
        this.btnDatBan.TabIndex = 4;
        this.btnDatBan.Text = "Đặt bàn";
        this.btnDatBan.UseVisualStyleBackColor = false;
        // 
        // btnThanhToan
        // 
        this.btnThanhToan.BackColor = System.Drawing.Color.LightSteelBlue;
        this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnThanhToan.Location = new System.Drawing.Point(149, 420);
        this.btnThanhToan.Name = "btnThanhToan";
        this.btnThanhToan.Size = new System.Drawing.Size(128, 35);
        this.btnThanhToan.TabIndex = 5;
        this.btnThanhToan.Text = "Thanh toán";
        this.btnThanhToan.UseVisualStyleBackColor = false;
        // 
        // btnQuayLai
        // 
        this.btnQuayLai.BackColor = System.Drawing.SystemColors.Control;
        this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnQuayLai.Location = new System.Drawing.Point(287, 420);
        this.btnQuayLai.Name = "btnQuayLai";
        this.btnQuayLai.Size = new System.Drawing.Size(128, 35);
        this.btnQuayLai.TabIndex = 6;
        this.btnQuayLai.Text = "Quay lại";
        this.btnQuayLai.UseVisualStyleBackColor = false;
        // 
        // frmTableDetail
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(890, 520);
        this.Controls.Add(this.pnlBill);
        this.Controls.Add(this.pnlMenu);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Chi Tiết Đặt Bàn & Gọi Món";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.pnlMenu.ResumeLayout(false);
        this.pnlMenu.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
        this.pnlBill.ResumeLayout(false);
        this.pnlBill.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

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
    private System.Windows.Forms.DataGridView dgvMenu;
    private System.Windows.Forms.Label lblSoLuong;
    private System.Windows.Forms.NumericUpDown nmSoLuong;
    private System.Windows.Forms.Button btnThemMon;
    private System.Windows.Forms.Panel pnlBill;
    private System.Windows.Forms.Label lblTenBan;
    private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
    private System.Windows.Forms.Label lblTongTienTitle;
    private System.Windows.Forms.Label lblTongTien;
    private System.Windows.Forms.Button btnDatBan;
    private System.Windows.Forms.Button btnThanhToan;
    private System.Windows.Forms.Button btnQuayLai;

    #endregion
}