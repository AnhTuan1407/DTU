using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum + arr[i];
            }

            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (max < arr[i]) max = arr[i];
            }
            int duong = 0, tongduong = 0;
            for (int i = 0; i < n; i++)
            {
                if(arr[i] > 0)
                {
                    duong++;
                    tongduong = tongduong + arr[i];
                }     
            }

            Console.WriteLine("Tong cac phan tu cua mang: " + sum);
            Console.WriteLine("So lon nhat trong mang: " + max);
            Console.WriteLine("So cac phan tu duong: " + duong + ", " + "Tong cac phan tu duong: " + tongduong);
            Console.ReadLine();
        }
    }
}
