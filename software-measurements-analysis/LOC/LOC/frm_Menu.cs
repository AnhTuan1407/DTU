using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOC
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private Form currenFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            currenFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childform);
            panel_Body.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Home());
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Main());
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AboutUs());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you really want to quit?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private int boderSize = 2;
        private void frm_Menu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(boderSize);
            this.BackColor = Color.Black;
            OpenChildForm(new frm_Home());
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
