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
    public partial class tim_thu : Form
    {
        public tim_thu()
        {
            InitializeComponent();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txt_Thu.Text);

            switch(num)
            {
                case 2: txt_Thu.Text = "Thứ hai"; break;
                case 3: txt_Thu.Text = "Thứ ba"; break;
                case 4: txt_Thu.Text = "Thứ tư"; break;
                case 5: txt_Thu.Text = "Thứ năm"; break;
                case 6: txt_Thu.Text = "Thứ sáu"; break;
                case 7: txt_Thu.Text = "Thứ bảy"; break;
                case 8: txt_Thu.Text = "Chủ nhật"; break;
            }
        }
    }
}
