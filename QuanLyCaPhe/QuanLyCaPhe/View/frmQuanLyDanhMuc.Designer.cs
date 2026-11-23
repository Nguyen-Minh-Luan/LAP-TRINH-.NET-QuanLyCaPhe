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
        tlpMain = new System.Windows.Forms.TableLayoutPanel();
        panel1 = new System.Windows.Forms.Panel();
        tlpInfo = new System.Windows.Forms.TableLayoutPanel();
        label3 = new System.Windows.Forms.Label();
        txtTenDanhMuc = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        txtMoTa = new System.Windows.Forms.TextBox();
        tlpButtons = new System.Windows.Forms.TableLayoutPanel();
        btnThem = new System.Windows.Forms.Button();
        btnSua = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        panel3 = new System.Windows.Forms.Panel();
        dgvDanhMuc = new System.Windows.Forms.DataGridView();
        idItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
        nameItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
        descItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
        tlpSearch = new System.Windows.Forms.TableLayoutPanel();
        label6 = new System.Windows.Forms.Label();
        txtTimKiemDM = new System.Windows.Forms.TextBox();
        btnTimDanhMuc = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        menuStrip1.SuspendLayout();
        tlpMain.SuspendLayout();
        panel1.SuspendLayout();
        tlpInfo.SuspendLayout();
        tlpButtons.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
        tlpSearch.SuspendLayout();
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
        // tlpMain
        // 
        tlpMain.ColumnCount = 2;
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tlpMain.Controls.Add(panel1, 0, 0);
        tlpMain.Controls.Add(panel2, 1, 0);
        tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpMain.Location = new System.Drawing.Point(0, 33);
        tlpMain.Name = "tlpMain";
        tlpMain.Padding = new System.Windows.Forms.Padding(10);
        tlpMain.RowCount = 1;
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpMain.Size = new System.Drawing.Size(957, 564);
        tlpMain.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.LightGray;
        panel1.Controls.Add(tlpInfo);
        panel1.Controls.Add(label1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(18, 18);
        panel1.Margin = new System.Windows.Forms.Padding(8);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(358, 528);
        panel1.TabIndex = 1;
        // 
        // tlpInfo
        // 
        tlpInfo.ColumnCount = 2;
        tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.195267F));
        tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.804733F));
        tlpInfo.Controls.Add(label3, 0, 0);
        tlpInfo.Controls.Add(txtTenDanhMuc, 1, 0);
        tlpInfo.Controls.Add(label5, 0, 2);
        tlpInfo.Controls.Add(txtMoTa, 0, 3);
        tlpInfo.Controls.Add(tlpButtons, 0, 4);
        tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpInfo.Location = new System.Drawing.Point(0, 72);
        tlpInfo.Name = "tlpInfo";
        tlpInfo.Padding = new System.Windows.Forms.Padding(10);
        tlpInfo.RowCount = 5;
        tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
        tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tlpInfo.Size = new System.Drawing.Size(358, 456);
        tlpInfo.TabIndex = 1;
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(13, 10);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(140, 50);
        label3.TabIndex = 1;
        label3.Text = "Tên danh mục :";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTenDanhMuc
        // 
        txtTenDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenDanhMuc.Location = new System.Drawing.Point(159, 19);
        txtTenDanhMuc.Name = "txtTenDanhMuc";
        txtTenDanhMuc.Size = new System.Drawing.Size(186, 31);
        txtTenDanhMuc.TabIndex = 2;
        // 
        // label5
        // 
        tlpInfo.SetColumnSpan(label5, 2);
        label5.Dock = System.Windows.Forms.DockStyle.Fill;
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(13, 110);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(332, 40);
        label5.TabIndex = 5;
        label5.Text = "Mô tả :";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtMoTa
        // 
        tlpInfo.SetColumnSpan(txtMoTa, 2);
        txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
        txtMoTa.Location = new System.Drawing.Point(13, 153);
        txtMoTa.Multiline = true;
        txtMoTa.Name = "txtMoTa";
        txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtMoTa.Size = new System.Drawing.Size(332, 220);
        txtMoTa.TabIndex = 6;
        // 
        // tlpButtons
        // 
        tlpButtons.ColumnCount = 3;
        tlpInfo.SetColumnSpan(tlpButtons, 2);
        tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
        tlpButtons.Controls.Add(btnThem, 0, 0);
        tlpButtons.Controls.Add(btnSua, 1, 0);
        tlpButtons.Controls.Add(btnXoa, 2, 0);
        tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpButtons.Location = new System.Drawing.Point(13, 379);
        tlpButtons.Name = "tlpButtons";
        tlpButtons.RowCount = 1;
        tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpButtons.Size = new System.Drawing.Size(332, 64);
        tlpButtons.TabIndex = 7;
        // 
        // btnThem
        // 
        btnThem.BackColor = System.Drawing.Color.FromArgb(139, 54, 48);
        btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
        btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThem.ForeColor = System.Drawing.Color.White;
        btnThem.Location = new System.Drawing.Point(3, 8);
        btnThem.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
        btnThem.Name = "btnThem";
        btnThem.Size = new System.Drawing.Size(104, 48);
        btnThem.TabIndex = 7;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = false;
        btnThem.Click += btnThem_Click;
        // 
        // btnSua
        // 
        btnSua.BackColor = System.Drawing.Color.FromArgb(139, 54, 48);
        btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
        btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSua.ForeColor = System.Drawing.Color.White;
        btnSua.Location = new System.Drawing.Point(113, 8);
        btnSua.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
        btnSua.Name = "btnSua";
        btnSua.Size = new System.Drawing.Size(104, 48);
        btnSua.TabIndex = 8;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = false;
        btnSua.Click += btnSua_Click;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = System.Drawing.Color.FromArgb(160, 60, 50);
        btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
        btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoa.ForeColor = System.Drawing.Color.White;
        btnXoa.Location = new System.Drawing.Point(223, 8);
        btnXoa.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(106, 48);
        btnXoa.TabIndex = 9;
        btnXoa.Text = "Xoá";
        btnXoa.UseVisualStyleBackColor = false;
        btnXoa.Click += btnXoa_Click;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.FromArgb(112, 67, 48);
        label1.Dock = System.Windows.Forms.DockStyle.Top;
        label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(358, 72);
        label1.TabIndex = 0;
        label1.Text = "Thông tin";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.LightGray;
        panel2.Controls.Add(panel3);
        panel2.Controls.Add(label2);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(392, 18);
        panel2.Margin = new System.Windows.Forms.Padding(8);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(547, 528);
        panel2.TabIndex = 2;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.WhiteSmoke;
        panel3.Controls.Add(dgvDanhMuc);
        panel3.Controls.Add(tlpSearch);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(0, 72);
        panel3.Name = "panel3";
        panel3.Padding = new System.Windows.Forms.Padding(8);
        panel3.Size = new System.Drawing.Size(547, 456);
        panel3.TabIndex = 2;
        // 
        // dgvDanhMuc
        // 
        dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
        dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idItems, nameItems, descItems });
        dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvDanhMuc.GridColor = System.Drawing.SystemColors.InfoText;
        dgvDanhMuc.Location = new System.Drawing.Point(8, 64);
        dgvDanhMuc.Name = "dgvDanhMuc";
        dgvDanhMuc.RowHeadersWidth = 62;
        dgvDanhMuc.Size = new System.Drawing.Size(531, 384);
        dgvDanhMuc.TabIndex = 3;
        dgvDanhMuc.Text = "dataGridView1";
        dgvDanhMuc.CellClick += dgvdsDanhMuc_CellClick;
        // 
        // idItems
        // 
        idItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        idItems.FillWeight = 22F;
        idItems.HeaderText = "Mã DM";
        idItems.MinimumWidth = 60;
        idItems.Name = "idItems";
        // 
        // nameItems
        // 
        nameItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        nameItems.FillWeight = 36F;
        nameItems.HeaderText = "Tên danh mục";
        nameItems.MinimumWidth = 80;
        nameItems.Name = "nameItems";
        // 
        // descItems
        // 
        descItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        descItems.FillWeight = 42F;
        descItems.HeaderText = "Mô tả";
        descItems.MinimumWidth = 80;
        descItems.Name = "descItems";
        // 
        // tlpSearch
        // 
        tlpSearch.ColumnCount = 3;
        tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
        tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        tlpSearch.Controls.Add(label6, 0, 0);
        tlpSearch.Controls.Add(txtTimKiemDM, 1, 0);
        tlpSearch.Controls.Add(btnTimDanhMuc, 2, 0);
        tlpSearch.Dock = System.Windows.Forms.DockStyle.Top;
        tlpSearch.Location = new System.Drawing.Point(8, 8);
        tlpSearch.Name = "tlpSearch";
        tlpSearch.RowCount = 1;
        tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpSearch.Size = new System.Drawing.Size(531, 56);
        tlpSearch.TabIndex = 0;
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(3, 0);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(124, 56);
        label6.TabIndex = 0;
        label6.Text = "Tìm kiếm:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTimKiemDM
        // 
        txtTimKiemDM.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiemDM.Location = new System.Drawing.Point(133, 12);
        txtTimKiemDM.Name = "txtTimKiemDM";
        txtTimKiemDM.PlaceholderText = "Tìm tên danh mục";
        txtTimKiemDM.Size = new System.Drawing.Size(295, 31);
        txtTimKiemDM.TabIndex = 1;
        txtTimKiemDM.TextChanged += txtTimKiemDM_TextChanged;
        // 
        // btnTimDanhMuc
        // 
        btnTimDanhMuc.BackColor = System.Drawing.Color.FromArgb(112, 67, 48);
        btnTimDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
        btnTimDanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimDanhMuc.ForeColor = System.Drawing.Color.White;
        btnTimDanhMuc.Location = new System.Drawing.Point(434, 8);
        btnTimDanhMuc.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
        btnTimDanhMuc.Name = "btnTimDanhMuc";
        btnTimDanhMuc.Size = new System.Drawing.Size(94, 40);
        btnTimDanhMuc.TabIndex = 2;
        btnTimDanhMuc.Text = "Tìm";
        btnTimDanhMuc.UseVisualStyleBackColor = false;
        btnTimDanhMuc.Click += btnTimDanhMuc_Click;
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.Color.FromArgb(112, 67, 48);
        label2.Dock = System.Windows.Forms.DockStyle.Top;
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(547, 72);
        label2.TabIndex = 1;
        label2.Text = "Danh sách danh mục";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // frmQuanLyDanhMuc
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(957, 597);
        Controls.Add(tlpMain);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new System.Drawing.Size(800, 560);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Quản lý danh mục";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        tlpMain.ResumeLayout(false);
        panel1.ResumeLayout(false);
        tlpInfo.ResumeLayout(false);
        tlpInfo.PerformLayout();
        tlpButtons.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
        tlpSearch.ResumeLayout(false);
        tlpSearch.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TableLayoutPanel tlpMain;
    private System.Windows.Forms.TableLayoutPanel tlpInfo;
    private System.Windows.Forms.TableLayoutPanel tlpButtons;
    private System.Windows.Forms.TableLayoutPanel tlpSearch;

    private System.Windows.Forms.DataGridViewTextBoxColumn idItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn descItems;

    private System.Windows.Forms.DataGridView dgvDanhMuc;

    private System.Windows.Forms.TextBox txtTimKiemDM;
    private System.Windows.Forms.Button btnTimDanhMuc;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.TextBox txtMoTa;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TextBox txtTenDanhMuc;

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