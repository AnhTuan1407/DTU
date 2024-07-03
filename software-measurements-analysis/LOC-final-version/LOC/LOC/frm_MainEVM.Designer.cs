namespace LOC
{
    partial class frm_MainEVM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_VAC = new System.Windows.Forms.TextBox();
            this.txt_ETC = new System.Windows.Forms.TextBox();
            this.txt_EAC = new System.Windows.Forms.TextBox();
            this.txt_CPI = new System.Windows.Forms.TextBox();
            this.txt_CV = new System.Windows.Forms.TextBox();
            this.txt_SPI = new System.Windows.Forms.TextBox();
            this.txt_SV = new System.Windows.Forms.TextBox();
            this.txt_PV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteEVM = new System.Windows.Forms.Button();
            this.btn_exportEVM = new System.Windows.Forms.Button();
            this.btn_EVM = new System.Windows.Forms.Button();
            this.txt_EV = new System.Windows.Forms.TextBox();
            this.txt_AC = new System.Windows.Forms.TextBox();
            this.txt_BAC = new System.Windows.Forms.TextBox();
            this.txt_monthE = new System.Windows.Forms.TextBox();
            this.txt_monthSC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_SPI = new System.Windows.Forms.Label();
            this.lb_CPI = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_CPI);
            this.groupBox1.Controls.Add(this.lb_SPI);
            this.groupBox1.Controls.Add(this.txt_VAC);
            this.groupBox1.Controls.Add(this.txt_ETC);
            this.groupBox1.Controls.Add(this.txt_EAC);
            this.groupBox1.Controls.Add(this.txt_CPI);
            this.groupBox1.Controls.Add(this.txt_CV);
            this.groupBox1.Controls.Add(this.txt_SPI);
            this.groupBox1.Controls.Add(this.txt_SV);
            this.groupBox1.Controls.Add(this.txt_PV);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 702);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Earned Value Management";
            this.groupBox1.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_VAC
            // 
            this.txt_VAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_VAC.Location = new System.Drawing.Point(368, 615);
            this.txt_VAC.Name = "txt_VAC";
            this.txt_VAC.ReadOnly = true;
            this.txt_VAC.Size = new System.Drawing.Size(133, 23);
            this.txt_VAC.TabIndex = 59;
            // 
            // txt_ETC
            // 
            this.txt_ETC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ETC.Location = new System.Drawing.Point(368, 570);
            this.txt_ETC.Name = "txt_ETC";
            this.txt_ETC.ReadOnly = true;
            this.txt_ETC.Size = new System.Drawing.Size(133, 23);
            this.txt_ETC.TabIndex = 58;
            // 
            // txt_EAC
            // 
            this.txt_EAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_EAC.Location = new System.Drawing.Point(368, 519);
            this.txt_EAC.Name = "txt_EAC";
            this.txt_EAC.ReadOnly = true;
            this.txt_EAC.Size = new System.Drawing.Size(133, 23);
            this.txt_EAC.TabIndex = 57;
            // 
            // txt_CPI
            // 
            this.txt_CPI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CPI.Location = new System.Drawing.Point(368, 468);
            this.txt_CPI.Name = "txt_CPI";
            this.txt_CPI.ReadOnly = true;
            this.txt_CPI.Size = new System.Drawing.Size(133, 23);
            this.txt_CPI.TabIndex = 56;
            // 
            // txt_CV
            // 
            this.txt_CV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CV.Location = new System.Drawing.Point(368, 414);
            this.txt_CV.Name = "txt_CV";
            this.txt_CV.ReadOnly = true;
            this.txt_CV.Size = new System.Drawing.Size(133, 23);
            this.txt_CV.TabIndex = 55;
            // 
            // txt_SPI
            // 
            this.txt_SPI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SPI.Location = new System.Drawing.Point(368, 361);
            this.txt_SPI.Name = "txt_SPI";
            this.txt_SPI.ReadOnly = true;
            this.txt_SPI.Size = new System.Drawing.Size(133, 23);
            this.txt_SPI.TabIndex = 54;
            // 
            // txt_SV
            // 
            this.txt_SV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SV.Location = new System.Drawing.Point(368, 309);
            this.txt_SV.Name = "txt_SV";
            this.txt_SV.ReadOnly = true;
            this.txt_SV.Size = new System.Drawing.Size(133, 23);
            this.txt_SV.TabIndex = 53;
            // 
            // txt_PV
            // 
            this.txt_PV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PV.Location = new System.Drawing.Point(368, 258);
            this.txt_PV.Name = "txt_PV";
            this.txt_PV.ReadOnly = true;
            this.txt_PV.Size = new System.Drawing.Size(133, 23);
            this.txt_PV.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 622);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 20);
            this.label15.TabIndex = 52;
            this.label15.Text = "Variance At Completion (VAC)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 577);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(251, 20);
            this.label14.TabIndex = 51;
            this.label14.Text = "Estimate To Complete (ETC)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(264, 20);
            this.label13.TabIndex = 50;
            this.label13.Text = "Estimate At Completion (EAC)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "Cost Performance Index (CPI)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Cost Variance (CV)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Schedule Performance Index (SPI)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Schedule Variance (SV)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Planned Value (PV)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DeleteEVM);
            this.groupBox2.Controls.Add(this.btn_exportEVM);
            this.groupBox2.Controls.Add(this.btn_EVM);
            this.groupBox2.Controls.Add(this.txt_EV);
            this.groupBox2.Controls.Add(this.txt_AC);
            this.groupBox2.Controls.Add(this.txt_BAC);
            this.groupBox2.Controls.Add(this.txt_monthE);
            this.groupBox2.Controls.Add(this.txt_monthSC);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(31, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 200);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // btn_DeleteEVM
            // 
            this.btn_DeleteEVM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(53)))), ((int)(((byte)(252)))));
            this.btn_DeleteEVM.FlatAppearance.BorderSize = 0;
            this.btn_DeleteEVM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteEVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteEVM.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteEVM.Location = new System.Drawing.Point(570, 131);
            this.btn_DeleteEVM.Name = "btn_DeleteEVM";
            this.btn_DeleteEVM.Size = new System.Drawing.Size(113, 33);
            this.btn_DeleteEVM.TabIndex = 44;
            this.btn_DeleteEVM.Text = "Delete";
            this.btn_DeleteEVM.UseVisualStyleBackColor = false;
            this.btn_DeleteEVM.Click += new System.EventHandler(this.btn_DeleteEVM_Click);
            // 
            // btn_exportEVM
            // 
            this.btn_exportEVM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(53)))), ((int)(((byte)(252)))));
            this.btn_exportEVM.FlatAppearance.BorderSize = 0;
            this.btn_exportEVM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportEVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportEVM.ForeColor = System.Drawing.Color.White;
            this.btn_exportEVM.Location = new System.Drawing.Point(570, 86);
            this.btn_exportEVM.Name = "btn_exportEVM";
            this.btn_exportEVM.Size = new System.Drawing.Size(113, 33);
            this.btn_exportEVM.TabIndex = 43;
            this.btn_exportEVM.Text = "Export";
            this.btn_exportEVM.UseVisualStyleBackColor = false;
            this.btn_exportEVM.Click += new System.EventHandler(this.btn_exportEVM_Click);
            // 
            // btn_EVM
            // 
            this.btn_EVM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(53)))), ((int)(((byte)(252)))));
            this.btn_EVM.FlatAppearance.BorderSize = 0;
            this.btn_EVM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EVM.ForeColor = System.Drawing.Color.White;
            this.btn_EVM.Location = new System.Drawing.Point(570, 42);
            this.btn_EVM.Name = "btn_EVM";
            this.btn_EVM.Size = new System.Drawing.Size(113, 33);
            this.btn_EVM.TabIndex = 42;
            this.btn_EVM.Text = "Count";
            this.btn_EVM.UseVisualStyleBackColor = false;
            this.btn_EVM.Click += new System.EventHandler(this.btn_EVM_Click);
            // 
            // txt_EV
            // 
            this.txt_EV.Location = new System.Drawing.Point(325, 159);
            this.txt_EV.Name = "txt_EV";
            this.txt_EV.Size = new System.Drawing.Size(133, 30);
            this.txt_EV.TabIndex = 41;
            this.txt_EV.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txt_EV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // txt_AC
            // 
            this.txt_AC.Location = new System.Drawing.Point(325, 120);
            this.txt_AC.Name = "txt_AC";
            this.txt_AC.Size = new System.Drawing.Size(133, 30);
            this.txt_AC.TabIndex = 40;
            this.txt_AC.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txt_AC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // txt_BAC
            // 
            this.txt_BAC.Location = new System.Drawing.Point(325, 84);
            this.txt_BAC.Name = "txt_BAC";
            this.txt_BAC.Size = new System.Drawing.Size(133, 30);
            this.txt_BAC.TabIndex = 39;
            this.txt_BAC.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txt_BAC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // txt_monthE
            // 
            this.txt_monthE.Location = new System.Drawing.Point(164, 48);
            this.txt_monthE.Name = "txt_monthE";
            this.txt_monthE.Size = new System.Drawing.Size(57, 30);
            this.txt_monthE.TabIndex = 38;
            this.txt_monthE.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txt_monthE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonth_KeyPress);
            // 
            // txt_monthSC
            // 
            this.txt_monthSC.Location = new System.Drawing.Point(325, 16);
            this.txt_monthSC.Name = "txt_monthSC";
            this.txt_monthSC.Size = new System.Drawing.Size(57, 30);
            this.txt_monthSC.TabIndex = 37;
            this.txt_monthSC.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txt_monthSC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonth_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Earned Value (EV)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Actual Cost (AC)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Budget at completion (BAC)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "months";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = " The end of the ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "months";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = " The project is scheduled to last for ";
            // 
            // lb_SPI
            // 
            this.lb_SPI.AutoSize = true;
            this.lb_SPI.Location = new System.Drawing.Point(555, 268);
            this.lb_SPI.Name = "lb_SPI";
            this.lb_SPI.Size = new System.Drawing.Size(0, 25);
            this.lb_SPI.TabIndex = 60;
            // 
            // lb_CPI
            // 
            this.lb_CPI.AutoSize = true;
            this.lb_CPI.Location = new System.Drawing.Point(555, 319);
            this.lb_CPI.Name = "lb_CPI";
            this.lb_CPI.Size = new System.Drawing.Size(0, 25);
            this.lb_CPI.TabIndex = 61;
            // 
            // frm_MainEVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 761);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_MainEVM";
            this.Text = "frm_MainEVM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_EV;
        private System.Windows.Forms.TextBox txt_AC;
        private System.Windows.Forms.TextBox txt_BAC;
        private System.Windows.Forms.TextBox txt_monthE;
        private System.Windows.Forms.TextBox txt_monthSC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_DeleteEVM;
        private System.Windows.Forms.Button btn_exportEVM;
        private System.Windows.Forms.Button btn_EVM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_VAC;
        private System.Windows.Forms.TextBox txt_ETC;
        private System.Windows.Forms.TextBox txt_EAC;
        private System.Windows.Forms.TextBox txt_CPI;
        private System.Windows.Forms.TextBox txt_CV;
        private System.Windows.Forms.TextBox txt_SPI;
        private System.Windows.Forms.TextBox txt_SV;
        private System.Windows.Forms.TextBox txt_PV;
        private System.Windows.Forms.Label lb_SPI;
        private System.Windows.Forms.Label lb_CPI;
    }
}