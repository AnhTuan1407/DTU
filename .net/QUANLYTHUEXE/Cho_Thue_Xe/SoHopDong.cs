using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cho_Thue_Xe
{
    internal class SoHopDong
    {
        private Dictionary<string, HopDongChoThue> socai;

        public SoHopDong()
        {
            socai = new Dictionary<string, HopDongChoThue>();
        }

        public void Save()
        {
            while (true)
            {
                Console.WriteLine("Nhap (1) de them hop dong , (0) de thoat");
                int chon = int.Parse(Console.ReadLine());
                if (chon == 1)
                {
                    HopDongChoThue hopDong = new HopDongChoThue();
                    hopDong.Nhap();
                    if (!socai.ContainsKey(hopDong.Sohopdong))
                    {
                        socai.Add(hopDong.Sohopdong, hopDong);
                        Console.WriteLine("Hop dong da duoc luu vao so cai.");
                    }
                    else
                    {
                        Console.WriteLine("Hop dong da ton tai trong so cai.");
                    }
                }
                else
                {
                    return;
                }
            }

        }

        public void tim()
        {
            Console.Write("Nhap so hop dong can tim: ");
            string soHopDong = Console.ReadLine();
            if (socai.ContainsKey(soHopDong))
            {
                HopDongChoThue hopDong = socai[soHopDong];
                Console.WriteLine("Thong tin ve hop dong:");
                hopDong.Xuat();
            }
            else
            {
                Console.WriteLine("Khong tim thay hop dong: " + soHopDong + "trong so cai.");
            }
        }

        public void Xoa()
        {
            Console.Write("Nhap so hop dong can xoa: ");
            string soHopDong = Console.ReadLine();
            if (socai.ContainsKey(soHopDong))
            {
                socai.Remove(soHopDong);
                Console.WriteLine("Hop dong: " + soHopDong + "đa duoc xoa khoi so cai.");
            }
            else
            {
                Console.WriteLine("Khong tim thay hop dong: " + soHopDong + "trong so cai.");
            }
        }
    }
}
