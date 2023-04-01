using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Bai4
    {
        public static void Main()
        {
            Console.Write("nhap diem : ");
            float diem = float.Parse(Console.ReadLine());
            if (diem >= 10 || diem >= 8.5f)
            {
                Console.Write(" A ");
            }
            else if (diem >= 8.4 || diem >= 7.0)
            {
                Console.Write(" B ");
            }
            else if (diem >= 6.9f || diem >= 5.5)
            {
                Console.Write(" C ");
            }
            else if (diem >= 5.4 || diem >= 4.0)
            {
                Console.Write(" D ");
            }
            else if (diem < 4)
            {
                Console.Write(" F ");
            }
        }
    }
}
