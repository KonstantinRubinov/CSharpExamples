using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {

                // .....

                unchecked
                {
                    byte b = 255;
                    b += 3;
                    Console.WriteLine(b);
                }

                // .....

            }
        }
    }
}
