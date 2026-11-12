using System.ComponentModel;

namespace QuanLyCaPhe.View;

partial class frmQuanLyDanhMuc
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
        phụcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        thựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        caLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        panel1 = new System.Windows.Forms.Panel();
        panel2 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        panel3 = new System.Windows.Forms.Panel();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        menuStrip1.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { phụcVụToolStripMenuItem, thựcĐơnToolStripMenuItem, caLàmToolStripMenuItem, thốngKêToolStripMenuItem, profileToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1108, 33);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // phụcVụToolStripMenuItem
        // 
        phụcVụToolStripMenuItem.Name = "phụcVụToolStripMenuItem";
        phụcVụToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
        phụcVụToolStripMenuItem.Text = "Phục vụ";
        // 
        // thựcĐơnToolStripMenuItem
        // 
        thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
        thựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
        thựcĐơnToolStripMenuItem.Text = "Thực đơn";
        // 
        // caLàmToolStripMenuItem
        // 
        caLàmToolStripMenuItem.Name = "caLàmToolStripMenuItem";
        caLàmToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
        caLàmToolStripMenuItem.Text = "Ca làm";
        // 
        // thốngKêToolStripMenuItem
        // 
        thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
        thốngKêToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
        thốngKêToolStripMenuItem.Text = "Thống kê";
        // 
        // profileToolStripMenuItem
        // 
        profileToolStripMenuItem.Name = "profileToolStripMenuItem";
        profileToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
        profileToolStripMenuItem.Text = "Profile";
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.LightGray;
        panel1.Controls.Add(button5);
        panel1.Controls.Add(button4);
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(textBox3);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label1);
        panel1.Location = new System.Drawing.Point(21, 47);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(386, 538);
        panel1.TabIndex = 1;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.LightGray;
        panel2.Controls.Add(panel3);
        panel2.Controls.Add(label2);
        panel2.Location = new System.Drawing.Point(424, 47);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(672, 538);
        panel2.TabIndex = 2;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.Brown;
        label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(386, 72);
        label1.TabIndex = 0;
        label1.Text = "Thông tin";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.Color.Brown;
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(672, 72);
        label2.TabIndex = 1;
        label2.Text = "Danh sách danh mục";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(3, 100);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(135, 31);
        label3.TabIndex = 1;
        label3.Text = "Mã danh mục :";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(144, 100);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(239, 31);
        textBox1.TabIndex = 2;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(0, 153);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(143, 31);
        label4.TabIndex = 3;
        label4.Text = "Tên danh mục :";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(144, 153);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(239, 31);
        textBox2.TabIndex = 4;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(3, 202);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(135, 31);
        label5.TabIndex = 5;
        label5.Text = "Mô tả :";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(84, 202);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(292, 101);
        textBox3.TabIndex = 6;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.WhiteSmoke;
        panel3.Location = new System.Drawing.Point(14, 75);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(645, 463);
        panel3.TabIndex = 2;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(8, 336);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(135, 48);
        button1.TabIndex = 7;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(241, 336);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(135, 48);
        button2.TabIndex = 8;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(8, 401);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(135, 48);
        button3.TabIndex = 9;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(241, 401);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(135, 48);
        button4.TabIndex = 10;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(79, 473);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(226, 48);
        button5.TabIndex = 11;
        button5.Text = "button5";
        button5.UseVisualStyleBackColor = true;
        // 
        // frmQuanLyDanhMuc
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1108, 597);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Text = "Quản lý danh mục";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem caLàmToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem phụcVụToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}