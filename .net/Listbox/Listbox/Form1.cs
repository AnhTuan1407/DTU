using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void btn_1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<Lib_A.SelectedItems.Count; i++)
            {
                Lib_B.Items.Add(Lib_A.SelectedItems[i]);
            }
        }
    }
}
