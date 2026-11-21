using System.ComponentModel;

namespace QuanLyCaPhe.View;

partial class frmQuanLyKhuVucVaBan
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
        tlpMain = new System.Windows.Forms.TableLayoutPanel();
        panel1 = new System.Windows.Forms.Panel();
        tlpKV = new System.Windows.Forms.TableLayoutPanel();
        label4 = new System.Windows.Forms.Label();
        txtTenKhu = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        txtMoTaKV = new System.Windows.Forms.TextBox();
        tlpKVButtons = new System.Windows.Forms.TableLayoutPanel();
        btnThemKV = new System.Windows.Forms.Button();
        btnSuaKV = new System.Windows.Forms.Button();
        btnXoaKV = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        tlpBan = new System.Windows.Forms.TableLayoutPanel();
        label8 = new System.Windows.Forms.Label();
        txtNameBan = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        cmbKhuVuc = new System.Windows.Forms.ComboBox();
        label9 = new System.Windows.Forms.Label();
        txtSoChoBan = new System.Windows.Forms.TextBox();
        label10 = new System.Windows.Forms.Label();
        txtStatusTable = new System.Windows.Forms.TextBox();
        tlpBanButtons = new System.Windows.Forms.TableLayoutPanel();
        btnThemBan = new System.Windows.Forms.Button();
        btnSuaBan = new System.Windows.Forms.Button();
        btnXoaBan = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        dgvKhuVuc = new System.Windows.Forms.DataGridView();
        idKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
        nameKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
        descKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
        tlpSearchKV = new System.Windows.Forms.TableLayoutPanel();
        label13 = new System.Windows.Forms.Label();
        txtTimTenKV = new System.Windows.Forms.TextBox();
        btnTimKV = new System.Windows.Forms.Button();
        label11 = new System.Windows.Forms.Label();
        panel4 = new System.Windows.Forms.Panel();
        dgvBan = new System.Windows.Forms.DataGridView();
        idTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        nameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        nameIdKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
        seatTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        statusTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        tlpSearchBan = new System.Windows.Forms.TableLayoutPanel();
        label14 = new System.Windows.Forms.Label();
        txtTimBan = new System.Windows.Forms.TextBox();
        btnTimKiemBan = new System.Windows.Forms.Button();
        label12 = new System.Windows.Forms.Label();
        tlpMain.SuspendLayout();
        panel1.SuspendLayout();
        tlpKV.SuspendLayout();
        tlpKVButtons.SuspendLayout();
        panel2.SuspendLayout();
        tlpBan.SuspendLayout();
        tlpBanButtons.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).BeginInit();
        tlpSearchKV.SuspendLayout();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBan).BeginInit();
        tlpSearchBan.SuspendLayout();
        SuspendLayout();
        // 
        // tlpMain
        // 
        tlpMain.ColumnCount = 2;
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
        tlpMain.Controls.Add(panel1, 0, 0);
        tlpMain.Controls.Add(panel2, 1, 0);
        tlpMain.Controls.Add(panel3, 0, 1);
        tlpMain.Controls.Add(panel4, 1, 1);
        tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpMain.Location = new System.Drawing.Point(0, 0);
        tlpMain.Name = "tlpMain";
        tlpMain.Padding = new System.Windows.Forms.Padding(10);
        tlpMain.RowCount = 2;
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
        tlpMain.Size = new System.Drawing.Size(1405, 641);
        tlpMain.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.ControlLight;
        panel1.Controls.Add(tlpKV);
        panel1.Controls.Add(label1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(18, 18);
        panel1.Margin = new System.Windows.Forms.Padding(8);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(510, 306);
        panel1.TabIndex = 1;
        // 
        // tlpKV
        // 
        tlpKV.ColumnCount = 2;
        tlpKV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tlpKV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpKV.Controls.Add(label4, 0, 0);
        tlpKV.Controls.Add(txtTenKhu, 1, 0);
        tlpKV.Controls.Add(label5, 0, 1);
        tlpKV.Controls.Add(txtMoTaKV, 1, 1);
        tlpKV.Controls.Add(tlpKVButtons, 0, 2);
        tlpKV.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpKV.Location = new System.Drawing.Point(0, 50);
        tlpKV.Name = "tlpKV";
        tlpKV.Padding = new System.Windows.Forms.Padding(10);
        tlpKV.RowCount = 3;
        tlpKV.RowStyles.Add(new System.Windows.Forms.RowStyle());
        tlpKV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpKV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
        tlpKV.Size = new System.Drawing.Size(510, 256);
        tlpKV.TabIndex = 1;
        // 
        // label4
        // 
        label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label4.AutoSize = true;
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(13, 22);
        label4.Margin = new System.Windows.Forms.Padding(3, 12, 12, 12);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(127, 28);
        label4.TabIndex = 3;
        label4.Text = "Tên khu vực:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTenKhu
        // 
        txtTenKhu.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenKhu.Location = new System.Drawing.Point(155, 20);
        txtTenKhu.Name = "txtTenKhu";
        txtTenKhu.Size = new System.Drawing.Size(342, 31);
        txtTenKhu.TabIndex = 4;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(13, 73);
        label5.Margin = new System.Windows.Forms.Padding(3, 11, 12, 3);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(70, 28);
        label5.TabIndex = 5;
        label5.Text = "Mô tả:";
        // 
        // txtMoTaKV
        // 
        txtMoTaKV.Dock = System.Windows.Forms.DockStyle.Fill;
        txtMoTaKV.Location = new System.Drawing.Point(155, 65);
        txtMoTaKV.Multiline = true;
        txtMoTaKV.Name = "txtMoTaKV";
        txtMoTaKV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtMoTaKV.Size = new System.Drawing.Size(342, 114);
        txtMoTaKV.TabIndex = 6;
        // 
        // tlpKVButtons
        // 
        tlpKVButtons.ColumnCount = 3;
        tlpKV.SetColumnSpan(tlpKVButtons, 2);
        tlpKVButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tlpKVButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tlpKVButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
        tlpKVButtons.Controls.Add(btnThemKV, 0, 0);
        tlpKVButtons.Controls.Add(btnSuaKV, 1, 0);
        tlpKVButtons.Controls.Add(btnXoaKV, 2, 0);
        tlpKVButtons.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpKVButtons.Location = new System.Drawing.Point(13, 185);
        tlpKVButtons.Name = "tlpKVButtons";
        tlpKVButtons.RowCount = 1;
        tlpKVButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpKVButtons.Size = new System.Drawing.Size(484, 58);
        tlpKVButtons.TabIndex = 7;
        // 
        // btnThemKV
        // 
        btnThemKV.BackColor = System.Drawing.Color.Brown;
        btnThemKV.Dock = System.Windows.Forms.DockStyle.Fill;
        btnThemKV.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThemKV.ForeColor = System.Drawing.Color.White;
        btnThemKV.Location = new System.Drawing.Point(4, 8);
        btnThemKV.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
        btnThemKV.Name = "btnThemKV";
        btnThemKV.Size = new System.Drawing.Size(153, 42);
        btnThemKV.TabIndex = 7;
        btnThemKV.Text = "Thêm";
        btnThemKV.UseVisualStyleBackColor = false;
        btnThemKV.Click += btnThemKV_Click;
        // 
        // btnSuaKV
        // 
        btnSuaKV.BackColor = System.Drawing.Color.Brown;
        btnSuaKV.Dock = System.Windows.Forms.DockStyle.Fill;
        btnSuaKV.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSuaKV.ForeColor = System.Drawing.Color.White;
        btnSuaKV.Location = new System.Drawing.Point(165, 8);
        btnSuaKV.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
        btnSuaKV.Name = "btnSuaKV";
        btnSuaKV.Size = new System.Drawing.Size(153, 42);
        btnSuaKV.TabIndex = 8;
        btnSuaKV.Text = "Sửa";
        btnSuaKV.UseVisualStyleBackColor = false;
        btnSuaKV.Click += btnSuaKV_Click;
        // 
        // btnXoaKV
        // 
        btnXoaKV.BackColor = System.Drawing.Color.Brown;
        btnXoaKV.Dock = System.Windows.Forms.DockStyle.Fill;
        btnXoaKV.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoaKV.ForeColor = System.Drawing.Color.White;
        btnXoaKV.Location = new System.Drawing.Point(326, 8);
        btnXoaKV.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
        btnXoaKV.Name = "btnXoaKV";
        btnXoaKV.Size = new System.Drawing.Size(154, 42);
        btnXoaKV.TabIndex = 9;
        btnXoaKV.Text = "Xoá";
        btnXoaKV.UseVisualStyleBackColor = false;
        btnXoaKV.Click += btnXoaKV_Click;
        // 
        // label1
        // 
        label1.AutoEllipsis = true;
        label1.BackColor = System.Drawing.Color.Brown;
        label1.Dock = System.Windows.Forms.DockStyle.Top;
        label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(510, 50);
        label1.TabIndex = 0;
        label1.Text = "Khu vực";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.SystemColors.ControlLight;
        panel2.Controls.Add(tlpBan);
        panel2.Controls.Add(label2);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(544, 18);
        panel2.Margin = new System.Windows.Forms.Padding(8);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(843, 306);
        panel2.TabIndex = 2;
        // 
        // tlpBan
        // 
        tlpBan.ColumnCount = 4;
        tlpBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tlpBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tlpBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpBan.Controls.Add(label8, 0, 0);
        tlpBan.Controls.Add(txtNameBan, 1, 0);
        tlpBan.Controls.Add(label7, 0, 1);
        tlpBan.Controls.Add(cmbKhuVuc, 1, 1);
        tlpBan.Controls.Add(label9, 2, 1);
        tlpBan.Controls.Add(txtSoChoBan, 3, 1);
        tlpBan.Controls.Add(label10, 0, 2);
        tlpBan.Controls.Add(txtStatusTable, 1, 2);
        tlpBan.Controls.Add(tlpBanButtons, 0, 3);
        tlpBan.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpBan.Location = new System.Drawing.Point(0, 50);
        tlpBan.Name = "tlpBan";
        tlpBan.Padding = new System.Windows.Forms.Padding(10);
        tlpBan.RowCount = 4;
        tlpBan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tlpBan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tlpBan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
        tlpBan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
        tlpBan.Size = new System.Drawing.Size(843, 256);
        tlpBan.TabIndex = 2;
        // 
        // label8
        // 
        label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label8.AutoSize = true;
        label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(13, 23);
        label8.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(89, 28);
        label8.TabIndex = 6;
        label8.Text = "Tên bàn:";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtNameBan
        // 
        txtNameBan.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        tlpBan.SetColumnSpan(txtNameBan, 3);
        txtNameBan.Location = new System.Drawing.Point(135, 22);
        txtNameBan.Name = "txtNameBan";
        txtNameBan.Size = new System.Drawing.Size(695, 31);
        txtNameBan.TabIndex = 7;
        // 
        // label7
        // 
        label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label7.AutoSize = true;
        label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(13, 78);
        label7.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(90, 28);
        label7.TabIndex = 4;
        label7.Text = "Khu vực:";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // cmbKhuVuc
        // 
        cmbKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        cmbKhuVuc.FormattingEnabled = true;
        cmbKhuVuc.Location = new System.Drawing.Point(135, 76);
        cmbKhuVuc.Name = "cmbKhuVuc";
        cmbKhuVuc.Size = new System.Drawing.Size(291, 33);
        cmbKhuVuc.TabIndex = 5;
        // 
        // label9
        // 
        label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label9.AutoSize = true;
        label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(444, 78);
        label9.Margin = new System.Windows.Forms.Padding(15, 0, 12, 0);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(79, 28);
        label9.TabIndex = 8;
        label9.Text = "Số chỗ:";
        label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtSoChoBan
        // 
        txtSoChoBan.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtSoChoBan.Location = new System.Drawing.Point(538, 77);
        txtSoChoBan.Name = "txtSoChoBan";
        txtSoChoBan.Size = new System.Drawing.Size(292, 31);
        txtSoChoBan.TabIndex = 9;
        // 
        // label10
        // 
        label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label10.AutoSize = true;
        label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label10.Location = new System.Drawing.Point(13, 133);
        label10.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(107, 28);
        label10.TabIndex = 10;
        label10.Text = "Trạng thái:";
        label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtStatusTable
        // 
        txtStatusTable.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        tlpBan.SetColumnSpan(txtStatusTable, 3);
        txtStatusTable.Location = new System.Drawing.Point(135, 132);
        txtStatusTable.Name = "txtStatusTable";
        txtStatusTable.Size = new System.Drawing.Size(695, 31);
        txtStatusTable.TabIndex = 11;
        // 
        // tlpBanButtons
        // 
        tlpBanButtons.ColumnCount = 3;
        tlpBan.SetColumnSpan(tlpBanButtons, 4);
        tlpBanButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tlpBanButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tlpBanButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
        tlpBanButtons.Controls.Add(btnThemBan, 0, 0);
        tlpBanButtons.Controls.Add(btnSuaBan, 1, 0);
        tlpBanButtons.Controls.Add(btnXoaBan, 2, 0);
        tlpBanButtons.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpBanButtons.Location = new System.Drawing.Point(13, 178);
        tlpBanButtons.Name = "tlpBanButtons";
        tlpBanButtons.RowCount = 1;
        tlpBanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpBanButtons.Size = new System.Drawing.Size(817, 65);
        tlpBanButtons.TabIndex = 12;
        // 
        // btnThemBan
        // 
        btnThemBan.BackColor = System.Drawing.Color.Brown;
        btnThemBan.Dock = System.Windows.Forms.DockStyle.Fill;
        btnThemBan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThemBan.ForeColor = System.Drawing.Color.White;
        btnThemBan.Location = new System.Drawing.Point(4, 8);
        btnThemBan.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
        btnThemBan.Name = "btnThemBan";
        btnThemBan.Size = new System.Drawing.Size(264, 49);
        btnThemBan.TabIndex = 12;
        btnThemBan.Text = "Thêm";
        btnThemBan.UseVisualStyleBackColor = false;
        btnThemBan.Click += btnThemBan_Click;
        // 
        // btnSuaBan
        // 
        btnSuaBan.BackColor = System.Drawing.Color.Brown;
        btnSuaBan.Dock = System.Windows.Forms.DockStyle.Fill;
        btnSuaBan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSuaBan.ForeColor = System.Drawing.Color.White;
        btnSuaBan.Location = new System.Drawing.Point(276, 8);
        btnSuaBan.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
        btnSuaBan.Name = "btnSuaBan";
        btnSuaBan.Size = new System.Drawing.Size(264, 49);
        btnSuaBan.TabIndex = 13;
        btnSuaBan.Text = "Sửa";
        btnSuaBan.UseVisualStyleBackColor = false;
        btnSuaBan.Click += btnSuaBan_Click;
        // 
        // btnXoaBan
        // 
        btnXoaBan.BackColor = System.Drawing.Color.Brown;
        btnXoaBan.Dock = System.Windows.Forms.DockStyle.Fill;
        btnXoaBan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoaBan.ForeColor = System.Drawing.Color.White;
        btnXoaBan.Location = new System.Drawing.Point(548, 8);
        btnXoaBan.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
        btnXoaBan.Name = "btnXoaBan";
        btnXoaBan.Size = new System.Drawing.Size(265, 49);
        btnXoaBan.TabIndex = 14;
        btnXoaBan.Text = "Xoá";
        btnXoaBan.UseVisualStyleBackColor = false;
        btnXoaBan.Click += btnXoaBan_Click;
        // 
        // label2
        // 
        label2.AutoEllipsis = true;
        label2.BackColor = System.Drawing.Color.Brown;
        label2.Dock = System.Windows.Forms.DockStyle.Top;
        label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.White;
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(843, 50);
        label2.TabIndex = 1;
        label2.Text = "Bàn";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel3
        // 
        panel3.Controls.Add(dgvKhuVuc);
        panel3.Controls.Add(tlpSearchKV);
        panel3.Controls.Add(label11);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(18, 340);
        panel3.Margin = new System.Windows.Forms.Padding(8);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(510, 283);
        panel3.TabIndex = 2;
        // 
        // dgvKhuVuc
        // 
        dgvKhuVuc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
        dgvKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idKV, nameKV, descKV });
        dgvKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvKhuVuc.Location = new System.Drawing.Point(0, 110);
        dgvKhuVuc.Name = "dgvKhuVuc";
        dgvKhuVuc.RowHeadersWidth = 62;
        dgvKhuVuc.Size = new System.Drawing.Size(510, 173);
        dgvKhuVuc.TabIndex = 2;
        dgvKhuVuc.CellClick += dgvKhuVuc_CellClick;
        // 
        // idKV
        // 
        idKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        idKV.FillWeight = 25F;
        idKV.HeaderText = "Mã KV";
        idKV.MinimumWidth = 60;
        idKV.Name = "idKV";
        // 
        // nameKV
        // 
        nameKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        nameKV.FillWeight = 35F;
        nameKV.HeaderText = "Tên KV";
        nameKV.MinimumWidth = 60;
        nameKV.Name = "nameKV";
        // 
        // descKV
        // 
        descKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        descKV.FillWeight = 40F;
        descKV.HeaderText = "Mô tả";
        descKV.MinimumWidth = 60;
        descKV.Name = "descKV";
        // 
        // tlpSearchKV
        // 
        tlpSearchKV.ColumnCount = 3;
        tlpSearchKV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tlpSearchKV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpSearchKV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
        tlpSearchKV.Controls.Add(label13, 0, 0);
        tlpSearchKV.Controls.Add(txtTimTenKV, 1, 0);
        tlpSearchKV.Controls.Add(btnTimKV, 2, 0);
        tlpSearchKV.Dock = System.Windows.Forms.DockStyle.Top;
        tlpSearchKV.Location = new System.Drawing.Point(0, 46);
        tlpSearchKV.Name = "tlpSearchKV";
        tlpSearchKV.Padding = new System.Windows.Forms.Padding(6);
        tlpSearchKV.RowCount = 1;
        tlpSearchKV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpSearchKV.Size = new System.Drawing.Size(510, 64);
        tlpSearchKV.TabIndex = 3;
        // 
        // label13
        // 
        label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label13.AutoSize = true;
        label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label13.Location = new System.Drawing.Point(9, 18);
        label13.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(129, 28);
        label13.TabIndex = 4;
        label13.Text = "Tìm khu vực:";
        label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTimTenKV
        // 
        txtTimTenKV.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimTenKV.Location = new System.Drawing.Point(151, 16);
        txtTimTenKV.Name = "txtTimTenKV";
        txtTimTenKV.PlaceholderText = "Nhập tên khu vực";
        txtTimTenKV.Size = new System.Drawing.Size(240, 31);
        txtTimTenKV.TabIndex = 11;
        txtTimTenKV.TextChanged += txtTimKiemKV_TextChanged;
        // 
        // btnTimKV
        // 
        btnTimKV.BackColor = System.Drawing.Color.Brown;
        btnTimKV.Dock = System.Windows.Forms.DockStyle.Fill;
        btnTimKV.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKV.ForeColor = System.Drawing.Color.White;
        btnTimKV.Location = new System.Drawing.Point(398, 9);
        btnTimKV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        btnTimKV.Name = "btnTimKV";
        btnTimKV.Size = new System.Drawing.Size(102, 46);
        btnTimKV.TabIndex = 10;
        btnTimKV.Text = "Tìm";
        btnTimKV.UseVisualStyleBackColor = false;
        btnTimKV.Click += timKiemKV_Click;
        // 
        // label11
        // 
        label11.AutoEllipsis = true;
        label11.BackColor = System.Drawing.Color.Brown;
        label11.Dock = System.Windows.Forms.DockStyle.Top;
        label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.ForeColor = System.Drawing.Color.White;
        label11.Location = new System.Drawing.Point(0, 0);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(510, 46);
        label11.TabIndex = 1;
        label11.Text = "Danh sách khu vực";
        label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel4
        // 
        panel4.Controls.Add(dgvBan);
        panel4.Controls.Add(tlpSearchBan);
        panel4.Controls.Add(label12);
        panel4.Dock = System.Windows.Forms.DockStyle.Fill;
        panel4.Location = new System.Drawing.Point(544, 340);
        panel4.Margin = new System.Windows.Forms.Padding(8);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(843, 283);
        panel4.TabIndex = 3;
        // 
        // dgvBan
        // 
        dgvBan.BackgroundColor = System.Drawing.SystemColors.ControlLight;
        dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idTable, nameTable, nameIdKV, seatTable, statusTable });
        dgvBan.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvBan.Location = new System.Drawing.Point(0, 110);
        dgvBan.Name = "dgvBan";
        dgvBan.RowHeadersWidth = 62;
        dgvBan.Size = new System.Drawing.Size(843, 173);
        dgvBan.TabIndex = 14;
        dgvBan.CellClick += dgvBan_CellClick;
        // 
        // idTable
        // 
        idTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        idTable.FillWeight = 18F;
        idTable.HeaderText = "Mã Bàn";
        idTable.MinimumWidth = 60;
        idTable.Name = "idTable";
        // 
        // nameTable
        // 
        nameTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        nameTable.FillWeight = 25F;
        nameTable.HeaderText = "Tên bàn";
        nameTable.MinimumWidth = 60;
        nameTable.Name = "nameTable";
        // 
        // nameIdKV
        // 
        nameIdKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        nameIdKV.FillWeight = 25F;
        nameIdKV.HeaderText = "Khu vực";
        nameIdKV.MinimumWidth = 60;
        nameIdKV.Name = "nameIdKV";
        // 
        // seatTable
        // 
        seatTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        seatTable.FillWeight = 15F;
        seatTable.HeaderText = "Chỗ ngồi";
        seatTable.MinimumWidth = 60;
        seatTable.Name = "seatTable";
        // 
        // statusTable
        // 
        statusTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        statusTable.FillWeight = 17F;
        statusTable.HeaderText = "Trạng thái";
        statusTable.MinimumWidth = 60;
        statusTable.Name = "statusTable";
        // 
        // tlpSearchBan
        // 
        tlpSearchBan.ColumnCount = 3;
        tlpSearchBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        tlpSearchBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpSearchBan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
        tlpSearchBan.Controls.Add(label14, 0, 0);
        tlpSearchBan.Controls.Add(txtTimBan, 1, 0);
        tlpSearchBan.Controls.Add(btnTimKiemBan, 2, 0);
        tlpSearchBan.Dock = System.Windows.Forms.DockStyle.Top;
        tlpSearchBan.Location = new System.Drawing.Point(0, 46);
        tlpSearchBan.Name = "tlpSearchBan";
        tlpSearchBan.Padding = new System.Windows.Forms.Padding(6);
        tlpSearchBan.RowCount = 1;
        tlpSearchBan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpSearchBan.Size = new System.Drawing.Size(843, 64);
        tlpSearchBan.TabIndex = 3;
        // 
        // label14
        // 
        label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
        label14.AutoSize = true;
        label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label14.Location = new System.Drawing.Point(9, 18);
        label14.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(127, 28);
        label14.TabIndex = 5;
        label14.Text = "Tìm tên bàn:";
        label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTimBan
        // 
        txtTimBan.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimBan.Location = new System.Drawing.Point(149, 16);
        txtTimBan.Name = "txtTimBan";
        txtTimBan.PlaceholderText = "Nhập tên bàn";
        txtTimBan.Size = new System.Drawing.Size(575, 31);
        txtTimBan.TabIndex = 12;
        txtTimBan.TextChanged += txtTimKiemBan_TextChanged;
        // 
        // btnTimKiemBan
        // 
        btnTimKiemBan.BackColor = System.Drawing.Color.Brown;
        btnTimKiemBan.Dock = System.Windows.Forms.DockStyle.Fill;
        btnTimKiemBan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiemBan.ForeColor = System.Drawing.Color.White;
        btnTimKiemBan.Location = new System.Drawing.Point(731, 9);
        btnTimKiemBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        btnTimKiemBan.Name = "btnTimKiemBan";
        btnTimKiemBan.Size = new System.Drawing.Size(102, 46);
        btnTimKiemBan.TabIndex = 13;
        btnTimKiemBan.Text = "Tìm";
        btnTimKiemBan.UseVisualStyleBackColor = false;
        btnTimKiemBan.Click += timKiemBan_Click;
        // 
        // label12
        // 
        label12.AutoEllipsis = true;
        label12.BackColor = System.Drawing.Color.Brown;
        label12.Dock = System.Windows.Forms.DockStyle.Top;
        label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.ForeColor = System.Drawing.Color.White;
        label12.Location = new System.Drawing.Point(0, 0);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(843, 46);
        label12.TabIndex = 2;
        label12.Text = "Bàn";
        label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // frmQuanLyKhuVucVaBan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        AutoScroll = true;
        AutoScrollMinSize = new System.Drawing.Size(1100, 640);
        ClientSize = new System.Drawing.Size(1405, 641);
        Controls.Add(tlpMain);
        MinimumSize = new System.Drawing.Size(900, 600);
        Text = "Quản lý Khu vực";
        tlpMain.ResumeLayout(false);
        panel1.ResumeLayout(false);
        tlpKV.ResumeLayout(false);
        tlpKV.PerformLayout();
        tlpKVButtons.ResumeLayout(false);
        panel2.ResumeLayout(false);
        tlpBan.ResumeLayout(false);
        tlpBan.PerformLayout();
        tlpBanButtons.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).EndInit();
        tlpSearchKV.ResumeLayout(false);
        tlpSearchKV.PerformLayout();
        panel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvBan).EndInit();
        tlpSearchBan.ResumeLayout(false);
        tlpSearchBan.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn seatTable;

    private System.Windows.Forms.TableLayoutPanel tlpMain;
    private System.Windows.Forms.TableLayoutPanel tlpKV;
    private System.Windows.Forms.TableLayoutPanel tlpKVButtons;
    private System.Windows.Forms.TableLayoutPanel tlpBan;
    private System.Windows.Forms.TableLayoutPanel tlpBanButtons;
    private System.Windows.Forms.TableLayoutPanel tlpSearchKV;
    private System.Windows.Forms.TableLayoutPanel tlpSearchBan;

    private System.Windows.Forms.DataGridViewTextBoxColumn idKV;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameKV;
    private System.Windows.Forms.DataGridViewTextBoxColumn descKV;
    private System.Windows.Forms.DataGridViewTextBoxColumn idTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameIdKV;
    private System.Windows.Forms.DataGridViewTextBoxColumn statusTable;

    private System.Windows.Forms.DataGridView dgvKhuVuc;
    private System.Windows.Forms.DataGridView dgvBan;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.Button btnXoaKV;
    private System.Windows.Forms.Button btnSuaKV;
    private System.Windows.Forms.Button btnThemKV;
    private System.Windows.Forms.Button btnThemBan;
    private System.Windows.Forms.Button btnSuaBan;
    private System.Windows.Forms.Button btnXoaBan;
    private System.Windows.Forms.Button btnTimKV;
    private System.Windows.Forms.Button btnTimKiemBan;

    private System.Windows.Forms.TextBox txtMoTaKV;
    private System.Windows.Forms.TextBox txtNameBan;
    private System.Windows.Forms.TextBox txtSoChoBan;
    private System.Windows.Forms.TextBox txtTimTenKV;
    private System.Windows.Forms.TextBox txtTimBan;
    private System.Windows.Forms.TextBox txtTenKhu;

    private System.Windows.Forms.ComboBox cmbKhuVuc;
    private System.Windows.Forms.TextBox txtStatusTable;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;

    #endregion
}