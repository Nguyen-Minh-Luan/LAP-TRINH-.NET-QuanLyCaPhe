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
        nhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        panel1 = new System.Windows.Forms.Panel();
        panel2 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        panel4 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        panel5 = new System.Windows.Forms.Panel();
        menuStrip1.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bánHàngToolStripMenuItem, quảnLýToolStripMenuItem, nhânSựToolStripMenuItem, thốngKêToolStripMenuItem, profileToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(954, 33);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // bánHàngToolStripMenuItem
        // 
        bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
        bánHàngToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
        bánHàngToolStripMenuItem.Text = "Bán hàng";
        // 
        // quảnLýToolStripMenuItem
        // 
        quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
        quảnLýToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
        quảnLýToolStripMenuItem.Text = "Quản lý";
        // 
        // nhânSựToolStripMenuItem
        // 
        nhânSựToolStripMenuItem.Name = "nhânSựToolStripMenuItem";
        nhânSựToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
        nhânSựToolStripMenuItem.Text = "Nhân sự";
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
        panel1.BackColor = System.Drawing.Color.Silver;
        panel1.Controls.Add(panel2);
        panel1.Location = new System.Drawing.Point(12, 36);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(355, 471);
        panel1.TabIndex = 1;
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
        label1.Location = new System.Drawing.Point(120, 0);
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
        panel3.Size = new System.Drawing.Size(562, 471);
        panel3.TabIndex = 2;
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
        label2.Location = new System.Drawing.Point(180, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(255, 49);
        label2.TabIndex = 0;
        label2.Text = "Khu vực làm việc";
        // 
        // panel5
        // 
        panel5.BackColor = System.Drawing.Color.White;
        panel5.Location = new System.Drawing.Point(13, 73);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(534, 398);
        panel5.TabIndex = 1;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(954, 519);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        Location = new System.Drawing.Point(22, 22);
        MainMenuStrip = menuStrip1;
        Text = "Trang chủ";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel panel5;

    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}