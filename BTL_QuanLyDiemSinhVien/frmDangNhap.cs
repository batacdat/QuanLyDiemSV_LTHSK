using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QuanLyDiemSinhVien
{
    public partial class frmDangNhap : Form
    {

        KetNoiCSDL kn = new KetNoiCSDL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string id, pass;
            id = txtUserName.Text.Trim();
            pass = txtPassWord.Text.Trim();
            DataTable dt = new DataTable();
            string query = "select * from tblSinhVien where sUserName = '" + id + "'and sPassWord = '" + pass + "'";
            dt = kn.Execute(query);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Exception!");

            }
            else
            {
                this.Hide();
                Form form = new frmTrangChu();
                form.Show();
            }
        }

        private void lbDangKi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmDoiMK();
            form.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình ??", "Thông báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }
    }
    }

