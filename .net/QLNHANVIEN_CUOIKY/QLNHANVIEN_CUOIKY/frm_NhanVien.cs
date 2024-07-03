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
    public partial class frm_NhanVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHANVIEN values ('" + txt_MSNV.Text + "', N'" + txt_HoTen.Text + "', N'" + cbb_PhongBan.SelectedValue + "',Convert(datetime,'" + date_NgayVaoLam.Text + "',103),'" + txt_ThamNien.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm nhân viên thành công");
            else MessageBox.Show("Thêm nhân viên thất bại");
            LoadNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update NHANVIEN set HOTEN = N'" + txt_HoTen.Text + "',MAPB = N'" + cbb_PhongBan.SelectedValue + "',NGAYVAOLAM = Convert(datetime,'" + date_NgayVaoLam.Text + "',103),THAMNIEN = '" + txt_ThamNien.Text + "' where MSNV ='" + txt_MSNV.Text + "'";
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
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from NHANVIEN";
            int kq = (int)lopchung.LayGT(sql);
            txt_SoLuong.Text = kq.ToString();
        }

        private void dt_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSNV.Text = dt_NhanVien.CurrentRow.Cells["MSNV"].Value.ToString();
            txt_HoTen.Text = dt_NhanVien.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_ThamNien.Text = dt_NhanVien.CurrentRow.Cells["THAMNIEN"].Value.ToString();
            cbb_PhongBan.SelectedValue = dt_NhanVien.CurrentRow.Cells["MAPB"].Value.ToString();
            date_NgayVaoLam.Text = dt_NhanVien.CurrentRow.Cells["NGAYVAOLAM"].Value.ToString();

        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadPB();
            LoadNV();
        }

        public void LoadPB()
        {
            string sql = "Select * from PHONGBAN";
            cbb_PhongBan.DataSource = lopchung.LoadDL(sql);
            cbb_PhongBan.DisplayMember = "TENPB";
            cbb_PhongBan.ValueMember = "MAPB";
        }

        public void LoadNV()
        {
            string sql = "Select * from NHANVIEN";
            dt_NhanVien.DataSource = lopchung.LoadDL(sql);
        }
    }
}
