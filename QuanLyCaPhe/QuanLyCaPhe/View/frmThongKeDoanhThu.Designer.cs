namespace QuanLyCaPhe.View;

partial class frmThongKeDoanhThu
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
        tabControlMain = new System.Windows.Forms.TabControl();
        tabDoanhThu = new System.Windows.Forms.TabPage();
        lblNam = new System.Windows.Forms.Label();
        cbNam = new System.Windows.Forms.ComboBox();
        dgvDoanhThu = new System.Windows.Forms.DataGridView();
        panelChartContainer = new System.Windows.Forms.Panel();
        tabMon = new System.Windows.Forms.TabPage();
        dgvMonBanChay = new System.Windows.Forms.DataGridView();
        tabControlMain.SuspendLayout();
        tabDoanhThu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
        tabMon.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMonBanChay).BeginInit();
        SuspendLayout();
        // tabControlMain
        tabControlMain.Controls.Add(tabDoanhThu);
        tabControlMain.Controls.Add(tabMon);
        tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControlMain.Location = new System.Drawing.Point(0, 0);
        tabControlMain.Name = "tabControlMain";
        tabControlMain.SelectedIndex = 0;
        tabControlMain.Size = new System.Drawing.Size(850, 480);
        tabControlMain.TabIndex = 0;
        
        // tabDoanhThu
        tabDoanhThu.Controls.Add(panelChartContainer);
        tabDoanhThu.Controls.Add(dgvDoanhThu);
        tabDoanhThu.Controls.Add(cbNam);
        tabDoanhThu.Controls.Add(lblNam);
        tabDoanhThu.Location = new System.Drawing.Point(4, 24);
        tabDoanhThu.Name = "tabDoanhThu";
        tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
        tabDoanhThu.Size = new System.Drawing.Size(842, 452);
        tabDoanhThu.TabIndex = 0;
        tabDoanhThu.Text = "Doanh thu";
        tabDoanhThu.UseVisualStyleBackColor = true;
        
        // lblNam
        lblNam.AutoSize = true;
        lblNam.Location = new System.Drawing.Point(20, 20);
        lblNam.Name = "lblNam";
        lblNam.Size = new System.Drawing.Size(33, 15);
        lblNam.TabIndex = 0;
        lblNam.Text = "Năm";
        
        // cbNam
        cbNam.FormattingEnabled = true;
        cbNam.Location = new System.Drawing.Point(60, 17);
        cbNam.Name = "cbNam";
        cbNam.Size = new System.Drawing.Size(120, 23);
        cbNam.TabIndex = 1;
        cbNam.SelectedIndexChanged += cbNam_SelectedIndexChanged;
        
        // dgvDoanhThu
        dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDoanhThu.Location = new System.Drawing.Point(20, 55);
        dgvDoanhThu.Name = "dgvDoanhThu";
        dgvDoanhThu.Size = new System.Drawing.Size(350, 375);
        dgvDoanhThu.TabIndex = 2;
        dgvDoanhThu.CellClick += dgvDoanhThu_CellClick;
        
        // panelChartContainer
        panelChartContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelChartContainer.Location = new System.Drawing.Point(390, 55);
        panelChartContainer.Name = "panelChartContainer";
        panelChartContainer.Size = new System.Drawing.Size(430, 375);
        panelChartContainer.TabIndex = 3;
        panelChartContainer.Paint += panelChartContainer_Paint;
         
        // tabMon
        tabMon.Controls.Add(dgvMonBanChay);
        tabMon.Location = new System.Drawing.Point(4, 24);
        tabMon.Name = "tabMon";
        tabMon.Padding = new System.Windows.Forms.Padding(3);
        tabMon.Size = new System.Drawing.Size(842, 452);
        tabMon.TabIndex = 1;
        tabMon.Text = "Món";
        tabMon.UseVisualStyleBackColor = true;
        
        // dgvMonBanChay
        dgvMonBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMonBanChay.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvMonBanChay.Location = new System.Drawing.Point(3, 3);
        dgvMonBanChay.Name = "dgvMonBanChay";
        dgvMonBanChay.Size = new System.Drawing.Size(836, 446);
        dgvMonBanChay.TabIndex = 0;
        dgvMonBanChay.CellClick += dgvMonBanChay_CellClick;
        
        // frmThongKeDoanhThu
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(850, 480);
        Controls.Add(tabControlMain);
        Name = "frmThongKeDoanhThu";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Thống Kê Doanh Thu";
        tabControlMain.ResumeLayout(false);
        tabDoanhThu.ResumeLayout(false);
        tabDoanhThu.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
        tabMon.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvMonBanChay).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabDoanhThu;
    private System.Windows.Forms.TabPage tabMon;
    private System.Windows.Forms.Label lblNam;
    private System.Windows.Forms.ComboBox cbNam;
    private System.Windows.Forms.DataGridView dgvDoanhThu;
    private System.Windows.Forms.Panel panelChartContainer;
    private System.Windows.Forms.DataGridView dgvMonBanChay;
}