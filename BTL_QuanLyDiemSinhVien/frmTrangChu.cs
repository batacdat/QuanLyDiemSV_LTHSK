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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmDoiMK();
            form.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmDoiMK();
            form.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình ??", "Thông báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }

        private void QuanLySVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new QuanLySV();
            form.Show();
        }

        private void QuanLyLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new QuanLyLop();
            form.Show();
        }

        private void QuanLyKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new QuanLyKhoa();
            form.Show();
        }

        private void QuanLyDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new QuanLyDiem();
            form.Show();
        }

        private void QuanLyMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new QuanLyMonHoc();
            form.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new QuanLyGV();
            form.Show();
        }
    }
}
