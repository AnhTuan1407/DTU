using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HuynhAnhTuan_0911
{
    public partial class chitiet1 : System.Web.UI.Page
    {
        //Khai báo chuỗi kết nối
        //string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\ky-thuat-thuong-mai-dien-tu\HuynhAnhTuan_0911\HuynhAnhTuan_0911\App_Data\QLHoa.mdf;Integrated Security=True";

        xuly kn = new xuly();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["mh"] == null)
                q = "SELECT * FROM Hoa";

            else
            {
                string mahoa = Context.Items["mh"].ToString();
                q = "SELECT * FROM Hoa WHERE MaHoa = '" + mahoa + "'";
            }

            try
            {
                //SqlDataAdapter da = new SqlDataAdapter(q, con);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                this.DataList2.DataSource = kn.getdata(q);
                this.DataList2.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}