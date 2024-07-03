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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        int dem = 0;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text.ToLower() == "admin" && txt_MatKhau.Text == "123456")
            {
                frm_Main frm = new frm_Main();
                frm.Show();
                this.Hide();
            }
            else
            {
                dem++;
                MessageBox.Show("Bạn đã nhập sai tài khoản mật khẩu " + dem.ToString() + " lần");
                if (dem == 3) Application.Exit();
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.ResetText();
            txt_MatKhau.ResetText();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_MatKhau.PasswordChar == '*')
            {
                txt_MatKhau.PasswordChar = '\0';
            } else
                txt_MatKhau.PasswordChar = '*';
        }
    }
}
