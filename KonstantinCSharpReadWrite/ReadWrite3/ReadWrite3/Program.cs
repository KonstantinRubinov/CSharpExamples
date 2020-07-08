using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWrite3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"J:\City.txt";
            string path2 = @"J:\NewCity.txt";
            string City;
            StreamWriter sw;
            StreamReader sr;
            string[] MyArr;
            string MyWord;

            sr = new StreamReader(path);

            string str = string.Empty;

            if (File.Exists(path))
            {
                while (sr.Peek() >= 0)
                {
                    str = str + sr.ReadLine();
                }
            }

            MyArr = str.Split(',');

            if (File.Exists(path2))
            {
                File.Delete(path2);
            }

            sw = new StreamWriter(path2);
            
            for (int MyCounter = 0; MyCounter < MyArr.Length; MyCounter++)
            {
                MyWord = MyArr[MyCounter];
                if (MyCounter % 2 == 0)
                {
                    sw.WriteLine(MyWord.ToLower());
                    Console.WriteLine(MyWord.ToLower());
                }
                else
                {
                    sw.WriteLine(MyWord.ToUpper());
                    Console.WriteLine(MyWord.ToUpper());
                }
            }

            sw.Close();
            sr.Close();
            Console.ReadLine();
        }
    }
}
