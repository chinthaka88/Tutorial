using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> myemp = new List<Employee>();

            myemp.Add(new Employee(01, "Nuwan", 20000));
            myemp.Add(new Employee(02, "Ruwan", 30000));
            myemp.Add(new Employee(03, "Kamal", 40000));

            foreach(Employee e in myemp)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();

        }
    }
}
