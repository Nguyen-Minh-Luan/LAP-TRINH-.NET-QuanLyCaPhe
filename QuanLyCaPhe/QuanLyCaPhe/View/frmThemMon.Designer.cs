using System.ComponentModel;

namespace QuanLyCaPhe.View;

partial class frmThemMon
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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTieuDe = new System.Windows.Forms.Label();
        lblTenMon = new System.Windows.Forms.Label();
        lblSoLuong = new System.Windows.Forms.Label();
        nudSoLuong = new System.Windows.Forms.NumericUpDown();
        btnHuyBo = new System.Windows.Forms.Button();
        btnThemMon = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
        SuspendLayout();
        // 
        // lblTieuDe
        // 
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)70)), ((int)((byte)130)), ((int)((byte)180)));
        lblTieuDe.Location = new System.Drawing.Point(20, 15);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(340, 25);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "CHỌN SỐ LƯỢNG MÓN";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTenMon
        // 
        lblTenMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)40)), ((int)((byte)40)));
        lblTenMon.Location = new System.Drawing.Point(20, 45);
        lblTenMon.Name = "lblTenMon";
        lblTenMon.Size = new System.Drawing.Size(340, 30);
        lblTenMon.TabIndex = 1;
        lblTenMon.Text = "Tên món ăn";
        lblTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblSoLuong
        // 
        lblSoLuong.AutoSize = true;
        lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        lblSoLuong.Location = new System.Drawing.Point(85, 92);
        lblSoLuong.Name = "lblSoLuong";
        lblSoLuong.Size = new System.Drawing.Size(66, 19);
        lblSoLuong.TabIndex = 2;
        lblSoLuong.Text = "Số lượng:";
        // 
        // nudSoLuong
        // 
        nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nudSoLuong.Location = new System.Drawing.Point(165, 87);
        nudSoLuong.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
        nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSoLuong.Name = "nudSoLuong";
        nudSoLuong.Size = new System.Drawing.Size(100, 29);
        nudSoLuong.TabIndex = 3;
        nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnHuyBo
        // 
        btnHuyBo.BackColor = System.Drawing.SystemColors.ActiveBorder;
        btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
        btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btnHuyBo.FlatAppearance.BorderSize = 0;
        btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnHuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnHuyBo.Location = new System.Drawing.Point(50, 145);
        btnHuyBo.Name = "btnHuyBo";
        btnHuyBo.Size = new System.Drawing.Size(125, 36);
        btnHuyBo.TabIndex = 5;
        btnHuyBo.Text = "Hủy bỏ";
        btnHuyBo.UseVisualStyleBackColor = false;
        btnHuyBo.Click += btnHuyBo_Click;
        // 
        // btnThemMon
        // 
        btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)((byte)70)), ((int)((byte)130)), ((int)((byte)180)));
        btnThemMon.Cursor = System.Windows.Forms.Cursors.Hand;
        btnThemMon.FlatAppearance.BorderSize = 0;
        btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnThemMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThemMon.ForeColor = System.Drawing.Color.White;
        btnThemMon.Location = new System.Drawing.Point(205, 145);
        btnThemMon.Name = "btnThemMon";
        btnThemMon.Size = new System.Drawing.Size(125, 36);
        btnThemMon.TabIndex = 4;
        btnThemMon.Text = "Thêm món";
        btnThemMon.UseVisualStyleBackColor = false;
        btnThemMon.Click += btnThemMon_Click;
        // 
        // frmThemMon
        // 
        AcceptButton = btnThemMon;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ButtonFace;
        CancelButton = btnHuyBo;
        ClientSize = new System.Drawing.Size(380, 205);
        Controls.Add(lblTieuDe);
        Controls.Add(lblTenMon);
        Controls.Add(lblSoLuong);
        Controls.Add(nudSoLuong);
        Controls.Add(btnHuyBo);
        Controls.Add(btnThemMon);
        Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Thêm Món";
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    public System.Windows.Forms.Label lblTieuDe;
    public System.Windows.Forms.Label lblTenMon;
    private System.Windows.Forms.Label lblSoLuong;
    public System.Windows.Forms.NumericUpDown nudSoLuong;
    private System.Windows.Forms.Button btnHuyBo;
    public System.Windows.Forms.Button btnThemMon;
}
