using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCANHAN_HuynhAnhTuan_00911
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien frm_NhanVien = new frm_NhanVien();
                frm_NhanVien.MdiParent = this;
                frm_NhanVien.Show();
            }
            else Application.OpenForms["frm_NhanVien"].Activate();
        }

        private void quảngLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_HangHoa"] == null)
            {
                frm_HangHoa frm_HangHoa = new frm_HangHoa();
                frm_HangHoa.MdiParent = this;
                frm_HangHoa.Show();
            }
            else Application.OpenForms["frm_HangHoa"].Activate();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_KhachHang"] == null)
            {
                frm_KhachHang frm_KhachHang = new frm_KhachHang();
                frm_KhachHang.MdiParent = this;
                frm_KhachHang.Show();
            }
            else Application.OpenForms["frm_KhachHang"].Activate();
        }

        private void xuấtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_XuatHoaDon"] == null)
            {
                frm_XuatHoaDon frm_XuatHoaDon = new frm_XuatHoaDon();
                frm_XuatHoaDon.MdiParent = this;
                frm_XuatHoaDon.Show();
            }
            else Application.OpenForms["frm_XuatHoaDon"].Activate();
        }
    }
}
