using System.ComponentModel;

namespace QuanLyCaPhe.View;

partial class popupGopBan
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
        panelHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        panelContent = new System.Windows.Forms.Panel();
        lblTenNhom = new System.Windows.Forms.Label();
        txtTenNhom = new System.Windows.Forms.TextBox();
        lblChonTang = new System.Windows.Forms.Label();
        cboChonTang = new System.Windows.Forms.ComboBox();
        lblDanhSachBan = new System.Windows.Forms.Label();
        clbDanhSachBan = new System.Windows.Forms.CheckedListBox();
        lblGhiChu = new System.Windows.Forms.Label();
        txtGhiChu = new System.Windows.Forms.TextBox();
        btnXacNhan = new System.Windows.Forms.Button();
        btnHuy = new System.Windows.Forms.Button();
        panelHeader.SuspendLayout();
        panelContent.SuspendLayout();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
        panelHeader.Controls.Add(lblTitle);
        panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        panelHeader.Location = new System.Drawing.Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new System.Drawing.Size(480, 50);
        panelHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTitle.ForeColor = System.Drawing.Color.White;
        lblTitle.Location = new System.Drawing.Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(480, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "GỘP BÀN";
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panelContent
        // 
        panelContent.BackColor = System.Drawing.Color.White;
        panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelContent.Controls.Add(lblTenNhom);
        panelContent.Controls.Add(txtTenNhom);
        panelContent.Controls.Add(lblChonTang);
        panelContent.Controls.Add(cboChonTang);
        panelContent.Controls.Add(lblDanhSachBan);
        panelContent.Controls.Add(clbDanhSachBan);
        panelContent.Controls.Add(lblGhiChu);
        panelContent.Controls.Add(txtGhiChu);
        panelContent.Controls.Add(btnXacNhan);
        panelContent.Controls.Add(btnHuy);
        panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
        panelContent.Location = new System.Drawing.Point(0, 50);
        panelContent.Name = "panelContent";
        panelContent.Size = new System.Drawing.Size(480, 420);
        panelContent.TabIndex = 1;
        // 
        // lblTenNhom
        // 
        lblTenNhom.AutoSize = true;
        lblTenNhom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTenNhom.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblTenNhom.Location = new System.Drawing.Point(30, 16);
        lblTenNhom.Name = "lblTenNhom";
        lblTenNhom.Size = new System.Drawing.Size(125, 17);
        lblTenNhom.TabIndex = 0;
        lblTenNhom.Text = "Tên nhóm bàn gộp:";
        // 
        // txtTenNhom
        // 
        txtTenNhom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        txtTenNhom.Location = new System.Drawing.Point(30, 38);
        txtTenNhom.Name = "txtTenNhom";
        txtTenNhom.PlaceholderText = "Ví dụ: Nhóm 1, Bàn ghép A...";
        txtTenNhom.Size = new System.Drawing.Size(415, 25);
        txtTenNhom.TabIndex = 1;
        // 
        // lblChonTang
        // 
        lblChonTang.AutoSize = true;
        lblChonTang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblChonTang.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblChonTang.Location = new System.Drawing.Point(30, 78);
        lblChonTang.Name = "lblChonTang";
        lblChonTang.Size = new System.Drawing.Size(117, 17);
        lblChonTang.TabIndex = 2;
        lblChonTang.Text = "Chọn khu vực/tầng:";
        // 
        // cboChonTang
        // 
        cboChonTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboChonTang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        cboChonTang.FormattingEnabled = true;
        cboChonTang.Location = new System.Drawing.Point(30, 100);
        cboChonTang.Name = "cboChonTang";
        cboChonTang.Size = new System.Drawing.Size(415, 25);
        cboChonTang.TabIndex = 3;
        // 
        // lblDanhSachBan
        // 
        lblDanhSachBan.AutoSize = true;
        lblDanhSachBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblDanhSachBan.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblDanhSachBan.Location = new System.Drawing.Point(30, 140);
        lblDanhSachBan.Name = "lblDanhSachBan";
        lblDanhSachBan.Size = new System.Drawing.Size(201, 17);
        lblDanhSachBan.TabIndex = 4;
        lblDanhSachBan.Text = "Chọn các bàn cần gộp vào nhóm:";
        // 
        // clbDanhSachBan
        // 
        clbDanhSachBan.CheckOnClick = true;
        clbDanhSachBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        clbDanhSachBan.FormattingEnabled = true;
        clbDanhSachBan.Location = new System.Drawing.Point(30, 162);
        clbDanhSachBan.Name = "clbDanhSachBan";
        clbDanhSachBan.Size = new System.Drawing.Size(415, 116);
        clbDanhSachBan.TabIndex = 5;
        // 
        // lblGhiChu
        // 
        lblGhiChu.AutoSize = true;
        lblGhiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblGhiChu.Location = new System.Drawing.Point(30, 290);
        lblGhiChu.Name = "lblGhiChu";
        lblGhiChu.Size = new System.Drawing.Size(57, 17);
        lblGhiChu.TabIndex = 6;
        lblGhiChu.Text = "Ghi chú:";
        // 
        // txtGhiChu
        // 
        txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        txtGhiChu.Location = new System.Drawing.Point(30, 312);
        txtGhiChu.Multiline = true;
        txtGhiChu.Name = "txtGhiChu";
        txtGhiChu.PlaceholderText = "Nhập ghi chú gộp bàn (nếu có)...";
        txtGhiChu.Size = new System.Drawing.Size(415, 45);
        txtGhiChu.TabIndex = 7;
        // 
        // btnXacNhan
        // 
        btnXacNhan.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
        btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
        btnXacNhan.FlatAppearance.BorderSize = 0;
        btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnXacNhan.ForeColor = System.Drawing.Color.White;
        btnXacNhan.Location = new System.Drawing.Point(215, 368);
        btnXacNhan.Name = "btnXacNhan";
        btnXacNhan.Size = new System.Drawing.Size(110, 35);
        btnXacNhan.TabIndex = 8;
        btnXacNhan.Text = "Gộp bàn";
        btnXacNhan.UseVisualStyleBackColor = false;
        // 
        // btnHuy
        // 
        btnHuy.BackColor = System.Drawing.Color.Gainsboro;
        btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
        btnHuy.FlatAppearance.BorderSize = 0;
        btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnHuy.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        btnHuy.Location = new System.Drawing.Point(335, 368);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new System.Drawing.Size(110, 35);
        btnHuy.TabIndex = 9;
        btnHuy.Text = "Hủy";
        btnHuy.UseVisualStyleBackColor = false;
        // 
        // popupGopBan
        // 
        AcceptButton = btnXacNhan;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        CancelButton = btnHuy;
        ClientSize = new System.Drawing.Size(480, 470);
        Controls.Add(panelContent);
        Controls.Add(panelHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "popupGopBan";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Gộp Bàn";
        panelHeader.ResumeLayout(false);
        panelContent.ResumeLayout(false);
        panelContent.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panelContent;
    private System.Windows.Forms.Label lblTenNhom;
    public System.Windows.Forms.TextBox txtTenNhom;
    private System.Windows.Forms.Label lblChonTang;
    public System.Windows.Forms.ComboBox cboChonTang;
    private System.Windows.Forms.Label lblDanhSachBan;
    public System.Windows.Forms.CheckedListBox clbDanhSachBan;
    private System.Windows.Forms.Label lblGhiChu;
    public System.Windows.Forms.TextBox txtGhiChu;
    public System.Windows.Forms.Button btnXacNhan;
    public System.Windows.Forms.Button btnHuy;
}
