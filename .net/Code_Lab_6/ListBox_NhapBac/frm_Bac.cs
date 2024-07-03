using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_NhapBac
{
    public partial class frm_Bac : Form
    {
        
        public frm_Bac()
        {
            InitializeComponent();                 
        }
        public int bac;
        string[] Lb_HeSo = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "K", "L"};       
        private void frm_Bac_Load(object sender, EventArgs e)
        {
            lb_Bac.Text = lb_Bac.Text + bac;
            for(int i = 0; i <= bac; i++)
            {
                Label lb = new Label();
                lb.Text = "Hệ số " + Lb_HeSo[i];
                lb.Location = new Point(50, 35 * (i + 1));
              //  lbl.Left = 50;
              //  lbl.Top = 35 * (i + 1);
              // lbl.AutoSize = true;
                this.Controls.Add(lb);

                TextBox txt = new TextBox();
                txt.Left = 150;
                txt.Top = 35 * (i + 1);
                this.Controls.Add(txt);
            }
            Button btn_Giai = new Button();
            btn_Giai.Text = "Giải";
            btn_Giai.Left = 50;
            btn_Giai.Top = 45 * (bac + 1);
            this.Controls.Add(btn_Giai);

            Button btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Left = 150;
            btnThoat.Top = 45 * (bac + 1);
            this.Controls.Add(btnThoat);

            btnThoat.Click += new System.EventHandler(btnThoat_Click);            // bước 2    
            //btnThoat.Click += btnThoat_Click;       
            // sau khi gõ dấu += thì sẽ hiện lên btnThoat_Click và nhấn phím Tab            
        }

        private void btnThoat_Click(object sender, EventArgs e)    // bước 1
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát ko", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

















        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    DialogResult DR = MessageBox.Show("Bạn có muốn thoát ko", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (DR == DialogResult.Yes)
        //        Application.Exit();
        //}
    }
}
