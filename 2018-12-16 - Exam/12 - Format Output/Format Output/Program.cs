using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Moishe";
            int age = 12;

            string s1 = string.Format("name = {0}, age = {1}", name, age);
            string s2 = $"name = {name}, age = {age}";
            string s3 = "name = " + name + ", age = " + age;

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            int num = 2;
            Console.WriteLine(num.ToString("###0"));
        }
    }
}
