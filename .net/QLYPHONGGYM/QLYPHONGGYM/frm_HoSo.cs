using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYPHONGGYM
{
    public partial class frm_HoSo : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_HoSo()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KHACHHANG values ('" + txt_MSKH.Text + "', N'" + txt_HoTen.Text + "', N'" + txt_DiaChi.Text + "',Convert(datetime,'" + dt_NgaySinh.Text + "',103),'" + cb_GiaoVien.SelectedValue + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm khách hàng thành công");
            else MessageBox.Show("Thêm khách hàng thất bại");
            LoadKH();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update KHACHHANG set HOTEN = N'" + txt_HoTen.Text + "',DIACHI = N'" + txt_DiaChi.Text + "',NGAYSINH = Convert(datetime,'" + dt_NgaySinh.Text + "',103),MSGVHD = '" + cb_GiaoVien.SelectedValue + "' where MSKH ='" + txt_MSKH.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật khách hàng thành công");
            else MessageBox.Show("Cập nhật khách hàng thất bại");
            LoadKH();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete KHACHHANG where MSKH = '" + txt_MSKH.Text + "'";
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
            txt_MSKH.Text = dt_KhachHang.CurrentRow.Cells["MSKH"].Value.ToString();
            txt_HoTen.Text = dt_KhachHang.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_DiaChi.Text = dt_KhachHang.CurrentRow.Cells["DIACHI"].Value.ToString();
            dt_NgaySinh.Text = dt_KhachHang.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            cb_GiaoVien.SelectedValue = dt_KhachHang.CurrentRow.Cells["MSGVHD"].Value.ToString();
        }

        private void frm_HoSo_Load(object sender, EventArgs e)
        {
            LoadKH();
            LoadGV();
        }

        public void LoadKH()
        {
            string sql = "Select * from KHACHHANG";
            dt_KhachHang.DataSource = lopchung.LoadDL(sql);
        }

        public void LoadGV()
        {
            string sql = "Select * from GIAOVIEN";
            cb_GiaoVien.DataSource = lopchung.LoadDL(sql);
            cb_GiaoVien.DisplayMember = "TENGVHD";
            cb_GiaoVien.ValueMember = "MSGVHD";
        }
    }
}
