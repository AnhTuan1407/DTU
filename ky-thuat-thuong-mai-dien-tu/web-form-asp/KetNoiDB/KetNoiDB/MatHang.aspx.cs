using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace KetNoiDB
{
    public partial class MatHang : System.Web.UI.Page
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\ky-thuat-thuong-mai-dien-tu\web-form-asp\KetNoiDB\KetNoiDB\App_Data\BanHang.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;    
            String MaLoai = Context.Items["ml"].ToString();
            SqlConnection con = new SqlConnection(conn);
            try
            {
                con.Open();
                string query = "SELECT * FROM MatHang where MaLoai ='" + MaLoai + "'";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                this.GridView1.DataSource = sqlDataReader;
                this.GridView1.DataBind();
            }
            catch (SqlException err)
            {
                Response.Write("<b>Error</b>" + err.Message + "</p>");
            }
            finally { con.Close(); }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}