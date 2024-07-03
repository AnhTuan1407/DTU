namespace DOANCANHAN_HuynhAnhTuan_00911
{
    partial class frm_XuatHoaDon
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.Lib_A = new System.Windows.Forms.ListBox();
            this.Lib_B = new System.Windows.Forms.ListBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Ngay = new System.Windows.Forms.TextBox();
            this.txt_Gio = new System.Windows.Forms.TextBox();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.txt_ThongTin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(321, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hàng hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hàng hóa đã chọn";
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.Location = new System.Drawing.Point(498, 483);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(143, 45);
            this.btn_Xuat.TabIndex = 5;
            this.btn_Xuat.Text = "Xuất hóa đơn";
            this.btn_Xuat.UseVisualStyleBackColor = true;
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(688, 483);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 45);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Lib_A
            // 
            this.Lib_A.FormattingEnabled = true;
            this.Lib_A.ItemHeight = 16;
            this.Lib_A.Items.AddRange(new object[] {
            "Mì tôm",
            "Trứng",
            "Xúc xích",
            "CocaCola",
            "Pepsi",
            "Sting",
            "Snack",
            "Heniken"});
            this.Lib_A.Location = new System.Drawing.Point(445, 108);
            this.Lib_A.Name = "Lib_A";
            this.Lib_A.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_A.Size = new System.Drawing.Size(125, 164);
            this.Lib_A.TabIndex = 8;
            // 
            // Lib_B
            // 
            this.Lib_B.FormattingEnabled = true;
            this.Lib_B.ItemHeight = 16;
            this.Lib_B.Location = new System.Drawing.Point(688, 105);
            this.Lib_B.Name = "Lib_B";
            this.Lib_B.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_B.Size = new System.Drawing.Size(119, 164);
            this.Lib_B.TabIndex = 9;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(597, 146);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(58, 38);
            this.btn_2.TabIndex = 10;
            this.btn_2.Text = ">>";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(597, 190);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(58, 38);
            this.btn_3.TabIndex = 11;
            this.btn_3.Text = "<";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(597, 234);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(58, 38);
            this.btn_4.TabIndex = 12;
            this.btn_4.Text = "<<";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(597, 98);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(58, 38);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = ">";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Giờ";
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.Location = new System.Drawing.Point(148, 180);
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Size = new System.Drawing.Size(208, 22);
            this.txt_Ngay.TabIndex = 16;
            // 
            // txt_Gio
            // 
            this.txt_Gio.Location = new System.Drawing.Point(148, 250);
            this.txt_Gio.Name = "txt_Gio";
            this.txt_Gio.Size = new System.Drawing.Size(208, 22);
            this.txt_Gio.TabIndex = 17;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(148, 114);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(208, 22);
            this.txt_TenKhachHang.TabIndex = 18;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(354, 483);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(94, 45);
            this.btn_Nhap.TabIndex = 19;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // txt_ThongTin
            // 
            this.txt_ThongTin.Location = new System.Drawing.Point(34, 317);
            this.txt_ThongTin.Multiline = true;
            this.txt_ThongTin.Name = "txt_ThongTin";
            this.txt_ThongTin.Size = new System.Drawing.Size(773, 144);
            this.txt_ThongTin.TabIndex = 20;
            // 
            // frm_XuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 550);
            this.Controls.Add(this.txt_ThongTin);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.txt_TenKhachHang);
            this.Controls.Add(this.txt_Gio);
            this.Controls.Add(this.txt_Ngay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.Lib_B);
            this.Controls.Add(this.Lib_A);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_XuatHoaDon";
            this.Text = "frm_XuatHoaDon";
            this.Load += new System.EventHandler(this.frm_XuatHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xuat;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ListBox Lib_A;
        private System.Windows.Forms.ListBox Lib_B;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Ngay;
        private System.Windows.Forms.TextBox txt_Gio;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.TextBox txt_ThongTin;
    }
}