using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Saman", "AAA");
            Console.WriteLine("Student says");
            st.PrintAbout();
            Console.WriteLine();


        }
    }
}
