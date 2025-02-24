using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyDiemSinhVien
{
    public partial class frmDoiMK : Form
        
    {

        KetNoiCSDL kn = new KetNoiCSDL();
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các trường nhập liệu
                string userName = txtTenDangNhap.Text.Trim();
                string matKhauCu = txbMKCu.Text.Trim();
                string matKhauMoi = txbMKMoi.Text.Trim();
                string nhapLaiMatKhau = txbNhapLaiMK.Text.Trim();

                // Kiểm tra các trường nhập liệu có rỗng không
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(matKhauCu) ||
                    string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(nhapLaiMatKhau))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mật khẩu mới và mật khẩu cũ  có khác nhau không
                if (matKhauCu == matKhauMoi)
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu cũ trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mật khẩu mới và nhập lại mật khẩu có khớp nhau không
                if (matKhauMoi != nhapLaiMatKhau)
                {
                    MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Kiểm tra mật khẩu cũ có đúng không
                string queryCheckOldPassword = "SELECT COUNT(*) FROM tblSinhVien WHERE sUserName = @TenDangNhap AND sPassWord = @MatKhau";
                var parametersCheckOldPassword = new Dictionary<string, object>
        {
            { "@TenDangNhap", userName },
            { "@MatKhau", matKhauCu }
        };

                int count = Convert.ToInt32(kn.ExecuteScalar(queryCheckOldPassword, parametersCheckOldPassword));
                if (count == 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật mật khẩu mới
                string queryUpdatePassword = "UPDATE tblSinhVien SET sPassWord = @MatKhauMoi WHERE sUserName = @TenDangNhap";
                var parametersUpdatePassword = new Dictionary<string, object>
        {
            { "@TenDangNhap", userName },
            { "@MatKhauMoi", matKhauMoi }
        };

                kn.ExecuteNonQuery(queryUpdatePassword, parametersUpdatePassword);

                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa các trường nhập liệu sau khi cập nhật thành công
                txtTenDangNhap.Clear();
                txbMKCu.Clear();
                txbMKMoi.Clear();
                txbNhapLaiMK.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form form = new frmDangNhap();
            form.Show();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmDangNhap();
            form.Show();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
