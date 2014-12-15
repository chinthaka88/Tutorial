using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(01, "Nuwan", 20000);
            Employee e2 = new Employee(02, "Ruwan", 30000);
            Employee e3 = new Employee(03, "Kamal", 40000);
            Employee e4 = e2;

            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);

            Console.WriteLine(e2.Equals(e4));

            Console.ReadLine();
        }
    }
}
