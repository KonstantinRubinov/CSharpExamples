using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int> { 10, 20, 30 };
            foreach (int item in items)
                Console.WriteLine(item);
            Console.WriteLine();

            Rainbow rainbow = new Rainbow { ConsoleColor.DarkBlue, ConsoleColor.Cyan };
            foreach (ConsoleColor item in rainbow)
                Console.WriteLine(item);

            // int[] arr = { 11, 22, 33 };

        }
    }
}
