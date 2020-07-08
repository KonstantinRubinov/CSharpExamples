//#define TESTING // Symbol
#define PRODUCTION

// Build Configuration

using System;
using System.Diagnostics;

namespace Debugging
{
    class Program
    {
        static void DoSomething1()
        {
#if TESTING
            Console.WriteLine("Doing Something in testing...");
#elif PRODUCTION
            Console.WriteLine("Doing Something in production...");
#endif
        }

        static void DoSomething2()
        {
#if DEBUG
            Console.WriteLine("Doing Something in debug...");
#else
            Console.WriteLine("Doing Something in release...");
#endif
        }

        [Conditional("DEBUG")]
        static void DoSomething3()
        {
            Console.WriteLine("Doing something in debug mode...");
        }

        [Conditional("TESTING")]
        static void DoSomething4()
        {
            Console.WriteLine("Doing something in testing mode...");
        }

        static void Main(string[] args)
        {
            DoSomething1();
            DoSomething2();
            DoSomething3();
            DoSomething4();
        }

#region Several Functions
        static void F1()
        {
        }
        static void F2()
        {
        }
        static void F3()
        {
        }
        static void F4()
        {
        }
#endregion

    }
}
