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
    public partial class frm_NhapBac : Form
    {
        public frm_NhapBac()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            frm_Bac Bac = new frm_Bac();
            Bac.bac = int.Parse(txt_NhapBac.Text);
            Bac.Show();
         }
    }
}
