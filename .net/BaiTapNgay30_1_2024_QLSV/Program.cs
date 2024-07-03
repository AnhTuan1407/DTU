using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay30_1_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soluongCNTT;
            int soluongDT;
            Console.Write("\nNhap so luong sinh vien CNTT: ");
            soluongCNTT = int.Parse(Console.ReadLine());
            Console.Write("\nNhap so luong sinh vien DT: ");
            soluongDT = int.Parse(Console.ReadLine());
            SinhVienKCNTT[] dsSinhVien = new SinhVienKCNTT[soluongCNTT];
            SinhVienDienTu[] daSinhVienDT = new SinhVienDienTu[soluongDT];
            //QuanLySV quanLySV = new QuanLySV();
            //quanLySV.NhapXuat();
            for (int i = 0; i < soluongCNTT; i++)
            {
                Console.Write("\nNhap thong tin sinh vien CNTT thu " + (i + 1));
                SinhVienKCNTT sinhVienKCNTT = new SinhVienKCNTT();
                sinhVienKCNTT.Nhap();
                dsSinhVien[i] = sinhVienKCNTT;
            }

            for (int i = 0; i < dsSinhVien.Length; i++)
            {
                Console.Write("\nThong tin sinh vien CNTT thu " + (i + 1));
                dsSinhVien[i].Xuat();
            }

            for (int i = 0; i < soluongDT; i++)
            {
                Console.Write("\n\n\nNhap thong tin sinh vien DT thu " + (i + 1));
                SinhVienDienTu sinhVienDienTu = new SinhVienDienTu();
                sinhVienDienTu.Nhap();
                daSinhVienDT[i] = sinhVienDienTu;
            }
            for (int i = 0; i < daSinhVienDT.Length; i++)
            {
                Console.Write("\nThong tin sinh vien DT thu " + (i + 1));
                daSinhVienDT[i].Xuat();
            }

            int countHSG = 0, counHSK = 0, countHSTB = 0, countHSY = 0;
            for (int i = 0; i < dsSinhVien.Length; i++)
            {
                if (dsSinhVien[i].Diemtb >= 8) countHSG += 1;
                else if (dsSinhVien[i].Diemtb >= 6.5) counHSK += 1;
                else if (dsSinhVien[i].Diemtb >= 5) countHSTB += 1;
                else countHSY += 1;
            }
            int counthsg = 0, counthsk = 0, counthstb = 0, counthsy = 0;
            for (int i = 0; i < daSinhVienDT.Length; i++)
            {
                if (daSinhVienDT[i].Diemtb >= 8) counthsg += 1;
                else if (daSinhVienDT[i].Diemtb >= 6.5) counthsk += 1;
                else if(daSinhVienDT[i].Diemtb >= 5) counthstb += 1;
                else counthsy += 1;
            }
            Console.Write("\nKHOA CONG NGHE THONG TIN");
            Console.Write($"\nSo HSG: {countHSG} \nSo HSK: {counHSK} \nSo HSTB: {countHSTB} \nSo HSY: {countHSY}");
            Console.Write("\nKHOA DIEN TU");
            Console.Write($"\nSo HSG: {counthsg} \nSo HSK: {counthsk} \nSo HSTB: {counthstb} \nSo HSY: {counthsy}");
            Console.ReadLine();
        }
    }
}
