using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cat> cats = new List<Cat>();

            cats.Add(new Cat { Name = "Mitsi", Age = 4 });
            cats.Add(new Cat { Name = "Kitsi", Age = 5 });
            cats.Add(new Cat { Name = "Hertzel", Age = 3 });

            foreach (Cat item in cats)
                Console.WriteLine(item.Name + " " + item.Age);
            Console.WriteLine();

            cats.Sort();

            foreach (Cat item in cats)
                Console.WriteLine(item.Name + " " + item.Age);
            Console.WriteLine();

            cats.Sort(new CatAgeComparer());

            foreach (Cat item in cats)
                Console.WriteLine(item.Name + " " + item.Age);
            Console.WriteLine();

        }
    }
}
