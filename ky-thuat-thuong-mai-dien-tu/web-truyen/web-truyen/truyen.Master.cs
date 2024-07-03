using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace web_truyen
{
    public partial class truyen : System.Web.UI.MasterPage
    {
        xuly kn = new xuly();
        //string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\ky-thuat-thuong-mai-dien-tu\web-truyen\web-truyen\App_Data\truyen.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q = "SELECT * FROM LoaiTruyen";
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string maloai = ((LinkButton)sender).CommandArgument;
            Context.Items["ml"] = maloai;
            Server.Transfer("sanphamtruyen.aspx");
        }
    }
}