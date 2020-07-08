using System;
using System.Collections;

namespace Constraints
{
    // class A<T> where T : class // T must be Reference Type (class / interface / delegate)
    // class A<T> where T : struct // T must be Value Type (struct / enum)
    // class A<T> where T : Person // T must be Person or derived from Person
    // class A<T> where T : IDisposable, IEnumerable, IComparable // T must implement all those interfaces
    // class A<T> where T : new() // T must contain an empty ctor (ctor = Constructor)
    // class A<T> where T : Person, IDisposable, IEnumerable, new() // Combination of several constraints
    class A<T> where T : new()
    {
        public T Value = new T();
    }

    class Program
    {
        static void Main(string[] args)
        {
            A<int> obj1 = new A<int>();
            obj1.Value = 123;

            A<string> obj2 = new A<string>();
            obj2.Value = "Hi";

            A<Person> obj3 = new A<Person>();
            obj3.Value = new Person();

            A<Cat> obj4 = new A<Cat>();
            obj4.Value = new Cat("Mitsi");

        }
    }

    class Person { }

    class Cat
    {
        public Cat(string name) { }
    }
}
