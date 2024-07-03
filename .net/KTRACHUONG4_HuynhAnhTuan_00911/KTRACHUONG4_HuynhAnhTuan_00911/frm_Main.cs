using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTRACHUONG4_HuynhAnhTuan_00911
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void bài1BàiTậpGiảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Baitap1"] == null)
            {
                frm_Baitap1 frm_Baitap1 = new frm_Baitap1();
                frm_Baitap1.MdiParent = this;
                frm_Baitap1.Show();
            }
            else Application.OpenForms["frm_Baitap1"].Activate();
        }

        private void bài3ChọnMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Baitap3"] == null)
            {
                frm_Baitap3 frm_Baitap3 = new frm_Baitap3();
                frm_Baitap3.MdiParent = this;
                frm_Baitap3.Show();
            }
            else Application.OpenForms["frm_Baitap3"].Activate();
        }
    }
}
