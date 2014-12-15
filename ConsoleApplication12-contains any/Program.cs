using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12_contains_any
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOne = Enumerable.Range(1, 10);
            var listTwo = Enumerable.Range(1, 20);

            bool listOneEmpty = listOne.Any();
            bool listTwoEmpty = listTwo.Any();

            Console.WriteLine("list one has members? " + listOneEmpty +
               " list two has members? " + listTwoEmpty);

            Console.WriteLine("listTwo has 12? " + listTwo.Contains(12) +
               " listTwo has 30? " + listTwo.Contains(30));

            Console.ReadLine();
        }
    }
}
