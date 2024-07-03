using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class NhanVienBienChe: NhanVien, ILUONG
    {
        int heSoLuong;
        double luongCoBan;

        public int HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap he so luong: ");
            HeSoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap luong co ban: ");
            LuongCoBan = double.Parse(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("Luong co ban: " + LuongCoBan);
        }

        public double phucap()
        {
            return LuongCoBan / 10;
        }

        public double thuclinh()
        {
            return HeSoLuong * LuongCoBan + phucap();
        }

    }
}
