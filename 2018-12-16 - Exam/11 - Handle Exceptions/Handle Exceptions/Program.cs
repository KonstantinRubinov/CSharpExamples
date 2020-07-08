using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Handle_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            int a = 0, b = 1 / a;
            Console.WriteLine("Done");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("Error.");
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine(sender);
        }
    }
}
