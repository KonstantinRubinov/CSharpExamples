using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Implementation_of_Interface
{
    interface IA
    {
        void f();
    }

    interface IB
    {
        void f();
    }

    class MyClass : IA, IB
    {
        public void f()
        {
            Console.WriteLine("IA.f");
        }

        void IB.f()
        {
            Console.WriteLine("IB.f");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.f(); // IA.f
            ((IA)obj).f(); // IA.f

            ((IB)obj).f(); // IB.f
        }
    }
}
