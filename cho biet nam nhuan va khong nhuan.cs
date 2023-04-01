using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so nam : ");
            int nam = Int32.Parse(Console.ReadLine());
            if (nam % 400 == 0 || nam % 4 == 0 || nam % 100 == 0)
            {
                Console.WriteLine("la nam nhuan ", nam);
            }
            else
            {
                Console.WriteLine("khong phai la nam nhuan ", nam);
            }
            Console.ReadKey(); //lenh dung man hinh
        }
    }
}