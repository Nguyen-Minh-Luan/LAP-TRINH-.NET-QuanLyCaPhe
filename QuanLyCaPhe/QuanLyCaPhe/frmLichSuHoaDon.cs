using System.Data;

namespace QuanLyCaPhe;

public partial class frmLichSuHoaDon : Form
{
   private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnTimKiem;
        private DataGridView dgvHoaDon;
        private DataGridView dgvChiTietHoaDon;
        private Label lblTuNgay;
        private Label lblDenNgay;
        private Label lblDanhSachHD;
        private Label lblChiTietHD;

        public frmLichSuHoaDon()
        {
            InitializeComponentCustom();
            LoadDataMau(); // Tải dữ liệu giả lên giao diện
        }

        private void InitializeComponentCustom()
        {
            this.Text = "Lịch Sử Hóa Đơn";
            this.Size = new Size(900, 550);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Label & DateTimePicker Từ ngày
            lblTuNgay = new Label() { Text = "Từ ngày:", Location = new Point(20, 20), AutoSize = true };
            dtpTuNgay = new DateTimePicker() { Location = new Point(80, 17), Format = DateTimePickerFormat.Short, Width = 120 };

            // Label & DateTimePicker Đến ngày
            lblDenNgay = new Label() { Text = "Đến ngày:", Location = new Point(220, 20), AutoSize = true };
            dtpDenNgay = new DateTimePicker() { Location = new Point(290, 17), Format = DateTimePickerFormat.Short, Width = 120 };

            // Nút Tra cứu
            btnTimKiem = new Button() { Text = "Tra cứu", Location = new Point(430, 15), Width = 90, Height = 28 };
            btnTimKiem.Click += (s, e) => MessageBox.Show("Chức năng tra cứu theo ngày!");

            // Label Danh sách hóa đơn
            lblDanhSachHD = new Label() { Text = "Danh sách hóa đơn", Location = new Point(20, 55), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };

            // DataGridView Hóa đơn
            dgvHoaDon = new DataGridView()
            {
                Location = new Point(20, 80),
                Size = new Size(430, 400),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;

            // Label Chi tiết hóa đơn
            lblChiTietHD = new Label() { Text = "Chi tiết hóa đơn được chọn", Location = new Point(470, 55), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };

            // DataGridView Chi tiết
            dgvChiTietHoaDon = new DataGridView()
            {
                Location = new Point(470, 80),
                Size = new Size(390, 400),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true
            };

            // Thêm Control vào Form
            this.Controls.Add(lblTuNgay);
            this.Controls.Add(dtpTuNgay);
            this.Controls.Add(lblDenNgay);
            this.Controls.Add(dtpDenNgay);
            this.Controls.Add(btnTimKiem);
            this.Controls.Add(lblDanhSachHD);
            this.Controls.Add(dgvHoaDon);
            this.Controls.Add(lblChiTietHD);
            this.Controls.Add(dgvChiTietHoaDon);
        }

        private void LoadDataMau()
        {
            // Tạo bảng dữ liệu hóa đơn mẫu
            DataTable dtHD = new DataTable();
            dtHD.Columns.Add("Mã HD");
            dtHD.Columns.Add("Tên Bàn");
            dtHD.Columns.Add("Ngày Tạo");
            dtHD.Columns.Add("Tổng Tiền");
            dtHD.Columns.Add("Người Lập");

            dtHD.Rows.Add("HD001", "Bàn 1", "01/11/2026 08:30", "75,000", "Nguyễn Văn A");
            dtHD.Rows.Add("HD002", "Bàn 3", "01/11/2026 09:15", "120,000", "Trần Thị B");
            dtHD.Rows.Add("HD003", "Bàn 5", "01/11/2026 10:00", "45,000", "Nguyễn Văn A");

            dgvHoaDon.DataSource = dtHD;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Giả lập hiển thị chi tiết khi bấm chọn hóa đơn
                DataTable dtCT = new DataTable();
                dtCT.Columns.Add("Tên Món");
                dtCT.Columns.Add("Số Lượng");
                dtCT.Columns.Add("Đơn Giá");
                dtCT.Columns.Add("Thành Tiền");

                if (e.RowIndex == 0)
                {
                    dtCT.Rows.Add("Cà phê sữa", 2, "25,000", "50,000");
                    dtCT.Rows.Add("Bạc xỉu", 1, "25,000", "25,000");
                }
                else
                {
                    dtCT.Rows.Add("Trà đào cam sả", 2, "35,000", "70,000");
                    dtCT.Rows.Add("Hướng dương", 1, "50,000", "50,000");
                }
                dgvChiTietHoaDon.DataSource = dtCT;
            }
        }
    }
