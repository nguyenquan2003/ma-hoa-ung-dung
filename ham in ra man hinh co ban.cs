using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //vi bang ma cua cmd la bang ma ASCII
            //nen khi in ra man hinh chu ban bi thanh b?n vi vay ta su dung
            //lenh Encoding.UTF8 de chuyen duoc chu ban thanh co dau
            Console.OutputEncoding = Encoding.UTF8;

            //lenh in ra man hinh
            Console.Write("xin chao ");//lenh write la in ra man hinh khong xuong dong
            Console.WriteLine("xin chào các bạn "); //con lenh writeline la in ra man hinh xuong dong
        }
    }
}
