﻿namespace QLYPHONGGYM
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.quảnLýHồSơToolStripMenuItem,
            this.quảnLýPhòngTậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hToolStripMenuItem.Text = "Hệ thống";
            // 
            // quảnLýHồSơToolStripMenuItem
            // 
            this.quảnLýHồSơToolStripMenuItem.Name = "quảnLýHồSơToolStripMenuItem";
            this.quảnLýHồSơToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.quảnLýHồSơToolStripMenuItem.Text = "Quản lý hồ sơ";
            // 
            // quảnLýPhòngTậpToolStripMenuItem
            // 
            this.quảnLýPhòngTậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýToolStripMenuItem});
            this.quảnLýPhòngTậpToolStripMenuItem.Name = "quảnLýPhòngTậpToolStripMenuItem";
            this.quảnLýPhòngTậpToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.quảnLýPhòngTậpToolStripMenuItem.Text = "Quản lý phòng tập";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.đăngKýToolStripMenuItem.Text = "Đăng ký";
            this.đăngKýToolStripMenuItem.Click += new System.EventHandler(this.đăngKýToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "frm_main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
    }
}

