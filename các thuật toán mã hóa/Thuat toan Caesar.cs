using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cons
{
    class Program
    {
        private static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;
            foreach(char ch in input)
            {
                output += Cipher(ch, key);
            }
            return output;
        }
        public static string Decipher(string input,int key)
        {
            return Encipher(input, 26 - key);
        }
        static void Main(string[] args)
        {
            string text = "The quick brown fox jumps over the lazy dog ";
            string CipherText = Encipher(text, 3);
            string PlainText = Decipher(CipherText, 3);
            Console.WriteLine(PlainText);
            Console.WriteLine(CipherText);
            Console.ReadLine();
        }
    }
}