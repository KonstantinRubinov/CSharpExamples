using System;
using System.Collections.Generic;
using System.Linq;

namespace Get_Current_Assembly_Types
{
    // class, struct, delegate, interface, enum

    struct A { }

    class Test
    {
        public void run()
        {
            List<Type> types = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(t => t.GetTypes())
                .Where(t => t.IsClass && t.Assembly == this.GetType().Assembly)
                .ToList();

            foreach (Type type in types)
                Console.WriteLine(type.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.run();
        }
    }
}
