using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_NhapBac
{
    public partial class frm_ListBox_HoTen : Form
    {
       // Dictionary<string, string[]> ho = new Dictionary<string, string[]>();
        public frm_ListBox_HoTen()
        {
            InitializeComponent();
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
            for(int i = 0; i < Lib_A.Items.Count; i++)
            {
                Lib_B.Items.Add(Lib_A.Items[i]);
            }
            Lib_A.Items.Clear();
            Lib_B.Sorted = true;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            for(int i = Lib_B.SelectedItems.Count - 1; i >= 0; i--)
            {
                Lib_A.Items.Add(Lib_B.SelectedItems[i]);
                Lib_B.Items.Remove(Lib_B.SelectedItems[i]);
            }
            Lib_A.Sorted = true;
            Lib_B.Sorted = true;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Lib_B.Items.Count; i++)
            {
                Lib_A.Items.Add(Lib_B.Items[i]);
            }
            Lib_B.Items.Clear();
            Lib_A.Sorted = true;
        }
        Dictionary<string, string[]> ho = new Dictionary<string, string[]>();
        private void frm_ListBox_HoTen_Load(object sender, EventArgs e)  // sự kiện load Form
        {
            ho.Add("Huỳnh", new string[] { "Huỳnh A", "Huỳnh B", "Huỳnh C" });
            ho.Add("Phạm", new string[] { "Phạm A", "Phạm B", "Phạm C", "Phạm D" });
            ho.Add("Nguyễn", new string[] { "Nguyễn A", "Nguyễn B" });
            foreach (string H in ho.Keys)
                cb_Ho.Items.Add(H);
        }
        private void cb_Ho_SelectedIndexChanged(object sender, EventArgs e)    // sự kiện Control Combobox
        {
            Lib_A.Items.Clear();
            foreach (string HT in ho[cb_Ho.SelectedItem.ToString()])
                Lib_A.Items.Add(HT);
        }
    }
}
