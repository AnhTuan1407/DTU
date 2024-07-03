using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN
{
    public class SinhVienKCNTT
    {
        private string mSSV;
        private string hoTen;
        private string diaChi;
        private DateTime ngaySinh;
        private double diemCS414;
        private double diemIS311;
        private double diemCS311;

        

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public double DiemCS414 { get => diemCS414; set => diemCS414 = value; }
        public double DiemIS311 { get => diemIS311; set => diemIS311 = value; }
        public double DiemCS311 { get => diemCS311; set => diemCS311 = value; }

        public double DiemTB
        {
            get { return (DiemCS414 + DiemIS311 + DiemCS311) / 3; }
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin sinh vien:");
            Console.Write("MSSV: ");
            MSSV = Console.ReadLine();
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();

            do
            {
                Console.Write("Ngay sinh (dd/mm/yyyy): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out ngaySinh));

            Console.Write("Diem CS414: ");
            DiemCS414 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem IS311: ");
            DiemIS311 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem CS311: ");
            DiemCS311 = Convert.ToDouble(Console.ReadLine());
        }

        public void TinhXepLoai()
        {
            double diemTB = DiemTB;
            if (diemTB >= 8)
                Console.WriteLine("Xep loai: Gioi");
            else if (diemTB >= 6.5)
                Console.WriteLine("Xep loai: Kha");
            else if (diemTB >= 5)
                Console.WriteLine("Xep loai: Trung binh");
            else
                Console.WriteLine("Xep loai: Yeu");
        }

        public void Xuat()
        {
            Console.WriteLine("Thong tin sinh vien:");
            Console.WriteLine($"MSSV: {MSSV}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Dia chi: {DiaChi}");
            Console.WriteLine($"Ngay sinh: {NgaySinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Diem trung binh: {DiemTB}");
            TinhXepLoai();
        }
    }
}
