using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSINHVIEN_MacTuongSon_3179
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_QuanLySinhVien());
            //Application.Run(new frm_DanhSachSinhVien());
            //Application.Run(new frm_ThongTinKhachHang());
        }
    }
}
