using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_Thue_Xe
{
    abstract class Nguoi
    {
        private long soChungMinh;
        private string hoTen;
        private string diaChi;
        private string dienThoai;

        public long SoChungMinh { get => soChungMinh; set => soChungMinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }

        public virtual void Nhap()
        {
            Console.Write("Nhap so chung minh: ");
            soChungMinh = long.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap dien thoai: ");
            dienThoai = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("So chung minh: " + soChungMinh);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Dia chi: " + diaChi);
            Console.WriteLine("Dien thoai: " + dienThoai);
        }
    }
}
