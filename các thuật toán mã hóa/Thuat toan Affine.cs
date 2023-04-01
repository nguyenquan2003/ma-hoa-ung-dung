using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affine_Cons
{
    class Program
    {
        public static string affine_encrypt(string plain_text,int a,int b)
        {
            string cipher_text = "";
            char[] chars = plain_text.ToUpper().ToCharArray();
            foreach(char c in chars)
            {
                int x = Convert.ToInt32(c - 65);
                cipher_text+=Convert.ToChar(((a*x+b)%26)+65);
            }
            return cipher_text;
        }
        public static int multiplicative_inverse(int a)
        {
            for(int x=1;x<27;x++)
            {
                if((a*x)%26==1)
                {
                    return x;
                }
            }
            throw new Exception("no multiplicative inverse found!");
        }
        public static string affine_decrypt(string cipher_text,int a,int b)
        {
            string plain_text = "";
            int inverse = multiplicative_inverse(a);
            char[] chars = cipher_text.ToUpper().ToCharArray();
            foreach(char c in chars)
            {
                int x = Convert.ToInt32(c - 65);
                if(x-b<0)
                {
                    x = Convert.ToInt32(x) + 26;
                }
                plain_text += Convert.ToChar(((inverse * (x - b)) % 26) + 65);
            }
            return plain_text;
        }
        static void Main(string[] args)
        {
            string text = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            string cipher_text = affine_encrypt(text, 3, 2);
            string plain_text = affine_decrypt(cipher_text, 3, 2);
            Console.WriteLine(plain_text);
            Console.WriteLine(cipher_text);
            Console.ReadLine();
        }
    }
}
