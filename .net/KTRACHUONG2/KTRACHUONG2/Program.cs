using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTRACHUONG2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bai1();
            Bai2();
            Bai3();
            Bai4();
            Bai5();
        }
        static void Bai1()
        {
            Console.WriteLine("Nhap phan tu thu X: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Gia tri phan tu thu X la: " + Fibonacci(x));
            Console.WriteLine("Tong gia tri cua day co X phan tu la: " + FibonacciSum(x));
            Console.ReadLine();
        }
        public static int Fibonacci(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }
        }

        public static int FibonacciSum(int x)
        {
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                sum += Fibonacci(i);
            }
            return sum;
        }

        static void Bai2()
        {
            Console.Write("Nhap thang: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int month))
            {
                if (month > 0 && month < 13)
                {
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.WriteLine("Tháng " + month + " có 31 ngày");
                            Console.ReadLine();
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            Console.WriteLine("Tháng " + month + " có 30 ngày");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Nhap nam: ");
                            int year = int.Parse(Console.ReadLine());
                            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                            {
                                Console.WriteLine("Thang " + month + " nam " + year + " co 29 ngay");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Thang " + month + " nam " + year + " có 28 ngay");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Khong co thang " + month);
                    Console.ReadLine();
                    Bai2();
                }
            }
            else
            {
                Console.WriteLine("Phai nhap vao so nguyen. Nhap lai!" );
                Console.ReadLine();
                Bai2();
            }
        }

        static void Bai3()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n))
            {
                if(n > 0)
                {
                    int[] arr = new int[n];
                    NhapMang(arr);
                    int max = maxOfArr(arr);
                    int min = minOfArr(arr);
                    List<int> posMinArr = posMin(arr, min);
                    Console.WriteLine("So lon nhat cua mang: " + max);
                    Console.WriteLine("So nho nhat cua mang: " + min);
                    Console.WriteLine("Vi tri so nho nhat cua mang: ");
                    foreach (int pos in posMinArr)
                    {
                        Console.Write(pos + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Cac so nguyen to cua mang: ");
                    HienThiSoNguyenTo(arr);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("So luong phan tu la so nguyen duong! Moi nhap lai!");
                    Console.ReadLine();
                    Bai3();
                }
            }
            else
            {
                Console.WriteLine("So luong phan tu la so nguyen duong! Moi nhap lai!");
                Console.ReadLine();
                Bai3();
            }
        }

        static void NhapMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu thu: {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static int maxOfArr(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static int minOfArr(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static List<int> posMin(int[] arr, int min)
        {
            List<int> posMinArr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                {
                    posMinArr.Add(i + 1);
                }
            }
            return posMinArr;
        }

        static bool CheckSoNguyenTo(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void HienThiSoNguyenTo(int[] arr)
        {
            foreach (int value in arr)
            {
                if (CheckSoNguyenTo(value))
                {
                    Console.Write(value + " ");
                }
            }
        }

        static void Bai4()
        {
            Console.WriteLine("Nhap so dong: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Nhap so cot: ");
            string input2 = Console.ReadLine();

            if (int.TryParse(input1, out int dong) && int.TryParse(input2, out int cot))
            {
                int[,] arr = new int[dong, cot];
                NhapMang(arr);
                int max = TimMax(arr);
                Console.WriteLine("So lon nhat cua mang la: " + max);
                Console.ReadLine();
                XoaDong(arr);
            }
            else
            {
                Console.WriteLine("So cot, so dong phai la so nguyen! Nhap lai!");
                Console.ReadLine();
                Bai4();
            }
        }

        public static void NhapMang(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int value = 0;
                    Console.WriteLine("Nhap phan tu thu [" + i + "," + j + "]: ");
                    string input = Console.ReadLine();
                    bool isInteger = int.TryParse(input, out value);
                    if (isInteger)
                    {
                        arr[i, j] = value;
                    }
                    else
                    {
                        Console.WriteLine("Phai la so nguyen!");
                        j--;
                    }
                }
            }
        }

        public static int TimMax(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
        public static void XoaDong(int[,] arr)
        {
            Console.WriteLine("Nhap dong can xoa: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int dong))
            {
                if (dong >= 0 && dong < arr.GetLength(0))
                {
                    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1)];
                    int k = 0;
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        if (i != dong)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                newArr[k, j] = arr[i, j];
                            }
                            k++;
                        }
                    }

                    Console.WriteLine("Mang sau khi xoa dong " + dong + " la:");
                    HienThiMang(newArr);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Dong khong hop le! Nhap lai!");
                    Console.ReadLine();
                    XoaDong(arr);
                }
            }
            else
            {
                Console.WriteLine("Phai la so nguyen! Nhap lai!");
                Console.ReadLine();
                XoaDong(arr);
            }
        }

        public static void HienThiMang(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Bai5()
        {
            Dictionary<string, string> QuanLyXe = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("QUAN LY XE");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Nhap xe moi");
                Console.WriteLine("2. Hien thi danh sach xe");
                Console.WriteLine("3. Xoa xe theo bien so");
                Console.WriteLine("4. Tim kiem va in ra xe theo bien so");
                Console.Write("Nhap lua chon: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("THOAT");
                            return;
                        case 1:
                            NhapXeMoi(QuanLyXe);
                            break;
                        case 2:
                            HienThiDanhSachXe(QuanLyXe);
                            break;
                        case 3:
                            XoaXe(QuanLyXe);
                            break;
                        case 4:
                            TimKiemXe(QuanLyXe);
                            break;
                        default:
                            Console.WriteLine("LUA CHON KHONG HOP LE");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("PHAI NHAP SO THEO DUNG LUA CHON");
                    Console.ReadLine();
                    Bai5();
                }
            }
        }

        public static void NhapXeMoi(Dictionary<string, string> QuanLyXe)
        {
            string bienSo = "";
            string thongTin = "";

            Console.Write("Nhap bien so xe: ");
            bienSo = Console.ReadLine();

            if (QuanLyXe.ContainsKey(bienSo))
            {
                Console.WriteLine("BIEN SO DA TON TAI!");
                Console.ReadLine();
                return;
            }

            Console.Write("Nhap thong tin xe: ");
            thongTin = Console.ReadLine();

            QuanLyXe.Add(bienSo, thongTin);
            Console.WriteLine("DA THEM XE MOI");
            Console.ReadLine();
        }

        static void XoaXe(Dictionary<string, string> QuanLyXe)
        {
            string bienSo = "";

            Console.Write("Nhap bien so xe can xoa: ");
            bienSo = Console.ReadLine();

            if (QuanLyXe.ContainsKey(bienSo))
            {
                QuanLyXe.Remove(bienSo);

                Console.WriteLine("DA XOA XE CO BIEN SO:" + bienSo);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("BIEN SO XE KHONG TON TAI");
                Console.ReadLine();
                return;
            }
        }

        public static void TimKiemXe(Dictionary<string, string> QuanLyXe)
        {
            string bienSo = "";

            Console.Write("Nhap bien so xe can tim: ");
            bienSo = Console.ReadLine();

            if (QuanLyXe.ContainsKey(bienSo))
            {
                string thongTin = QuanLyXe[bienSo];

                HienThiXe(bienSo, thongTin);
            }
            else
            {
                Console.WriteLine("BIEN SO XE KHONG TON TAI");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }

        public static void HienThiXe(string bienSo, string thongTin)
        {
            Console.WriteLine("BIEN SO XE: " + bienSo);
            Console.ReadKey();
            Console.WriteLine("THONG TIN: " + thongTin);
            Console.ReadKey();
        }

        public static void HienThiDanhSachXe(Dictionary<string, string> QuanLyXe)
        {
            foreach (KeyValuePair<string, string> element in QuanLyXe)
            {
                Console.WriteLine("BIEN SO XE {0}, THONG TIN: {1}", element.Key, element.Value);
            }
        }
    }
}
