using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN
{
    class QLSinhVien
    {
        public static void Main()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());

            SinhVienKCNTT[] dsSinhVien = new SinhVienKCNTT[n];
            SinhVienDienTu[] dsSinhVienDT = new SinhVienDienTu[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Chon loai sinh vien (D: Dien tu, C: Cong nghe thong tin): ");
                char loai = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (loai == 'D')
                {
                    dsSinhVienDT[i] = new SinhVienDienTu();
                    dsSinhVienDT[i].Nhap();
                }
                else if (loai == 'C')
                {
                    dsSinhVien[i] = new SinhVienKCNTT();
                    dsSinhVien[i].Nhap();
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thong tin sinh vien:");
            for (int i = 0; i < n; i++)
            {
                if (dsSinhVienDT[i] != null)
                    dsSinhVienDT[i].Xuat();
                else
                    dsSinhVien[i].Xuat();

                Console.WriteLine();
            }
        }
    }
}
