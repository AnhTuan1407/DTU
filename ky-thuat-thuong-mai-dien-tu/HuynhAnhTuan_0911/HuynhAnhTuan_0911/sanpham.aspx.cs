using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace HuynhAnhTuan_0911
{
    public partial class sanpham : System.Web.UI.Page
    {
        //Khai báo chuỗi kết nối
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\ky-thuat-thuong-mai-dien-tu\HuynhAnhTuan_0911\HuynhAnhTuan_0911\App_Data\QLHoa.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["ml"] == null)
                q = "SELECT * FROM Hoa";

            else
            {
                string madm = Context.Items["ml"].ToString();
                q = "SELECT * FROM Hoa WHERE MaDM = '" + madm + "'"; 
            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();
            }
            catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string mahoa = ((LinkButton)sender).CommandArgument;
            Context.Items["mh"] = mahoa;
            Server.Transfer("chitiet.aspx");
        }
    }
}