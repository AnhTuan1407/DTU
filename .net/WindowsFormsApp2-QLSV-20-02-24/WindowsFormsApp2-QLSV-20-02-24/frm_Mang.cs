using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_QLSV_20_02_24
{
    public partial class frm_Mang : Form
    {
        public frm_Mang()
        {
            InitializeComponent();
        }

        private void btn_Tinhtoan_Click(object sender, EventArgs e)
        {
            string input = txt_MangA.Text;
            string[] stringArray = input.Split(' ');

            stringArray = stringArray.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            int[] array = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (int.TryParse(stringArray[i], out int num))
                {
                    array[i] = num;
                }
                else
                {
                    MessageBox.Show($"Giá trị không hợp lệ ở vị trí {i + 1}. Vui lòng nhập lại.");
                    return;
                }
            }

            int tongChan = 0;
            int tongLe = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    tongChan += number;
                }
                else
                {
                    tongLe += number;
                }
            }

        }
    }
}
