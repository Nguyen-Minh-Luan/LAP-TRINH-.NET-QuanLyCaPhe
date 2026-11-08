namespace QuanLyCaPhe;

partial class frmThongKeMonBanChay
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTuNgay = new System.Windows.Forms.Label();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        lblDenNgay = new System.Windows.Forms.Label();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        btnXemBaoCao = new System.Windows.Forms.Button();
        lblTieuDe = new System.Windows.Forms.Label();
        dgvMonBanChay = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvMonBanChay).BeginInit();
        SuspendLayout();
        // 
        // lblTuNgay
        // 
        lblTuNgay.AutoSize = true;
        lblTuNgay.Location = new System.Drawing.Point(20, 20);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new System.Drawing.Size(52, 15);
        lblTuNgay.TabIndex = 0;
        lblTuNgay.Text = "Từ ngày:";
        // 
        // dtpTuNgay
        // 
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpTuNgay.Location = new System.Drawing.Point(80, 17);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(120, 23);
        dtpTuNgay.TabIndex = 1;
        // 
        // lblDenNgay
        // 
        lblDenNgay.AutoSize = true;
        lblDenNgay.Location = new System.Drawing.Point(220, 20);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(60, 15);
        lblDenNgay.TabIndex = 2;
        lblDenNgay.Text = "Đến ngày:";
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDenNgay.Location = new System.Drawing.Point(290, 17);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(120, 23);
        dtpDenNgay.TabIndex = 3;
        // 
        // btnXemBaoCao
        // 
        btnXemBaoCao.Location = new System.Drawing.Point(430, 15);
        btnXemBaoCao.Name = "btnXemBaoCao";
        btnXemBaoCao.Size = new System.Drawing.Size(110, 26);
        btnXemBaoCao.TabIndex = 4;
        btnXemBaoCao.Text = "Xem Báo Cáo";
        btnXemBaoCao.UseVisualStyleBackColor = true;
        btnXemBaoCao.Click += btnXemBaoCao_Click;
        // 
        // lblTieuDe
        // 
        lblTieuDe.AutoSize = true;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
        lblTieuDe.Location = new System.Drawing.Point(20, 60);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(262, 17);
        lblTieuDe.TabIndex = 5;
        lblTieuDe.Text = "BẢNG XẾP HẠNG TOP MÓN BÁN CHẠY NHẤT";
        // 
        // dgvMonBanChay
        // 
        dgvMonBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMonBanChay.Location = new System.Drawing.Point(20, 90);
        dgvMonBanChay.Name = "dgvMonBanChay";
        dgvMonBanChay.Size = new System.Drawing.Size(760, 350);
        dgvMonBanChay.TabIndex = 6;
        dgvMonBanChay.CellClick += dgvMonBanChay_CellClick;
        // 
        // frmThongKeMonBanChay
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 460);
        Controls.Add(dgvMonBanChay);
        Controls.Add(lblTieuDe);
        Controls.Add(btnXemBaoCao);
        Controls.Add(dtpDenNgay);
        Controls.Add(lblDenNgay);
        Controls.Add(dtpTuNgay);
        Controls.Add(lblTuNgay);
        Name = "frmThongKeMonBanChay";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Thống Kê Món Bán Chạy";
        ((System.ComponentModel.ISupportInitialize)dgvMonBanChay).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Button btnXemBaoCao;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.DataGridView dgvMonBanChay;
}