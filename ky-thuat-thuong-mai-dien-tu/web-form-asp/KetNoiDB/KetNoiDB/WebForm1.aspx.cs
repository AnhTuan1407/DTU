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
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Khai báo chuỗi kết nối
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\ky-thuat-thuong-mai-dien-tu\web-form-asp\KetNoiDB\KetNoiDB\App_Data\BanHang.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q = "SELECT * FROM LoaiHang";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.RadioButtonList1.DataSource = dt;
                this.RadioButtonList1.DataValueField = "MaLoai";
                this.RadioButtonList1.DataTextField = "Tenloai";
                this.RadioButtonList1.DataBind();

                this.DropDownList1.DataSource = dt;
                this.DropDownList1.DataValueField = "MaLoai";
                this.DropDownList1.DataTextField = "Tenloai";
                this.DropDownList1.DataBind();
            }
            catch(SqlException ex)  
            {
                Response.Write(ex.Message);
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String MaLoai = this.RadioButtonList1.SelectedItem.Value;
            Context.Items["ml"] = MaLoai;
            Server.Transfer("MatHang.aspx");
        }
    }
}