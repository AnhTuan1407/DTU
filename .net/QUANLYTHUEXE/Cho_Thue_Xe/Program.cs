using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_Thue_Xe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HopDongChoThue hopdong = new HopDongChoThue();

            hopdong.Nhap();
            hopdong.Xuat();
            Console.ReadLine();

            SoHopDong sohopdong = new SoHopDong();
            sohopdong.Save();
            sohopdong.tim();
            sohopdong.Xoa();


        }
    }
}
