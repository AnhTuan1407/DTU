﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay30_1_2024
{
    internal class SinhVienDienTu:SinhVien
    {
        private float ee200;
        private float ee201;
        private float ee205;
        private float diemtb;

        public float Ee200 { get => ee200; set => ee200 = value; }
        public float Ee201 { get => ee201; set => ee201 = value; }
        public float Ee205 { get => ee205; set => ee205 = value; }
        public float Diemtb { get => this.diemtb; set => this.diemtb = value; }

        public SinhVienDienTu() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\nNhap diem EE200: ");
            Ee200 = float.Parse(Console.ReadLine());
            Console.Write("\nNhap diem EE201: ");
            Ee201 = float.Parse(Console.ReadLine());
            Console.Write("\nNhap diem EE205: ");
            Ee205 = float.Parse(Console.ReadLine());
            this.Diemtb = (Ee200 + Ee201 + Ee205) / 3;
        }


        public void TinhXepLoai()
        {
                if (Diemtb >= 8)
                {
                    Console.Write("\nBan xep loai gioi!!!");
                }
                else if (Diemtb >= 6.5)
                {
                    Console.Write("\nBan xep loai kha!!!");
                }
                else if (Diemtb >= 5)
                {
                    Console.Write("\nBan xep loai trung binh!!!");
                }
                else
                {
                    Console.Write("\nBan xep lai yeu!!!");
                }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write("\nDiem trung binh: {0} ", Diemtb);
            TinhXepLoai();
        }
    }
}

