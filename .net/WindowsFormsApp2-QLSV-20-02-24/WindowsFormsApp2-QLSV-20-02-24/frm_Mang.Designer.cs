namespace WindowsFormsApp2_QLSV_20_02_24
{
    partial class frm_Mang
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
            this.txt_MangA = new System.Windows.Forms.TextBox();
            this.txt_Tongle = new System.Windows.Forms.TextBox();
            this.txt_Tongchan = new System.Windows.Forms.TextBox();
            this.txt_Tongso = new System.Windows.Forms.TextBox();
            this.btn_Tinhtoan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng các số lẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng các số chẵn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng các số Mảng A";
            // 
            // txt_MangA
            // 
            this.txt_MangA.Location = new System.Drawing.Point(258, 45);
            this.txt_MangA.Name = "txt_MangA";
            this.txt_MangA.Size = new System.Drawing.Size(336, 22);
            this.txt_MangA.TabIndex = 4;
            // 
            // txt_Tongle
            // 
            this.txt_Tongle.Location = new System.Drawing.Point(258, 107);
            this.txt_Tongle.Name = "txt_Tongle";
            this.txt_Tongle.Size = new System.Drawing.Size(100, 22);
            this.txt_Tongle.TabIndex = 5;
            // 
            // txt_Tongchan
            // 
            this.txt_Tongchan.Location = new System.Drawing.Point(258, 166);
            this.txt_Tongchan.Name = "txt_Tongchan";
            this.txt_Tongchan.Size = new System.Drawing.Size(100, 22);
            this.txt_Tongchan.TabIndex = 6;
            // 
            // txt_Tongso
            // 
            this.txt_Tongso.Location = new System.Drawing.Point(258, 227);
            this.txt_Tongso.Name = "txt_Tongso";
            this.txt_Tongso.Size = new System.Drawing.Size(100, 22);
            this.txt_Tongso.TabIndex = 7;
            // 
            // btn_Tinhtoan
            // 
            this.btn_Tinhtoan.Location = new System.Drawing.Point(173, 347);
            this.btn_Tinhtoan.Name = "btn_Tinhtoan";
            this.btn_Tinhtoan.Size = new System.Drawing.Size(90, 23);
            this.btn_Tinhtoan.TabIndex = 8;
            this.btn_Tinhtoan.Text = "Tính toán";
            this.btn_Tinhtoan.UseVisualStyleBackColor = true;
            this.btn_Tinhtoan.Click += new System.EventHandler(this.btn_Tinhtoan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(503, 347);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // frm_Mang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Tinhtoan);
            this.Controls.Add(this.txt_Tongso);
            this.Controls.Add(this.txt_Tongchan);
            this.Controls.Add(this.txt_Tongle);
            this.Controls.Add(this.txt_MangA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Mang";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MangA;
        private System.Windows.Forms.TextBox txt_Tongle;
        private System.Windows.Forms.TextBox txt_Tongchan;
        private System.Windows.Forms.TextBox txt_Tongso;
        private System.Windows.Forms.Button btn_Tinhtoan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Thoat;
    }
}