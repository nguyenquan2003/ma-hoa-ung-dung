using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Bai2
    {
        public static void Main()
        {
            Console.Write("Nhap gia tri cua a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            if (d == 0)
            {
                Console.Write("Phuong trinh co mot nghiem duy nhat.\n");
                Console.Write("Nghiem duy nhat cua phuong trinh la = {0}\n", x1);
            }
            else if (d > 0)
            {
                Console.Write("PHUONG TRINH CO 2 NGHIEM PHAN BIET\n");
                Console.Write("Nghiem thu nhat: x1 = {0}\n", x1);
                Console.Write("Nghiem thu nhat: x2 = {0}\n", x2);
            }
            else
            {
                Console.Write("Phuong trinh vo nghiem ");
            }
            Console.ReadKey();
        }
    }
}