using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_b1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dsmonhoc = new Dictionary<string, string>();
            Console.WriteLine("Nhap vao so mon hoc: ");
            int somon = int.Parse(Console.ReadLine());
            for(int i = 0; i<somon; i++)
            {
                Console.WriteLine("Nhap vao ma mon: ");
                string mamon = Console.ReadLine();
                Console.WriteLine("Nhap vao ten mon: ");
                string tenmon = Console.ReadLine();
                //Thuc hien them vao thu vien
                dsmonhoc.Add(mamon, tenmon);
                if (dsmonhoc.ContainsValue("Ky thuat thuong mai dien tu") == true)
                {
                    Console.WriteLine("Da co mon nay roi");
                }
                else
                {
                    dsmonhoc.Add("IS385", "Ky thuat thuong mai dien tu");
                }

                if (dsmonhoc.ContainsKey("CS464") == true)
                {
                    Console.WriteLine("Co mon nay");
                    dsmonhoc.Remove("CS464");
                }
                else
                {
                    Console.WriteLine("Chua co mon nay");
                }
            }
        }
    }
}
