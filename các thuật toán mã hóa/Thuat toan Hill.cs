using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hill_Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, end = 0;
            int[,] mtrx = new int[25, 25];
            int[,] ans = new int[25, 1];
            string text = "";
            Console.Write("enter your plain text : ");
            text = Console.ReadLine();
            char[] txt = text.ToCharArray();
            end = txt.Length;
            for(i=0;i<end;i++)
            {
                txt[i] = Convert.ToChar(txt[i] - 'a');
            }
            Random rnd = new Random();
            for(i=0;i<end;i++)
            {
                for(j=0;j<end;j++)
                {
                    mtrx[i, j] = rnd.Next();
                }
            }
            for(i=0;i<end;i++)
            {
                int sum = 0;
                for(j=0;j<end;j++)
                {
                    sum += mtrx[i, j] * (int)txt[j];
                }
                ans[i, 0] = sum;
            }
            Console.Write("your ciphertext is : ");
            for (i = 0; i < end; i++)
            {
                char cipher = (char)((ans[i, 0] % 26) + 97);
                Console.Write("\t" + cipher);
            }
            Console.ReadKey();
        }
    }
}
