using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Employee
    {
        private int id;
        private string name;
        private double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return string.Format("[{0} - {1} - {2}]", id, name, salary);
        }

        public override bool Equals(object obj)
        {
            bool res = false;
            Employee emp = null;
            if (obj is Employee)
            {
                emp = (Employee)obj;

                if (this.id == emp.id)
                    res = true;
            }
            return res;
        }
    }
}
