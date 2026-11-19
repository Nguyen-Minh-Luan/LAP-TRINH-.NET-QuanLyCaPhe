using System.ComponentModel;

namespace QuanLyCaPhe.View;

partial class popupQuenMK
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
        label1 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        btnHuy = new System.Windows.Forms.Button();
        btnDoiMK = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        txtXacNhanMKMoi = new System.Windows.Forms.TextBox();
        txtNhanMKMoi = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        txtTenDNMK = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(67, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(585, 101);
        label1.TabIndex = 0;
        label1.Text = "ĐẶT LẠI MẬT KHẨU";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnHuy);
        panel1.Controls.Add(btnDoiMK);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(txtXacNhanMKMoi);
        panel1.Controls.Add(txtNhanMKMoi);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(txtTenDNMK);
        panel1.Controls.Add(label2);
        panel1.Location = new System.Drawing.Point(34, 113);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(671, 337);
        panel1.TabIndex = 1;
        // 
        // btnHuy
        // 
        btnHuy.BackColor = System.Drawing.Color.Chocolate;
        btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnHuy.ForeColor = System.Drawing.Color.MintCream;
        btnHuy.Location = new System.Drawing.Point(435, 260);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new System.Drawing.Size(166, 53);
        btnHuy.TabIndex = 7;
        btnHuy.Text = "Huỷ";
        btnHuy.UseVisualStyleBackColor = false;
        // 
        // btnDoiMK
        // 
        btnDoiMK.BackColor = System.Drawing.Color.DarkOliveGreen;
        btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDoiMK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        btnDoiMK.Location = new System.Drawing.Point(64, 260);
        btnDoiMK.Name = "btnDoiMK";
        btnDoiMK.Size = new System.Drawing.Size(166, 53);
        btnDoiMK.TabIndex = 6;
        btnDoiMK.Text = "Đổi mật khẩu";
        btnDoiMK.UseVisualStyleBackColor = false;
        btnDoiMK.Click += btnDoiMK_Click;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(3, 172);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(217, 31);
        label4.TabIndex = 5;
        label4.Text = "Xác nhận mật khẩu:";
        // 
        // txtXacNhanMKMoi
        // 
        txtXacNhanMKMoi.Location = new System.Drawing.Point(220, 172);
        txtXacNhanMKMoi.Name = "txtXacNhanMKMoi";
        txtXacNhanMKMoi.Size = new System.Drawing.Size(426, 31);
        txtXacNhanMKMoi.TabIndex = 4;
        // 
        // txtNhanMKMoi
        // 
        txtNhanMKMoi.Location = new System.Drawing.Point(220, 107);
        txtNhanMKMoi.Name = "txtNhanMKMoi";
        txtNhanMKMoi.Size = new System.Drawing.Size(426, 31);
        txtNhanMKMoi.TabIndex = 3;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(0, 107);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(164, 39);
        label3.TabIndex = 2;
        label3.Text = "Mật khẩu mới:";
        // 
        // txtTenDNMK
        // 
        txtTenDNMK.Location = new System.Drawing.Point(220, 49);
        txtTenDNMK.Name = "txtTenDNMK";
        txtTenDNMK.Size = new System.Drawing.Size(426, 31);
        txtTenDNMK.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(3, 49);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(198, 55);
        label2.TabIndex = 0;
        label2.Text = "Tên đăng nhập:";
        // 
        // popupQuenMK
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(731, 469);
        Controls.Add(panel1);
        Controls.Add(label1);
        ForeColor = System.Drawing.Color.Indigo;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Đặt lại mật khẩu";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnDoiMK;
    private System.Windows.Forms.Button btnHuy;

    private System.Windows.Forms.TextBox txtXacNhanMKMoi;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtNhanMKMoi;

    private System.Windows.Forms.TextBox txtTenDNMK;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label label1;

    #endregion
}