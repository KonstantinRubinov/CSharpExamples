using System;

namespace Create_Object
{
    class Cat { }

    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Cat);

            Cat c = (Cat)Activator.CreateInstance(t);
            Console.WriteLine(c.GetType().Name);

            object obj = Activator.CreateInstance(t);
            Console.WriteLine(obj.GetType().Name);
        }
    }
}
