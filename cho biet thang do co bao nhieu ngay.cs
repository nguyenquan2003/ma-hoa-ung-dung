using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Bai3
    {
        public static void Main()
        {
            Console.Write("nhap thang : ");
            int thang = Int32.Parse(Console.ReadLine());
            if (thang == 2)
            {
                Console.Write("nhap nam : ");
                int nam = Int32.Parse(Console.ReadLine());
                if (nam % 400 == 0 || (nam % 4 == 0) || nam % 100 == 0)
                {
                    Console.Write("la nam nhuan co 29 ngay ");
                }
                else
                {
                    Console.Write("khong phai la nam nhuan co 28 ngay ");
                }
            }
            else if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                Console.Write("31 ngay ");
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                Console.Write("30 ngay ");
            }
            Console.ReadKey();
        }
    }
}