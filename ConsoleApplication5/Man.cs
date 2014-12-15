using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
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
