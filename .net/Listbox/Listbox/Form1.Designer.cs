namespace Listbox
{
    partial class Form1
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.Lib_B = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Lib_A
            // 
            this.Lib_A.FormattingEnabled = true;
            this.Lib_A.ItemHeight = 16;
            this.Lib_A.Location = new System.Drawing.Point(78, 129);
            this.Lib_A.Name = "Lib_A";
            this.Lib_A.Size = new System.Drawing.Size(154, 148);
            this.Lib_A.TabIndex = 0;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(306, 94);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 43);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = ">";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(306, 152);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 44);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = ">>";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(306, 214);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 39);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "<";
            this.btn_3.UseVisualStyleBackColor = true;
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(306, 271);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 40);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "<<";
            this.btn_4.UseVisualStyleBackColor = true;
            // 
            // Lib_B
            // 
            this.Lib_B.FormattingEnabled = true;
            this.Lib_B.ItemHeight = 16;
            this.Lib_B.Location = new System.Drawing.Point(453, 129);
            this.Lib_B.Name = "Lib_B";
            this.Lib_B.Size = new System.Drawing.Size(154, 148);
            this.Lib_B.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lib_B);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.Lib_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lib_A;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.ListBox Lib_B;
    }
}

