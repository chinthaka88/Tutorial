using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 65;
            char[] alphabet = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)temp;
                temp++;
            }

            foreach (char character in alphabet)
            {
                Console.WriteLine(character);
            }
            Console.ReadLine();
        }
    }
}
