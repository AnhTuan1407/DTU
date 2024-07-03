using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_Thue_Xe
{
    internal class XeChoHang:Xe
    {
        private int soTan;

        public int TrongTaiHang { get => soTan; set => soTan = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap trong tai hang: ");
            soTan = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Trong tai hang: " + soTan);
        }
    }
}
