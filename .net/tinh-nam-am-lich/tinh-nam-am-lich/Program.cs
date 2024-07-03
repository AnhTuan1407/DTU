using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinh_nam_am_lich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập năm dương lịch: ");
            int namdl = int.Parse(Console.ReadLine());
            string[] can = new string[] {"Canh", "Tan", "Nham", "Quy", "Binh", "Giap", "At", "Dinh", "Mau" , "Ky" };

            string[] chi = new string[] { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo" , "Mui" };

            Console.WriteLine(can[namdl % 10] + " " + chi[namdl % 12]);
            Console.ReadLine();
        }
    }
}
