using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.Nhap();
            ds.In();
            Console.WriteLine("Tong quy luong la: " + ds.TongQuyLuong());
            ds.Tim();
            ds.Xoa();
            Console.WriteLine("Danh sach sau khi xoa la: \n");
            ds.In();
            Console.ReadLine();
        }
    }
}
