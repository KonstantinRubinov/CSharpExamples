using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GC
{
    class Cat : IDisposable
    {
        StreamWriter writer = new StreamWriter("myfile.txt");

        protected void Dispose(bool disposing)
        {
            if(disposing)
                Console.WriteLine("Free .NET Resources...");

            Console.WriteLine("Free other resources...");

            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        ~Cat() { // Destructor = Finalize
            Dispose(false);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();

            Console.WriteLine(GC.GetGeneration(c)); // 0

            GC.Collect();

            Console.WriteLine(GC.GetGeneration(c)); // 1

            GC.Collect();

            Console.WriteLine(GC.GetGeneration(c)); // 2

            GC.Collect();

            Console.WriteLine(GC.GetGeneration(c)); // 2

            GC.Collect();

            Console.WriteLine(GC.GetGeneration(c)); // 2

        }
    }
}
