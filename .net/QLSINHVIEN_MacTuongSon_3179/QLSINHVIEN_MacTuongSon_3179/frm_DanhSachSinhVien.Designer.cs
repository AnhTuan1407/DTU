namespace QLSINHVIEN_MacTuongSon_3179
{
    partial class frm_DanhSachSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DanhSachSinhVien));
            this.lbl_CapNhatDanhSachSinhVien = new System.Windows.Forms.Label();
            this.lbl_MaSinhVien = new System.Windows.Forms.Label();
            this.lbl_HoVaTen = new System.Windows.Forms.Label();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.dt_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.tb_MaSinhVien = new System.Windows.Forms.MaskedTextBox();
            this.tb_HoVaTen = new System.Windows.Forms.TextBox();
            this.tb_Lop = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lbl_DanhSachSinhVien = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CapNhatDanhSachSinhVien
            // 
            this.lbl_CapNhatDanhSachSinhVien.AutoSize = true;
            this.lbl_CapNhatDanhSachSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CapNhatDanhSachSinhVien.ForeColor = System.Drawing.Color.Red;
            this.lbl_CapNhatDanhSachSinhVien.Location = new System.Drawing.Point(186, 9);
            this.lbl_CapNhatDanhSachSinhVien.Name = "lbl_CapNhatDanhSachSinhVien";
            this.lbl_CapNhatDanhSachSinhVien.Size = new System.Drawing.Size(464, 31);
            this.lbl_CapNhatDanhSachSinhVien.TabIndex = 0;
            this.lbl_CapNhatDanhSachSinhVien.Text = "CẬP NHẬT DANH SÁCH SINH VIÊN";
            // 
            // lbl_MaSinhVien
            // 
            this.lbl_MaSinhVien.AutoSize = true;
            this.lbl_MaSinhVien.Location = new System.Drawing.Point(77, 118);
            this.lbl_MaSinhVien.Name = "lbl_MaSinhVien";
            this.lbl_MaSinhVien.Size = new System.Drawing.Size(67, 13);
            this.lbl_MaSinhVien.TabIndex = 1;
            this.lbl_MaSinhVien.Text = "Mã sinh viên";
            // 
            // lbl_HoVaTen
            // 
            this.lbl_HoVaTen.AutoSize = true;
            this.lbl_HoVaTen.Location = new System.Drawing.Point(77, 157);
            this.lbl_HoVaTen.Name = "lbl_HoVaTen";
            this.lbl_HoVaTen.Size = new System.Drawing.Size(54, 13);
            this.lbl_HoVaTen.TabIndex = 1;
            this.lbl_HoVaTen.Text = "Họ và tên";
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Location = new System.Drawing.Point(77, 197);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(25, 13);
            this.lbl_Lop.TabIndex = 1;
            this.lbl_Lop.Text = "Lớp";
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.AutoSize = true;
            this.dt_NgaySinh.Location = new System.Drawing.Point(77, 236);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(54, 13);
            this.dt_NgaySinh.TabIndex = 1;
            this.dt_NgaySinh.Text = "Ngày sinh";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(77, 272);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(40, 13);
            this.lbl_DiaChi.TabIndex = 1;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // tb_MaSinhVien
            // 
            this.tb_MaSinhVien.Location = new System.Drawing.Point(173, 111);
            this.tb_MaSinhVien.Name = "tb_MaSinhVien";
            this.tb_MaSinhVien.Size = new System.Drawing.Size(157, 20);
            this.tb_MaSinhVien.TabIndex = 3;
            // 
            // tb_HoVaTen
            // 
            this.tb_HoVaTen.Location = new System.Drawing.Point(173, 150);
            this.tb_HoVaTen.Name = "tb_HoVaTen";
            this.tb_HoVaTen.Size = new System.Drawing.Size(157, 20);
            this.tb_HoVaTen.TabIndex = 4;
            // 
            // tb_Lop
            // 
            this.tb_Lop.Location = new System.Drawing.Point(173, 190);
            this.tb_Lop.Name = "tb_Lop";
            this.tb_Lop.Size = new System.Drawing.Size(157, 20);
            this.tb_Lop.TabIndex = 4;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(173, 265);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(157, 20);
            this.tb_DiaChi.TabIndex = 4;
            // 
            // ptb_HinhAnh
            // 
            this.ptb_HinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("ptb_HinhAnh.Image")));
            this.ptb_HinhAnh.Location = new System.Drawing.Point(521, 111);
            this.ptb_HinhAnh.Name = "ptb_HinhAnh";
            this.ptb_HinhAnh.Size = new System.Drawing.Size(174, 174);
            this.ptb_HinhAnh.TabIndex = 6;
            this.ptb_HinhAnh.TabStop = false;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(80, 304);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 38);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(161, 304);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 38);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(242, 304);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 38);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // lbl_DanhSachSinhVien
            // 
            this.lbl_DanhSachSinhVien.AutoSize = true;
            this.lbl_DanhSachSinhVien.Location = new System.Drawing.Point(47, 358);
            this.lbl_DanhSachSinhVien.Name = "lbl_DanhSachSinhVien";
            this.lbl_DanhSachSinhVien.Size = new System.Drawing.Size(104, 13);
            this.lbl_DanhSachSinhVien.TabIndex = 8;
            this.lbl_DanhSachSinhVien.Text = "Danh sách sinh viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(50, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 116);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sinh viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Hình ảnh";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã lớp";
            this.Column6.Name = "Column6";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // frm_DanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 502);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_DanhSachSinhVien);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.ptb_HinhAnh);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_Lop);
            this.Controls.Add(this.tb_HoVaTen);
            this.Controls.Add(this.tb_MaSinhVien);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.dt_NgaySinh);
            this.Controls.Add(this.lbl_Lop);
            this.Controls.Add(this.lbl_HoVaTen);
            this.Controls.Add(this.lbl_MaSinhVien);
            this.Controls.Add(this.lbl_CapNhatDanhSachSinhVien);
            this.Name = "frm_DanhSachSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.frm_DanhSachSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CapNhatDanhSachSinhVien;
        private System.Windows.Forms.Label lbl_MaSinhVien;
        private System.Windows.Forms.Label lbl_HoVaTen;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.Label dt_NgaySinh;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.MaskedTextBox tb_MaSinhVien;
        private System.Windows.Forms.TextBox tb_HoVaTen;
        private System.Windows.Forms.TextBox tb_Lop;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.PictureBox ptb_HinhAnh;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label lbl_DanhSachSinhVien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}