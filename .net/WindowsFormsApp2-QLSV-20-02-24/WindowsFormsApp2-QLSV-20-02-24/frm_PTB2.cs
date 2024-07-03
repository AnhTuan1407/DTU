using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_QLSV_20_02_24
{
    public partial class frm_PTB2 : Form
    {
        public frm_PTB2()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Giai_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (double.TryParse(txt_HesoA.Text, out a) && double.TryParse(txt_HesoB.Text, out b) && double.TryParse(txt_HesoC.Text, out c))
            {
                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    MessageBox.Show($"Phương trình có 2 nghiệm:\nX1 = {x1}\nX2 = {x2}");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    MessageBox.Show($"Phương trình có nghiệm kép:\nX = {x}");
                }
                else
                {
                    MessageBox.Show("Phương trình không có nghiệm thực.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập các hệ số là số hợp lệ.");
            }
        }
    }
}

