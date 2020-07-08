using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void MyDel1(int x, string y);
    delegate void MyDel2(double d);
    delegate void MyDel3(short s, int i, DateTime dt);

    class Program
    {
        static void F1(int a, string b)
        {
            Console.WriteLine("F1, a = " + a + ", " + b);
        }

        static void Main(string[] args)
        {
            F1(10, "Hello");

            MyDel1 funcAddress1 = new MyDel1(F1);
            funcAddress1.Invoke(10, "Hello");

            MyDel1 funcAddress1b = F1;
            funcAddress1b.Invoke(10, "Hello");

            MyDel1 funcAddress1c = F1;
            funcAddress1c(10, "Hello");

            MyDel2 funcAddress2 = Tester.F2;
            funcAddress2(12.34);

            Tester t = new Tester();
            MyDel3 funcAddress3 = t.F3;
            funcAddress3(100, 300000, DateTime.Now);

        }

    }
}
