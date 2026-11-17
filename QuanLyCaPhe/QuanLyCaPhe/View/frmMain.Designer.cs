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
        bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        profileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        panel1 = new System.Windows.Forms.Panel();
        label3 = new System.Windows.Forms.Label();
        lblThoiGianTruc = new System.Windows.Forms.Label();
        label11 = new System.Windows.Forms.Label();
        lblTenCa = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        lblVaiTro = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        lblTenNV = new System.Windows.Forms.Label();
        label100 = new System.Windows.Forms.Label();
        lblMaNV = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
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
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bánHàngToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêToolStripMenuItem, profileToolStripMenuItem, profileToolStripMenuItem1 });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(954, 33);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // bánHàngToolStripMenuItem
        // 
        bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
        bánHàngToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
        bánHàngToolStripMenuItem.Text = "Phục vụ";
        // 
        // quảnLýToolStripMenuItem
        // 
        quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
        quảnLýToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
        quảnLýToolStripMenuItem.Text = "Thực đơn";
        quảnLýToolStripMenuItem.Click += quảnLýToolStripMenuItem_Click;
        // 
        // thốngKêToolStripMenuItem
        // 
        thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
        thốngKêToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
        thốngKêToolStripMenuItem.Text = "Ca làm";
        // 
        // profileToolStripMenuItem
        // 
        profileToolStripMenuItem.Name = "profileToolStripMenuItem";
        profileToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
        profileToolStripMenuItem.Text = "Thống kê";
        // 
        // profileToolStripMenuItem1
        // 
        profileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { thôngTinCáNhânToolStripMenuItem });
        profileToolStripMenuItem1.Name = "profileToolStripMenuItem1";
        profileToolStripMenuItem1.Size = new System.Drawing.Size(102, 29);
        profileToolStripMenuItem1.Text = "Tài khoản";
        // 
        // thôngTinCáNhânToolStripMenuItem
        // 
        thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
        thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
        thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.Silver;
        panel1.Controls.Add(label3);
        panel1.Controls.Add(lblThoiGianTruc);
        panel1.Controls.Add(label11);
        panel1.Controls.Add(lblTenCa);
        panel1.Controls.Add(label9);
        panel1.Controls.Add(lblVaiTro);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(lblTenNV);
        panel1.Controls.Add(label100);
        panel1.Controls.Add(lblMaNV);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(panel2);
        panel1.Location = new System.Drawing.Point(12, 48);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(355, 442);
        panel1.TabIndex = 1;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.Brown;
        label3.Location = new System.Drawing.Point(3, 84);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(349, 76);
        label3.TabIndex = 13;
        label3.Text = "CHÀO BẠN ĐẾN HỆ THỐNG POS BÁN CÀ PHÊ";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblThoiGianTruc
        // 
        lblThoiGianTruc.Location = new System.Drawing.Point(167, 361);
        lblThoiGianTruc.Name = "lblThoiGianTruc";
        lblThoiGianTruc.Size = new System.Drawing.Size(122, 32);
        lblThoiGianTruc.TabIndex = 12;
        lblThoiGianTruc.Text = "7h00 - 10h00";
        // 
        // label11
        // 
        label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.Location = new System.Drawing.Point(16, 358);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(106, 35);
        label11.TabIndex = 11;
        label11.Text = "Thời gian:";
        label11.Click += label11_Click;
        // 
        // lblTenCa
        // 
        lblTenCa.Location = new System.Drawing.Point(167, 324);
        lblTenCa.Name = "lblTenCa";
        lblTenCa.Size = new System.Drawing.Size(88, 32);
        lblTenCa.TabIndex = 9;
        lblTenCa.Text = "Ca sáng";
        lblTenCa.Click += label10_Click;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(16, 324);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(83, 35);
        label9.TabIndex = 8;
        label9.Text = "Tên ca:";
        label9.Click += label9_Click;
        // 
        // lblVaiTro
        // 
        lblVaiTro.Location = new System.Drawing.Point(167, 292);
        lblVaiTro.Name = "lblVaiTro";
        lblVaiTro.Size = new System.Drawing.Size(135, 32);
        lblVaiTro.TabIndex = 7;
        lblVaiTro.Text = "Nhân viên";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(16, 289);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(98, 35);
        label7.TabIndex = 6;
        label7.Text = "Vai trò:";
        // 
        // lblTenNV
        // 
        lblTenNV.Location = new System.Drawing.Point(167, 257);
        lblTenNV.Name = "lblTenNV";
        lblTenNV.Size = new System.Drawing.Size(135, 32);
        lblTenNV.TabIndex = 5;
        lblTenNV.Text = "Name user";
        lblTenNV.Click += lblTenNV_Click;
        // 
        // label100
        // 
        label100.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label100.Location = new System.Drawing.Point(16, 254);
        label100.Name = "label100";
        label100.Size = new System.Drawing.Size(145, 35);
        label100.TabIndex = 4;
        label100.Text = "Tên nhân viên:";
        // 
        // lblMaNV
        // 
        lblMaNV.Location = new System.Drawing.Point(167, 222);
        lblMaNV.Name = "lblMaNV";
        lblMaNV.Size = new System.Drawing.Size(135, 32);
        lblMaNV.TabIndex = 3;
        lblMaNV.Text = "NV01";
        lblMaNV.Click += label4_Click;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(16, 219);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(145, 35);
        label5.TabIndex = 2;
        label5.Text = "Mã nhân viên:";
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.Brown;
        panel2.Controls.Add(label1);
        panel2.Location = new System.Drawing.Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(355, 52);
        panel2.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label1.Location = new System.Drawing.Point(97, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(158, 52);
        label1.TabIndex = 0;
        label1.Text = "Nhân viên";
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.Silver;
        panel3.Controls.Add(panel5);
        panel3.Controls.Add(panel4);
        panel3.Location = new System.Drawing.Point(382, 48);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(562, 442);
        panel3.TabIndex = 2;
        // 
        // panel5
        // 
        panel5.BackColor = System.Drawing.Color.White;
        panel5.Controls.Add(button5);
        panel5.Controls.Add(button4);
        panel5.Controls.Add(button3);
        panel5.Controls.Add(button2);
        panel5.Controls.Add(label12);
        panel5.Location = new System.Drawing.Point(13, 58);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(534, 396);
        panel5.TabIndex = 1;
        // 
        // button5
        // 
        button5.BackColor = System.Drawing.Color.DarkRed;
        button5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button5.ForeColor = System.Drawing.Color.White;
        button5.Location = new System.Drawing.Point(299, 278);
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
        button4.Location = new System.Drawing.Point(35, 278);
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
        button3.Location = new System.Drawing.Point(299, 139);
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
        button2.Location = new System.Drawing.Point(35, 139);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(214, 73);
        button2.TabIndex = 2;
        button2.Text = "Sơ đồ bàn và Order";
        button2.UseVisualStyleBackColor = false;
        // 
        // label12
        // 
        label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(90, 37);
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
        panel4.Location = new System.Drawing.Point(0, 0);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(629, 52);
        panel4.TabIndex = 0;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label2.Location = new System.Drawing.Point(175, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(255, 49);
        label2.TabIndex = 0;
        label2.Text = "Khu vực làm việc";
        // 
        // frmMain
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(954, 500);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Trang chủ";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel5.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;

    private System.Windows.Forms.Label label100;

    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lblThoiGianTruc;

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem1;

    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblTenCa;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblVaiTro;

    private System.Windows.Forms.Label label5;
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

    private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}