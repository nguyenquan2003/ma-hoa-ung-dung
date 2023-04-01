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
        static void min(int []a,int n)
        {
            int min = a[0];
            for(int i=0;i<n;i++)
            {
                if(min>a[i])
                {
                    min = a[i];
                }
            }
            Console.Write("gia tri nho nhat : " + min);
        }
        static void max(int []a,int n)
        {
            int max = a[0];
            for(int i=0;i<n;i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.Write("gia tri lon nhat : " + max);
        }
        static Boolean kt_ng_to(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return false;
            }
            // check so nguyen to khi n >= 2
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void ng_to(int []a,int n)
        {
            Console.Write("Cac so nguyen to la: ");
            for (int i = 0; i < n; i++)
            {
                if (kt_ng_to(i))
                {
                    Console.Write("{0} ", i);
                }
            }
        }
        static void Main( string[] args)
        {
            int[] a = new int[100];
            Console.WriteLine("=================MENU=================");
            Console.WriteLine("1. nhap mang va xuat mang ");
            Console.WriteLine("2. xuat gia tri chan trong mang ");
            Console.WriteLine("3. tim gia tri nho nhat va lon nhat ");
            Console.WriteLine("4. xuat so nguyen to trong mang ");
            Console.Write("moi ban chon bai  : ");
            int chon = int.Parse(Console.ReadLine());
            Console.Write("nhap n ptu : ");
            int n = int.Parse(Console.ReadLine());
            nhap_mang(a, n);
            switch (chon)
            {
                case 1:
                    Console.Write("mang vua nhap : ");
                    xuat_mang(a, n);
                    break;
                case 2:
                    Console.Write("mang so chan : ");
                    chan(a, n);
                    break;
                case 3:
                    min(a, n);
                    Console.Write("\n");
                    max(a, n);
                    break;
                case 4:
                    ng_to(a, n);
                    break;
                default: Console.Write("bn nhap sai cu phap. Vui long chay lai ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
