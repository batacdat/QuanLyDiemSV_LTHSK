namespace BTL_QuanLyDiemSinhVien
{
    partial class QuanLyGV
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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhSachSV = new System.Windows.Forms.DataGridView();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtBangCap = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.txtNhapTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel5.Controls.Add(this.btnThoat);
            this.panel5.Controls.Add(this.btnQuayLai);
            this.panel5.Location = new System.Drawing.Point(1176, 494);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 58);
            this.panel5.TabIndex = 35;
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
            // dgvDanhSachSV
            // 
            this.dgvDanhSachSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSV.Location = new System.Drawing.Point(587, 12);
            this.dgvDanhSachSV.Name = "dgvDanhSachSV";
            this.dgvDanhSachSV.RowHeadersWidth = 51;
            this.dgvDanhSachSV.RowTemplate.Height = 24;
            this.dgvDanhSachSV.Size = new System.Drawing.Size(849, 449);
            this.dgvDanhSachSV.TabIndex = 31;
            this.dgvDanhSachSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSV_CellClick);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(360, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(155, 22);
            this.txtUserName.TabIndex = 28;
            // 
            // txtBangCap
            // 
            this.txtBangCap.Location = new System.Drawing.Point(112, 222);
            this.txtBangCap.Name = "txtBangCap";
            this.txtBangCap.Size = new System.Drawing.Size(148, 22);
            this.txtBangCap.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtBangCap);
            this.panel1.Controls.Add(this.txtPassWord);
            this.panel1.Controls.Add(this.txtTenGV);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtMaGV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(34, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 288);
            this.panel1.TabIndex = 32;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(362, 82);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(155, 22);
            this.txtPassWord.TabIndex = 27;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(112, 82);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(148, 22);
            this.txtTenGV.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "UserName:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "PassWord:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(110, 154);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(148, 22);
            this.txtSDT.TabIndex = 18;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(110, 12);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(148, 22);
            this.txtMaGV.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giảng viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bằng cấp";
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXoaGV.Location = new System.Drawing.Point(400, 3);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(66, 42);
            this.btnXoaGV.TabIndex = 14;
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.UseVisualStyleBackColor = false;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXoaTT);
            this.panel4.Controls.Add(this.txtNhapTT);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.cbTimKiem);
            this.panel4.Controls.Add(this.btnTim);
            this.panel4.Location = new System.Drawing.Point(34, 360);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(529, 101);
            this.panel4.TabIndex = 34;
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.Location = new System.Drawing.Point(414, 63);
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
            this.txtNhapTT.Size = new System.Drawing.Size(229, 22);
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
            "Mã giảng viên",
            "Họ tên",
            "Bằng cấp"});
            this.cbTimKiem.Location = new System.Drawing.Point(120, 8);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(229, 24);
            this.cbTimKiem.TabIndex = 19;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(414, 8);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(66, 31);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSuaGV.Location = new System.Drawing.Point(231, 3);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(66, 42);
            this.btnSuaGV.TabIndex = 13;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.UseVisualStyleBackColor = false;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemGV);
            this.panel2.Controls.Add(this.btnSuaGV);
            this.panel2.Controls.Add(this.btnXoaGV);
            this.panel2.Location = new System.Drawing.Point(34, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 47);
            this.panel2.TabIndex = 33;
            // 
            // btnThemGV
            // 
            this.btnThemGV.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThemGV.Location = new System.Drawing.Point(59, 3);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(66, 42);
            this.btnThemGV.TabIndex = 12;
            this.btnThemGV.Text = "Thêm ";
            this.btnThemGV.UseVisualStyleBackColor = false;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // QuanLyGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 644);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvDanhSachSV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "QuanLyGV";
            this.Text = "QuanLyGV";
            this.Load += new System.EventHandler(this.QuanLyGV_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhSachSV;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtBangCap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.TextBox txtNhapTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemGV;
    }
}