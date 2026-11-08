using System.ComponentModel;

namespace QuanLyCaPhe.View;

partial class popupChuyenBan
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
        lblBanHienTai = new System.Windows.Forms.Label();
        cboBanHienTai = new System.Windows.Forms.ComboBox();
        lblMuiTen = new System.Windows.Forms.Label();
        lblBanMoi = new System.Windows.Forms.Label();
        cboBanMoi = new System.Windows.Forms.ComboBox();
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
        panelHeader.Size = new System.Drawing.Size(460, 50);
        panelHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblTitle.ForeColor = System.Drawing.Color.White;
        lblTitle.Location = new System.Drawing.Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(460, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "CHUYỂN BÀN";
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panelContent
        // 
        panelContent.BackColor = System.Drawing.Color.White;
        panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelContent.Controls.Add(lblBanHienTai);
        panelContent.Controls.Add(cboBanHienTai);
        panelContent.Controls.Add(lblMuiTen);
        panelContent.Controls.Add(lblBanMoi);
        panelContent.Controls.Add(cboBanMoi);
        panelContent.Controls.Add(lblGhiChu);
        panelContent.Controls.Add(txtGhiChu);
        panelContent.Controls.Add(btnXacNhan);
        panelContent.Controls.Add(btnHuy);
        panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
        panelContent.Location = new System.Drawing.Point(0, 50);
        panelContent.Name = "panelContent";
        panelContent.Size = new System.Drawing.Size(460, 230);
        panelContent.TabIndex = 1;
        // 
        // lblBanHienTai
        // 
        lblBanHienTai.AutoSize = true;
        lblBanHienTai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblBanHienTai.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblBanHienTai.Location = new System.Drawing.Point(30, 20);
        lblBanHienTai.Name = "lblBanHienTai";
        lblBanHienTai.Size = new System.Drawing.Size(127, 17);
        lblBanHienTai.TabIndex = 0;
        lblBanHienTai.Text = "Chuyển từ bàn:";
        // 
        // cboBanHienTai
        // 
        cboBanHienTai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboBanHienTai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        cboBanHienTai.FormattingEnabled = true;
        cboBanHienTai.Location = new System.Drawing.Point(30, 42);
        cboBanHienTai.Name = "cboBanHienTai";
        cboBanHienTai.Size = new System.Drawing.Size(165, 25);
        cboBanHienTai.TabIndex = 1;
        // 
        // lblMuiTen
        // 
        lblMuiTen.AutoSize = true;
        lblMuiTen.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblMuiTen.ForeColor = System.Drawing.Color.FromArgb(70, 130, 180);
        lblMuiTen.Location = new System.Drawing.Point(212, 42);
        lblMuiTen.Name = "lblMuiTen";
        lblMuiTen.Size = new System.Drawing.Size(34, 25);
        lblMuiTen.TabIndex = 2;
        lblMuiTen.Text = "➔";
        lblMuiTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblBanMoi
        // 
        lblBanMoi.AutoSize = true;
        lblBanMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblBanMoi.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblBanMoi.Location = new System.Drawing.Point(260, 20);
        lblBanMoi.Name = "lblBanMoi";
        lblBanMoi.Size = new System.Drawing.Size(117, 17);
        lblBanMoi.TabIndex = 3;
        lblBanMoi.Text = "Đến bàn trống:";
        // 
        // cboBanMoi
        // 
        cboBanMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboBanMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        cboBanMoi.FormattingEnabled = true;
        cboBanMoi.Location = new System.Drawing.Point(260, 42);
        cboBanMoi.Name = "cboBanMoi";
        cboBanMoi.Size = new System.Drawing.Size(165, 25);
        cboBanMoi.TabIndex = 4;
        // 
        // lblGhiChu
        // 
        lblGhiChu.AutoSize = true;
        lblGhiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblGhiChu.Location = new System.Drawing.Point(30, 85);
        lblGhiChu.Name = "lblGhiChu";
        lblGhiChu.Size = new System.Drawing.Size(107, 17);
        lblGhiChu.TabIndex = 5;
        lblGhiChu.Text = "Lý do / Ghi chú:";
        // 
        // txtGhiChu
        // 
        txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        txtGhiChu.Location = new System.Drawing.Point(30, 107);
        txtGhiChu.Multiline = true;
        txtGhiChu.Name = "txtGhiChu";
        txtGhiChu.PlaceholderText = "Nhập lý do chuyển bàn (nếu có)...";
        txtGhiChu.Size = new System.Drawing.Size(395, 52);
        txtGhiChu.TabIndex = 6;
        // 
        // btnXacNhan
        // 
        btnXacNhan.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
        btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
        btnXacNhan.FlatAppearance.BorderSize = 0;
        btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        btnXacNhan.ForeColor = System.Drawing.Color.White;
        btnXacNhan.Location = new System.Drawing.Point(195, 175);
        btnXacNhan.Name = "btnXacNhan";
        btnXacNhan.Size = new System.Drawing.Size(110, 35);
        btnXacNhan.TabIndex = 7;
        btnXacNhan.Text = "Xác nhận";
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
        btnHuy.Location = new System.Drawing.Point(315, 175);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new System.Drawing.Size(110, 35);
        btnHuy.TabIndex = 8;
        btnHuy.Text = "Hủy";
        btnHuy.UseVisualStyleBackColor = false;
        // 
        // popupChuyenBan
        // 
        AcceptButton = btnXacNhan;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        CancelButton = btnHuy;
        ClientSize = new System.Drawing.Size(460, 280);
        Controls.Add(panelContent);
        Controls.Add(panelHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "popupChuyenBan";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chuyển Bàn";
        panelHeader.ResumeLayout(false);
        panelContent.ResumeLayout(false);
        panelContent.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panelContent;
    private System.Windows.Forms.Label lblBanHienTai;
    public System.Windows.Forms.ComboBox cboBanHienTai;
    private System.Windows.Forms.Label lblMuiTen;
    private System.Windows.Forms.Label lblBanMoi;
    public System.Windows.Forms.ComboBox cboBanMoi;
    private System.Windows.Forms.Label lblGhiChu;
    public System.Windows.Forms.TextBox txtGhiChu;
    public System.Windows.Forms.Button btnXacNhan;
    public System.Windows.Forms.Button btnHuy;
}
