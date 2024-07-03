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
    public partial class frm_HangHoa : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_HangHoa()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into HANGHOA values ('" + txt_MAHH.Text + "', N'" + txt_TenHang.Text + "', N'" + txt_NCC.Text + "',Convert(datetime,'" + date_NgayNhap.Text + "',103), N'" + txt_Gia.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Nhập hàng hóa thành công");
            else MessageBox.Show("Nhập hàng hóa thất bại");
            LoadHH();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update HANGHOA set TenHang = N'" + txt_TenHang.Text + "',NhaCungCap = N'" + txt_NCC.Text + "',NgayNhap =Convert(datetime,'" + date_NgayNhap.Text + "',103),Gia = '" + txt_Gia.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật thông tin hàng hóa thành công");
            else MessageBox.Show("Cập nhật thông tin hàng hóa thất bại");
            LoadHH();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete HANGHOA where MSHH = '" + txt_MAHH.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xoá hàng hóa thành công");
                else MessageBox.Show("Xoá hàng hóa thất bại");
                LoadHH();
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

        private void dt_HangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MAHH.Text = dt_HangHoa.CurrentRow.Cells["MSHH"].Value.ToString();
            txt_TenHang.Text = dt_HangHoa.CurrentRow.Cells["TenHang"].Value.ToString();
            txt_NCC.Text = dt_HangHoa.CurrentRow.Cells["NhaCungCap"].Value.ToString();
            date_NgayNhap.Text = dt_HangHoa.CurrentRow.Cells["NgayNhap"].Value.ToString();
            txt_Gia.Text = dt_HangHoa.CurrentRow.Cells["Gia"].Value.ToString();
        }

        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            LoadHH();
        }

        public void LoadHH()
        {
            string sql = "Select * from HANGHOA";
            dt_HangHoa.DataSource = lopchung.LoadDL(sql);
        }
    }
}
