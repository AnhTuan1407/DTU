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
    public partial class frm_GiaoVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_GiaoVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into GIAOVIEN values ('" + txt_MSGV.Text + "', N'" + txt_TenGiaoVien.Text + "',Convert(datetime,'" + date_NgaySinh.Text + "',103),'" + txt_TrinhDo.Text + "', N'" + txt_Luong.Text + "', N'" + txt_DiaChi.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm giáo viên thành công");
            else MessageBox.Show("Thêm giáo viên thất bại");
            LoadGV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update GIAOVIEN set TenGiaoVien = N'" + txt_TenGiaoVien.Text + "',DiaChi = N'" + txt_DiaChi.Text + "',NgaySinh = Convert(datetime,'" + date_NgaySinh.Text + "',103),TrinhDo = '" + txt_TrinhDo.Text + "' where MSGV ='" + txt_MSGV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật giáo viên thành công");
            else MessageBox.Show("Cập nhật giáo viên thất bại");
            LoadGV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete GIAOVIEN where MSGV = '" + txt_MSGV.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xoá giáo viên thành công");
                else MessageBox.Show("Xoá giáo viên thất bại");
                LoadGV();
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

        private void dt_GiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSGV.Text = dt_GiaoVien.CurrentRow.Cells["MSGV"].Value.ToString();
            txt_TenGiaoVien.Text = dt_GiaoVien.CurrentRow.Cells["TenGiaoVien"].Value.ToString();
            txt_DiaChi.Text = dt_GiaoVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            date_NgaySinh.Text = dt_GiaoVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_TrinhDo.Text = dt_GiaoVien.CurrentRow.Cells["TrinhDo"].Value.ToString();
            txt_Luong.Text = dt_GiaoVien.CurrentRow.Cells["Luong"].Value.ToString();
        }

        private void frm_GiaoVien_Load(object sender, EventArgs e)
        {
            LoadGV();
        }

        public void LoadGV()
        {
            string sql = "Select * from GIAOVIEN";
            dt_GiaoVien.DataSource = lopchung.LoadDL(sql);
        }
    }
}
