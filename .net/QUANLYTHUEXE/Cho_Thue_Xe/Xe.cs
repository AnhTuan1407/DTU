using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_Thue_Xe
{
    internal class Xe
    {
        private string bienSo;
        private string tenXe;
        private int trongTai;
        private DateTime ngayDangKiem;
        private int tieuChuanBang;

        public string BienSo { get => bienSo; set => bienSo = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
        public int TrongTai { get => trongTai; set => trongTai = value; }
        public DateTime NgayDangKiem { get => ngayDangKiem; set => ngayDangKiem = value; }
        public int TieuChuanBang { get => tieuChuanBang; set => tieuChuanBang = value; }

        public virtual void Nhap()
        {
            Console.Write("Nhap bien so: ");
            bienSo = Console.ReadLine();
            Console.Write("Nhap ten xe: ");
            tenXe = Console.ReadLine();
            Console.Write("Nhap trong tai: ");
            trongTai = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay dang kiem: ");
            ngayDangKiem = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap tieu chuan bang: ");
            tieuChuanBang = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Bien so: " + bienSo);
            Console.WriteLine("Ten xe: " + tenXe);
            Console.WriteLine("Trong tai: " + trongTai);
            Console.WriteLine("Ngay dang kiem: " + ngayDangKiem);
            Console.WriteLine("Tieu chuan bang: " + tieuChuanBang);
        }
    }
}
