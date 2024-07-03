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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        //Khai báo chuỗi kết nối
        //string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\ky-thuat-thuong-mai-dien-tu\HuynhAnhTuan_0911\HuynhAnhTuan_0911\App_Data\QLHoa.mdf;Integrated Security=True";

        xuly kn = new xuly();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q = "SELECT * FROM DanhMuc";
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter(q, con);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                this.DataList1.DataSource = kn.getdata(q);
                this.DataList1.DataBind();
            }catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }



        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            string madm = ((LinkButton)sender).CommandArgument;
            Context.Items["ml"] = madm;
            Server.Transfer("sanpham.aspx");
        }
    }
}