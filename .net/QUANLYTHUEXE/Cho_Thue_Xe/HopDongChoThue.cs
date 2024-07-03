using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_Thue_Xe
{
    internal class HopDongChoThue
    {
        string sohopdong;
        Xe xe;
        Nguoi nhanvien;
        Nguoi khachhang;
        int songaythue;
        double dongia;
        DateTime ngaythue;
        QuanLyXe List;


        public string Sohopdong { get => sohopdong; set => sohopdong = value; }
        public int Songaythue { get => songaythue; set => songaythue = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public DateTime Ngaythue { get => ngaythue; set => ngaythue = value; }
        private Xe _xe;

        internal Xe Xe
        {
            get => _xe;
            set => _xe = value;
        }
        internal Nguoi Nhanvien { get => nhanvien; set => nhanvien = value; }
        internal Nguoi Khachhang { get => khachhang; set => khachhang = value; }
        internal QuanLyXe List1 { get => List; set => List = value; }

        public double ThanhTien()
        {
            
                if (Xe is XeChoHang)
                {
                    dongia = 500000;
                }
                else if (Xe is XeDuLich)
                {
                    if (((XeDuLich)Xe).SoChoNgoi <= 5)
                        dongia = 500000;
                    else if (((XeDuLich)Xe).SoChoNgoi <= 7)
                        dongia = 700000;
                    else
                        dongia = 1000000;
                }

            return dongia * songaythue;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cac xe:");
            QuanLyXe quanLyXe = new QuanLyXe();
            quanLyXe.Nhap();
            Console.WriteLine("Nhap so hop dong: ");
            sohopdong = Console.ReadLine();
            Console.WriteLine("Nhap bien so xe can thue: ");
            string bienSoXe = Console.ReadLine();
            Xe = quanLyXe.TimXe(bienSoXe);

            if (Xe != null)
            {
                Console.WriteLine("Thong tin xe da thue:");
                Xe.Xuat();

                Console.WriteLine("Nhap thong tin nhan vien:");
                Nhanvien = new NhanVien();
                nhanvien.Nhap();

                Console.WriteLine("Nhap thong tin khach hang:");
                khachhang = new KhachHang();
                khachhang.Nhap();

                Console.Write("Nhap so ngay thue: ");
                songaythue = int.Parse(Console.ReadLine());
                Console.Write("Nhap Ngay Thue (yyyy/MM/dd): ");
                ngaythue = DateTime.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Khong tim thay xe co bien so: " + bienSoXe + " Khong the thue.");
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Hien thi thong tin hop dong:");
            Console.WriteLine("So hop dong: " + sohopdong);

            Console.WriteLine("Thong tin xe da thue:");
            Xe.Xuat();

            Console.WriteLine("Thong tin nhan vien:");
            nhanvien.Xuat();

            Console.WriteLine("Thong tin khach hang:");
            khachhang.Xuat();
            Console.WriteLine("Bien so xe: " + Xe.BienSo);
            Console.WriteLine("So tien phai tra: " + ThanhTien());

        }
    }
}
