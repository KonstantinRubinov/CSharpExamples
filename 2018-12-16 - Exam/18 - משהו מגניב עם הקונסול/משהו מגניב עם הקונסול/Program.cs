using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace משהו_מגניב_עם_הקונסול
{

    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter("MyFile.txt"))
            {
                Console.SetOut(w);
                Console.WriteLine("Hi");
                Console.WriteLine("This is a second line.");
            }
        }
    }
}
