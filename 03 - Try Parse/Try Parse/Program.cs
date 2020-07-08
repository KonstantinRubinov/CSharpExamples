using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12.34a";
            double d;
            bool success = double.TryParse(s, out d);
            if (success)
                Console.WriteLine(d);
            else
                Console.WriteLine("fail to convert. d = " + d);
        }
    }
}
