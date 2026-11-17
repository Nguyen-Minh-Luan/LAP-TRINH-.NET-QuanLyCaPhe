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
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        MenuStripPhucVu = new System.Windows.Forms.ToolStripMenuItem();
        MenuStripThucDon = new System.Windows.Forms.ToolStripMenuItem();
        MenuStripCaLam = new System.Windows.Forms.ToolStripMenuItem();
        MenuStripThongKe = new System.Windows.Forms.ToolStripMenuItem();
        MenuStripTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
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
        button5 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        label12 = new System.Windows.Forms.Label();
        panel4 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        menuStrip1.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuStripPhucVu, MenuStripThucDon, MenuStripCaLam, MenuStripThongKe, MenuStripTaiKhoan });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1148, 33);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // MenuStripPhucVu
        // 
        MenuStripPhucVu.Name = "MenuStripPhucVu";
        MenuStripPhucVu.Size = new System.Drawing.Size(90, 29);
        MenuStripPhucVu.Text = "Phục vụ";
        // 
        // MenuStripThucDon
        // 
        MenuStripThucDon.Name = "MenuStripThucDon";
        MenuStripThucDon.Size = new System.Drawing.Size(103, 29);
        MenuStripThucDon.Text = "Thực đơn";
        // 
        // MenuStripCaLam
        // 
        MenuStripCaLam.Name = "MenuStripCaLam";
        MenuStripCaLam.Size = new System.Drawing.Size(82, 29);
        MenuStripCaLam.Text = "Ca làm";
        // 
        // MenuStripThongKe
        // 
        MenuStripThongKe.Name = "MenuStripThongKe";
        MenuStripThongKe.Size = new System.Drawing.Size(102, 29);
        MenuStripThongKe.Text = "Thống kê";
        // 
        // MenuStripTaiKhoan
        // 
        MenuStripTaiKhoan.Name = "MenuStripTaiKhoan";
        MenuStripTaiKhoan.Size = new System.Drawing.Size(102, 29);
        MenuStripTaiKhoan.Text = "Tài khoản";
        // 
        // panel1
        // 
        panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        panel1.BackColor = System.Drawing.Color.Silver;
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
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
        tableLayoutPanel1.Location = new System.Drawing.Point(39, 210);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.Size = new System.Drawing.Size(408, 244);
        tableLayoutPanel1.TabIndex = 14;
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(3, 48);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(198, 48);
        label6.TabIndex = 5;
        label6.Text = "Tên nhân viên:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(3, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(198, 48);
        label4.TabIndex = 3;
        label4.Text = "Mã nhân viên:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblThoiGianTruc
        // 
        lblThoiGianTruc.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblThoiGianTruc.Location = new System.Drawing.Point(207, 202);
        lblThoiGianTruc.Name = "lblThoiGianTruc";
        lblThoiGianTruc.Size = new System.Drawing.Size(198, 32);
        lblThoiGianTruc.TabIndex = 12;
        lblThoiGianTruc.Text = "7h00 - 10h00";
        lblThoiGianTruc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label11
        // 
        label11.Dock = System.Windows.Forms.DockStyle.Fill;
        label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.Location = new System.Drawing.Point(3, 192);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(198, 52);
        label11.TabIndex = 11;
        label11.Text = "Thời gian:";
        label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTenCa
        // 
        lblTenCa.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblTenCa.Location = new System.Drawing.Point(207, 152);
        lblTenCa.Name = "lblTenCa";
        lblTenCa.Size = new System.Drawing.Size(198, 32);
        lblTenCa.TabIndex = 9;
        lblTenCa.Text = "Ca sáng";
        lblTenCa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label7
        // 
        label7.Dock = System.Windows.Forms.DockStyle.Fill;
        label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(3, 96);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(198, 48);
        label7.TabIndex = 6;
        label7.Text = "Vai trò:";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblVaiTro
        // 
        lblVaiTro.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblVaiTro.Location = new System.Drawing.Point(207, 104);
        lblVaiTro.Name = "lblVaiTro";
        lblVaiTro.Size = new System.Drawing.Size(198, 32);
        lblVaiTro.TabIndex = 7;
        lblVaiTro.Text = "Nhân viên";
        lblVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label9
        // 
        label9.Dock = System.Windows.Forms.DockStyle.Fill;
        label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(3, 144);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(198, 48);
        label9.TabIndex = 8;
        label9.Text = "Tên ca:";
        label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTenNV
        // 
        lblTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblTenNV.Location = new System.Drawing.Point(207, 56);
        lblTenNV.Name = "lblTenNV";
        lblTenNV.Size = new System.Drawing.Size(198, 32);
        lblTenNV.TabIndex = 5;
        lblTenNV.Text = "Name user";
        lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblMaNV
        // 
        lblMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblMaNV.Location = new System.Drawing.Point(207, 8);
        lblMaNV.Name = "lblMaNV";
        lblMaNV.Size = new System.Drawing.Size(198, 32);
        lblMaNV.TabIndex = 3;
        lblMaNV.Text = "NV01";
        lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.Brown;
        label3.Location = new System.Drawing.Point(3, 84);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(478, 76);
        label3.TabIndex = 13;
        label3.Text = "CHÀO BẠN ĐẾN HỆ THỐNG POS BÁN CÀ PHÊ";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.Brown;
        panel2.Controls.Add(label1);
        panel2.Dock = System.Windows.Forms.DockStyle.Top;
        panel2.Location = new System.Drawing.Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(484, 52);
        panel2.TabIndex = 0;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(484, 52);
        label1.TabIndex = 0;
        label1.Text = "Nhân viên";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel3
        // 
        panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
        panel3.BackColor = System.Drawing.Color.Silver;
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
        panel5.Controls.Add(button5);
        panel5.Controls.Add(button4);
        panel5.Controls.Add(button3);
        panel5.Controls.Add(button2);
        panel5.Controls.Add(label12);
        panel5.Location = new System.Drawing.Point(14, 75);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(596, 407);
        panel5.TabIndex = 1;
        // 
        // button5
        // 
        button5.BackColor = System.Drawing.Color.DarkRed;
        button5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button5.ForeColor = System.Drawing.Color.White;
        button5.Location = new System.Drawing.Point(358, 320);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(208, 73);
        button5.TabIndex = 5;
        button5.Text = "Thống kê doanh thu";
        button5.UseVisualStyleBackColor = false;
        // 
        // button4
        // 
        button4.BackColor = System.Drawing.Color.DarkRed;
        button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button4.ForeColor = System.Drawing.Color.White;
        button4.Location = new System.Drawing.Point(35, 319);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(214, 73);
        button4.TabIndex = 4;
        button4.Text = "Lịch sử hoá đơn";
        button4.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.DarkRed;
        button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button3.ForeColor = System.Drawing.Color.White;
        button3.Location = new System.Drawing.Point(358, 161);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(208, 73);
        button3.TabIndex = 3;
        button3.Text = "Đặt bàn trước";
        button3.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.DarkRed;
        button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.ForeColor = System.Drawing.Color.White;
        button2.Location = new System.Drawing.Point(35, 161);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(214, 73);
        button2.TabIndex = 2;
        button2.Text = "Sơ đồ bàn và Order";
        button2.UseVisualStyleBackColor = false;
        // 
        // label12
        // 
        label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(127, 54);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(370, 56);
        label12.TabIndex = 1;
        label12.Text = "Chọn chức năng ở thanh menu hoặc các ô dưới để bắt đầu";
        label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // panel4
        // 
        panel4.BackColor = System.Drawing.Color.Brown;
        panel4.Controls.Add(label2);
        panel4.Dock = System.Windows.Forms.DockStyle.Top;
        panel4.Location = new System.Drawing.Point(0, 0);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(624, 52);
        panel4.TabIndex = 0;
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(624, 52);
        label2.TabIndex = 0;
        label2.Text = "Khu vực làm việc";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(1148, 594);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new System.Drawing.Size(1000, 650);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Trang chủ";
        Load += frmMain_Load;
        Resize += frmMain_Resize;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel5.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lblThoiGianTruc;

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;

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

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}