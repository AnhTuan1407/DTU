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
    public partial class frm_NhanVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHANVIEN values ('" + txt_MSNV.Text + "', N'" + txt_HoTen.Text + "',Convert(datetime,'" + date_NgaySinh.Text + "',103), N'" + txt_DiaChi.Text + "','" + txt_ChucVu.Text + "', N'" + txt_Luong.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm nhân viên thành công");
            else MessageBox.Show("Thêm sinh nhân thất bại");
            LoadNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update NHANVIEN set HoTen = N'" + txt_HoTen.Text + "',DiaChi = N'" + txt_DiaChi.Text + "',NgaySinh = Convert(datetime,'" + date_NgaySinh.Text + "',103),ChucVu = '" + txt_ChucVu.Text + "',Luong = '" + txt_Luong.Text + "' where MSNV ='" + txt_MSNV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật nhân viên thành công");
            else MessageBox.Show("Cập nhật nhân viên thất bại");
            LoadNV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete NHANVIEN where MSNV = '" + txt_MSNV.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xoá nhân viên thành công");
                else MessageBox.Show("Xoá nhân viên thất bại");
                LoadNV();
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

        private void dt_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSNV.Text = dt_NhanVien.CurrentRow.Cells["MSNV"].Value.ToString();
            txt_HoTen.Text = dt_NhanVien.CurrentRow.Cells["HoTen"].Value.ToString();
            txt_DiaChi.Text = dt_NhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            date_NgaySinh.Text = dt_NhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_ChucVu.Text = dt_NhanVien.CurrentRow.Cells["Chucvu"].Value.ToString();
            txt_Luong.Text = dt_NhanVien.CurrentRow.Cells["Luong"].Value.ToString();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        public void LoadNV()
        {
            string sql = "Select * from NHANVIEN";
            dt_NhanVien.DataSource = lopchung.LoadDL(sql);
        }
    }
}
