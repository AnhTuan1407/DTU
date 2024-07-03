using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLSV_05_03_24
{
    public partial class frm_SinhVien : Form
    {
        public frm_SinhVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\.net\QLSV_05_03_24\QLSV_05_03_24\QLSinhVien.mdf;Integrated Security=True";
            string sql = "INSERT INTO SinhVien VALUES('"+ txt_MaSinhVien.Text + "', '"+ txt_HoTen.Text + "' , '"+txt_DiaChi.Text + "' )";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            if (kq >= 1) MessageBox.Show("Thêm sinh viên thành công!");
            else MessageBox.Show("Thêm sinh viên thất bại!");
        }


        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\.net\QLSV_05_03_24\QLSV_05_03_24\QLSinhVien.mdf;Integrated Security=True";
            string sql = "SELECT COUNT (*) FROM SinhVien";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int sosv = (int)comm.ExecuteScalar();
            conn.Close();
            txt_SoSinhVien.Text = sosv.ToString();
        }
    }
}
