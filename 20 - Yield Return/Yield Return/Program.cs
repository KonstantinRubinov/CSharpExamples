using System;
using System.Collections.Generic;

namespace Yield_Return
{
    class Program
    {
        static IEnumerable<int> GetNumbers()
        {
            yield return 10;
            yield return 20;
            yield return 30;
        }

        static void Main(string[] args)
        {
            foreach (int item in GetNumbers())
            {
                Console.WriteLine(item);
            }
        }
    }
}
