using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_Thue_Xe
{
    internal class KhachHang:Nguoi
    {
        private string maKhachHang;
        private DateTime hangBangLai;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime HangBangLai { get => hangBangLai; set => hangBangLai = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ma khach hang: ");
            maKhachHang = Console.ReadLine();
            Console.Write("Nhap hang bang lai: ");
            hangBangLai = DateTime.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma khach hang: " + maKhachHang);
            Console.WriteLine("Hang bang lai: " + hangBangLai);
        }
    }
}
