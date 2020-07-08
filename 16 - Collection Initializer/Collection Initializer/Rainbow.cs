using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Initializer
{
    class Rainbow : IEnumerable
    {
        private List<ConsoleColor> colors = new List<ConsoleColor> {
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.Magenta
        };

        public void Add(ConsoleColor color)
        {
            colors.Add(color);
        }

        public IEnumerator GetEnumerator()
        {
            return colors.GetEnumerator();
        }
    }
}
