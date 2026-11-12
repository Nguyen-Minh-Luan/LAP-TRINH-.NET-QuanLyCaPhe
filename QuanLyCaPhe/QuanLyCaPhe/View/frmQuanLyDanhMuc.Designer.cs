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
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { phụcVụToolStripMenuItem, thựcĐơnToolStripMenuItem, caLàmToolStripMenuItem, thốngKêToolStripMenuItem, profileToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(966, 33);
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
        // frmQuanLyDanhMuc
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(966, 571);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Quản lý danh mục";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem caLàmToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem phụcVụToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}