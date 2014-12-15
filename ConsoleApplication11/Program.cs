using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee( "Nuwan", 20000);
            Employee e2 = new Employee( "Ruwan", 6000);
            Employee e3 = new Employee("Kamal", 40000);
            Employee e4 = e2;

            var emps = new List<Employee>();


            emps.Add(e1);
            emps.Add(e2);
            emps.Add(e3);
            emps.Sort();

            foreach (Employee ele in emps)
                Console.WriteLine(ele);
            Console.ReadLine();
        }
    }
}
