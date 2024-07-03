using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class DanhSachNhanVien
    {
        Dictionary<string, NhanVien> dsnhanVien = new Dictionary<string, NhanVien>();
        public void Nhap()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Nhap nhan vien bien che (1)");
                Console.WriteLine("Nhan Vien Hop Dong (2)");
                Console.WriteLine("Thoat (0)");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        NhanVienBienChe nvbc = new NhanVienBienChe();
                        nvbc.nhap();
                        dsnhanVien.Add(nvbc.Manv, nvbc);
                        break;
                    case "2":
                        NhanVienHopDong nvhd = new NhanVienHopDong();
                        nvhd.nhap();
                        dsnhanVien.Add(nvhd.Manv, nvhd);
                        break;
                    case "0":
                        check = false;
                        break;
                }
            }

        }

        public void In(){
            foreach(NhanVien nv in  dsnhanVien.Values) {
                nv.xuat();
            }
        }

        public double TongQuyLuong()
        {
            double s = 0;
            foreach (var nv in dsnhanVien.Values)
            {
                if(nv is NhanVienBienChe)
                {
                    NhanVienBienChe nvb = (NhanVienBienChe)nv;
                    s += nvb.thuclinh();
                }
                if(nv is NhanVienHopDong)
                {
                    NhanVienHopDong nvh = (NhanVienHopDong)nv;
                    s += nvh.thuclinh();
                }
            }
                return s;
        }


        public void Tim()
        {
            string manv;
            Console.Write("Nhap nhan vien can tim: ");
            manv = Console.ReadLine();

            if (dsnhanVien.ContainsKey(manv))
            {
                Console.Write("Nhan vien can tim la: ");
                dsnhanVien[manv].xuat();
            }
            else
            {
                Console.Write("Khong tim thay nhan vien can xoa!");
            }
        }


        public void Xoa()
        {
            string manv;
            Console.Write("Nhap nhan vien can xoa: ");
            manv = Console.ReadLine();

            if (dsnhanVien.ContainsKey(manv))
            {
                dsnhanVien.Remove(manv);
                Console.Write("Da xoa nhan vien");
            }
            else
            {
                Console.Write("Khong tim thay nhan vien can xoa!");
            }
        }




    }
}
