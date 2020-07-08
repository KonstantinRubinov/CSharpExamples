using System;
using System.Collections;

namespace Enumerable_Example
{
    class Rainbow : IEnumerable
    {
        public ConsoleColor color1 = ConsoleColor.Red;
        public ConsoleColor color2 = ConsoleColor.Yellow;
        public ConsoleColor color3 = ConsoleColor.Green;
        public ConsoleColor color4 = ConsoleColor.Blue;
        public ConsoleColor color5 = ConsoleColor.Magenta;

        public IEnumerator GetEnumerator()
        {
            return new RainbowEnumerator(this);
        }
    }


    class RainbowEnumerator : IEnumerator
    {
        private Rainbow rainbow;
        private int index = 0;

        public RainbowEnumerator(Rainbow rainbow)
        {
            this.rainbow = rainbow;
        }

        public object Current // החזרת הפריט הנוכחי מהאוסף
        {
            get
            {
                switch(index)
                {
                    case 1: return rainbow.color1;
                    case 2: return rainbow.color2;
                    case 3: return rainbow.color3;
                    case 4: return rainbow.color4;
                    default: return rainbow.color5;
                }
            }
        }

        public bool MoveNext() // הזזה לפריט הבא באוסף
        {
            index++;
            return index <= 5;
        }

        public void Reset() // איפוס הריצה על האוסף
        {
            index = 0;
        }
    }
}
