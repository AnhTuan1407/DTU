using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTRACHUONG4_HuynhAnhTuan_00911
{
    public partial class frm_Baitap3 : Form
    {
        public frm_Baitap3()
        {
            InitializeComponent();

            this.Load += frm_Baitap3_Load;

            Timer timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void frm_Baitap3_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = Lib_A.SelectedItems.Count - 1; i >= 0; i--)
            {
                Lib_B.Items.Add(Lib_A.SelectedItems[i]);
                Lib_A.Items.Remove(Lib_A.SelectedItems[i]);
            }
            Lib_A.Sorted = true;  
            Lib_B.Sorted = true;
        }
        private void button2_Click(object sender, EventArgs e)  
        {
            for (int i = 0; i < Lib_A.Items.Count; i++)
            {
                Lib_B.Items.Add(Lib_A.Items[i]);
            }
            Lib_A.Items.Clear();
            Lib_B.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = Lib_B.SelectedItems.Count - 1; i >= 0; i--)
            {
                Lib_A.Items.Add(Lib_B.SelectedItems[i]);
                Lib_B.Items.Remove(Lib_B.SelectedItems[i]);
            }
            Lib_A.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
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
            string hoTen = txt_HoTen.Text;
            string selectedItems = "";

            for(int i = 0; i < Lib_B.Items.Count; i++)
            {
                selectedItems += Lib_B.Items[i].ToString() + ", ";
            }
            string ngay = txt_Ngay.Text;
            string gio = txt_Gio.Text;
            txt_ThongTin.Text = $"Họ tên: {hoTen}\r\nMôn học đã chọn: {selectedItems}\r\nNgay: {ngay}\r\nGio: {gio}";
        }

        private void btn_LamTrong_Click(object sender, EventArgs e)
        {
            txt_HoTen.ResetText();
            for (int i = 0; i < Lib_B.Items.Count; i++)
            {
                Lib_A.Items.Add(Lib_B.Items[i]);
            }
            Lib_B.Items.Clear();
            Lib_A.Sorted = true;
            txt_ThongTin.ResetText();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
