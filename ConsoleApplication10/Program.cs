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
            List<int> age = new List<int>();

            IEnumerable<int> age_IEnumerable = (IEnumerable<int>)ages;
            foreach (int a in age_IEnumerable)
                Console.WriteLine(age);

            IEnumerator<int> age_IEnumerator = ages.GetEnumrator();

        }
    }
}
