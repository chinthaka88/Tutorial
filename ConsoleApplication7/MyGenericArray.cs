using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class MyGenericArray<ck>
    {
        private string[] array;
        public MyGenericArray(int size)
        {
            array = new string[size + 1];
        }
        public string getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, string value)
        {
            array[index] = value;
        }
    }
}
