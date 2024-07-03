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
    public partial class frm_Dangnhap : Form
    {
        public frm_Dangnhap()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
           DialogResult dt = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           if(dt == DialogResult.Yes)
            {
                Application.Exit();
            }     
        }

        int dem = 0;

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            if(txt_Taikhoan.Text.ToLower() == "admin" && txt_Matkhau.Text == "123456")
            {
                frm_QLSV sv = new frm_QLSV();
                sv.Show();
            }
            else
            {
                dem++;
                MessageBox.Show("Bạn đã nhập sai tài khoản mật khẩu " + dem.ToString() + " lần");
                if (dem == 3) Application.Exit();
            }
        }
    }
}
