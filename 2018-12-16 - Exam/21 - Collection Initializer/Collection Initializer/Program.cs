using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Initializer
{
    static class AssafExtensions
    {
        public static void Add(this People people, string name) => people.Add123(name);
    }

    class People : IEnumerable<string>
    {
        private List<string> names = new List<string>();

        public void Add123(string name)
        {
            names.Add(name);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return names.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return names.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People p = new People() { "Moishe", "Kipi" };

            foreach (string item in p)
            {
                Console.WriteLine(item);
            }

            int x = 7;

            switch(x)
            {
                case 1: Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                default: Console.WriteLine("Unknown");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
            }
        }
    }
}
