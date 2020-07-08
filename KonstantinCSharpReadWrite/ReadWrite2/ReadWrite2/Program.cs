using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWrite2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"J:\City.txt";
            string City;
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
            
            for (int MyCounter = 0; MyCounter < MyArr.Length; MyCounter++)
            {
                Console.WriteLine("The Average is: " + MyArr[MyCounter]);
            }

            Console.WriteLine("Enter The City:");
            City=Console.ReadLine();

            for (int MyCounter = 0; MyCounter < MyArr.Length; MyCounter++)
            {
                if (City == MyArr[MyCounter]) Console.WriteLine(MyCounter);
            }

            sr.Close();
            Console.ReadLine();
        }
    }
}
