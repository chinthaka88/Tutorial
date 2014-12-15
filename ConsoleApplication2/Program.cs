using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            c.D = 5;
            Console.WriteLine("Area= {0}", c.GetArea());
            Console.ReadLine();
        }
    }
}
