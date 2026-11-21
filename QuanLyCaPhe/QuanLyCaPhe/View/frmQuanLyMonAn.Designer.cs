using System.ComponentModel;

namespace QuanLyCaPhe.View;

partial class frmQuanLyMonAn
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
        tblRoot = new System.Windows.Forms.TableLayoutPanel();
        panel1 = new System.Windows.Forms.TableLayoutPanel();
        label1 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        txtDonGia = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        tblNut = new System.Windows.Forms.TableLayoutPanel();
        btnThem = new System.Windows.Forms.Button();
        btnSua = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        txtTenMon = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        cmbDanhMuc = new System.Windows.Forms.ComboBox();
        txtDonViTinh = new System.Windows.Forms.TextBox();
        panel2 = new System.Windows.Forms.TableLayoutPanel();
        label2 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        txtTimKiemMon = new System.Windows.Forms.TextBox();
        btnTimKiemMon = new System.Windows.Forms.Button();
        dgvDanhSachMon = new System.Windows.Forms.DataGridView();
        idCoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
        nameCoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
        itemsCoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
        priceCoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
        unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        statusCoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
        tblRoot.SuspendLayout();
        panel1.SuspendLayout();
        tblNut.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDanhSachMon).BeginInit();
        SuspendLayout();
        // 
        // tblRoot
        // 
        tblRoot.ColumnCount = 1;
        tblRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tblRoot.Controls.Add(panel1, 0, 0);
        tblRoot.Controls.Add(panel2, 0, 1);
        tblRoot.Dock = System.Windows.Forms.DockStyle.Fill;
        tblRoot.Location = new System.Drawing.Point(0, 0);
        tblRoot.Name = "tblRoot";
        tblRoot.Padding = new System.Windows.Forms.Padding(12);
        tblRoot.RowCount = 2;
        tblRoot.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tblRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tblRoot.Size = new System.Drawing.Size(1135, 626);
        tblRoot.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.AutoSize = true;
        panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        panel1.BackColor = System.Drawing.SystemColors.ControlLight;
        panel1.ColumnCount = 6;
        panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.69381F));
        panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.856678F));
        panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.286646F));
        panel1.Controls.Add(label1, 0, 0);
        panel1.Controls.Add(label6, 0, 2);
        panel1.Controls.Add(txtDonGia, 1, 2);
        panel1.Controls.Add(label7, 2, 2);
        panel1.Controls.Add(tblNut, 0, 3);
        panel1.Controls.Add(label4, 0, 1);
        panel1.Controls.Add(txtTenMon, 1, 1);
        panel1.Controls.Add(label5, 2, 1);
        panel1.Controls.Add(cmbDanhMuc, 3, 1);
        panel1.Controls.Add(txtDonViTinh, 3, 2);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(12, 12);
        panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
        panel1.Name = "panel1";
        panel1.RowCount = 4;
        panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
        panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        panel1.Size = new System.Drawing.Size(1111, 230);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.Brown;
        panel1.SetColumnSpan(label1, 6);
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Margin = new System.Windows.Forms.Padding(0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(1111, 57);
        label1.TabIndex = 0;
        label1.Text = "Thông tin món";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label6
        // 
        label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label6.AutoSize = true;
        label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(16, 127);
        label6.Margin = new System.Windows.Forms.Padding(16, 12, 8, 12);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(136, 28);
        label6.TabIndex = 7;
        label6.Text = "Đơn giá VNĐ:";
        // 
        // txtDonGia
        // 
        txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtDonGia.Location = new System.Drawing.Point(160, 126);
        txtDonGia.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
        txtDonGia.Name = "txtDonGia";
        txtDonGia.Size = new System.Drawing.Size(287, 31);
        txtDonGia.TabIndex = 8;
        // 
        // label7
        // 
        label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label7.AutoSize = true;
        label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(471, 127);
        label7.Margin = new System.Windows.Forms.Padding(24, 12, 8, 12);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(118, 28);
        label7.TabIndex = 9;
        label7.Text = "Đơn vị tính:";
        // 
        // tblNut
        // 
        tblNut.AutoSize = true;
        tblNut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        tblNut.ColumnCount = 4;
        panel1.SetColumnSpan(tblNut, 6);
        tblNut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tblNut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tblNut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tblNut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tblNut.Controls.Add(btnThem, 0, 0);
        tblNut.Controls.Add(btnSua, 1, 0);
        tblNut.Controls.Add(btnXoa, 2, 0);
        tblNut.Dock = System.Windows.Forms.DockStyle.Fill;
        tblNut.Location = new System.Drawing.Point(10, 169);
        tblNut.Margin = new System.Windows.Forms.Padding(10, 0, 10, 14);
        tblNut.Name = "tblNut";
        tblNut.RowCount = 1;
        tblNut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
        tblNut.Size = new System.Drawing.Size(1091, 47);
        tblNut.TabIndex = 11;
        // 
        // btnThem
        // 
        btnThem.BackColor = System.Drawing.Color.Firebrick;
        btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
        btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThem.ForeColor = System.Drawing.Color.White;
        btnThem.Location = new System.Drawing.Point(6, 0);
        btnThem.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        btnThem.Name = "btnThem";
        btnThem.Size = new System.Drawing.Size(260, 47);
        btnThem.TabIndex = 11;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = false;
        btnThem.Click += btnThem_Click;
        // 
        // btnSua
        // 
        btnSua.BackColor = System.Drawing.Color.Firebrick;
        btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
        btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSua.ForeColor = System.Drawing.Color.White;
        btnSua.Location = new System.Drawing.Point(278, 0);
        btnSua.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        btnSua.Name = "btnSua";
        btnSua.Size = new System.Drawing.Size(260, 47);
        btnSua.TabIndex = 12;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = false;
        btnSua.Click += btnSua_Click;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = System.Drawing.Color.Firebrick;
        btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
        btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoa.ForeColor = System.Drawing.Color.White;
        btnXoa.Location = new System.Drawing.Point(550, 0);
        btnXoa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(260, 47);
        btnXoa.TabIndex = 13;
        btnXoa.Text = "Xoá";
        btnXoa.UseVisualStyleBackColor = false;
        btnXoa.Click += btnXoa_Click;
        // 
        // label4
        // 
        label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label4.AutoSize = true;
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(24, 71);
        label4.Margin = new System.Windows.Forms.Padding(24, 12, 8, 12);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(97, 28);
        label4.TabIndex = 3;
        label4.Text = "Tên món:";
        // 
        // txtTenMon
        // 
        txtTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenMon.Location = new System.Drawing.Point(160, 70);
        txtTenMon.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
        txtTenMon.Name = "txtTenMon";
        txtTenMon.Size = new System.Drawing.Size(287, 31);
        txtTenMon.TabIndex = 4;
        // 
        // label5
        // 
        label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(471, 71);
        label5.Margin = new System.Windows.Forms.Padding(24, 12, 8, 12);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(110, 28);
        label5.TabIndex = 5;
        label5.Text = "Danh mục:";
        // 
        // cmbDanhMuc
        // 
        cmbDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        cmbDanhMuc.FormattingEnabled = true;
        cmbDanhMuc.Location = new System.Drawing.Point(597, 69);
        cmbDanhMuc.Margin = new System.Windows.Forms.Padding(0, 12, 16, 12);
        cmbDanhMuc.Name = "cmbDanhMuc";
        cmbDanhMuc.Size = new System.Drawing.Size(272, 33);
        cmbDanhMuc.TabIndex = 6;
        // 
        // txtDonViTinh
        // 
        txtDonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtDonViTinh.Location = new System.Drawing.Point(597, 126);
        txtDonViTinh.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
        txtDonViTinh.Name = "txtDonViTinh";
        txtDonViTinh.Size = new System.Drawing.Size(288, 31);
        txtDonViTinh.TabIndex = 10;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.SystemColors.ControlLight;
        panel2.ColumnCount = 3;
        panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        panel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        panel2.Controls.Add(label2, 0, 0);
        panel2.Controls.Add(label8, 0, 1);
        panel2.Controls.Add(txtTimKiemMon, 1, 1);
        panel2.Controls.Add(btnTimKiemMon, 2, 1);
        panel2.Controls.Add(dgvDanhSachMon, 0, 2);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(12, 254);
        panel2.Margin = new System.Windows.Forms.Padding(0);
        panel2.Name = "panel2";
        panel2.RowCount = 3;
        panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
        panel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        panel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        panel2.Size = new System.Drawing.Size(1111, 360);
        panel2.TabIndex = 1;
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.Color.Brown;
        panel2.SetColumnSpan(label2, 3);
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.White;
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Margin = new System.Windows.Forms.Padding(0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(1111, 57);
        label2.TabIndex = 1;
        label2.Text = "Danh sách món";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label8
        // 
        label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label8.AutoSize = true;
        label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(16, 72);
        label8.Margin = new System.Windows.Forms.Padding(16, 12, 8, 12);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(102, 28);
        label8.TabIndex = 2;
        label8.Text = "Tìm kiếm:";
        // 
        // txtTimKiemMon
        // 
        txtTimKiemMon.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiemMon.Location = new System.Drawing.Point(126, 71);
        txtTimKiemMon.Margin = new System.Windows.Forms.Padding(0, 12, 12, 12);
        txtTimKiemMon.Name = "txtTimKiemMon";
        txtTimKiemMon.PlaceholderText = "Tìm danh mục, tên món";
        txtTimKiemMon.Size = new System.Drawing.Size(817, 31);
        txtTimKiemMon.TabIndex = 3;
        txtTimKiemMon.TextChanged += txtTimKiemMon_TextChanged;
        // 
        // btnTimKiemMon
        // 
        btnTimKiemMon.BackColor = System.Drawing.Color.Firebrick;
        btnTimKiemMon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiemMon.ForeColor = System.Drawing.Color.White;
        btnTimKiemMon.Location = new System.Drawing.Point(955, 63);
        btnTimKiemMon.Margin = new System.Windows.Forms.Padding(0, 6, 16, 6);
        btnTimKiemMon.Name = "btnTimKiemMon";
        btnTimKiemMon.Size = new System.Drawing.Size(140, 47);
        btnTimKiemMon.TabIndex = 13;
        btnTimKiemMon.Text = "Tìm";
        btnTimKiemMon.UseVisualStyleBackColor = false;
        btnTimKiemMon.Click += timKiem_Click;
        // 
        // dgvDanhSachMon
        // 
        dgvDanhSachMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvDanhSachMon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
        dgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDanhSachMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idCoffee, nameCoffee, itemsCoffee, priceCoffee, unitPrice, statusCoffee });
        panel2.SetColumnSpan(dgvDanhSachMon, 3);
        dgvDanhSachMon.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvDanhSachMon.Location = new System.Drawing.Point(16, 116);
        dgvDanhSachMon.Margin = new System.Windows.Forms.Padding(16, 0, 16, 16);
        dgvDanhSachMon.Name = "dgvDanhSachMon";
        dgvDanhSachMon.RowHeadersWidth = 62;
        dgvDanhSachMon.Size = new System.Drawing.Size(1079, 228);
        dgvDanhSachMon.TabIndex = 14;
        dgvDanhSachMon.Text = "dataGridView1";
        dgvDanhSachMon.CellClick += dgvDanhSachMon_CellClick;
        // 
        // idCoffee
        // 
        idCoffee.FillWeight = 12F;
        idCoffee.HeaderText = "Mã món";
        idCoffee.MinimumWidth = 60;
        idCoffee.Name = "idCoffee";
        // 
        // nameCoffee
        // 
        nameCoffee.FillWeight = 28F;
        nameCoffee.HeaderText = "Tên món";
        nameCoffee.MinimumWidth = 60;
        nameCoffee.Name = "nameCoffee";
        nameCoffee.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        // 
        // itemsCoffee
        // 
        itemsCoffee.FillWeight = 20F;
        itemsCoffee.HeaderText = "Danh mục";
        itemsCoffee.MinimumWidth = 60;
        itemsCoffee.Name = "itemsCoffee";
        // 
        // priceCoffee
        // 
        priceCoffee.FillWeight = 16F;
        priceCoffee.HeaderText = "Đơn giá";
        priceCoffee.MinimumWidth = 60;
        priceCoffee.Name = "priceCoffee";
        // 
        // unitPrice
        // 
        unitPrice.FillWeight = 10F;
        unitPrice.HeaderText = "ĐVT";
        unitPrice.MinimumWidth = 60;
        unitPrice.Name = "unitPrice";
        // 
        // statusCoffee
        // 
        statusCoffee.FillWeight = 14F;
        statusCoffee.HeaderText = "Trạng thái";
        statusCoffee.MinimumWidth = 60;
        statusCoffee.Name = "statusCoffee";
        // 
        // frmQuanLyMonAn
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1135, 626);
        Controls.Add(tblRoot);
        MinimumSize = new System.Drawing.Size(900, 600);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Quản lý món ăn";
        tblRoot.ResumeLayout(false);
        tblRoot.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        tblNut.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDanhSachMon).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn idCoffee;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameCoffee;
    private System.Windows.Forms.DataGridViewTextBoxColumn itemsCoffee;
    private System.Windows.Forms.DataGridViewTextBoxColumn priceCoffee;
    private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn statusCoffee;

    private System.Windows.Forms.TextBox txtTimKiemMon;
    private System.Windows.Forms.Button btnTimKiemMon;
    private System.Windows.Forms.DataGridView dgvDanhSachMon;

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;

    private System.Windows.Forms.Button btnThem;

    private System.Windows.Forms.TextBox txtDonViTinh;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.TextBox txtDonGia;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cmbDanhMuc;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtTenMon;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TableLayoutPanel panel2;
    private System.Windows.Forms.TableLayoutPanel tblRoot;
    private System.Windows.Forms.TableLayoutPanel tblNut;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TableLayoutPanel panel1;

    #endregion
}