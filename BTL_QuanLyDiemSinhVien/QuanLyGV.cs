using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BTL_QuanLyDiemSinhVien
{
    public partial class QuanLyGV : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public QuanLyGV()
        {
            InitializeComponent();
            // Gán sự kiện cho các nút
            btnQuayLai.Click += btnQuayLai_Click;
            btnThoat.Click += btnThoat_Click;
            btnThemGV.Click += btnThemGV_Click;
            btnSuaGV.Click += btnSuaGV_Click;
            btnXoaGV.Click += btnXoaGV_Click;
            btnTim.Click += btnTim_Click;
            btnXoaTT.Click += btnXoaTT_Click;
            dgvDanhSachSV.CellClick += dgvDanhSachSV_CellClick;
        }

        private void QuanLyGV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM tblGiangVien";
            DataTable dataTable = kn.Execute(query);
            dgvDanhSachSV.DataSource = dataTable;
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string maGV = txtMaGV.Text.Trim();
                string tenGV = txtTenGV.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string bangCap = txtBangCap.Text.Trim();
                string userName = txtUserName.Text.Trim();
                string passWord = txtPassWord.Text.Trim();

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maGV) || string.IsNullOrEmpty(tenGV) || string.IsNullOrEmpty(sdt) ||
                    string.IsNullOrEmpty(bangCap) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Chuẩn bị câu lệnh SQL để chèn dữ liệu
                string query = "INSERT INTO tblGiangVien (sMaGV, sTenGV, sSDT, sBangCap, sUserName, sPassWord) " +
                               "VALUES (@maGV, @tenGV, @sdt, @bangCap, @userName, @passWord)";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
                {
                    { "@maGV", maGV },
                    { "@tenGV", tenGV },
                    { "@sdt", sdt },
                    { "@bangCap", bangCap },
                    { "@userName", userName },
                    { "@passWord", passWord }
                };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh chèn dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Thêm giảng viên thành công!");

                // Cập nhật lại DataGridView
                LoadData();

                // Xóa các trường nhập liệu
                ClearInputs();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string maGV = txtMaGV.Text.Trim();
                string tenGV = txtTenGV.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string bangCap = txtBangCap.Text.Trim();
                string userName = txtUserName.Text.Trim();
                string passWord = txtPassWord.Text.Trim();

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maGV) || string.IsNullOrEmpty(tenGV) || string.IsNullOrEmpty(sdt) ||
                    string.IsNullOrEmpty(bangCap) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Chuẩn bị câu lệnh SQL để cập nhật dữ liệu
                string query = "UPDATE tblGiangVien SET sTenGV = @tenGV, sSDT = @sdt, sBangCap = @bangCap, " +
                               "sUserName = @userName, sPassWord = @passWord WHERE sMaGV = @maGV";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
                {
                    { "@maGV", maGV },
                    { "@tenGV", tenGV },
                    { "@sdt", sdt },
                    { "@bangCap", bangCap },
                    { "@userName", userName },
                    { "@passWord", passWord }
                };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh cập nhật dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Cập nhật thông tin giảng viên thành công!");

                // Cập nhật lại DataGridView
                LoadData();

                // Xóa các trường nhập liệu
                ClearInputs();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã giảng viên từ trường nhập liệu
                string maGV = txtMaGV.Text.Trim();

                // Kiểm tra trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maGV))
                {
                    MessageBox.Show("Vui lòng chọn giảng viên cần xóa.");
                    return;
                }

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Chuẩn bị câu lệnh SQL để xóa dữ liệu
                    string query = "DELETE FROM tblGiangVien WHERE sMaGV = @maGV";

                    // Sử dụng parameterized query để tránh SQL Injection
                    var parameters = new Dictionary<string, object>
                    {
                        { "@maGV", maGV }
                    };

                    // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh xóa dữ liệu
                    kn.ExecuteNonQuery(query, parameters);

                    // Thông báo thành công
                    MessageBox.Show("Xóa giảng viên thành công!");

                    // Cập nhật lại DataGridView
                    LoadData();

                    // Xóa các trường nhập liệu
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tiêu chí tìm kiếm từ ComboBox
                string tieuChi = cbTimKiem.SelectedItem?.ToString();

                // Lấy giá trị tìm kiếm từ TextBox
                string giaTriTimKiem = txtNhapTT.Text.Trim();

                // Kiểm tra xem người dùng đã chọn tiêu chí và nhập giá trị tìm kiếm chưa
                if (string.IsNullOrEmpty(tieuChi) || string.IsNullOrEmpty(giaTriTimKiem))
                {
                    MessageBox.Show("Vui lòng chọn tiêu chí và nhập giá trị tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xây dựng câu lệnh SQL dựa trên tiêu chí tìm kiếm
                string query = "SELECT * FROM tblGiangVien WHERE ";

                switch (tieuChi)
                {
                    case "Mã giảng viên":
                        query += "sMaGV LIKE @giaTriTimKiem";
                        break;
                    case "Họ tên":
                        query += "sTenGV LIKE @giaTriTimKiem";
                        break;
                    case "Số điện thoại":
                        query += "sSDT LIKE @giaTriTimKiem";
                        break;
                    case "Bằng cấp":
                        query += "sBangCap LIKE @giaTriTimKiem";
                        break;
                    default:
                        MessageBox.Show("Tiêu chí tìm kiếm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                // Thêm ký tự % để tìm kiếm gần đúng
                giaTriTimKiem = "%" + giaTriTimKiem + "%";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
                {
                    { "@giaTriTimKiem", giaTriTimKiem }
                };

                // Thực hiện truy vấn và lấy kết quả
                DataTable dt = kn.Execute(query, parameters);

                // Kiểm tra xem có kết quả nào không
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Hiển thị kết quả lên DataGridView
                dgvDanhSachSV.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            ClearInputs();
            // Cập nhật lại DataGridView
            LoadData();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmTrangChu();
            form.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình ??", "Thông báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }

        private void dgvDanhSachSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng đã chọn một hàng hợp lệ
            {
                DataGridViewRow row = dgvDanhSachSV.Rows[e.RowIndex];
                txtMaGV.Text = row.Cells["sMaGV"].Value.ToString();
                txtTenGV.Text = row.Cells["sTenGV"].Value.ToString();
                txtSDT.Text = row.Cells["sSDT"].Value.ToString();
                txtBangCap.Text = row.Cells["sBangCap"].Value.ToString();
                txtUserName.Text = row.Cells["sUserName"].Value.ToString();
                txtPassWord.Text = row.Cells["sPassWord"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtMaGV.Clear();
            txtTenGV.Clear();
            txtSDT.Clear();
            txtBangCap.Clear();
            txtUserName.Clear();
            txtPassWord.Clear();
            txtNhapTT.Clear();
        }
    }
}