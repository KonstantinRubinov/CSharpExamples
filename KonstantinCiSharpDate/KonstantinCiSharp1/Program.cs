using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstantinCiSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Date myDate = new Date();
            int flag = 0;
            int x;

            while (flag!=5)
            {
                Console.WriteLine("Choose what to do?");
                Console.WriteLine("1. Print date");
                Console.WriteLine("2. Add Day");
                Console.WriteLine("3. Add Mounth");
                Console.WriteLine("4. Add Year");
                Console.WriteLine("5. Exit\n");

                flag = int.Parse(Console.ReadLine());
                switch (flag)
                {
                    case 1: Console.WriteLine(myDate.toString());
                        break;

                    case 2:
                        {
                            Console.WriteLine("How many days to add?");
                            x = int.Parse(Console.ReadLine());
                            myDate.AddDay(x);
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("How many months to add?");
                            x = int.Parse(Console.ReadLine());
                            myDate.AddMonth(x);
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("How many years to add?");
                            x = int.Parse(Console.ReadLine());
                            myDate.AddYear(x);
                        }
                        break;

                    default: Console.WriteLine("Wrong choice !");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
