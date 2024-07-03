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
    public partial class frm_XuatHoaDon : Form
    {
        public frm_XuatHoaDon()
        {
            InitializeComponent();
            this.Load += frm_XuatHoaDon_Load;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void frm_XuatHoaDon_Load(object sender, EventArgs e)
        {
            UpdateCurrentDateTime();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateCurrentTime();
        }
        private void UpdateCurrentDateTime()
        {
            txt_Ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void UpdateCurrentTime()
        {
            txt_Gio.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void btn_1_Click(object sender, EventArgs e) 
        {
            for (int i = Lib_A.SelectedItems.Count - 1; i >= 0; i--)
            {
                Lib_B.Items.Add(Lib_A.SelectedItems[i]);
                Lib_A.Items.Remove(Lib_A.SelectedItems[i]);
            }
            Lib_A.Sorted = true; 
            Lib_B.Sorted = true;
        }
        private void btn_2_Click(object sender, EventArgs e) 
        {
            for (int i = 0; i < Lib_A.Items.Count; i++)
            {
                Lib_B.Items.Add(Lib_A.Items[i]);
            }
            Lib_A.Items.Clear();
            Lib_B.Sorted = true;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            for (int i = Lib_B.SelectedItems.Count - 1; i >= 0; i--)
            {
                Lib_A.Items.Add(Lib_B.SelectedItems[i]);
                Lib_B.Items.Remove(Lib_B.SelectedItems[i]);
            }
            Lib_A.Sorted = true;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lib_B.Items.Count; i++)
            {
                Lib_A.Items.Add(Lib_B.Items[i]);
            }
            Lib_B.Items.Clear();
            Lib_A.Sorted = true;
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            string hoTen = txt_TenKhachHang.Text;
            string selectedItems = "";

            for (int i = 0; i < Lib_B.Items.Count; i++)
            {
                selectedItems += Lib_B.Items[i].ToString() + ", ";
            }
            string ngay = txt_Ngay.Text;
            string gio = txt_Gio.Text;
            txt_ThongTin.Text = $"Họ tên khách hàng: {hoTen}\r\nHàng hóa đã chọn: {selectedItems}\r\nNgay: {ngay}\r\nGio: {gio}";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất hóa đơn thành công!");
        }
    }
}
