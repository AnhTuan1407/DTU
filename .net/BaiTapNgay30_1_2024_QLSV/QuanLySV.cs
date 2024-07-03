using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay30_1_2024
{
    internal class QuanLySV
    {
        public void NhapXuat()
        {
            string choice;
            while (true)
            {
                Console.Write("\nNhap lua chon [Sinh vien dien tu (D)] || [Sinh vien cong nghe thong tin[C]  || [T] de thoat: ");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
                if(choice == "D")
                {
                    SinhVienDienTu svdt = new SinhVienDienTu();
                    svdt.Nhap();
                    svdt.Xuat();
                }
                if(choice == "C")
                {
                    SinhVienKCNTT svcntt = new SinhVienKCNTT();
                    svcntt.Nhap();
                    svcntt.Xuat();
                }
                if (choice == "T") break;
            }
        }


    }
}
