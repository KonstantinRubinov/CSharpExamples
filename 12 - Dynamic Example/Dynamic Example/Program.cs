using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj1 = new Cat { Name = "Mitsi", Age = 4 }; // Untyped 
            var obj2 = new Cat { Name = "Mitsi", Age = 4 }; // Typed
            dynamic obj3 = new Cat { Name = "Mitsi", Age = 4 }; // Untyped but it won't make a compilation error!

            // Console.WriteLine(obj1.Name); // Compilation Error.
            Console.WriteLine((obj1 as Cat).Name);
            Console.WriteLine(((Cat)obj1).Name);

            Console.WriteLine(obj2.Name);

            Console.WriteLine(obj3.Name); 
            Console.WriteLine(obj3.Age);
            // Console.WriteLine(obj3.Color); // Runtime Exception


            dynamic message = new ExpandoObject();
            message.From = "Moishe";
            Console.WriteLine(message.From);
        }
    }
}
