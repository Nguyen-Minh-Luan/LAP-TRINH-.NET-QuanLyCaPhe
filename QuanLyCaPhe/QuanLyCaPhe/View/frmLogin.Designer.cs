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
        txtName = new System.Windows.Forms.TextBox();
        lblLogin = new System.Windows.Forms.Label();
        lblPassword = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        lblIntroduce = new System.Windows.Forms.Label();
        pictureLogin = new System.Windows.Forms.PictureBox();
        txtPassword = new System.Windows.Forms.TextBox();
        btnLogin = new System.Windows.Forms.Button();
        pictureUser = new System.Windows.Forms.PictureBox();
        picturePassword = new System.Windows.Forms.PictureBox();
        pictureProfile = new System.Windows.Forms.PictureBox();
        lblForgotPass = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureLogin).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picturePassword).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureProfile).BeginInit();
        SuspendLayout();
        // 
        // txtName
        // 
        txtName.Location = new System.Drawing.Point(516, 265);
        txtName.Multiline = true;
        txtName.Name = "txtName";
        txtName.PlaceholderText = "Nhập tên đăng nhập...";
        txtName.Size = new System.Drawing.Size(579, 37);
        txtName.TabIndex = 4;
        // 
        // lblLogin
        // 
        lblLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        lblLogin.Location = new System.Drawing.Point(556, 220);
        lblLogin.Name = "lblLogin";
        lblLogin.Size = new System.Drawing.Size(226, 42);
        lblLogin.TabIndex = 7;
        lblLogin.Text = "Tên đăng nhập:";
        // 
        // lblPassword
        // 
        lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        lblPassword.Location = new System.Drawing.Point(557, 317);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new System.Drawing.Size(226, 43);
        lblPassword.TabIndex = 8;
        lblPassword.Text = "Mật khẩu:";
        // 
        // lblTitle
        // 
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        lblTitle.Location = new System.Drawing.Point(589, 118);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(456, 64);
        lblTitle.TabIndex = 10;
        lblTitle.Text = "Đăng nhập tài khoản";
        lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        lblTitle.Click += label3_Click;
        // 
        // lblIntroduce
        // 
        lblIntroduce.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblIntroduce.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        lblIntroduce.Location = new System.Drawing.Point(579, 172);
        lblIntroduce.Name = "lblIntroduce";
        lblIntroduce.Size = new System.Drawing.Size(456, 33);
        lblIntroduce.TabIndex = 11;
        lblIntroduce.Text = "Chào bạn đến hệ thống Quản lý quán cà phê";
        lblIntroduce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // pictureLogin
        // 
        pictureLogin.Image = ((System.Drawing.Image)resources.GetObject("pictureLogin.Image"));
        pictureLogin.Location = new System.Drawing.Point(5, 2);
        pictureLogin.Name = "pictureLogin";
        pictureLogin.Size = new System.Drawing.Size(481, 534);
        pictureLogin.TabIndex = 12;
        pictureLogin.TabStop = false;
        // 
        // txtPassword
        // 
        txtPassword.Location = new System.Drawing.Point(516, 363);
        txtPassword.Multiline = true;
        txtPassword.Name = "txtPassword";
        txtPassword.PlaceholderText = "Nhập mật khẩu...";
        txtPassword.Size = new System.Drawing.Size(579, 37);
        txtPassword.TabIndex = 13;
        txtPassword.TextChanged += textBox2_TextChanged;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = System.Drawing.Color.OrangeRed;
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)200)), ((int)((byte)50)), ((int)((byte)0)));
        btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)105)), ((int)((byte)50)));
        btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btnLogin.Location = new System.Drawing.Point(589, 465);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new System.Drawing.Size(456, 48);
        btnLogin.TabIndex = 14;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // pictureUser
        // 
        pictureUser.Image = ((System.Drawing.Image)resources.GetObject("pictureUser.Image"));
        pictureUser.Location = new System.Drawing.Point(516, 220);
        pictureUser.Name = "pictureUser";
        pictureUser.Size = new System.Drawing.Size(34, 42);
        pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureUser.TabIndex = 15;
        pictureUser.TabStop = false;
        // 
        // picturePassword
        // 
        picturePassword.Image = ((System.Drawing.Image)resources.GetObject("picturePassword.Image"));
        picturePassword.Location = new System.Drawing.Point(517, 317);
        picturePassword.Name = "picturePassword";
        picturePassword.Size = new System.Drawing.Size(34, 43);
        picturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        picturePassword.TabIndex = 16;
        picturePassword.TabStop = false;
        // 
        // pictureProfile
        // 
        pictureProfile.Image = ((System.Drawing.Image)resources.GetObject("pictureProfile.Image"));
        pictureProfile.Location = new System.Drawing.Point(755, 9);
        pictureProfile.Name = "pictureProfile";
        pictureProfile.Size = new System.Drawing.Size(124, 106);
        pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureProfile.TabIndex = 17;
        pictureProfile.TabStop = false;
        // 
        // lblForgotPass
        // 
        lblForgotPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblForgotPass.ForeColor = System.Drawing.Color.Yellow;
        lblForgotPass.Location = new System.Drawing.Point(923, 416);
        lblForgotPass.Name = "lblForgotPass";
        lblForgotPass.Size = new System.Drawing.Size(172, 27);
        lblForgotPass.TabIndex = 18;
        lblForgotPass.Text = "Quên mật khẩu?";
        // 
        // frmLogin
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Brown;
        ClientSize = new System.Drawing.Size(1128, 534);
        Controls.Add(lblForgotPass);
        Controls.Add(pictureProfile);
        Controls.Add(picturePassword);
        Controls.Add(pictureUser);
        Controls.Add(btnLogin);
        Controls.Add(txtPassword);
        Controls.Add(pictureLogin);
        Controls.Add(lblIntroduce);
        Controls.Add(lblTitle);
        Controls.Add(lblPassword);
        Controls.Add(lblLogin);
        Controls.Add(txtName);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Đăng nhập";
        Load += frmLogin_Load;
        ((System.ComponentModel.ISupportInitialize)pictureLogin).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
        ((System.ComponentModel.ISupportInitialize)picturePassword).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureProfile).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblForgotPass;

    private System.Windows.Forms.PictureBox pictureProfile;

    private System.Windows.Forms.PictureBox picturePassword;

    private System.Windows.Forms.PictureBox pictureUser;

    private System.Windows.Forms.Button btnLogin;

    private System.Windows.Forms.PictureBox pictureLogin;

    private System.Windows.Forms.Label lblIntroduce;

    private System.Windows.Forms.Label lblTitle;

    private System.Windows.Forms.Label lblPassword;

    private System.Windows.Forms.Label lblLogin;

    private System.Windows.Forms.TextBox txtPassword;

    private System.Windows.Forms.TextBox txtName;

    #endregion
}