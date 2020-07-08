using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("MyFile.txt"))
            {
                Console.SetOut(writer);
                Console.WriteLine("Hi");
                Console.WriteLine("Hi");
                Console.WriteLine("Hi");
            }
        }
    }
}
