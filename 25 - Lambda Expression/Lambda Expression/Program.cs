using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {

            Action f1 = () => {
                Console.Write("F1 ");
                Console.Write("F1 ");
                Console.WriteLine("F1");
            };
            f1();

            Action f2 = () => Console.WriteLine("F2");
            f2();

            Action<int, double, string> f3 = (a, b, c) => {
                Console.WriteLine("F3");
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("c = " + c);
            };
            f3(10, 12.34, "HI");

            Action<int, double, string> f4 = (a, b, c) => Console.WriteLine("F4 a = {0}, b = {1}, c = {2}", a, b, c);
            f4(10, 12.34, "HI");

            Func<int> f5 = () => {
                Console.WriteLine("F5");
                return 123;
            };
            Console.WriteLine(f5());

            Func<int> f6 = () => 12345;
            Console.WriteLine(f6());

            Func<int, double, string> f7 = (a, b) => "Result: " + (a * b);
            Console.WriteLine(f7(100, 3.4));

            Func<int, double> f8 = a => a * a * 1.1;
            Console.WriteLine(f8(12));

        }
    }
}
