using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_and_Func
{
    delegate void MyDel();
    delegate void MyDel<T>(T t1);
    delegate void MyDel<T1, T2>(T1 t1, T2 t2);
    delegate T MyFunc<T>();
    delegate TResult MyFunc<T1, TResult>(T1 t1);

    class Program
    {
        static void F1()
        {
            Console.WriteLine("F1");
        }
        static void F2(int x)
        {
            Console.WriteLine("F2");
        }
        static void F3(string x)
        {
            Console.WriteLine("F3");
        }
        static void F4(short s, double d)
        {
            Console.WriteLine("F4");
        }
        static int F5()
        {
            Console.WriteLine("F5");
            return 123;
        }
        static double F6(int x)
        {
            Console.WriteLine("F6");
            return 123.456;
        }

        static void Main(string[] args)
        {
            MyDel f1 = F1;
            f1();

            MyDel<int> f2 = F2;
            f2(123);

            MyDel<string> f3 = F3;
            f3("Hi");

            MyDel<short, double> f4 = F4;
            f4(100, 12.34);

            MyFunc<int> f5 = F5;
            Console.WriteLine(f5());

            MyFunc<int, double> f6 = F6;
            Console.WriteLine(f6(100));
            
            Action<short, double> f4b = F4;
            f4b(100, 12.34);

            Func<int, double> f6b = F6;
            Console.WriteLine(f6b(123));
        }
    }
}
