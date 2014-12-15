using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.141;

            bool? boolval = new bool?();

            Console.WriteLine("Nullbles at show: {0},{1},{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("Nullbles boolean valu: {0}", boolval);
            Console.ReadLine();
        }
    }
}
