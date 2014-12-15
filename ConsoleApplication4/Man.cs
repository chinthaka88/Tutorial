using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Man
    {
        private string name;

        public Man(string name)
        {
            this.name = name;
        }

        public virtual void PrintAbout()
        {
            Console.WriteLine("I am" + name);
        }
    }
}
