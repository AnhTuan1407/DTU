using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay30_1_2024
{
    internal class SinhVienKCNTT : SinhVien
    {
        private float diemcs414;
        private float diemis311;
        private float diemcs311;
        private float diemtb;
        public float Diemcs414 { get => diemcs414; set => diemcs414 = value; }
        public float Diemis311 { get => diemis311; set => diemis311 = value; }
        public float Diemcs311 { get => diemcs311; set => diemcs311 = value; }
        public float Diemtb { get => diemtb; set => diemtb = value; }
        public SinhVienKCNTT()
        {

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

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\nNhap diem CS414: ");
            Diemcs414 = float.Parse(Console.ReadLine());
            Console.Write("\nNhap diem CS311: ");
            Diemcs311 = float.Parse(Console.ReadLine());
            Console.Write("\nNhap diem IS311: ");
            Diemis311 = float.Parse(Console.ReadLine());
            this.Diemtb = (Diemcs311 + Diemcs414 + Diemis311) / 3;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write("\nDiem trung binh: {0} ", Diemtb);
            TinhXepLoai();
        }
    }
}
