using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex regex = new Regex("AB.C");
            //string str = "bla bla AB6C 123 456 ABxC Hello ABC World AB0C!";
            //Console.WriteLine(regex.IsMatch(str));
            //foreach (Match item in regex.Matches(str))
            //    Console.WriteLine(item.Index + " " + item.Value);


            // Mobile: 05x-xxxxxxx
            Regex regexPhone = new Regex(@"^0\d-?\d{7}$");

            Console.WriteLine("Enter your mobile: ");
            string phone = Console.ReadLine();
            if(regexPhone.IsMatch(phone))
                Console.WriteLine("Your phone is legal.");
            else
                Console.WriteLine("Your phone is NOT legal.");

        }
    }
}
