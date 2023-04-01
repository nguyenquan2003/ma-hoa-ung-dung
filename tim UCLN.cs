using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Bai10
    {
        public static void Main()
        {
            Console.Write("nhap a : ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("nhap b : ");
            int b = Int32.Parse(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.Write("UCLN : ");
            Console.Write(a);
            Console.ReadKey();
        }
    }
}
