using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class circle
    {
        private float _D;

        public float D
        {
            get { return _D/2; }
            set { _D = value*2; }
        }

        public float GetArea()
        {
            return (float)Math.PI * _D * _D / 4;
        }
    }
}
