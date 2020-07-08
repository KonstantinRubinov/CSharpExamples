using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable_Example
{
    class Rainbow2 : IEnumerable
    {
        private ConsoleColor[] colors = {
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.Magenta
        };

        public IEnumerator GetEnumerator()
        {
            return colors.GetEnumerator();
        }
    }
}
