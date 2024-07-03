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
    public partial class frm_KhachHang : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KHACHHANG values ('" + txt_MaKH.Text + "', N'" + txt_HoTen.Text + "', N'" + txt_DiaChi.Text + "', N'" + txt_SDT.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Lưu thông tin khách hàng thành công");
            else MessageBox.Show("Lưu thông tin khách hàng thất bại");
            LoadKH();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update KHACHHANG set HoTen = N'" + txt_HoTen.Text + "',DiaChi = N'" + txt_DiaChi.Text + "',SDT = '" + txt_SDT.Text +"'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật thông tin khách hàng thành công");
            else MessageBox.Show("Cập nhật thông tin khách hàng thất bại");
            LoadKH();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete KHACHHANG where MSKH = '" + txt_MaKH.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xoá khách hàng thành công");
                else MessageBox.Show("Xoá khách hàng thất bại");
                LoadKH();
            }
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dt_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKH.Text = dt_KhachHang.CurrentRow.Cells["MSKH"].Value.ToString();
            txt_HoTen.Text = dt_KhachHang.CurrentRow.Cells["HoTen"].Value.ToString();
            txt_DiaChi.Text = dt_KhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = dt_KhachHang.CurrentRow.Cells["SDT"].Value.ToString();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        public void LoadKH()
        {
            string sql = "Select * from KHACHHANG";
            dt_KhachHang.DataSource = lopchung.LoadDL(sql);
        }
    }
}
