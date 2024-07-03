namespace ListBox_NhapBac
{
    partial class frm_ListBox_HoTen
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
            this.cb_Ho = new System.Windows.Forms.ComboBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lib_A
            // 
            this.Lib_A.FormattingEnabled = true;
            this.Lib_A.ItemHeight = 20;
            this.Lib_A.Location = new System.Drawing.Point(52, 151);
            this.Lib_A.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Lib_A.Name = "Lib_A";
            this.Lib_A.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_A.Size = new System.Drawing.Size(259, 304);
            this.Lib_A.TabIndex = 0;
            // 
            // Lib_B
            // 
            this.Lib_B.FormattingEnabled = true;
            this.Lib_B.ItemHeight = 20;
            this.Lib_B.Location = new System.Drawing.Point(545, 151);
            this.Lib_B.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Lib_B.Name = "Lib_B";
            this.Lib_B.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_B.Size = new System.Drawing.Size(267, 304);
            this.Lib_B.TabIndex = 1;
            // 
            // cb_Ho
            // 
            this.cb_Ho.FormattingEnabled = true;
            this.cb_Ho.Location = new System.Drawing.Point(52, 46);
            this.cb_Ho.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cb_Ho.Name = "cb_Ho";
            this.cb_Ho.Size = new System.Drawing.Size(180, 28);
            this.cb_Ho.TabIndex = 2;
            this.cb_Ho.SelectedIndexChanged += new System.EventHandler(this.cb_Ho_SelectedIndexChanged);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(371, 151);
            this.btn_1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(113, 35);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = ">";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(371, 214);
            this.btn_2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(113, 35);
            this.btn_2.TabIndex = 4;
            this.btn_2.Text = ">>";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(371, 357);
            this.btn_3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(113, 35);
            this.btn_3.TabIndex = 5;
            this.btn_3.Text = "<";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(371, 422);
            this.btn_4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(113, 35);
            this.btn_4.TabIndex = 6;
            this.btn_4.Text = "<<";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // frm_ListBox_HoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 517);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.cb_Ho);
            this.Controls.Add(this.Lib_B);
            this.Controls.Add(this.Lib_A);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_ListBox_HoTen";
            this.Text = "frm_ListBox_HoTen";
            this.Load += new System.EventHandler(this.frm_ListBox_HoTen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lib_A;
        private System.Windows.Forms.ListBox Lib_B;
        private System.Windows.Forms.ComboBox cb_Ho;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
    }
}