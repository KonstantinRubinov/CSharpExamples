using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checked_Block
{
    class Program
    {
        static void Main(string[] args)
        {

            checked
            {
                byte b = 255;
                b += 3;
                Console.WriteLine(b);

                unchecked
                {
                    byte b2 = 255;
                    b2 += 3;
                    Console.WriteLine(b2);
                }
            }

        }
    }
}
