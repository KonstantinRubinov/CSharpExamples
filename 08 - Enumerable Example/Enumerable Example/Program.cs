using System;
using System.Collections;

namespace Enumerable_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Rainbow rainbow = new Rainbow();

            IEnumerator enumerator = rainbow.GetEnumerator();
            enumerator.Reset();
            while(enumerator.MoveNext())
            {
                ConsoleColor item = (ConsoleColor)enumerator.Current;
                Console.ForegroundColor = item;
                Console.WriteLine(item);
                Console.ResetColor();
            }

            Console.WriteLine("---------------------");

            foreach (ConsoleColor item in rainbow)
            {
                Console.ForegroundColor = item;
                Console.WriteLine(item);
                Console.ResetColor();
            }

            Console.WriteLine("---------------------");

            Rainbow2 rainbow2 = new Rainbow2();
            foreach (ConsoleColor item in rainbow2)
            {
                Console.ForegroundColor = item;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }
    }
}
