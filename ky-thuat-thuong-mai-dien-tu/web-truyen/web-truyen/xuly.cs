using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace web_truyen
{
    public class xuly
    {
        SqlConnection con;

        private void knoi()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\ky-thuat-thuong-mai-dien-tu\web-truyen\web-truyen\App_Data\truyen.mdf;Integrated Security=True");
            con.Open();
        }

        private void dongknoi()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                knoi();
                SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                adap.Fill(dt);
            }catch
            {
                dt = null;
            }
            finally
            {
                dongknoi();
            }
            return dt;
        }
    }
}