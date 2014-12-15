using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class class1
    {
        private static int count = 0;

        public class1()
        {
            class1.count ++;

        }
        public static int GetInstanceCount()
        {
            return count;
        }
    }
}
