using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_Suffixes
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 1.2F;
            decimal d = 1.2M;
            long l = 100L;
            F1(100);
            F1(100L);
        }

        static void F1(int x)
        {
            Console.WriteLine("F1(int x)");
        }

        static void F1(long x)
        {
            Console.WriteLine("F1(long x)");
        }
    }
}
