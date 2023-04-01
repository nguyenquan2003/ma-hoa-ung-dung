using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Bai12
    {
        static void nhap_mang(int []a,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write("A[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat_mang(int []a,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void chan(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
        static void Main( string[] args)
        {
            int[] a = new int[100];
            Console.Write("nhap n ptu : ");
            int n = int.Parse(Console.ReadLine());
            nhap_mang(a, n);
            Console.Write("mang so chan : ");
            chan(a, n);
            Console.ReadKey();
        }
    }
}
