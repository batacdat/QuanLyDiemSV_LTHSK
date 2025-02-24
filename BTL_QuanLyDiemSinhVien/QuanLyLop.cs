using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BTL_QuanLyDiemSinhVien
{
    public partial class QuanLyLop : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public QuanLyLop()
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

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tblLop";
            dt = kn.Execute(query);
            dgvDanhSachLop.DataSource = dt;

        }

        


        private void dgvDanhSachLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachLop.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells["sMaLop"].Value.ToString();
                txtTenLop.Text = row.Cells["sTenLop"].Value.ToString();
                txtMaKhoa.Text = row.Cells["sMaKhoa"].Value.ToString();
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txtMaLop.Text.Trim();
                string tenLop = txtTenLop.Text.Trim();
                string maKhoa = txtMaKhoa.Text.Trim();

                if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(maKhoa))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                string query = "INSERT INTO tblLop (sMaLop, sTenLop, sMaKhoa) VALUES (@MaLop, @TenLop, @MaKhoa)";
                var parameters = new Dictionary<string, object>
                {
                    { "@MaLop", maLop },
                    { "@TenLop", tenLop },
                    { "@MaKhoa", maKhoa }
                };

                kn.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Thêm lớp thành công!");
                ClearInputs();
                // load data ra man hinh
                QuanLyLop_Load(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaKhoa.Clear();
            txtNhapTT.Clear();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string maLop = txtMaLop.Text.Trim();
                string tenLop = txtTenLop.Text.Trim();
                string maKhoa = txtMaKhoa.Text.Trim();

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(maKhoa))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                // Chuẩn bị câu lệnh SQL để cập nhật dữ liệu
                string query = "UPDATE tblLop SET sTenLop = @TenLop, sMaKhoa = @MaKhoa WHERE sMaLop = @MaLop";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
        {
            { "@MaLop", maLop },
            { "@TenLop", tenLop },
            { "@MaKhoa", maKhoa }
        };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh cập nhật dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Cập nhật lớp thành công!");

                // Cập nhật lại DataGridView
                QuanLyLop_Load(sender, e);
                ClearInputs();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã lớp từ trường nhập liệu
                string maLop = txtMaLop.Text.Trim();

                // Kiểm tra trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maLop))
                {
                    MessageBox.Show("Vui lòng chọn lớp cần xóa.");
                    return;
                }

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Chuẩn bị câu lệnh SQL để xóa dữ liệu
                    string query = "DELETE FROM tblLop WHERE sMaLop = @MaLop";

                    // Sử dụng parameterized query để tránh SQL Injection
                    var parameters = new Dictionary<string, object>
            {
                { "@MaLop", maLop }
            };

                    // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh xóa dữ liệu
                    kn.ExecuteNonQuery(query, parameters);

                    // Thông báo thành công
                    MessageBox.Show("Xóa lớp thành công!");

                    // Cập nhật lại DataGridView
                    QuanLyLop_Load(sender, e);
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
                if(string.IsNullOrEmpty(tieuChi) || string.IsNullOrEmpty(giaTriTimKiem))
                    {
                    MessageBox.Show("Vui lòng chọn tiêu chí và nhập giá trị tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                // Xây dựng câu lệnh SQL dựa trên tiêu chí tìm kiếm
                string query = "select * from tblLop where ";
                switch (tieuChi)
                {
                    case "Mã lớp":
                        {
                            query += "sMaLop LIKE @giaTriTimKiem";
                            break;
                        }
                    case "Tên lớp":
                        {
                            query += "sTenLop  LIKE  @giaTriTimKiem";
                            break;
                        }
                    case "Mã khoa":
                        {
                            query += "sMaKhoa LIKE @giaTriTimKiem";
                            break;
                        }
                    default:
                        MessageBox.Show("Tiêu chí tìm kiếm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                }
                
                // Thêm ký tự % để tìm kiếm gần đúng
                giaTriTimKiem = "%" + giaTriTimKiem + "%";
                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
                {
                    {"@giaTriTimKiem", giaTriTimKiem }
                };
               
                // Thực thi truy vấn và lấy kết quả
                DataTable dt = kn.Execute(query, parameters);

                // Kiểm tra xem có kết quả nào không
                if (dt.Rows.Count==0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Hiển thị kết quả lên DataGridView

                dgvDanhSachLop.DataSource = dt;

            }
            catch (Exception ex) {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            ClearInputs();
            // Cập nhật lại DataGridView
            QuanLyLop_Load(sender, e);
        }
    }
}