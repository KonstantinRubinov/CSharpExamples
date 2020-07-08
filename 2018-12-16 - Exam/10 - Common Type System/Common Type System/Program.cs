using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Common_Type_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "Hi";
            //String s2 = "Hi";

            //int n1 = 123;
            //Int32 n2 = 123;

            //int x = int.Parse("123"); // Doesn't support nulls
            //Console.WriteLine(x);

            //int x2 = Convert.ToInt32("123"); // Support nulls
            //Console.WriteLine(x2);


            MatchCollection collection = Regex.Matches("aababaaaba", "b");
            foreach (Match item in collection)
                Console.WriteLine(item.Value);

            
        }
    }
}
