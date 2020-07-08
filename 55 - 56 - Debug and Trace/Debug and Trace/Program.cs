using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug_and_Trace
{
    class Program
    {
        static void DoSomethingWithPositiveNumber(int num)
        {
            Debug.Assert(num > 0);
            Trace.Assert(num > 0);

            Console.WriteLine(num);
        }


        static void Main(string[] args)
        {
            Console.ReadLine();

            Debug.WriteLine("This is in Debug.WriteLine...");
            Trace.WriteLine("This is in Trace.WriteLine...");

            DoSomethingWithPositiveNumber(-10);

            Console.ReadLine();
        }
    }
}
