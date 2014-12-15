using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
class Student:Man
    {
        private string school;

        public Student(string name, string school)
            : base(name)
        {
            this.school = school;
        }

        public string GetSchol()
        {
            return this.school;
        }

        public override void PrintAbout()
        {
            base.PrintAbout();
            Console.WriteLine("My school is " + this.school);
        }
    }

}
