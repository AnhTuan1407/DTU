namespace KTRACHUONG4_HuynhAnhTuan_00911
{
    partial class frm_Baitap3
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lib_A = new System.Windows.Forms.ListBox();
            this.Lib_B = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_Ngay = new System.Windows.Forms.TextBox();
            this.txt_Gio = new System.Windows.Forms.TextBox();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.btn_LamTrong = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_ThongTin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(288, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN MÔN HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giờ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh sách môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh sách đã chọn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thông tin";
            // 
            // Lib_A
            // 
            this.Lib_A.FormattingEnabled = true;
            this.Lib_A.ItemHeight = 16;
            this.Lib_A.Items.AddRange(new object[] {
            "Hướng đối tượng",
            "Tiếng Anh",
            "Lập trình .NET",
            "Java",
            "Web"});
            this.Lib_A.Location = new System.Drawing.Point(84, 238);
            this.Lib_A.Name = "Lib_A";
            this.Lib_A.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_A.Size = new System.Drawing.Size(125, 196);
            this.Lib_A.TabIndex = 7;
            // 
            // Lib_B
            // 
            this.Lib_B.FormattingEnabled = true;
            this.Lib_B.ItemHeight = 16;
            this.Lib_B.Location = new System.Drawing.Point(447, 238);
            this.Lib_B.Name = "Lib_B";
            this.Lib_B.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_B.Size = new System.Drawing.Size(125, 196);
            this.Lib_B.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 12;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 13;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(178, 80);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(232, 22);
            this.txt_HoTen.TabIndex = 14;
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.Location = new System.Drawing.Point(178, 129);
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Size = new System.Drawing.Size(100, 22);
            this.txt_Ngay.TabIndex = 15;
            // 
            // txt_Gio
            // 
            this.txt_Gio.Location = new System.Drawing.Point(520, 129);
            this.txt_Gio.Name = "txt_Gio";
            this.txt_Gio.Size = new System.Drawing.Size(100, 22);
            this.txt_Gio.TabIndex = 16;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(447, 496);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(102, 44);
            this.btn_Nhap.TabIndex = 17;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // btn_LamTrong
            // 
            this.btn_LamTrong.Location = new System.Drawing.Point(447, 552);
            this.btn_LamTrong.Name = "btn_LamTrong";
            this.btn_LamTrong.Size = new System.Drawing.Size(102, 44);
            this.btn_LamTrong.TabIndex = 18;
            this.btn_LamTrong.Text = "Làm trống";
            this.btn_LamTrong.UseVisualStyleBackColor = true;
            this.btn_LamTrong.Click += new System.EventHandler(this.btn_LamTrong_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(447, 602);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(102, 44);
            this.btn_Thoat.TabIndex = 19;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_ThongTin
            // 
            this.txt_ThongTin.Location = new System.Drawing.Point(84, 507);
            this.txt_ThongTin.Multiline = true;
            this.txt_ThongTin.Name = "txt_ThongTin";
            this.txt_ThongTin.Size = new System.Drawing.Size(213, 139);
            this.txt_ThongTin.TabIndex = 20;
            // 
            // frm_Baitap3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 658);
            this.Controls.Add(this.txt_ThongTin);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamTrong);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.txt_Gio);
            this.Controls.Add(this.txt_Ngay);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lib_B);
            this.Controls.Add(this.Lib_A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "frm_Baitap3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_Baitap3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Lib_A;
        private System.Windows.Forms.ListBox Lib_B;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_Ngay;
        private System.Windows.Forms.TextBox txt_Gio;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Button btn_LamTrong;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_ThongTin;
    }
}