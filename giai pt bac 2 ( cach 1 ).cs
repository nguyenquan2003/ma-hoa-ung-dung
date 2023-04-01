using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Bai2
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a : ");
            float a = Int32.Parse(Console.ReadLine());
            Console.Write("nhap b : ");
            float b = Int32.Parse(Console.ReadLine());
            Console.Write("nhap c : ");
            float c = Int32.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.Write("phuong trinh vo so nghiem ");
                    }
                    else
                    {
                        Console.Write("phuong trinh vo nghiem ");
                    }
                }
                else
                {
                    Console.Write("phuong trinh co nghiem duy nhat : {0}", -c / b);
                }
            }
            else
            {
                double delta = (b * b) - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("nghiem thu nhat x1 = {0} ", x1);
                    Console.Write("nghiem thu hai x2 = {0} ", x2);
                }
                else if (delta == 0)
                {
                    Console.Write("phuong trinh co nghiem kep x1=x2 : {0}", -b / 2 * a);
                }
                else
                {
                    Console.Write("phuong trinh vo nghiem ");
                }
            }
            Console.ReadKey();
        }
    }
}