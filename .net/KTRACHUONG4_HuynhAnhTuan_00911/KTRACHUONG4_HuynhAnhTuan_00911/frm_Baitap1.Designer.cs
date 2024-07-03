namespace KTRACHUONG4_HuynhAnhTuan_00911
{
    partial class frm_Baitap1
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
            this.txt_HeSoA = new System.Windows.Forms.TextBox();
            this.txt_HeSoB = new System.Windows.Forms.TextBox();
            this.txt_HeSoC = new System.Windows.Forms.TextBox();
            this.btn_Giai = new System.Windows.Forms.Button();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(140, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(141, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ số B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(140, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ số C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(229, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // txt_HeSoA
            // 
            this.txt_HeSoA.Location = new System.Drawing.Point(326, 95);
            this.txt_HeSoA.Name = "txt_HeSoA";
            this.txt_HeSoA.Size = new System.Drawing.Size(209, 22);
            this.txt_HeSoA.TabIndex = 4;
            // 
            // txt_HeSoB
            // 
            this.txt_HeSoB.Location = new System.Drawing.Point(326, 167);
            this.txt_HeSoB.Name = "txt_HeSoB";
            this.txt_HeSoB.Size = new System.Drawing.Size(209, 22);
            this.txt_HeSoB.TabIndex = 5;
            // 
            // txt_HeSoC
            // 
            this.txt_HeSoC.Location = new System.Drawing.Point(326, 234);
            this.txt_HeSoC.Name = "txt_HeSoC";
            this.txt_HeSoC.Size = new System.Drawing.Size(209, 22);
            this.txt_HeSoC.TabIndex = 6;
            // 
            // btn_Giai
            // 
            this.btn_Giai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Giai.Location = new System.Drawing.Point(160, 306);
            this.btn_Giai.Name = "btn_Giai";
            this.btn_Giai.Size = new System.Drawing.Size(90, 43);
            this.btn_Giai.TabIndex = 7;
            this.btn_Giai.Text = "Giải";
            this.btn_Giai.UseVisualStyleBackColor = true;
            this.btn_Giai.Click += new System.EventHandler(this.btn_Giai_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_NhapLai.Location = new System.Drawing.Point(326, 306);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(90, 43);
            this.btn_NhapLai.TabIndex = 8;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.UseVisualStyleBackColor = true;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(484, 306);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(90, 43);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_Baitap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_NhapLai);
            this.Controls.Add(this.btn_Giai);
            this.Controls.Add(this.txt_HeSoC);
            this.Controls.Add(this.txt_HeSoB);
            this.Controls.Add(this.txt_HeSoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "frm_Baitap1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_Baitap1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HeSoA;
        private System.Windows.Forms.TextBox txt_HeSoB;
        private System.Windows.Forms.TextBox txt_HeSoC;
        private System.Windows.Forms.Button btn_Giai;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.Button btn_Thoat;
    }
}