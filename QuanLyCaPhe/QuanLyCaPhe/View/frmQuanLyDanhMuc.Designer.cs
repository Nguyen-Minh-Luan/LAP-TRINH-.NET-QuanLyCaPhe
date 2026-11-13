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
        button4 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        textBox3 = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        idItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
        nameItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
        descItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
        button6 = new System.Windows.Forms.Button();
        textBox4 = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        menuStrip1.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { phụcVụToolStripMenuItem, thựcĐơnToolStripMenuItem, caLàmToolStripMenuItem, thốngKêToolStripMenuItem, profileToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(957, 33);
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
        panel1.Controls.Add(comboBox1);
        panel1.Controls.Add(button4);
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(textBox3);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label1);
        panel1.Location = new System.Drawing.Point(21, 47);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(386, 538);
        panel1.TabIndex = 1;
        // 
        // button4
        // 
        button4.BackColor = System.Drawing.Color.RoyalBlue;
        button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button4.ForeColor = System.Drawing.Color.White;
        button4.Location = new System.Drawing.Point(241, 458);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(135, 48);
        button4.TabIndex = 10;
        button4.Text = "Lưu";
        button4.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.Firebrick;
        button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button3.ForeColor = System.Drawing.Color.White;
        button3.Location = new System.Drawing.Point(8, 458);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(135, 48);
        button3.TabIndex = 9;
        button3.Text = "Xoá";
        button3.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.Firebrick;
        button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.ForeColor = System.Drawing.Color.White;
        button2.Location = new System.Drawing.Point(241, 380);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(135, 48);
        button2.TabIndex = 8;
        button2.Text = "Sửa";
        button2.UseVisualStyleBackColor = false;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.Firebrick;
        button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ForeColor = System.Drawing.Color.White;
        button1.Location = new System.Drawing.Point(8, 380);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(135, 48);
        button1.TabIndex = 7;
        button1.Text = "Thêm";
        button1.UseVisualStyleBackColor = false;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(17, 236);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(359, 101);
        textBox3.TabIndex = 6;
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
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(144, 100);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(232, 31);
        textBox1.TabIndex = 2;
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
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.LightGray;
        panel2.Controls.Add(panel3);
        panel2.Controls.Add(label2);
        panel2.Location = new System.Drawing.Point(424, 47);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(530, 538);
        panel2.TabIndex = 2;
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.Color.Brown;
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(530, 72);
        label2.TabIndex = 1;
        label2.Text = "Danh sách danh mục";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.WhiteSmoke;
        panel3.Controls.Add(dataGridView1);
        panel3.Controls.Add(button6);
        panel3.Controls.Add(textBox4);
        panel3.Controls.Add(label6);
        panel3.Location = new System.Drawing.Point(0, 75);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(530, 463);
        panel3.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = System.Drawing.Color.White;
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idItems, nameItems, descItems });
        dataGridView1.GridColor = System.Drawing.SystemColors.InfoText;
        dataGridView1.Location = new System.Drawing.Point(9, 56);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new System.Drawing.Size(518, 404);
        dataGridView1.TabIndex = 3;
        dataGridView1.Text = "dataGridView1";
        // 
        // idItems
        // 
        idItems.HeaderText = "Mã DM";
        idItems.MinimumWidth = 8;
        idItems.Name = "idItems";
        idItems.Width = 150;
        // 
        // nameItems
        // 
        nameItems.HeaderText = "Tên danh mục";
        nameItems.MinimumWidth = 8;
        nameItems.Name = "nameItems";
        nameItems.Width = 150;
        // 
        // descItems
        // 
        descItems.HeaderText = "Mô tả";
        descItems.MinimumWidth = 8;
        descItems.Name = "descItems";
        descItems.Width = 150;
        // 
        // button6
        // 
        button6.BackColor = System.Drawing.Color.Firebrick;
        button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button6.ForeColor = System.Drawing.Color.White;
        button6.Location = new System.Drawing.Point(442, 14);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(85, 36);
        button6.TabIndex = 2;
        button6.Text = "Tìm";
        button6.UseVisualStyleBackColor = false;
        button6.Click += button6_Click;
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(163, 17);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(255, 31);
        textBox4.TabIndex = 1;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(23, 14);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(123, 31);
        label6.TabIndex = 0;
        label6.Text = "Tìm kiếm:";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(144, 158);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(232, 33);
        comboBox1.TabIndex = 11;
        // 
        // frmQuanLyDanhMuc
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(957, 597);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Quản lý danh mục";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.DataGridViewTextBoxColumn idItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn descItems;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;

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