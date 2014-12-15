using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            ////declaring an int array
            //MyGenericArray<int> intArray = new MyGenericArray<int>(5); 
            ////setting values
            //for(int c=0;c<5;c++)
            //{
            //    intArray.setItem(c, c * 5);
            //}
            ////retrieving the values
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(intArray.getItem(c));
            //}
            //Console.ReadLine();
            MyGenericArray<string> EmployeeArray = new MyGenericArray<string>(4);

            for (int i = 0; i < 4; i++)
            {
                EmployeeArray.setItem(i, "Employee " + i);
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(EmployeeArray.getItem(i));
            }
            Console.ReadLine();

        }
    }
}
