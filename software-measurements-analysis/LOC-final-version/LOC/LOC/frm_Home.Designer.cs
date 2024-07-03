namespace LOC
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.lb_Text = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Try = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Text
            // 
            this.lb_Text.AutoSize = true;
            this.lb_Text.BackColor = System.Drawing.Color.Transparent;
            this.lb_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Text.ForeColor = System.Drawing.Color.Black;
            this.lb_Text.Location = new System.Drawing.Point(57, 430);
            this.lb_Text.Name = "lb_Text";
            this.lb_Text.Size = new System.Drawing.Size(502, 116);
            this.lb_Text.TabIndex = 37;
            this.lb_Text.Text = "    Count the lines of code in your project \r\nwith our easy-to-use tool! Our tool" +
    " supports \r\n  a variety of programming languages and \r\n                 provides" +
    " accurate results.";
            // 
            // btn_Try
            // 
            this.btn_Try.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(236)))));
            this.btn_Try.FlatAppearance.BorderSize = 0;
            this.btn_Try.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(12)))), ((int)(((byte)(236)))));
            this.btn_Try.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(12)))), ((int)(((byte)(236)))));
            this.btn_Try.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Try.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Try.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_Try.Location = new System.Drawing.Point(224, 602);
            this.btn_Try.Name = "btn_Try";
            this.btn_Try.Size = new System.Drawing.Size(167, 43);
            this.btn_Try.TabIndex = 38;
            this.btn_Try.Text = "TRY IT NOW!";
            this.btn_Try.UseVisualStyleBackColor = false;
            this.btn_Try.Click += new System.EventHandler(this.btn_Try_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 774);
            this.Controls.Add(this.btn_Try);
            this.Controls.Add(this.lb_Text);
            this.DoubleBuffered = true;
            this.Name = "frm_Home";
            this.Text = "frm_Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Text;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Try;
    }
}