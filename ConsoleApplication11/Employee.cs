using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Employee : IComparable<Employee>
    {
  
        private string name;
        private int salary;


        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Employee( string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public int CompareTo(Employee other)
        {
            //if (this.salary < other.salary) return 1;
            //else if (this.salary > other.salary)return -1
            //else return 0;

            int res = this.salary - other.salary;
            return res;
        }

        public override string ToString()
        {
            
            return string.Format("[{0} - {1} ]", name, salary);
        }
      
    }
}
