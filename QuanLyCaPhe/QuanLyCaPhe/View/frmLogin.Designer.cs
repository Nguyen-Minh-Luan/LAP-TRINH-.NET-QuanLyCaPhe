using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe;

public partial class frmLogin
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(frmLogin));
        pictureProfile = new PictureBox();
        lblTitle = new Label();
        lblIntroduce = new Label();
        label1 = new Label();
        pictureUser = new PictureBox();
        txtName = new TextBox();
        label2 = new Label();
        picturePassword = new PictureBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        btnThoat = new Button();
        ((ISupportInitialize)pictureProfile).BeginInit();
        ((ISupportInitialize)pictureUser).BeginInit();
        ((ISupportInitialize)picturePassword).BeginInit();
        SuspendLayout();

        pictureProfile.Image = (Image)resources.GetObject("pictureProfile.Image");
        pictureProfile.Location = new Point(190, 25);
        pictureProfile.Name = "pictureProfile";
        pictureProfile.Size = new Size(80, 80);
        pictureProfile.SizeMode = PictureBoxSizeMode.Zoom;
        pictureProfile.TabIndex = 0;
        pictureProfile.TabStop = false;

        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.ForeColor = Color.FromArgb(74, 48, 37);
        lblTitle.Location = new Point(20, 112);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(420, 40);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;

        lblIntroduce.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblIntroduce.ForeColor = Color.FromArgb(125, 101, 86);
        lblIntroduce.Location = new Point(20, 155);
        lblIntroduce.Name = "lblIntroduce";
        lblIntroduce.Size = new Size(420, 25);
        lblIntroduce.TabIndex = 2;
        lblIntroduce.Text = "Phần mềm Quản lý Quán Cà Phê";
        lblIntroduce.TextAlign = ContentAlignment.MiddleCenter;

        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.FromArgb(74, 48, 37);
        label1.Location = new Point(40, 195);
        label1.Name = "label1";
        label1.Size = new Size(116, 19);
        label1.TabIndex = 3;
        label1.Text = "Tên đăng nhập:";

        pictureUser.Image = (Image)resources.GetObject("pictureUser.Image");
        pictureUser.Location = new Point(40, 223);
        pictureUser.Name = "pictureUser";
        pictureUser.Size = new Size(28, 28);
        pictureUser.SizeMode = PictureBoxSizeMode.Zoom;
        pictureUser.TabIndex = 4;
        pictureUser.TabStop = false;

        txtName.BackColor = Color.White;
        txtName.BorderStyle = BorderStyle.FixedSingle;
        txtName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtName.ForeColor = Color.FromArgb(55, 40, 32);
        txtName.Location = new Point(74, 222);
        txtName.Name = "txtName";
        txtName.PlaceholderText = "Nhập tên đăng nhập...";
        txtName.Size = new Size(346, 27);
        txtName.TabIndex = 5;

        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.FromArgb(74, 48, 37);
        label2.Location = new Point(40, 267);
        label2.Name = "label2";
        label2.Size = new Size(75, 19);
        label2.TabIndex = 6;
        label2.Text = "Mật khẩu:";

        picturePassword.Image = (Image)resources.GetObject("picturePassword.Image");
        picturePassword.Location = new Point(40, 295);
        picturePassword.Name = "picturePassword";
        picturePassword.Size = new Size(28, 28);
        picturePassword.SizeMode = PictureBoxSizeMode.Zoom;
        picturePassword.TabIndex = 7;
        picturePassword.TabStop = false;

        txtPassword.BackColor = Color.White;
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtPassword.ForeColor = Color.FromArgb(55, 40, 32);
        txtPassword.Location = new Point(74, 294);
        txtPassword.Name = "txtPassword";
        txtPassword.PlaceholderText = "Nhập mật khẩu...";
        txtPassword.Size = new Size(346, 27);
        txtPassword.TabIndex = 8;
        txtPassword.UseSystemPasswordChar = true;

        btnLogin.BackColor = Color.FromArgb(139, 75, 54);
        btnLogin.Cursor = Cursors.Hand;
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(105, 55, 40);
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(165, 91, 66);
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(40, 345);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(380, 44);
        btnLogin.TabIndex = 9;
        btnLogin.Text = "ĐĂNG NHẬP";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;

        btnThoat.BackColor = Color.FromArgb(232, 224, 214);
        btnThoat.Cursor = Cursors.Hand;
        btnThoat.FlatAppearance.BorderSize = 0;
        btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(215, 204, 190);
        btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 214, 202);
        btnThoat.FlatStyle = FlatStyle.Flat;
        btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnThoat.ForeColor = Color.FromArgb(110, 85, 70);
        btnThoat.Location = new Point(40, 399);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(380, 36);
        btnThoat.TabIndex = 10;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = false;
        btnThoat.Click += btnThoat_Click;

        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 240, 232);
        ClientSize = new Size(460, 465);
        Controls.Add(btnThoat);
        Controls.Add(btnLogin);
        Controls.Add(txtPassword);
        Controls.Add(picturePassword);
        Controls.Add(label2);
        Controls.Add(txtName);
        Controls.Add(pictureUser);
        Controls.Add(label1);
        Controls.Add(lblIntroduce);
        Controls.Add(lblTitle);
        Controls.Add(pictureProfile);
        Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "frmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng nhập";
        ((ISupportInitialize)pictureProfile).EndInit();
        ((ISupportInitialize)pictureUser).EndInit();
        ((ISupportInitialize)picturePassword).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureProfile;
    private Label lblTitle;
    private Label lblIntroduce;
    private Label label1;
    private PictureBox pictureUser;
    private TextBox txtName;
    private Label label2;
    private PictureBox picturePassword;
    private TextBox txtPassword;
    private Button btnLogin;
    private Button btnThoat;
}
