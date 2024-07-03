using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_Thue_Xe
{
    internal class QuanLyXe
    {
        Dictionary<string, Xe> dsXe = new Dictionary<string, Xe>();

        public virtual void Nhap()
        {
            Console.WriteLine("Chon loai xe: ");
            Console.WriteLine("H. Xe cho hang");
            Console.WriteLine("D. Xe du lich");
            Console.Write("Chon: ");
            char chon = char.Parse(Console.ReadLine());
            if (chon == 'H' || chon == 'h')
            {
                XeChoHang xeChoHang = new XeChoHang();
                xeChoHang.Nhap();
                dsXe.Add(xeChoHang.BienSo, xeChoHang);
            }
            else if (chon == 'D' || chon == 'd')
            {
                XeDuLich xeDuLich = new XeDuLich();
                xeDuLich.Nhap();
                dsXe.Add(xeDuLich.BienSo, xeDuLich);
            }
        }

        public Xe TimXe(string bienSo)
        {
            if (dsXe.ContainsKey(bienSo))
            {
                return dsXe[bienSo];
            }
            return null;
        }

        public void XoaXe(string bienSo)
        {
            if (dsXe.ContainsKey(bienSo))
            {
                dsXe.Remove(bienSo);
            }
        }

        public void XuatXe()
        {
            foreach (var Xe in dsXe)
            {
                Xe.Value.Xuat();
                Console.WriteLine();
            }
        }

    }
}
