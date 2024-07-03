using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCANHAN_LeHoaiAnh
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_GiaoVien"] == null)
            {
                frm_GiaoVien frm_GiaoVien = new frm_GiaoVien();
                frm_GiaoVien.MdiParent = this;
                frm_GiaoVien.Show();
            }
            else Application.OpenForms["frm_GiaoVien"].Activate();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_SinhVien"] == null)
            {
                frm_SinhVien frm_SinhVien = new frm_SinhVien();
                frm_SinhVien.MdiParent = this;
                frm_SinhVien.Show();
            }
            else Application.OpenForms["frm_SinhVien"].Activate();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_SinhVien"] == null)
            {
                frm_SinhVien frm_SinhVien = new frm_SinhVien();
                frm_SinhVien.MdiParent = this;
                frm_SinhVien.Show();
            }
            else Application.OpenForms["frm_SinhVien"].Activate();
        }
    }
}
