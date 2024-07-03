using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_xe
{
    class Xe
    {
        private string bienso, tenxe;
        private int trongtai, tieuChuanBang;
        private DateTime ngayDK;

        public Xe() { }
        public Xe(string bienso, string tenxe, int trongtai, DateTime ngayDK, int tieuChuanBang)
        {
            this.bienso = bienso;
            this.tenxe = tenxe;
            this.trongtai = trongtai;
            this.ngayDK = ngayDK;
            this.tieuChuanBang = tieuChuanBang;
        }
        public string Bienso { get => bienso; set => bienso = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public int Trongtai { get => trongtai; set => trongtai = value; }
        public DateTime NgayDK { get => ngayDK; set => ngayDK = value; }
        public int TieuChuanBang { get => tieuChuanBang; set => tieuChuanBang = value; }

        public void nhap()
        {
            Console.WriteLine("Nhap thong tin xe:");

            Console.Write("Bien so: ");
            this.bienso = Console.ReadLine();

            Console.Write("Ten xe: ");
            this.tenxe = Console.ReadLine();

            Console.Write("trong tai: ");

            while (!int.TryParse(Console.ReadLine(), out this.trongtai) || this.trongtai <= 0)
            {
                Console.WriteLine("Nhap so nguyen duong:");
                Console.Write("trong tai: ");
            }

            Console.Write("Ngay Dang ky (dd/MM/yyyy): ");
            DateTime ngayDangKy;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out this.ngayDK))
            {
                Console.WriteLine("nhap ngay theo dinh dang (dd/MM/yyyy).");
                Console.Write("Ngay dang ky (dd/MM/yyyy): ");
            }

            Console.Write("Tieu chuan bang: ");

            while (!int.TryParse(Console.ReadLine(), out this.tieuChuanBang) || this.tieuChuanBang <= 0)
            {
                Console.WriteLine("Nhap so nguyen duong.");
                Console.Write("Tieu chuan bang: ");
            }

        }
        public void xuat()
        {
            Console.WriteLine($"BienSo: {this.bienso}" +
                              $"\nTenXe: {this.tenxe}" +
                              $"\nTrongTai: {this.trongtai}" +
                              $"\nNgayDangKiem: {this.ngayDK.ToShortDateString()}" +
                              $"\nTieuChuanBang: {this.tieuChuanBang}");
        }
    }
    
}
