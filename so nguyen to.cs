using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Bai9
    {
        static void Main(string[] args)
        {
            Console.Write("nhap n : ");
            int n = Int32.Parse(Console.ReadLine());
            bool so_ng_to = true;
            if (n < 2)
            {
                so_ng_to = false;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    so_ng_to = false;
                    break;
                }
            }
            if (so_ng_to)
            {
                Console.Write($"{n} la so nguyen to.");
            }
            else
            {
                Console.Write($"{n} khong phai so nguyen to.");
            }
            Console.ReadKey();
        }
    }
}
