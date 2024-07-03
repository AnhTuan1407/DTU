namespace WindowsFormsApp2_QLSV_20_02_24
{
    partial class frm_PTB2
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
            this.txt_HesoA = new System.Windows.Forms.TextBox();
            this.txt_HesoB = new System.Windows.Forms.TextBox();
            this.txt_HesoC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Giai = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_HesoA
            // 
            this.txt_HesoA.Location = new System.Drawing.Point(362, 71);
            this.txt_HesoA.Name = "txt_HesoA";
            this.txt_HesoA.Size = new System.Drawing.Size(198, 22);
            this.txt_HesoA.TabIndex = 0;
            // 
            // txt_HesoB
            // 
            this.txt_HesoB.Location = new System.Drawing.Point(362, 137);
            this.txt_HesoB.Name = "txt_HesoB";
            this.txt_HesoB.Size = new System.Drawing.Size(198, 22);
            this.txt_HesoB.TabIndex = 1;
            // 
            // txt_HesoC
            // 
            this.txt_HesoC.Location = new System.Drawing.Point(362, 206);
            this.txt_HesoC.Name = "txt_HesoC";
            this.txt_HesoC.Size = new System.Drawing.Size(198, 22);
            this.txt_HesoC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hệ số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hệ số B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hệ số C";
            // 
            // btn_Giai
            // 
            this.btn_Giai.Location = new System.Drawing.Point(273, 277);
            this.btn_Giai.Name = "btn_Giai";
            this.btn_Giai.Size = new System.Drawing.Size(86, 40);
            this.btn_Giai.TabIndex = 8;
            this.btn_Giai.Text = "Giải";
            this.btn_Giai.UseVisualStyleBackColor = true;
            this.btn_Giai.Click += new System.EventHandler(this.btn_Giai_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(417, 277);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(86, 40);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_PTB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Giai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_HesoC);
            this.Controls.Add(this.txt_HesoB);
            this.Controls.Add(this.txt_HesoA);
            this.Name = "frm_PTB2";
            this.Text = "PTB2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HesoA;
        private System.Windows.Forms.TextBox txt_HesoB;
        private System.Windows.Forms.TextBox txt_HesoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Giai;
        private System.Windows.Forms.Button btn_Thoat;
    }
}