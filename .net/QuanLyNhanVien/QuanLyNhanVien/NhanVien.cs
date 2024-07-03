using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class NhanVien
    {
        string hoten;
        int namsinh;
        string gioitinh;
        long cmnd;
        string manv;

        public string Hoten { get => hoten; set => hoten = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public long Cmnd { get => cmnd; set => cmnd = value; }
        public string Manv { get => manv; set => manv = value; }

        public virtual void nhap()
        {
            Console.Write("Nhap ho va ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            Namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            Gioitinh = Console.ReadLine();
            Console.Write("Nhap so CMND: ");
            Cmnd = long.Parse(Console.ReadLine());
            Console.Write("Nhap ma nhan vien: ");
            Manv = Console.ReadLine();
        }

        public virtual void xuat()
        {
            Console.WriteLine("Ho va ten: " + Hoten);
            Console.WriteLine("Nam sinh: " + Namsinh);
            Console.WriteLine("Gioi tinh: " + Gioitinh);
            Console.WriteLine("So CMND: " + Cmnd);
            Console.WriteLine("Ma nhan vien: " + Manv);
        }

    }
}
