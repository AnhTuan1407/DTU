namespace LOC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_deleteall = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_Folder = new System.Windows.Forms.Button();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btn_count);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1178, 774);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_deleteall);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.btn_export);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1158, 530);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // btn_deleteall
            // 
            this.btn_deleteall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btn_deleteall.FlatAppearance.BorderSize = 0;
            this.btn_deleteall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteall.ForeColor = System.Drawing.Color.White;
            this.btn_deleteall.Location = new System.Drawing.Point(983, 431);
            this.btn_deleteall.Name = "btn_deleteall";
            this.btn_deleteall.Size = new System.Drawing.Size(141, 33);
            this.btn_deleteall.TabIndex = 18;
            this.btn_deleteall.Text = "Delete All";
            this.btn_deleteall.UseVisualStyleBackColor = false;
            this.btn_deleteall.Click += new System.EventHandler(this.btn_deleteall_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(914, 467);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(983, 484);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(141, 33);
            this.btn_export.TabIndex = 12;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(983, 380);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 33);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_count
            // 
            this.btn_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(53)))), ((int)(((byte)(252)))));
            this.btn_count.FlatAppearance.BorderSize = 0;
            this.btn_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_count.ForeColor = System.Drawing.Color.White;
            this.btn_count.Location = new System.Drawing.Point(511, 185);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(153, 33);
            this.btn_count.TabIndex = 13;
            this.btn_count.Text = "Count Function";
            this.btn_count.UseVisualStyleBackColor = false;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_file);
            this.groupBox1.Controls.Add(this.btn_file);
            this.groupBox1.Controls.Add(this.btn_Folder);
            this.groupBox1.Controls.Add(this.txt_folder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 155);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Folder or File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Folder";
            // 
            // txt_file
            // 
            this.txt_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(236)))));
            this.txt_file.Location = new System.Drawing.Point(141, 91);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(804, 27);
            this.txt_file.TabIndex = 11;
            // 
            // btn_file
            // 
            this.btn_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(236)))));
            this.btn_file.FlatAppearance.BorderSize = 0;
            this.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.ForeColor = System.Drawing.Color.White;
            this.btn_file.Location = new System.Drawing.Point(983, 96);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(141, 33);
            this.btn_file.TabIndex = 10;
            this.btn_file.Text = "Select File";
            this.btn_file.UseVisualStyleBackColor = false;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_Folder
            // 
            this.btn_Folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(236)))));
            this.btn_Folder.FlatAppearance.BorderSize = 0;
            this.btn_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Folder.ForeColor = System.Drawing.Color.White;
            this.btn_Folder.Location = new System.Drawing.Point(983, 40);
            this.btn_Folder.Name = "btn_Folder";
            this.btn_Folder.Size = new System.Drawing.Size(141, 33);
            this.btn_Folder.TabIndex = 7;
            this.btn_Folder.Text = "Select Folder";
            this.btn_Folder.UseVisualStyleBackColor = false;
            this.btn_Folder.Click += new System.EventHandler(this.btn_Folder_Click);
            // 
            // txt_folder
            // 
            this.txt_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_folder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(236)))));
            this.txt_folder.Location = new System.Drawing.Point(141, 40);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(804, 27);
            this.txt_folder.TabIndex = 6;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1178, 774);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btn_Folder;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Button btn_deleteall;
    }
}