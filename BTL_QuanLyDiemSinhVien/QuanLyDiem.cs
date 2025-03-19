using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL_QuanLyDiemSinhVien
{
    public partial class QuanLyDiem : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public QuanLyDiem()
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

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select * from tblDiemHP";
            dt = kn.Execute(query);
            dgvDanhSachDiem.DataSource = dt;
        }

        private void dgvDanhSachDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng đã chọn một hàng hợp lệ
            {
                DataGridViewRow row = dgvDanhSachDiem.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["sMaSV"].Value.ToString();
                txtMaMH.Text = row.Cells["sMaMH"].Value.ToString();
              
                txtHocKy.Text = row.Cells["sHocKy"].Value.ToString();
                txtNamHoc.Text = row.Cells["sNamHoc"].Value.ToString();
                txtDiemCC.Text = row.Cells["fDiemCC"].Value.ToString();
                txtDiemGK.Text = row.Cells["fDiemGK"].Value.ToString();
                txtDiemCK.Text = row.Cells["fDiemCK"].Value.ToString();
            }
        }
        private void btnThemDiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string maSV = txtMaSV.Text;
                string maMH = txtMaMH.Text;
                string hocKy = txtHocKy.Text;
                string namHoc = txtNamHoc.Text;

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maMH) || string.IsNullOrEmpty(hocKy) || string.IsNullOrEmpty(namHoc))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Khai báo biến để lưu điểm và kiểm tra đầu vào
                float diemCC, diemGK, diemCK;

                // Kiểm tra và chuyển đổi giá trị điểm
                if (!float.TryParse(txtDiemCC.Text, out diemCC) || diemCC < 0 || diemCC > 10)
                {
                    MessageBox.Show("Điểm CC phải là số từ 0 đến 10.");
                    return;
                }

                if (!float.TryParse(txtDiemGK.Text, out diemGK) || diemGK < 0 || diemGK > 10)
                {
                    MessageBox.Show("Điểm GK phải là số từ 0 đến 10.");
                    return;
                }

                if (!float.TryParse(txtDiemCK.Text, out diemCK) || diemCK < 0 || diemCK > 10)
                {
                    MessageBox.Show("Điểm CK phải là số từ 0 đến 10.");
                    return;
                }

                // Chuẩn bị câu lệnh SQL để chèn dữ liệu
                string query = "INSERT INTO tblDiemHP (sMaSV, sMaMH, sHocKy, sNamHoc, fDiemCC, fDiemGK, fDiemCK) " +
                               "VALUES (@maSV, @maMH, @hocKy, @namHoc, @diemCC, @diemGK, @diemCK)";

                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
                {
                    { "@maSV", maSV },
                    { "@maMH", maMH },
                    { "@hocKy", hocKy },
                    { "@namHoc", namHoc },
                    { "@diemCC", diemCC },
                    { "@diemGK", diemGK },
                    { "@diemCK", diemCK }
                };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh chèn dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Thêm điểm thành công!");

                // Cập nhật lại DataGridView
                QuanLyDiem_Load(sender, e);
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
            txtMaMH.Clear();
            txtHocKy.Clear();
            txtNamHoc.Clear();
            txtDiemCC.Clear();
            txtDiemGK.Clear();
            txtDiemCK.Clear();
            txtNhapTT.Clear();
           
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string maSV = txtMaSV.Text;
                string maMH = txtMaMH.Text;
                string hocKy = txtHocKy.Text;
                string namHoc = txtNamHoc.Text;

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maMH) || string.IsNullOrEmpty(hocKy) || string.IsNullOrEmpty(namHoc))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Khai báo biến để lưu điểm và kiểm tra đầu vào
                float diemCC, diemGK, diemCK;

                // Kiểm tra và chuyển đổi giá trị điểm
                if (!float.TryParse(txtDiemCC.Text, out diemCC) || diemCC < 0 || diemCC > 10)
                {
                    MessageBox.Show("Điểm CC phải là số từ 0 đến 10.");
                    return;
                }

                if (!float.TryParse(txtDiemGK.Text, out diemGK) || diemGK < 0 || diemGK > 10)
                {
                    MessageBox.Show("Điểm GK phải là số từ 0 đến 10.");
                    return;
                }

                if (!float.TryParse(txtDiemCK.Text, out diemCK) || diemCK < 0 || diemCK > 10)
                {
                    MessageBox.Show("Điểm CK phải là số từ 0 đến 10.");
                    return;
                }

                // Chuẩn bị câu lệnh SQL để chèn dữ liệu
                string query = "UPDATE tblDiemHP SET  fDiemCC = @diemCC, fDiemGK = @diemGK, fDiemCK = @diemCK " +
                        "WHERE sMaSV = @maSV AND sMaMH = @maMH and sHocKy = @hocKy and sNamHoc = @namHoc ";
                // Sử dụng parameterized query để tránh SQL Injection
                var parameters = new Dictionary<string, object>
                {
                    { "@maSV", maSV },
                    { "@maMH", maMH },
                    { "@hocKy", hocKy },
                    { "@namHoc", namHoc },
                    { "@diemCC", diemCC },
                    { "@diemGK", diemGK },
                    { "@diemCK", diemCK }
                };

                // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh chèn dữ liệu
                kn.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Sửa điểm thành công!");

                // Cập nhật lại DataGridView
                QuanLyDiem_Load(sender, e);
                ClearInputs();

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã sinh viên và mã môn học từ các trường nhập liệu
                string maSV = txtMaSV.Text;
                string maMH = txtMaMH.Text;

                // Kiểm tra các trường nhập liệu có rỗng hay không
                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maMH))
                {
                    MessageBox.Show("Vui lòng chọn điểm cần xóa.");
                    return;
                }

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa điểm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Chuẩn bị câu lệnh SQL để xóa dữ liệu
                    string query = "DELETE FROM tblDiemHP WHERE sMaSV = @maSV AND sMaMH = @maMH";

                    // Sử dụng parameterized query để tránh SQL Injection
                    var parameters = new Dictionary<string, object>
            {
                { "@maSV", maSV },
                { "@maMH", maMH }
            };

                    // Sử dụng phương thức ExecuteNonQuery để thực hiện lệnh xóa dữ liệu
                    kn.ExecuteNonQuery(query, parameters);

                    // Thông báo thành công
                    MessageBox.Show("Xóa điểm thành công!");

                    // Cập nhật lại DataGridView
                    QuanLyDiem_Load(sender, e);
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
                string query = "SELECT * FROM tblDiemHP WHERE ";

                switch (tieuChi)
                {
                    case "Mã sinh viên":
                        query += "sMaSV LIKE @giaTriTimKiem";
                        break;
                    case "Mã môn học":
                        query += "sMaMH LIKE @giaTriTimKiem";
                        break;
                    case "Học kỳ":
                        query += "sHocKy LIKE @giaTriTimKiem";
                        break;
                    case "Năm học":
                        query += "sNamHoc LIKE @giaTriTimKiem";
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
                dgvDanhSachDiem.DataSource = dt;
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
            QuanLyDiem_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem mã môn học đã được chọn hay chưa
                if (string.IsNullOrEmpty(txtMaMH.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem năm học và học kỳ đã được chọn hay chưa
                if (string.IsNullOrEmpty(txtNamHoc.Text) || string.IsNullOrEmpty(txtHocKy.Text))
                {
                    MessageBox.Show("Vui lòng nhập năm học và học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Truy vấn dữ liệu từ cơ sở dữ liệu
                string query = @"
    SELECT tblMonHoc.sMaMH, tblMonHoc.sTenMH, tblMonHoc.iSoTC, tblDiemHP.sHocKy, tblDiemHP.sNamHoc,
           tblSinhVien.sMaSV, tblSinhVien.sTenSV, tblSinhVien.dNgaySinh, 
           tblDiemHP.fDiemCC, tblDiemHP.fDiemGK, tblDiemHP.fDiemCK
    FROM tblMonHoc
    INNER JOIN tblDiemHP ON tblMonHoc.sMaMH = tblDiemHP.sMaMH
    INNER JOIN tblSinhVien ON tblDiemHP.sMaSV = tblSinhVien.sMaSV
    WHERE tblMonHoc.sMaMH = @MaMH AND tblDiemHP.sNamHoc = @NamHoc AND tblDiemHP.sHocKy = @HocKy";

                var parameters = new Dictionary<string, object>
        {
            { "@MaMH", txtMaMH.Text },
            { "@NamHoc", txtNamHoc.Text },
            { "@HocKy", txtHocKy.Text }
        };

                // Thực thi truy vấn và lấy dữ liệu
                DataTable dt = kn.Execute(query, parameters);

                // Kiểm tra xem có dữ liệu trả về hay không
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Gán dữ liệu cho Crystal Report
                rptBangDiem2 baocao = new rptBangDiem2();
                baocao.SetDataSource(dt);

                // Hiển thị báo cáo
                frmInBaoCao form = new frmInBaoCao();
                form.crystalReportViewer1.ReportSource = baocao;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}