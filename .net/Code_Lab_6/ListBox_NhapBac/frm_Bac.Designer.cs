namespace ListBox_NhapBac
{
    partial class frm_Bac
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
            this.lb_Bac = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Bac
            // 
            this.lb_Bac.AutoSize = true;
            this.lb_Bac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Bac.Location = new System.Drawing.Point(49, 11);
            this.lb_Bac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Bac.Name = "lb_Bac";
            this.lb_Bac.Size = new System.Drawing.Size(264, 29);
            this.lb_Bac.TabIndex = 0;
            this.lb_Bac.Text = "Giải phương trình bậc:   ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Bac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Bac);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Bac";
            this.Text = "frm_Bac";
            this.Load += new System.EventHandler(this.frm_Bac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Bac;
        private System.Windows.Forms.Button button1;
    }
}