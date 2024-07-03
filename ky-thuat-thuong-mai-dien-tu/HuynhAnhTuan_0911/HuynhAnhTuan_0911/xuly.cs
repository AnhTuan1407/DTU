using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace HuynhAnhTuan_0911
{
    public class xuly
    {
        SqlConnection con;
        //Phương thức kết nối Data
        private void knoi()
        {
            //Khởi tạo giá trị cho đối tượng SqlConnection
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DTU\ky-thuat-thuong-mai-dien-tu\HuynhAnhTuan_0911\HuynhAnhTuan_0911\App_Data\QLHoa.mdf;Integrated Security=True");
            con.Open(); //Mở kết nối
        }
        //Phương thức đóng kết nối data
        private void dongknoi()
        {
            //Nếu kết nối đang mở
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        //Tạo hàm lấy dữ liệu có kiểu dữ liệu là DataTable
        //Giá trị truyền vào là 1 chuỗi sql
        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                knoi(); //Mở kết nối
                SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                adap.Fill(dt); //Đổ dữ liệu vào dt
            }
            catch
            {
                dt = null;
            }
            finally
            {
                dongknoi();
            }
            return dt; //Kết quả trả về là 1 DataTable
        }
    }
}