namespace BTL_QuanLyDiemSinhVien
{
    partial class QuanLyLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.txtNhapTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khoa";
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(404, 12);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            this.dgvDanhSachLop.RowHeadersWidth = 51;
            this.dgvDanhSachLop.RowTemplate.Height = 24;
            this.dgvDanhSachLop.Size = new System.Drawing.Size(574, 315);
            this.dgvDanhSachLop.TabIndex = 17;
            this.dgvDanhSachLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLop_CellClick);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(30, 3);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(79, 49);
            this.btnThemLop.TabIndex = 9;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Location = new System.Drawing.Point(156, 3);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(79, 49);
            this.btnSuaLop.TabIndex = 10;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(283, 3);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(79, 49);
            this.btnXoaLop.TabIndex = 11;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemLop);
            this.panel2.Controls.Add(this.btnSuaLop);
            this.panel2.Controls.Add(this.btnXoaLop);
            this.panel2.Location = new System.Drawing.Point(19, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 55);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaKhoa);
            this.panel1.Controls.Add(this.txtTenLop);
            this.panel1.Controls.Add(this.txtMaLop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 157);
            this.panel1.TabIndex = 18;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(97, 114);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(265, 22);
            this.txtMaKhoa.TabIndex = 9;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(97, 64);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(265, 22);
            this.txtTenLop.TabIndex = 8;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(97, 11);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(265, 22);
            this.txtMaLop.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnQuayLai);
            this.panel4.Location = new System.Drawing.Point(697, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 58);
            this.panel4.TabIndex = 28;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(116, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 44);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(12, 6);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(81, 44);
            this.btnQuayLai.TabIndex = 0;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXoaTT);
            this.panel5.Controls.Add(this.txtNhapTT);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.cbTimKiem);
            this.panel5.Controls.Add(this.btnTim);
            this.panel5.Location = new System.Drawing.Point(19, 236);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(379, 101);
            this.panel5.TabIndex = 30;
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.Location = new System.Drawing.Point(296, 63);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.Size = new System.Drawing.Size(66, 28);
            this.btnXoaTT.TabIndex = 30;
            this.btnXoaTT.Text = "Xóa";
            this.btnXoaTT.UseVisualStyleBackColor = true;
            this.btnXoaTT.Click += new System.EventHandler(this.btnXoaTT_Click);
            // 
            // txtNhapTT
            // 
            this.txtNhapTT.Location = new System.Drawing.Point(120, 63);
            this.txtNhapTT.Name = "txtNhapTT";
            this.txtNhapTT.Size = new System.Drawing.Size(157, 22);
            this.txtNhapTT.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nhập TT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tìm kiếm theo";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã lớp",
            "Tên lớp",
            "Mã khoa"});
            this.cbTimKiem.Location = new System.Drawing.Point(120, 8);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(157, 24);
            this.cbTimKiem.TabIndex = 19;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(296, 8);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(66, 31);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // QuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 500);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvDanhSachLop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyLop";
            this.Text = "QuanLyLop";
            this.Load += new System.EventHandler(this.QuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDanhSachLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.TextBox txtNhapTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Button btnTim;
    }
}