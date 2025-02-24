using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyDiemSinhVien
{
    public partial class QuanLySV : Form
    {
     //   string connectionString = ConfigurationManager.ConnectionStrings["QL_DIEM"].ConnectionString;
        KetNoiCSDL kn = new KetNoiCSDL();
        public QuanLySV()
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
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }

        private void QuanLySV_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tblSinhVien";
            dt = kn.Execute(query);
            dgvDanhSachSV.DataSource = dt;
        }

        private void dgvDanhSachSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachSV.Rows[e.RowIndex];
            txtMaSV.Text = row.Cells["sMaSV"].Value.ToString();
            txtTenSV.Text = row.Cells["sTenSV"].Value.ToString();
            txtGioiTinh.Text = row.Cells["sGioiTinh"].Value.ToString();
            txtNgaySinh.Text = row.Cells["dNgaySinh"].Value.ToString();
            txtQueQuan.Text = row.Cells["sQueQuan"].Value.ToString();
            txtUserName.Text = row.Cells["sUserName"].Value.ToString();
            txtPassWord.Text = row.Cells["sPassWord"].Value.ToString();
            txtMaLop.Text = row.Cells["sMaLop"].Value.ToString();
        }


        private void btnThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string maSV = txtMaSV.Text.Trim();
                string maLop = txtMaLop.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                string gioiTinh = txtGioiTinh.Text.Trim();
                string queQuan = txtQueQuan.Text.Trim();
                string ngaySinhText = txtNgaySinh.Text.Trim();
                string userName = txtUserName.Text.Trim();
                string passWord = txtPassWord.Text.Trim();

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenSV) ||
                    string.IsNullOrEmpty(gioiTinh) || string.IsNullOrEmpty(queQuan) || string.IsNullOrEmpty(ngaySinhText) ||
                    string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Chuyển đổi chuỗi ngày sinh sang kiểu DateTime
                DateTime ngaySinh;
                if (!DateTime.TryParseExact(ngaySinhText, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
                {
                    MessageBox.Show("Định dạng ngày sinh không hợp lệ. Vui lòng nhập theo định dạng yyyy-MM-dd.");
                    return;
                }

                // Chuẩn bị câu lệnh SQL để chèn dữ liệu
                string query = "INSERT INTO tblSinhVien (sMaSV, sTenSV, sGioiTinh, sQueQuan, dNgaySinh,sUserName,sPassWord ,sMaLop) " +
                               "VALUES (@maSV, @tenSV, @gioiTinh, @queQuan, @ngaySinh,@userName,@passWord ,@maLop)";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
        {
            { "@maSV", maSV },
            { "@tenSV", tenSV },
            { "@gioiTinh", gioiTinh },
            { "@queQuan", queQuan },
            { "@ngaySinh", ngaySinh.ToString("yyyy-MM-dd") },
            {"@userName",userName },
            {"@passWord",passWord },
            { "@maLop", maLop }
        };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh chèn dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Thêm sinh viên thành công!");

                // Cập nhật lại DataGridView
                QuanLySV_Load(sender, e);
                // Clear các trường nhập liệu
                ClearInputs();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string maSV = txtMaSV.Text.Trim();
                string maLop = txtMaLop.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                string gioiTinh = txtGioiTinh.Text.Trim();
                string queQuan = txtQueQuan.Text.Trim();
                string ngaySinhText = txtNgaySinh.Text.Trim();
                string userName = txtUserName.Text.Trim();
                string passWord = txtPassWord.Text.Trim();

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenSV) ||
                    string.IsNullOrEmpty(gioiTinh) || string.IsNullOrEmpty(queQuan) || string.IsNullOrEmpty(ngaySinhText) ||
                    string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Chuyển đổi chuỗi ngày sinh sang kiểu DateTime
                DateTime ngaySinh;
                if (!DateTime.TryParseExact(ngaySinhText, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
                {
                    MessageBox.Show("Định dạng ngày sinh không hợp lệ. Vui lòng nhập theo định dạng yyyy-MM-dd.");
                    return;
                }

                // Chuẩn bị câu lệnh SQL để cập nhật dữ liệu
                string query = "UPDATE tblSinhVien SET sTenSV = @tenSV, sGioiTinh = @gioiTinh, sQueQuan = @queQuan, " +
                               "dNgaySinh = @ngaySinh, sUserName = @userName, sPassWord = @passWord, sMaLop = @maLop " +
                               "WHERE sMaSV = @maSV";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
        {
            { "@maSV", maSV },
            { "@tenSV", tenSV },
            { "@gioiTinh", gioiTinh },
            { "@queQuan", queQuan },
            { "@ngaySinh", ngaySinh.ToString("yyyy-MM-dd") },
            { "@userName", userName },
            { "@passWord", passWord },
            { "@maLop", maLop }
        };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh cập nhật dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!");

                // Cập nhật lại DataGridView
                QuanLySV_Load(sender, e);
                // Clear các trường nhập liệu
                ClearInputs();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã sinh viên từ trường nhập liệu
                string maSV = txtMaSV.Text.Trim();

                // Kiểm tra xem mã sinh viên có rỗng hay không
                if (string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                    return;
                }

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                // Chuẩn bị câu lệnh SQL để xóa dữ liệu
                string query = "DELETE FROM tblSinhVien WHERE sMaSV = @maSV";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
        {
            { "@maSV", maSV }
        };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh xóa dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Xóa sinh viên thành công!");

                // Cập nhật lại DataGridView
                QuanLySV_Load(sender, e);

                // Clear các trường nhập liệu
                ClearInputs();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtGioiTinh.Clear();
            txtNgaySinh.Clear();
            txtQueQuan.Clear();
            txtUserName.Clear();
            txtPassWord.Clear();
            txtMaLop.Clear();
            txtNhapTT.Clear();  // xóa thông tin tìm kiếm trong ô nhập TT
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
                string query = "SELECT * FROM tblSinhVien WHERE ";

                switch (tieuChi)
                {
                    case "Mã sinh viên":
                        query += "sMaSV LIKE @giaTriTimKiem";
                        break;
                    case "Họ tên":
                        query += "sTenSV LIKE @giaTriTimKiem";
                        break;
                    case "Mã lớp":
                        query += "sMaLop LIKE @giaTriTimKiem";
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

                // Thực thi truy vấn và lấy kết quả
                DataTable dt = kn.Execute(query, parameters);

                // Kiểm tra xem có kết quả nào không
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear các trường nhập liệu
            ClearInputs();
            // Cập nhật lại DataGridView
            QuanLySV_Load(sender, e);


        }
    }
}

