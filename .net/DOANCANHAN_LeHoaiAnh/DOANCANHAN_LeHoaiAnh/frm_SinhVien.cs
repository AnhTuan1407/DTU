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
    public partial class frm_SinhVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_SinhVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SINHVIEN values ('" + txt_MSSV.Text + "', N'" + txt_TenSinhVien.Text + "',Convert(datetime,'" + date_NgaySinh.Text + "',103),'" + txt_DiaChi.Text + "', N'" + txt_Lop.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm sinh viên thành công");
            else MessageBox.Show("Thêm sinh viên thất bại");
            LoadSV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update SINHVIEN set TenSinhVien = N'" + txt_TenSinhVien.Text + "',DiaChi = N'" + txt_DiaChi.Text + "',NgaySinh = Convert(datetime,'" + date_NgaySinh.Text + "',103),Lop = '" + txt_Lop.Text + "' where MSSV ='" + txt_MSSV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật sinh viên thành công");
            else MessageBox.Show("Cập nhật sinh viên thất bại");
            LoadSV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete SINHVIEN where MSSV = '" + txt_MSSV.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xoá sinh viên thành công");
                else MessageBox.Show("Xoá sinh viên thất bại");
                LoadSV();
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

        private void dt_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSSV.Text = dt_SinhVien.CurrentRow.Cells["MSSV"].Value.ToString();
            txt_TenSinhVien.Text = dt_SinhVien.CurrentRow.Cells["TenSinhVien"].Value.ToString();
            txt_DiaChi.Text = dt_SinhVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            date_NgaySinh.Text = dt_SinhVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_Lop.Text = dt_SinhVien.CurrentRow.Cells["Lop"].Value.ToString();
        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            LoadSV();
        }

        public void LoadSV()
        {
            string sql = "Select * from SINHVIEN";
            dt_SinhVien.DataSource = lopchung.LoadDL(sql);
        }

    }
}
