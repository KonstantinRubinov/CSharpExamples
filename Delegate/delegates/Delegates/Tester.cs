using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Tester
    {
        public static void F2(double d)
        {
            Console.WriteLine("F2, d = " + d);
        }

        public void F3(short s, int i, DateTime dt)
        {
            Console.WriteLine("F3, s = " + s + ", i = " + i + ", dt = " + dt);
        }
    }
}
