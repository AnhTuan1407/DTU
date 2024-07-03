using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_120124
{
    class Program
    {
        static void Main(string[] args)
        {
            Bai1();
            Bai2();
            Bai3();
            Bai4a();
            Bai4b();
            Bai5();
        }
        static void Bai1()
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            //Tinh tong
            int s = 0;
            for (int i = 1; i < n; i++)
            {
                s += i;
            }

            Console.WriteLine("Tong la: " + s);
            Console.ReadLine();
        }

        static void Bai2()
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i < n; i++)
            {
                s += i * i;
            }
            Console.WriteLine("Tong la: " + s);
            Console.ReadLine();
        }

        static void Bai3()
        {
            int n;
            int f = 1;
            Console.WriteLine("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine("Giai thua cua n: " + f);
            Console.ReadLine();
        }

        static void Bai4a()
        {
            int h = 5;
            for (int i = 0; i < h; i++)
            {
                for (int j = 1; j <= h + i - 1; j++)
                {
                    if (Math.Abs(h - j) <= i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        static void Bai4b()
        {
            int h = 5;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h + i - 1; j++)
                {
                    if (Math.Abs(h - j) == i - 1 || i == h)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        static void Bai5()
        {
            int h;
            Console.WriteLine("Nhap h: ");
            h = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < h; i++)
            {
                for (int j = 1; j <= h + i - 1; j++)
                {
                    if (Math.Abs(h - j) <= i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
