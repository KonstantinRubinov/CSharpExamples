using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateFunc
{
    delegate void Mydelegate();

    class Program
    {
        static void Func()
        {
            Console.WriteLine("Delegate!");
        }


        static void Main(string[] args)
        {
            Mydelegate del = new Mydelegate(Func);
            del();

            Console.WriteLine(del.GetType().BaseType.ToString());


        }
    }
}
