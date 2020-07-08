using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWrite1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"J:\Numbers.txt";

            StreamWriter sw;
            StreamReader sr;

            sr = new StreamReader(path);

            string str = string.Empty;

            if (File.Exists(path))
            {
                while (sr.Peek() >= 0)
                {
                    str = sr.ReadLine();
                }
            }

            string[] MyArr = str.Split(',');
            int avg = 0;
            for (int MyCounter = 0; MyCounter < MyArr.Length; MyCounter++)
            {
                avg = avg + int.Parse(MyArr[MyCounter]);
            }
            avg = avg / MyArr.Length;

            int big = 0;
            int small = 0;
            for (int MyCounter = 0; MyCounter < MyArr.Length; MyCounter++)
            {
                if (int.Parse(MyArr[MyCounter]) > avg) big++;
                if (int.Parse(MyArr[MyCounter]) < avg) small++;
            }

            Console.WriteLine("The Average is: " + avg);
            Console.WriteLine("The Bigger Numbers: " + big);
            Console.WriteLine("The Smaller Numbers: " + small);

            sr.Close();
            Console.ReadLine();
        }
    }
}
