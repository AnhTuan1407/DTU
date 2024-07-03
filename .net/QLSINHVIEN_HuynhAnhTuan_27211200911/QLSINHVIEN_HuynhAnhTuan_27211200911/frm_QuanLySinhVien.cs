using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSINHVIEN_HuynhAnhTuan_27211200911
{
    public partial class frm_QuanLySinhVien : Form
    {
        public frm_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DanhSachSinhVien"] == null)
            {
                frm_DanhSachSinhVien frm_DanhSachSinhVien = new frm_DanhSachSinhVien();
                frm_DanhSachSinhVien.MdiParent = this;
                frm_DanhSachSinhVien.Show();
            }
            else Application.OpenForms["frm_DanhSachSinhVien"].Activate();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThongTinKhachHang"] == null)
            {
                frm_ThongTinKhachHang frm = new frm_ThongTinKhachHang();
                frm.MdiParent = this;
                frm.Show();
            }
            else Application.OpenForms["frm_ThongTinKhachHang"].Activate();
        }
    }
}
