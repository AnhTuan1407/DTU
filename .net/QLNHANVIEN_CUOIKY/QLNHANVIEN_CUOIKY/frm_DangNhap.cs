using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANVIEN_CUOIKY
{
    public partial class frm_DangNhap : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            int dem = 0;
            string sql = "Select COUNT (*) from TAIKHOAN where TENDANGNHAP = '" + txt_TenDangNhap.Text + "' and MATKHAU = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopchung.LayGT(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_NhanVien frm_NhanVien = new frm_NhanVien();
                this.Hide();
                frm_NhanVien.ShowDialog();
                this.Show();
            }
            else
            {
                dem++;
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu " + dem.ToString() + " lần");
                if (dem == 3) Application.Exit();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
