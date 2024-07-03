using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class NhanVienHopDong:NhanVien,ILUONG
    {
        double mucLuong;

        public double Mucluong { get => Mucluong; set => Mucluong = value; }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap muc luong: ");
            Mucluong = double.Parse(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Muc luong la: " + Mucluong);
        }

        public double phucap()
        {
            return Mucluong / 10;
        }

        public double thuclinh() {  
            return Mucluong + phucap();
        }

    }
}
