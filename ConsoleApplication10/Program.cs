using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> age = new List<int>();

            //IEnumerable<int> age_IEnumerable = (IEnumerable<int>)ages;
            //foreach (int a in age_IEnumerable)
            //    Console.WriteLine(age);

            //IEnumerator<int> age_IEnumerator = ages.GetEnumrator();

            Employee e1 = new Employee(1, "zaa", 4000);
            Employee e2 = new Employee(2, "bbb", 2342);
            List<Employee> emps = new List<Employee>();

            emps.Add(e1);
            emps.Add(e2);
            //emps.Sort();
            Console.WriteLine(emps is IEnumerable<Employee>);

            IEnumerable<Employee> emps_IEnumerable = (IEnumerable<Employee>)emps;
            Console.WriteLine("using foreach");
            foreach (Employee ele in emps_IEnumerable)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("using IEnumerator");

            IEnumerator<Employee> emps_Inumerator = emps.GetEnumerator();
            while (emps_Inumerator.MoveNext())
            {
                Console.WriteLine(emps_Inumerator.Current);
            }
            Console.ReadLine();


        }
    }
}
