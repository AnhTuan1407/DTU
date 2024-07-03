using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> dssinhvien = new Dictionary<string, string[]>();
            Console.Write("Nhap vao so luong sinh vien: ");
            int sosv = int.Parse(Console.ReadLine());
            for(int i=0; i<sosv; i++)
            {
                Console.Write("Nhap vao ma so sinh vien " + "so " + (i + 1) + ": ");
                string mssv = Console.ReadLine();
                Console.Write("Nhap vao ho ten sinh vien " + "so " + (i + 1) + ": ");
                string hoten = Console.ReadLine();
                Console.Write("Nhap vao dia chi sinh vien " + "so " + (i + 1) + ": ");
                string diachi = Console.ReadLine();
                Console.Write("Nhap vao ngay sinh sinh vien " + "so " + (i + 1) + ": ");
                string ngaysinh = Console.ReadLine();
                string[] thongtinsv = new string[] {hoten, diachi, ngaysinh };
                dssinhvien.Add(mssv, thongtinsv);
            }

            foreach(KeyValuePair<string, string[]> element in dssinhvien)
            {
                Console.WriteLine("MSSV {0}, Thong tin: Ho va ten: {1}, Dia chi: {2}, Ngay sinh: {3}", element.Key, element.Value[0], element.Value[1], element.Value[2]);
            }
            Console.ReadLine();
        }
    }
}
