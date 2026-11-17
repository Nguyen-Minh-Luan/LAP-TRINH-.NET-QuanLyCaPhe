using System.ComponentModel;

namespace QuanLyCaPhe;

partial class frmThongTinCaNhan
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinCaNhan));
        tlpMain = new System.Windows.Forms.TableLayoutPanel();
        panel1 = new System.Windows.Forms.Panel();
        tlpThongTin = new System.Windows.Forms.TableLayoutPanel();
        panel7 = new System.Windows.Forms.Panel();
        lblStatus = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        panel8 = new System.Windows.Forms.Panel();
        tlpNgayGio = new System.Windows.Forms.TableLayoutPanel();
        pictureBox5 = new System.Windows.Forms.PictureBox();
        lblDateToday = new System.Windows.Forms.Label();
        pictureBox6 = new System.Windows.Forms.PictureBox();
        lblTimeToday = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        txtTenDN = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        txtHoTenNV = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        txtSDT = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        panel4 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        panel2 = new System.Windows.Forms.Panel();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        datework = new System.Windows.Forms.DataGridViewTextBoxColumn();
        shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
        startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        panel5 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        panel3 = new System.Windows.Forms.Panel();
        tlpDoiMatKhau = new System.Windows.Forms.TableLayoutPanel();
        label10 = new System.Windows.Forms.Label();
        textBox4 = new System.Windows.Forms.TextBox();
        label11 = new System.Windows.Forms.Label();
        textBox5 = new System.Windows.Forms.TextBox();
        label12 = new System.Windows.Forms.Label();
        textBox6 = new System.Windows.Forms.TextBox();
        button3 = new System.Windows.Forms.Button();
        panel6 = new System.Windows.Forms.Panel();
        label3 = new System.Windows.Forms.Label();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        tlpMain.SuspendLayout();
        panel1.SuspendLayout();
        tlpThongTin.SuspendLayout();
        panel7.SuspendLayout();
        panel8.SuspendLayout();
        tlpNgayGio.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        panel3.SuspendLayout();
        tlpDoiMatKhau.SuspendLayout();
        panel6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // tlpMain
        // 
        tlpMain.ColumnCount = 2;
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tlpMain.Controls.Add(panel1, 0, 0);
        tlpMain.Controls.Add(panel2, 1, 0);
        tlpMain.Controls.Add(panel3, 1, 1);
        tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpMain.Location = new System.Drawing.Point(12, 12);
        tlpMain.Name = "tlpMain";
        tlpMain.RowCount = 2;
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpMain.Size = new System.Drawing.Size(1135, 587);
        tlpMain.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.Silver;
        panel1.Controls.Add(tlpThongTin);
        panel1.Controls.Add(panel4);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(6, 6);
        panel1.Margin = new System.Windows.Forms.Padding(6);
        panel1.Name = "panel1";
        tlpMain.SetRowSpan(panel1, 2);
        panel1.Size = new System.Drawing.Size(442, 575);
        panel1.TabIndex = 1;
        // 
        // tlpThongTin
        // 
        tlpThongTin.ColumnCount = 2;
        tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tlpThongTin.Controls.Add(panel7, 0, 0);
        tlpThongTin.Controls.Add(panel8, 0, 1);
        tlpThongTin.Controls.Add(label4, 0, 2);
        tlpThongTin.Controls.Add(txtTenDN, 1, 2);
        tlpThongTin.Controls.Add(label5, 0, 3);
        tlpThongTin.Controls.Add(txtHoTenNV, 1, 3);
        tlpThongTin.Controls.Add(label6, 0, 4);
        tlpThongTin.Controls.Add(txtSDT, 1, 4);
        tlpThongTin.Controls.Add(button1, 0, 6);
        tlpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpThongTin.Location = new System.Drawing.Point(0, 52);
        tlpThongTin.Name = "tlpThongTin";
        tlpThongTin.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
        tlpThongTin.RowCount = 7;
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tlpThongTin.Size = new System.Drawing.Size(442, 523);
        tlpThongTin.TabIndex = 14;
        // 
        // panel7
        // 
        panel7.BackColor = System.Drawing.Color.Moccasin;
        tlpThongTin.SetColumnSpan(panel7, 2);
        panel7.Controls.Add(lblStatus);
        panel7.Controls.Add(label8);
        panel7.Dock = System.Windows.Forms.DockStyle.Fill;
        panel7.Location = new System.Drawing.Point(23, 13);
        panel7.Name = "panel7";
        panel7.Size = new System.Drawing.Size(396, 104);
        panel7.TabIndex = 10;
        // 
        // lblStatus
        // 
        lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblStatus.ForeColor = System.Drawing.Color.Green;
        lblStatus.Location = new System.Drawing.Point(0, 40);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(396, 64);
        lblStatus.TabIndex = 1;
        lblStatus.Text = "Đang hoạt động";
        lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label8
        // 
        label8.Dock = System.Windows.Forms.DockStyle.Top;
        label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(0, 0);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(396, 40);
        label8.TabIndex = 0;
        label8.Text = "Trạng thái tài khoản";
        label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // panel8
        // 
        panel8.BackColor = System.Drawing.Color.Moccasin;
        tlpThongTin.SetColumnSpan(panel8, 2);
        panel8.Controls.Add(tlpNgayGio);
        panel8.Dock = System.Windows.Forms.DockStyle.Fill;
        panel8.Location = new System.Drawing.Point(23, 123);
        panel8.Name = "panel8";
        panel8.Size = new System.Drawing.Size(396, 54);
        panel8.TabIndex = 13;
        // 
        // tlpNgayGio
        // 
        tlpNgayGio.ColumnCount = 2;
        tlpNgayGio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpNgayGio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tlpNgayGio.Controls.Add(pictureBox5, 0, 0);
        tlpNgayGio.Controls.Add(lblDateToday, 1, 0);
        tlpNgayGio.Controls.Add(pictureBox6, 0, 1);
        tlpNgayGio.Controls.Add(lblTimeToday, 1, 1);
        tlpNgayGio.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpNgayGio.Location = new System.Drawing.Point(0, 0);
        tlpNgayGio.Name = "tlpNgayGio";
        tlpNgayGio.RowCount = 2;
        tlpNgayGio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpNgayGio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpNgayGio.Size = new System.Drawing.Size(396, 54);
        tlpNgayGio.TabIndex = 4;
        // 
        // pictureBox5
        // 
        pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
        pictureBox5.Image = ((System.Drawing.Image)resources.GetObject("pictureBox5.Image"));
        pictureBox5.Location = new System.Drawing.Point(3, 3);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new System.Drawing.Size(152, 21);
        pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox5.TabIndex = 0;
        pictureBox5.TabStop = false;
        // 
        // lblDateToday
        // 
        lblDateToday.Dock = System.Windows.Forms.DockStyle.Fill;
        lblDateToday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDateToday.Location = new System.Drawing.Point(161, 0);
        lblDateToday.Name = "lblDateToday";
        lblDateToday.Size = new System.Drawing.Size(232, 27);
        lblDateToday.TabIndex = 2;
        lblDateToday.Text = "05/11/2026";
        lblDateToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pictureBox6
        // 
        pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
        pictureBox6.Image = ((System.Drawing.Image)resources.GetObject("pictureBox6.Image"));
        pictureBox6.Location = new System.Drawing.Point(3, 30);
        pictureBox6.Name = "pictureBox6";
        pictureBox6.Size = new System.Drawing.Size(152, 21);
        pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox6.TabIndex = 1;
        pictureBox6.TabStop = false;
        // 
        // lblTimeToday
        // 
        lblTimeToday.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTimeToday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTimeToday.Location = new System.Drawing.Point(161, 27);
        lblTimeToday.Name = "lblTimeToday";
        lblTimeToday.Size = new System.Drawing.Size(232, 27);
        lblTimeToday.TabIndex = 3;
        lblTimeToday.Text = "17:00:25";
        lblTimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(23, 180);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(154, 55);
        label4.TabIndex = 1;
        label4.Text = "Tên đăng nhập:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTenDN
        // 
        txtTenDN.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenDN.Location = new System.Drawing.Point(183, 192);
        txtTenDN.Name = "txtTenDN";
        txtTenDN.Size = new System.Drawing.Size(236, 31);
        txtTenDN.TabIndex = 2;
        // 
        // label5
        // 
        label5.Dock = System.Windows.Forms.DockStyle.Fill;
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(23, 235);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(154, 55);
        label5.TabIndex = 3;
        label5.Text = "Tên nhân viên:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtHoTenNV
        // 
        txtHoTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtHoTenNV.Location = new System.Drawing.Point(183, 247);
        txtHoTenNV.Name = "txtHoTenNV";
        txtHoTenNV.Size = new System.Drawing.Size(236, 31);
        txtHoTenNV.TabIndex = 4;
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(23, 290);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(154, 55);
        label6.TabIndex = 5;
        label6.Text = "Số điện thoại:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtSDT
        // 
        txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtSDT.Location = new System.Drawing.Point(183, 302);
        txtSDT.Name = "txtSDT";
        txtSDT.Size = new System.Drawing.Size(236, 31);
        txtSDT.TabIndex = 6;
        txtSDT.TextChanged += textBox3_TextChanged;
        // 
        // button1
        // 
        button1.Anchor = System.Windows.Forms.AnchorStyles.None;
        button1.BackColor = System.Drawing.Color.DarkRed;
        tlpThongTin.SetColumnSpan(button1, 2);
        button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)0)), ((int)((byte)0)));
        button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)64)), ((int)((byte)0)));
        button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ForeColor = System.Drawing.Color.White;
        button1.Location = new System.Drawing.Point(68, 430);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(305, 53);
        button1.TabIndex = 9;
        button1.Text = "Cập nhật thông tin";
        button1.UseVisualStyleBackColor = false;
        // 
        // panel4
        // 
        panel4.BackColor = System.Drawing.Color.Brown;
        panel4.Controls.Add(label1);
        panel4.Controls.Add(pictureBox1);
        panel4.Dock = System.Windows.Forms.DockStyle.Top;
        panel4.Location = new System.Drawing.Point(0, 0);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(442, 52);
        panel4.TabIndex = 0;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(80, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(362, 52);
        label1.TabIndex = 1;
        label1.Text = "Thông tin cá nhân";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
        pictureBox1.Size = new System.Drawing.Size(80, 52);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.Silver;
        panel2.Controls.Add(dataGridView1);
        panel2.Controls.Add(panel5);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(460, 6);
        panel2.Margin = new System.Windows.Forms.Padding(6);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(669, 281);
        panel2.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.BackgroundColor = System.Drawing.Color.White;
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { datework, shift, startdate, enddate });
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView1.Location = new System.Drawing.Point(0, 52);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new System.Drawing.Size(669, 229);
        dataGridView1.TabIndex = 2;
        dataGridView1.Text = "dataGridView1";
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // datework
        // 
        datework.HeaderText = "Ngày làm";
        datework.MinimumWidth = 8;
        datework.Name = "datework";
        datework.ReadOnly = true;
        // 
        // shift
        // 
        shift.HeaderText = "Ca làm";
        shift.MinimumWidth = 8;
        shift.Name = "shift";
        shift.ReadOnly = true;
        // 
        // startdate
        // 
        startdate.HeaderText = "Giờ bắt đầu";
        startdate.MinimumWidth = 8;
        startdate.Name = "startdate";
        startdate.ReadOnly = true;
        // 
        // enddate
        // 
        enddate.HeaderText = "Giờ kết thúc";
        enddate.MinimumWidth = 8;
        enddate.Name = "enddate";
        enddate.ReadOnly = true;
        // 
        // panel5
        // 
        panel5.BackColor = System.Drawing.Color.Brown;
        panel5.Controls.Add(label2);
        panel5.Controls.Add(pictureBox2);
        panel5.Dock = System.Windows.Forms.DockStyle.Top;
        panel5.Location = new System.Drawing.Point(0, 0);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(669, 52);
        panel5.TabIndex = 1;
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.White;
        label2.Location = new System.Drawing.Point(80, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(589, 52);
        label2.TabIndex = 2;
        label2.Text = "Lịch làm việc cá nhân";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox2
        // 
        pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(0, 0);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
        pictureBox2.Size = new System.Drawing.Size(80, 52);
        pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.Silver;
        panel3.Controls.Add(tlpDoiMatKhau);
        panel3.Controls.Add(panel6);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(460, 299);
        panel3.Margin = new System.Windows.Forms.Padding(6);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(669, 282);
        panel3.TabIndex = 3;
        // 
        // tlpDoiMatKhau
        // 
        tlpDoiMatKhau.ColumnCount = 2;
        tlpDoiMatKhau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpDoiMatKhau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tlpDoiMatKhau.Controls.Add(label10, 0, 0);
        tlpDoiMatKhau.Controls.Add(textBox4, 1, 0);
        tlpDoiMatKhau.Controls.Add(label11, 0, 1);
        tlpDoiMatKhau.Controls.Add(textBox5, 1, 1);
        tlpDoiMatKhau.Controls.Add(label12, 0, 2);
        tlpDoiMatKhau.Controls.Add(textBox6, 1, 2);
        tlpDoiMatKhau.Controls.Add(button3, 0, 3);
        tlpDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpDoiMatKhau.Location = new System.Drawing.Point(0, 49);
        tlpDoiMatKhau.Name = "tlpDoiMatKhau";
        tlpDoiMatKhau.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
        tlpDoiMatKhau.RowCount = 4;
        tlpDoiMatKhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
        tlpDoiMatKhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
        tlpDoiMatKhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
        tlpDoiMatKhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
        tlpDoiMatKhau.Size = new System.Drawing.Size(669, 233);
        tlpDoiMatKhau.TabIndex = 18;
        // 
        // label10
        // 
        label10.Dock = System.Windows.Forms.DockStyle.Fill;
        label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label10.Location = new System.Drawing.Point(23, 10);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(245, 51);
        label10.TabIndex = 13;
        label10.Text = "Mật khẩu hiện tại:";
        label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBox4
        // 
        textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBox4.Location = new System.Drawing.Point(274, 20);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(372, 31);
        textBox4.TabIndex = 13;
        // 
        // label11
        // 
        label11.Dock = System.Windows.Forms.DockStyle.Fill;
        label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.Location = new System.Drawing.Point(23, 61);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(245, 51);
        label11.TabIndex = 14;
        label11.Text = "Mật khẩu mới:";
        label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBox5
        // 
        textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBox5.Location = new System.Drawing.Point(274, 71);
        textBox5.Name = "textBox5";
        textBox5.Size = new System.Drawing.Size(372, 31);
        textBox5.TabIndex = 15;
        // 
        // label12
        // 
        label12.Dock = System.Windows.Forms.DockStyle.Fill;
        label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(23, 112);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(245, 51);
        label12.TabIndex = 16;
        label12.Text = "Xác nhận mật khẩu:";
        label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBox6
        // 
        textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBox6.Location = new System.Drawing.Point(274, 122);
        textBox6.Name = "textBox6";
        textBox6.Size = new System.Drawing.Size(372, 31);
        textBox6.TabIndex = 17;
        // 
        // button3
        // 
        button3.Anchor = System.Windows.Forms.AnchorStyles.None;
        button3.BackColor = System.Drawing.Color.DarkRed;
        tlpDoiMatKhau.SetColumnSpan(button3, 2);
        button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
        button3.FlatAppearance.BorderSize = 0;
        button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)0)), ((int)((byte)0)));
        button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)64)), ((int)((byte)0)));
        button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button3.ForeColor = System.Drawing.Color.White;
        button3.Location = new System.Drawing.Point(182, 166);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(305, 53);
        button3.TabIndex = 13;
        button3.Text = "Cập nhật mật khẩu";
        button3.UseVisualStyleBackColor = false;
        // 
        // panel6
        // 
        panel6.BackColor = System.Drawing.Color.Brown;
        panel6.Controls.Add(label3);
        panel6.Controls.Add(pictureBox3);
        panel6.Dock = System.Windows.Forms.DockStyle.Top;
        panel6.Location = new System.Drawing.Point(0, 0);
        panel6.Name = "panel6";
        panel6.Size = new System.Drawing.Size(669, 49);
        panel6.TabIndex = 2;
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.White;
        label3.Location = new System.Drawing.Point(80, 0);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(589, 49);
        label3.TabIndex = 3;
        label3.Text = "Đổi mật khẩu";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox3
        // 
        pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
        pictureBox3.Image = ((System.Drawing.Image)resources.GetObject("pictureBox3.Image"));
        pictureBox3.Location = new System.Drawing.Point(0, 0);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
        pictureBox3.Size = new System.Drawing.Size(80, 49);
        pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 3;
        pictureBox3.TabStop = false;
        // 
        // frmThongTinCaNhan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1159, 611);
        Controls.Add(tlpMain);
        MinimumSize = new System.Drawing.Size(1000, 650);
        Padding = new System.Windows.Forms.Padding(12);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Thông tin cá nhân";
        tlpMain.ResumeLayout(false);
        panel1.ResumeLayout(false);
        tlpThongTin.ResumeLayout(false);
        tlpThongTin.PerformLayout();
        panel7.ResumeLayout(false);
        panel8.ResumeLayout(false);
        tlpNgayGio.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
        panel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel5.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        panel3.ResumeLayout(false);
        tlpDoiMatKhau.ResumeLayout(false);
        tlpDoiMatKhau.PerformLayout();
        panel6.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tlpMain;
    private System.Windows.Forms.TableLayoutPanel tlpThongTin;
    private System.Windows.Forms.TableLayoutPanel tlpNgayGio;
    private System.Windows.Forms.TableLayoutPanel tlpDoiMatKhau;

    private System.Windows.Forms.DataGridViewTextBoxColumn datework;
    private System.Windows.Forms.DataGridViewTextBoxColumn shift;
    private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
    private System.Windows.Forms.DataGridViewTextBoxColumn enddate;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Label lblDateToday;
    private System.Windows.Forms.Label lblTimeToday;

    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.PictureBox pictureBox6;

    private System.Windows.Forms.Panel panel8;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox textBox6;

    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox textBox5;

    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label lblStatus;

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Panel panel7;

    private System.Windows.Forms.Button button1;


    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtSDT;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtHoTenNV;
    private System.Windows.Forms.TextBox txtTenDN;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.PictureBox pictureBox3;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Panel panel6;

    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel1;

    #endregion
}