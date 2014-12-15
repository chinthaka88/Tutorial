using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Man[] manArray = new Man[100];
            for (int i = 0; i < 100; i++)
            {
                manArray[i] = new Man("Saman"+i); 
            }

            foreach (Man m in manArray)
            {
                m.PrintAbout(); 
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
