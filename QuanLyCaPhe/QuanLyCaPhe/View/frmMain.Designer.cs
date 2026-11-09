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
        panel1 = new System.Windows.Forms.Panel();
        button1 = new System.Windows.Forms.Button();
        label10 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        panel2 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        panel5 = new System.Windows.Forms.Panel();
        panel4 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        label11 = new System.Windows.Forms.Label();
        label12 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        menuStrip1.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
        profileToolStripMenuItem1.Name = "profileToolStripMenuItem1";
        profileToolStripMenuItem1.Size = new System.Drawing.Size(78, 29);
        profileToolStripMenuItem1.Text = "Profile";
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.Silver;
        panel1.Controls.Add(button1);
        panel1.Controls.Add(label10);
        panel1.Controls.Add(label9);
        panel1.Controls.Add(label8);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(pictureBox1);
        panel1.Controls.Add(panel2);
        panel1.Location = new System.Drawing.Point(12, 36);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(355, 454);
        panel1.TabIndex = 1;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.Red;
        button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        button1.Location = new System.Drawing.Point(67, 381);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(188, 41);
        button1.TabIndex = 10;
        button1.Text = "Đăng xuất";
        button1.UseVisualStyleBackColor = false;
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(105, 326);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(197, 32);
        label10.TabIndex = 9;
        label10.Text = "Ca sáng (7h00 - 10h00)";
        label10.Click += label10_Click;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(16, 323);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(83, 35);
        label9.TabIndex = 8;
        label9.Text = "Ca trực:";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(120, 291);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(135, 32);
        label8.TabIndex = 7;
        label8.Text = "Nhân viên";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(16, 288);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(98, 35);
        label7.TabIndex = 6;
        label7.Text = "Vai trò:";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(167, 256);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(135, 32);
        label6.TabIndex = 5;
        label6.Text = "Name user";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(16, 253);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(145, 35);
        label5.TabIndex = 4;
        label5.Text = "Tên nhân viên:";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(167, 221);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(135, 32);
        label4.TabIndex = 3;
        label4.Text = "NV01";
        label4.Click += label4_Click;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(16, 218);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(145, 35);
        label3.TabIndex = 2;
        label3.Text = "Mã nhân viên:";
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(94, 73);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(161, 139);
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
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
        label1.Location = new System.Drawing.Point(94, 0);
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
        panel3.Location = new System.Drawing.Point(382, 36);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(562, 454);
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
        panel5.Controls.Add(label11);
        panel5.Location = new System.Drawing.Point(13, 58);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(534, 396);
        panel5.TabIndex = 1;
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
        // label11
        // 
        label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.ForeColor = System.Drawing.Color.Brown;
        label11.Location = new System.Drawing.Point(88, 15);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(373, 38);
        label11.TabIndex = 0;
        label11.Text = "Chào mừng Nguyễn Văn A";
        // 
        // label12
        // 
        label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(90, 64);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(370, 56);
        label12.TabIndex = 1;
        label12.Text = "Chọn chức năng ở thanh menu hoặc các ô dưới để bắt đầu";
        label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
        // frmMain
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(954, 500);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        Location = new System.Drawing.Point(22, 22);
        MainMenuStrip = menuStrip1;
        Text = "Trang chủ";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel5.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem1;

    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.PictureBox pictureBox1;

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