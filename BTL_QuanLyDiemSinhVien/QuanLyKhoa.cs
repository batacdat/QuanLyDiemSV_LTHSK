using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace BTL_QuanLyDiemSinhVien
{
    public partial class QuanLyKhoa : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public QuanLyKhoa()
        {
            InitializeComponent();
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

        private void QuanLyKhoa_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select * from tblKhoa";
            dt = kn.Execute(query);
            dgvDanhSachKhoa.DataSource = dt;
        }

        private void dgvDanhSachKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng đã chọn một hàng hợp lệ
            {
                DataGridViewRow row = dgvDanhSachKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells["sMaKhoa"].Value.ToString();
                txtTenKhoa.Text = row.Cells["sTenKhoa"].Value.ToString();
                txtSDT.Text = row.Cells["sSDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["sDiaChiKhoa"].Value.ToString();
            }
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string maKhoa = txtMaKhoa.Text.Trim();
                string tenKhoa = txtTenKhoa.Text.Trim();
                string SDT = txtSDT.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maKhoa) || string.IsNullOrEmpty(tenKhoa) || string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(diaChi))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Chuẩn bị câu lệnh SQL để chèn dữ liệu
                string query = "INSERT INTO tblKhoa (sMaKhoa, sTenKhoa, sSDT, sDiaChiKhoa) " +
                               "VALUES (@maKhoa, @tenKhoa, @SDT, @diaChi)";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
                {
                    { "@maKhoa", maKhoa },
                    { "@tenKhoa", tenKhoa },
                    { "@SDT", SDT },
                    { "@diaChi", diaChi }
                };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh chèn dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Thêm khoa thành công!");

                // Cập nhật lại DataGridView
                QuanLyKhoa_Load(sender, e);

                ClearInputs();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string maKhoa = txtMaKhoa.Text.Trim();
                string tenKhoa = txtTenKhoa.Text.Trim();
                string SDT = txtSDT.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maKhoa) || string.IsNullOrEmpty(tenKhoa) || string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(diaChi))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Chuẩn bị câu lệnh SQL để cập nhật dữ liệu
                string query = "UPDATE tblKhoa SET sTenKhoa = @tenKhoa, sSDT = @SDT, sDiaChiKhoa = @diaChi WHERE sMaKhoa = @maKhoa";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
        {
            { "@maKhoa", maKhoa },
            { "@tenKhoa", tenKhoa },
            { "@SDT", SDT },
            { "@diaChi", diaChi }
        };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh cập nhật dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Cập nhật khoa thành công!");

                // Cập nhật lại DataGridView
                QuanLyKhoa_Load(sender, e);
                ClearInputs();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã khoa từ trường nhập liệu
                string maKhoa = txtMaKhoa.Text.Trim();

                // Kiểm tra trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maKhoa))
                {
                    MessageBox.Show("Vui lòng chọn khoa cần xóa.");
                    return;
                }

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Chuẩn bị câu lệnh SQL để xóa dữ liệu
                    string query = "DELETE FROM tblKhoa WHERE sMaKhoa = @maKhoa";

                    // Sử dụng parameterized query để tránh SQL Injection
                    var parameters = new Dictionary<string, object>
            {
                { "@maKhoa", maKhoa }
            };

                    // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh xóa dữ liệu
                    kn.ExecuteNonQuery(query, parameters);

                    // Thông báo thành công
                    MessageBox.Show("Xóa khoa thành công!");

                    // Cập nhật lại DataGridView
                    QuanLyKhoa_Load(sender, e);
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtNhapTT.Clear();
           

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {    // Lấy tiêu chí tìm kiếm từ ComboBox
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
                string query = "select * from tblKhoa where ";

                switch (tieuChi)
                {
                    case "Mã khoa":
                        {
                            query += "sMaKhoa LIKE @giaTriTimKiem";
                            break;
                        }
                    case "Tên khoa":
                        {
                            query += "sTenKhoa LIKE @giaTriTimKiem";
                            break;
                        }
                    case "Số điện thoại":
                        {
                            query += "sSDT LIKE @giaTriTimKiem";
                            break;
                        }
                    case "Địa chỉ":
                        {
                            query += "sDiaChiKhoa LIKE @giaTriTimKiem";
                            break;
                        }
                    default:
                        MessageBox.Show("Tiêu chí tìm kiếm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;


                }
                // Thêm ký tự % để tìm kiếm gần đúng
                giaTriTimKiem = "%"+ giaTriTimKiem + "%";
                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
                {
                    { "@giaTriTimKiem", giaTriTimKiem }
                 };

                DataTable dt = kn.Execute(query, parameters);

                // Kiểm tra xem có kết quả nào không
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Hiển thị kết quả lên DataGridView
                dgvDanhSachKhoa.DataSource = dt;
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
            QuanLyKhoa_Load(sender, e);
        }
    }
}