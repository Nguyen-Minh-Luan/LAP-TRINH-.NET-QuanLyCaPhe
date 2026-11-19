using System.ComponentModel;

namespace QuanLyCaPhe;

public partial class frmLogin
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
        lblTitle = new System.Windows.Forms.Label();
        lblIntroduce = new System.Windows.Forms.Label();
        btnLogin = new System.Windows.Forms.Button();
        pictureUser = new System.Windows.Forms.PictureBox();
        picturePassword = new System.Windows.Forms.PictureBox();
        pictureProfile = new System.Windows.Forms.PictureBox();
        lblForgotPass = new System.Windows.Forms.Label();
        tblMain = new System.Windows.Forms.TableLayoutPanel();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        txtName = new System.Windows.Forms.TextBox();
        txtPassword = new System.Windows.Forms.TextBox();
        tblTop = new System.Windows.Forms.TableLayoutPanel();
        tblBottom = new System.Windows.Forms.TableLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picturePassword).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureProfile).BeginInit();
        tblMain.SuspendLayout();
        tblTop.SuspendLayout();
        tblBottom.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(74, 48, 37);
        lblTitle.Location = new System.Drawing.Point(3, 62);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(1221, 48);
        lblTitle.TabIndex = 10;
        lblTitle.Text = "Đăng nhập tài khoản";
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblIntroduce
        // 
        lblIntroduce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblIntroduce.Font = new System.Drawing.Font("Segoe UI", 10.5F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblIntroduce.ForeColor = System.Drawing.Color.FromArgb(125, 101, 86);
        lblIntroduce.Location = new System.Drawing.Point(3, 110);
        lblIntroduce.Name = "lblIntroduce";
        lblIntroduce.Size = new System.Drawing.Size(1221, 36);
        lblIntroduce.TabIndex = 11;
        lblIntroduce.Text = "Chào bạn đến hệ thống Quản lý quán cà phê";
        lblIntroduce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnLogin
        // 
        btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnLogin.BackColor = System.Drawing.Color.FromArgb(139, 75, 54);
        tblBottom.SetColumnSpan(btnLogin, 2);
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(105, 55, 40);
        btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(165, 91, 66);
        btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLogin.ForeColor = System.Drawing.Color.White;
        btnLogin.Location = new System.Drawing.Point(3, 73);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new System.Drawing.Size(1221, 48);
        btnLogin.TabIndex = 14;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLogin.Margin = new System.Windows.Forms.Padding(45, 8, 45, 8);
        btnLogin.Click += btnLogin_Click;
        // 
        // pictureUser
        // 
        pictureUser.Anchor = System.Windows.Forms.AnchorStyles.None;
        pictureUser.Image = ((System.Drawing.Image)resources.GetObject("pictureUser.Image"));
        pictureUser.Location = new System.Drawing.Point(43, 229);
        pictureUser.Name = "pictureUser";
        pictureUser.Size = new System.Drawing.Size(38, 42);
        pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureUser.TabIndex = 15;
        pictureUser.TabStop = false;
        // 
        // picturePassword
        // 
        picturePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
        picturePassword.Image = ((System.Drawing.Image)resources.GetObject("picturePassword.Image"));
        picturePassword.Location = new System.Drawing.Point(45, 444);
        picturePassword.Name = "picturePassword";
        picturePassword.Size = new System.Drawing.Size(34, 43);
        picturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picturePassword.TabIndex = 16;
        picturePassword.TabStop = false;
        // 
        // pictureProfile
        // 
        pictureProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
        pictureProfile.Image = ((System.Drawing.Image)resources.GetObject("pictureProfile.Image"));
        pictureProfile.Location = new System.Drawing.Point(516, 3);
        pictureProfile.Name = "pictureProfile";
        pictureProfile.Size = new System.Drawing.Size(194, 60);
        pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureProfile.TabIndex = 17;
        pictureProfile.TabStop = false;
        // 
        // lblForgotPass
        // 
        lblForgotPass.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lblForgotPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblForgotPass.ForeColor = System.Drawing.Color.FromArgb(151, 77, 54);
        lblForgotPass.Location = new System.Drawing.Point(1052, 0);
        lblForgotPass.Name = "lblForgotPass";
        lblForgotPass.Size = new System.Drawing.Size(172, 30);
        lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
        lblForgotPass.TabIndex = 18;
        lblForgotPass.Text = "Quên mật khẩu?";
        lblForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        lblForgotPass.Click += lblForgotPass_Click;
        // 
        // tblMain
        // 
        tblMain.ColumnCount = 3;
        tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
        tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
        tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tblMain.Controls.Add(picturePassword, 0, 2);
        tblMain.Controls.Add(pictureUser, 0, 1);
        tblMain.Controls.Add(label2, 1, 2);
        tblMain.Controls.Add(label1, 1, 1);
        tblMain.Controls.Add(txtPassword, 2, 2);
        tblMain.Controls.Add(txtName, 2, 1);
        tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tblMain.Location = new System.Drawing.Point(0, 0);
        tblMain.Margin = new System.Windows.Forms.Padding(0);
        tblMain.Padding = new System.Windows.Forms.Padding(26, 8, 26, 8);
        tblMain.BackColor = System.Drawing.Color.FromArgb(245, 240, 232);
        tblMain.Name = "tblMain";
        tblMain.RowCount = 4;
        tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
        tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
        tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
        tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
        tblMain.Size = new System.Drawing.Size(1227, 717);
        tblMain.TabIndex = 19;
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(74, 48, 37);
        label2.Location = new System.Drawing.Point(128, 358);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(359, 215);
        label2.TabIndex = 20;
        label2.Text = "Mật khẩu:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(74, 48, 37);
        label1.Location = new System.Drawing.Point(128, 143);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(359, 215);
        label1.TabIndex = 17;
        label1.Text = "Tên đăng nhập:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtName
        // 
        txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtName.Location = new System.Drawing.Point(493, 232);
        txtName.Multiline = true;
        txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtName.BackColor = System.Drawing.Color.White;
        txtName.ForeColor = System.Drawing.Color.FromArgb(55, 40, 32);
        txtName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtName.Margin = new System.Windows.Forms.Padding(12, 8, 18, 8);
        txtName.Name = "txtName";
        txtName.PlaceholderText = "Nhập tên đăng nhập...";
        txtName.Size = new System.Drawing.Size(731, 37);
        txtName.TabIndex = 18;
        // 
        // txtPassword
        // 
        txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtPassword.Location = new System.Drawing.Point(493, 447);
        txtPassword.Multiline = true;
        txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtPassword.BackColor = System.Drawing.Color.White;
        txtPassword.ForeColor = System.Drawing.Color.FromArgb(55, 40, 32);
        txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtPassword.Margin = new System.Windows.Forms.Padding(12, 8, 18, 8);
        txtPassword.Name = "txtPassword";
        txtPassword.PlaceholderText = "Nhập mật khẩu...";
        txtPassword.Size = new System.Drawing.Size(731, 37);
        txtPassword.TabIndex = 19;
        // 
        // tblTop
        // 
        tblTop.ColumnCount = 1;
        tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tblTop.Controls.Add(pictureProfile, 0, 0);
        tblTop.Controls.Add(lblIntroduce, 0, 2);
        tblTop.Controls.Add(lblTitle, 0, 1);
        tblTop.Dock = System.Windows.Forms.DockStyle.Top;
        tblTop.BackColor = System.Drawing.Color.FromArgb(245, 240, 232);
        tblTop.Location = new System.Drawing.Point(0, 0);
        tblTop.Name = "tblTop";
        tblTop.RowCount = 3;
        tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.444443F));
        tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.333332F));
        tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.222221F));
        tblTop.Size = new System.Drawing.Size(1227, 150);
        tblTop.TabIndex = 20;
        // 
        // tblBottom
        // 
        tblBottom.ColumnCount = 2;
        tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tblBottom.Controls.Add(btnLogin, 0, 1);
        tblBottom.Controls.Add(lblForgotPass, 1, 0);
        tblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        tblBottom.BackColor = System.Drawing.Color.FromArgb(245, 240, 232);
        tblBottom.Padding = new System.Windows.Forms.Padding(18, 4, 18, 10);
        tblBottom.Location = new System.Drawing.Point(0, 576);
        tblBottom.Name = "tblBottom";
        tblBottom.RowCount = 2;
        tblBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
        tblBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
        tblBottom.Size = new System.Drawing.Size(1227, 141);
        tblBottom.TabIndex = 21;
        // 
        // frmLogin
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(245, 240, 232);
        ClientSize = new System.Drawing.Size(1227, 717);
        Controls.Add(tblBottom);
        Controls.Add(tblTop);
        Controls.Add(tblMain);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Đăng nhập";
        ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
        ((System.ComponentModel.ISupportInitialize)picturePassword).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureProfile).EndInit();
        tblMain.ResumeLayout(false);
        tblMain.PerformLayout();
        tblTop.ResumeLayout(false);
        tblBottom.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tblBottom;

    private System.Windows.Forms.TableLayoutPanel tblTop;

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TableLayoutPanel tblMain;

    private System.Windows.Forms.Label lblForgotPass;

    private System.Windows.Forms.PictureBox pictureProfile;

    private System.Windows.Forms.PictureBox picturePassword;

    private System.Windows.Forms.PictureBox pictureUser;

    private System.Windows.Forms.Button btnLogin;

    private System.Windows.Forms.Label lblIntroduce;

    private System.Windows.Forms.Label lblTitle;

    #endregion
}