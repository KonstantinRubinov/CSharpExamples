using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constrains
{
    // class A<T> where T : class // T must be reference type (class / interface / delegate)
    // class A<T> where T : struct // T must be value type (struct / enum)
    // class A<T> where T : IDisposable, IConvertible // T must implement those interfaces
    // class A<T> where T : Person // T must be Person or derived from Person
    // class A<T, G> where T : G // T must derived from G
    class A<T> where T: new() // T must have an empty ctor
    // class A<T> where T : Person, IDisposable, IConvertible, new() // several constrains
    {
        public T Value = new T();
        //public G Value2;
    }

    class Program
    {
        static void Main(string[] args)
        {
            A<int> obj1 = new A<int>();
            A<string> obj2 = new A<string>();
        }
    }

    class Person { }
}
