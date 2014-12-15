using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            class1 c2 = new class1();
            class1 c3 = new class1();
            Console.WriteLine("Instances= {0}", class1.GetInstanceCount());
            Console.ReadLine();
        }     
    }
}
