using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00911_HuynhAnhTuan
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
            string sql = "Insert into NHANVIEN values ('" + txt_MaNV.Text + "', N'" + txt_HoTen.Text + "', N'" + txt_DiaChi.Text + "',Convert(datetime,'" + date_NgaySinh.Text + "',103),'" + txt_ChucVu.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm nhân viên thành công");
            else MessageBox.Show("Thêm sinh nhân thất bại");
            LoadSV();
            txt_MaNV.ResetText();
            txt_HoTen.ResetText();
            txt_ChucVu.ResetText();
            txt_DiaChi.ResetText();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update NHANVIEN set HOTEN = N'" + txt_HoTen.Text + "',DIACHI = N'" + txt_DiaChi.Text + "',NGAYSINH = Convert(datetime,'" + date_NgaySinh.Text + "',103),CHUCVU = '" + txt_ChucVu.Text + "' where MSNV ='" + txt_MaNV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật nhân viên thành công");
            else MessageBox.Show("Cập nhật nhân viên thất bại");
            LoadSV();
            txt_MaNV.ResetText();
            txt_HoTen.ResetText();
            txt_ChucVu.ResetText();
            txt_DiaChi.ResetText();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete NHANVIEN where MSNV = '" + txt_MaNV.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xoá nhân viên thành công");
                else MessageBox.Show("Xoá nhân viên thất bại");
                LoadSV();
                txt_MaNV.ResetText();
                txt_HoTen.ResetText();
                txt_ChucVu.ResetText();
                txt_DiaChi.ResetText();
            }
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadSV();
        }

        public void LoadSV()
        {
            string sql = "Select * from NHANVIEN";
            dt_NhanVien.DataSource = lopchung.LoadDL(sql);
        }



        private void dt_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dt_NhanVien.CurrentRow.Cells["MSNV"].Value.ToString();
            txt_HoTen.Text = dt_NhanVien.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_DiaChi.Text = dt_NhanVien.CurrentRow.Cells["DIACHI"].Value.ToString();
            date_NgaySinh.Text = dt_NhanVien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_ChucVu.Text = dt_NhanVien.CurrentRow.Cells["CHUCVU"].Value.ToString();
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
