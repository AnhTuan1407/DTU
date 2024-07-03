using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_truyen
{
    public partial class sanphamtruyen : System.Web.UI.Page
    {
        xuly kn = new xuly();
        //Khai bao chuoi ket noi
        //string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\ky-thuat-thuong-mai-dien-tu\web-truyen\web-truyen\App_Data\truyen.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if(Context.Items["ml"] == null )
            {
                q = "SELECT * FROM Truyen";
            }else {
                string maloai = Context.Items["ml"].ToString();
                q = "SELECT * FROM Truyen WHERE MaLoai = '" + maloai + "'";
            }

            try
            {
                //SqlDataAdapter da = new SqlDataAdapter(q, con);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                this.DataList1.DataSource = kn.getdata(q);
                this.DataList1.DataBind();
            }catch(SqlException ex)
            {
                Response.Write( ex.Message );
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string matruyen = ((LinkButton)sender).CommandArgument;
            Context.Items["mt"] = matruyen;
            Server.Transfer("chitiet.aspx");
        }
    }
}