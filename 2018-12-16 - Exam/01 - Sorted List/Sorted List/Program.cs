using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();

            sl.Add(3, "a");
            sl.Add(1, "b");
            sl.Add(4, "c");
            sl.Add(2, "d");

            foreach (int key in sl.Keys)
            {
                Console.WriteLine(key + " --> " + sl[key]);
            }

        }
    }
}
