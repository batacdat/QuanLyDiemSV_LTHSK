using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BTL_QuanLyDiemSinhVien
{
    public partial class QuanLyMonHoc : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public QuanLyMonHoc()
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

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM tblMonHoc";
                dt = kn.Execute(query);
                dgvDanhSachMH.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvDanhSachMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng hợp lệ
            {
                DataGridViewRow row = dgvDanhSachMH.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells["sMaMH"].Value.ToString();
                txtTenMH.Text = row.Cells["sTenMH"].Value.ToString();
                txtSoTinChi.Text = row.Cells["iSoTC"].Value.ToString();
            }
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = txtMaMH.Text.Trim();
                string tenMH = txtTenMH.Text.Trim();
                string soTCText = txtSoTinChi.Text.Trim();

                // Kiểm tra giá trị nhập vào
                if (string.IsNullOrEmpty(maMH) || string.IsNullOrEmpty(tenMH) || string.IsNullOrEmpty(soTCText))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                if (!int.TryParse(soTCText, out int soTC) || soTC <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải là số nguyên dương!");
                    return;
                }

                // Sử dụng tham số hóa để tránh SQL Injection
                string query = "INSERT INTO tblMonHoc (sMaMH, sTenMH, iSoTC) VALUES (@MaMH, @TenMH, @SoTC)";
                var parameters = new Dictionary<string, object>
                {
                    { "@MaMH", maMH },
                    { "@TenMH", tenMH },
                    { "@SoTC", soTC }
                };

                kn.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Thêm môn học thành công!");
                ClearInputs();
                LoadData(); // Tải lại dữ liệu sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtSoTinChi.Clear();
            txtNhapTT.Clear();
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = txtMaMH.Text.Trim();
                string tenMH = txtTenMH.Text.Trim();
                string soTCText = txtSoTinChi.Text.Trim();

                // Kiểm tra giá trị nhập vào
                if (string.IsNullOrEmpty(maMH) || string.IsNullOrEmpty(tenMH) || string.IsNullOrEmpty(soTCText))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }

                if (!int.TryParse(soTCText, out int soTC) || soTC <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải là số nguyên dương!");
                    return;
                }

                // Sử dụng tham số hóa để tránh SQL Injection
                string query = "UPDATE tblMonHoc SET sTenMH = @TenMH, iSoTC = @SoTC WHERE sMaMH = @MaMH";
                var parameters = new Dictionary<string, object>
        {
            { "@MaMH", maMH },
            { "@TenMH", tenMH },
            { "@SoTC", soTC }
        };

                kn.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Sửa môn học thành công!");
                ClearInputs();
                LoadData(); // Tải lại dữ liệu sau khi sửa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = txtMaMH.Text.Trim();

                // Kiểm tra giá trị nhập vào
                if (string.IsNullOrEmpty(maMH))
                {
                    MessageBox.Show("Vui lòng chọn môn học cần xóa!");
                    return;
                }

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Sử dụng tham số hóa để tránh SQL Injection
                    string query = "DELETE FROM tblMonHoc WHERE sMaMH = @MaMH";
                    var parameters = new Dictionary<string, object>
            {
                { "@MaMH", maMH }
            };

                    kn.ExecuteNonQuery(query, parameters);

                    MessageBox.Show("Xóa môn học thành công!");
                    ClearInputs();
                    LoadData(); // Tải lại dữ liệu sau khi xóa
                }
            }
            catch (Exception ex)
            {
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
                string query = "SELECT * FROM tblMonHoc WHERE ";

                switch (tieuChi)
                {
                    case "Mã môn học":
                        query += "sMaMH LIKE @giaTriTimKiem";
                        break;
                    case "Tên môn học":
                        query += "sTenMH LIKE @giaTriTimKiem";
                        break;
                    case "Số tín chỉ":
                        query += "iSoTC LIKE @giaTriTimKiem";
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
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Hiển thị kết quả lên DataGridView
                dgvDanhSachMH.DataSource = dt;
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
            QuanLyMonHoc_Load(sender, e);
        }
    }
}