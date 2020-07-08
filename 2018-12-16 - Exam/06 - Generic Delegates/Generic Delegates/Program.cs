using System;

namespace Generic_Delegates
{
    class Program
    {
        static void F1(string s, int i, double d, DateTime dt, short sh)
        {
            Console.WriteLine("F1");
        }

        static char F2(string s, int i, double d, DateTime dt, short sh)
        {
            Console.WriteLine("F2");
            return 'a';
        }

        static int F3(int x)
        {
            Console.WriteLine("F3");
            return 123;
        }

        static void Main(string[] args)
        {
            Action<string, int, double, DateTime, short> funcAddress1 = F1;
            funcAddress1("Hi", 123, 1.2, DateTime.Now, 100);

            Func<string, int, double, DateTime, short, char> funcAddress2 = F2;
            char result = funcAddress2("Hi", 123, 1.2, DateTime.Now, 100);
            Console.WriteLine(result);

            Func<int, int> funcAddress3 = F3;
            int result2 = funcAddress3(123);
            Console.WriteLine(result2);
        }
    }
}
