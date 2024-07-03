namespace ListBox_NhapBac
{
    partial class frm_ListBox
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
            this.Lib_A = new System.Windows.Forms.ListBox();
            this.Lib_B = new System.Windows.Forms.ListBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lib_A
            // 
            this.Lib_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lib_A.FormattingEnabled = true;
            this.Lib_A.ItemHeight = 29;
            this.Lib_A.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.Lib_A.Location = new System.Drawing.Point(16, 30);
            this.Lib_A.Margin = new System.Windows.Forms.Padding(4);
            this.Lib_A.Name = "Lib_A";
            this.Lib_A.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_A.Size = new System.Drawing.Size(352, 323);
            this.Lib_A.TabIndex = 0;
            // 
            // Lib_B
            // 
            this.Lib_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lib_B.FormattingEnabled = true;
            this.Lib_B.ItemHeight = 39;
            this.Lib_B.Location = new System.Drawing.Point(700, 30);
            this.Lib_B.Margin = new System.Windows.Forms.Padding(4);
            this.Lib_B.Name = "Lib_B";
            this.Lib_B.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_B.Size = new System.Drawing.Size(336, 277);
            this.Lib_B.TabIndex = 1;
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(529, 42);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(67, 44);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = ">";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(529, 113);
            this.btn_2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(67, 41);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = ">>";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(529, 188);
            this.btn_3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(67, 53);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "<";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(529, 265);
            this.btn_4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(67, 47);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "<<";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // frm_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 448);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.Lib_B);
            this.Controls.Add(this.Lib_A);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ListBox";
            this.Text = "frm_ListBox";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Lib_B;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.ListBox Lib_A;
    }
}