using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ReadWrite4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"H:\Students.txt";
            string[] MyArr;
            StreamReader sr;
            int avg = 0;
            
            int Counter = 0;

            sr = new StreamReader(path);

            string str = string.Empty;

            if (File.Exists(path))
            {
                while (sr.Peek() >= 0)
                {
                    str = str + sr.ReadLine() + ',';
                    
                }
            }
            sr.Close();
            MyArr = str.Split(',');

            MyArr = MyArr.Where(w => w != MyArr[MyArr.Length-1]).ToArray();
           
            for (int place = 8; place < MyArr.Length; place+=9)
            {
                avg = avg + int.Parse(MyArr[place]);
                Counter++;
            }
            avg = avg / Counter;
            
            Console.WriteLine("The Average is: " + avg);

            for (int place = 0; place < MyArr.Length; place += 9)
            {
                if ((int.Parse(MyArr[place + 3]) > avg) || (int.Parse(MyArr[place + 4]) > avg) || (int.Parse(MyArr[place + 5]) > avg) || (int.Parse(MyArr[place + 6]) > avg) || (int.Parse(MyArr[place + 7]) > avg))
                {
                    Console.WriteLine("The Name: " + MyArr[place]);
                    Console.WriteLine("The Age: " + MyArr[place+1]);
                    Console.WriteLine("The Address: " + MyArr[place+2]);
                }
            }            
            Console.ReadLine();
        }
    }
}
