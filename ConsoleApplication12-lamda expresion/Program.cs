using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12_lamda_expresion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            //find the index of first odd element
            int oddIndex = elements.FindIndex(X => X % 2 != 0);
            Console.WriteLine(oddIndex);
            Console.ReadLine();
        }
    }
}
