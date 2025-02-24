namespace BTL_QuanLyDiemSinhVien
{
    partial class QuanLyMonHoc
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
            this.dgvDanhSachMH = new System.Windows.Forms.DataGridView();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMH)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tín chỉ";
            // 
            // dgvDanhSachMH
            // 
            this.dgvDanhSachMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMH.Location = new System.Drawing.Point(400, 12);
            this.dgvDanhSachMH.Name = "dgvDanhSachMH";
            this.dgvDanhSachMH.RowHeadersWidth = 51;
            this.dgvDanhSachMH.RowTemplate.Height = 24;
            this.dgvDanhSachMH.Size = new System.Drawing.Size(579, 332);
            this.dgvDanhSachMH.TabIndex = 15;
            this.dgvDanhSachMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMH_CellClick);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(20, 3);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(81, 48);
            this.btnThemMH.TabIndex = 9;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Location = new System.Drawing.Point(149, 3);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(81, 48);
            this.btnSuaMH.TabIndex = 10;
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Location = new System.Drawing.Point(274, 0);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(81, 51);
            this.btnXoaMH.TabIndex = 11;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemMH);
            this.panel2.Controls.Add(this.btnSuaMH);
            this.panel2.Controls.Add(this.btnXoaMH);
            this.panel2.Location = new System.Drawing.Point(16, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 54);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSoTinChi);
            this.panel1.Controls.Add(this.txtTenMH);
            this.panel1.Controls.Add(this.txtMaMH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 162);
            this.panel1.TabIndex = 16;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(119, 116);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(236, 22);
            this.txtSoTinChi.TabIndex = 8;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(119, 65);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(236, 22);
            this.txtTenMH.TabIndex = 7;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(119, 13);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(236, 22);
            this.txtMaMH.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnQuayLai);
            this.panel4.Location = new System.Drawing.Point(737, 376);
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
            this.panel5.Location = new System.Drawing.Point(16, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 101);
            this.panel5.TabIndex = 31;
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
            this.label7.Location = new System.Drawing.Point(17, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nhập TT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tìm kiếm theo";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã môn học",
            "Tên môn học",
            "Số tín chỉ"});
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
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 493);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvDanhSachMH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyMonHoc";
            this.Text = "QuanLyMonHoc";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMH)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDanhSachMH;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.TextBox txtNhapTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Button btnTim;
    }
}