using System;

namespace Equatable_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat { ID = 100, Name = "Mitsi" };
            Cat c2 = new Cat { ID = 100, Name = "Mitsi" };

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1.Equals(8));

        }
    }
}
