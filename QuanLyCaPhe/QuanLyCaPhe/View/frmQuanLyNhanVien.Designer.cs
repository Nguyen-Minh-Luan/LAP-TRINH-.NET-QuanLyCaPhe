using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe.View
{
    partial class frmQuanLyNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlTop;
        private Label lblTitle;
        private Panel pnlLeft;
        private Panel pnlSearch;
        private TextBox txtTimKiem;
        private ComboBox cboLocVaiTro;
        private Button btnTimKiem;
        private DataGridView dgvNhanVien;

        private Panel pnlRight;
        private Label lblFormHeader;
        private Label lblMaNV;
        private TextBox txtMaNV;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblVaiTro;
        private ComboBox cboVaiTro;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnDatLaiMK;
        private Button btnLamMoi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlTop = new Panel();
            lblTitle = new Label();
            pnlLeft = new Panel();
            pnlSearch = new Panel();
            txtTimKiem = new TextBox();
            cboLocVaiTro = new ComboBox();
            btnTimKiem = new Button();
            dgvNhanVien = new DataGridView();
            pnlRight = new Panel();
            lblFormHeader = new Label();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblVaiTro = new Label();
            cboVaiTro = new ComboBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnDatLaiMK = new Button();
            btnLamMoi = new Button();

            SuspendLayout();

            // pnlTop
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Height = 55;
            pnlTop.BackColor = Color.FromArgb(112, 67, 48);
            lblTitle.Text = "QUẢN LÝ NHÂN VIÊN & PHÂN QUYỀN";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Padding = new Padding(15, 0, 0, 0);
            pnlTop.Controls.Add(lblTitle);

            // pnlRight
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Width = 360;
            pnlRight.BackColor = Color.White;
            pnlRight.Padding = new Padding(20);

            lblFormHeader.Text = "THÔNG TIN NHÂN VIÊN";
            lblFormHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFormHeader.ForeColor = Color.FromArgb(112, 67, 48);
            lblFormHeader.Location = new Point(20, 15);
            lblFormHeader.AutoSize = true;

            int y = 50;
            int gap = 54;

            lblMaNV.Text = "Mã nhân viên:";
            lblMaNV.Location = new Point(20, y);
            lblMaNV.AutoSize = true;
            txtMaNV.Location = new Point(20, y + 20);
            txtMaNV.Width = 315;
            txtMaNV.ReadOnly = true;
            txtMaNV.BackColor = Color.WhiteSmoke;

            y += gap;
            lblHoTen.Text = "Họ và tên (*):";
            lblHoTen.Location = new Point(20, y);
            lblHoTen.AutoSize = true;
            txtHoTen.Location = new Point(20, y + 20);
            txtHoTen.Width = 315;

            y += gap;
            lblTenDangNhap.Text = "Tên đăng nhập (*):";
            lblTenDangNhap.Location = new Point(20, y);
            lblTenDangNhap.AutoSize = true;
            txtTenDangNhap.Location = new Point(20, y + 20);
            txtTenDangNhap.Width = 315;

            y += gap;
            lblMatKhau.Text = "Mật khẩu (*):";
            lblMatKhau.Location = new Point(20, y);
            lblMatKhau.AutoSize = true;
            txtMatKhau.Location = new Point(20, y + 20);
            txtMatKhau.Width = 315;
            txtMatKhau.UseSystemPasswordChar = true;

            y += gap;
            lblSoDienThoai.Text = "Số điện thoại:";
            lblSoDienThoai.Location = new Point(20, y);
            lblSoDienThoai.AutoSize = true;
            txtSoDienThoai.Location = new Point(20, y + 20);
            txtSoDienThoai.Width = 315;

            y += gap;
            lblVaiTro.Text = "Vai trò (*):";
            lblVaiTro.Location = new Point(20, y);
            lblVaiTro.AutoSize = true;
            cboVaiTro.Location = new Point(20, y + 20);
            cboVaiTro.Width = 315;
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaiTro.Items.AddRange(new object[] { "Quản lý", "Thu ngân", "Phục vụ", "Pha chế" });
            cboVaiTro.SelectedIndex = 1;

            y += gap;
            lblTrangThai.Text = "Trạng thái làm việc:";
            lblTrangThai.Location = new Point(20, y);
            lblTrangThai.AutoSize = true;
            cboTrangThai.Location = new Point(20, y + 20);
            cboTrangThai.Width = 315;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Nghỉ việc" });
            cboTrangThai.SelectedIndex = 0;

            // Buttons
            y += 62;
            btnThem.Text = "Thêm mới";
            btnThem.Location = new Point(20, y);
            btnThem.Size = new Size(100, 36);
            btnThem.BackColor = Color.FromArgb(139, 54, 48);
            btnThem.ForeColor = Color.White;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Click += btnThem_Click;

            btnSua.Text = "Cập nhật";
            btnSua.Location = new Point(128, y);
            btnSua.Size = new Size(100, 36);
            btnSua.BackColor = Color.FromArgb(112, 67, 48);
            btnSua.ForeColor = Color.White;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Click += btnSua_Click;

            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(236, y);
            btnXoa.Size = new Size(99, 36);
            btnXoa.BackColor = Color.FromArgb(160, 60, 50);
            btnXoa.ForeColor = Color.White;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Click += btnXoa_Click;

            y += 44;
            btnDatLaiMK.Text = "Đặt lại mật khẩu";
            btnDatLaiMK.Location = new Point(20, y);
            btnDatLaiMK.Size = new Size(154, 35);
            btnDatLaiMK.BackColor = Color.FromArgb(139, 75, 54);
            btnDatLaiMK.ForeColor = Color.White;
            btnDatLaiMK.FlatStyle = FlatStyle.Flat;
            btnDatLaiMK.Click += btnDatLaiMK_Click;

            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Location = new Point(181, y);
            btnLamMoi.Size = new Size(154, 35);
            btnLamMoi.BackColor = Color.FromArgb(120, 100, 90);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Click += btnLamMoi_Click;

            pnlRight.Controls.AddRange(new Control[]
            {
                lblFormHeader, lblMaNV, txtMaNV, lblHoTen, txtHoTen,
                lblTenDangNhap, txtTenDangNhap, lblMatKhau, txtMatKhau,
                lblSoDienThoai, txtSoDienThoai, lblVaiTro, cboVaiTro,
                lblTrangThai, cboTrangThai, btnThem, btnSua, btnXoa, btnDatLaiMK, btnLamMoi
            });

            // pnlLeft
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Padding = new Padding(15);

            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Height = 45;

            txtTimKiem.PlaceholderText = "Tìm theo họ tên, tên đăng nhập, SĐT...";
            txtTimKiem.Location = new Point(0, 8);
            txtTimKiem.Width = 250;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            cboLocVaiTro.Location = new Point(260, 8);
            cboLocVaiTro.Width = 140;
            cboLocVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocVaiTro.Items.AddRange(new object[] { "Tất cả", "Quản lý", "Thu ngân", "Phục vụ", "Pha chế" });
            cboLocVaiTro.SelectedIndex = 0;
            cboLocVaiTro.SelectedIndexChanged += cboLocVaiTro_SelectedIndexChanged;

            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Location = new Point(410, 7);
            btnTimKiem.Size = new Size(90, 29);
            btnTimKiem.BackColor = Color.FromArgb(112, 67, 48);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;

            pnlSearch.Controls.AddRange(new Control[] { txtTimKiem, cboLocVaiTro, btnTimKiem });

            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;

            pnlLeft.Controls.Add(dgvNhanVien);
            pnlLeft.Controls.Add(pnlSearch);

            // Form
            ClientSize = new Size(1050, 620);
            Font = new Font("Segoe UI", 9.5F);
            BackColor = Color.FromArgb(245, 245, 245);
            Text = "Quản Lý Nhân Viên";
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Controls.Add(pnlTop);
            Load += frmQuanLyNhanVien_Load;

            ResumeLayout(false);
        }
    }
}