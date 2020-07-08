using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks_Example
{
    class Program
    {
        static void Print1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("1 ");
                Thread.Sleep(500);
            }
        }

        static void Print2(object count)
        {
            for (int i = 1; i <= (int)count; i++)
            {
                Console.Write("2 ");
                Thread.Sleep(500);
            }


            Task t = new Task(()=> {
                Thread.Sleep(1000);
                Console.WriteLine("Doing Something...");
                Thread.Sleep(1000);
            }, TaskCreationOptions.AttachedToParent);
            t.Start();
        }

        static int Print3()
        {
            int total = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("3 ");
                Thread.Sleep(500);
                total += i;
            }
            return total;
        }

        static void Main(string[] args)
        {
            Task t1 = new Task(Print1);
            Task t2 = new Task(Print2, 10);
            Task<int> t3 = new Task<int>(Print3);

            t1.Start();
            t2.Start();
            t3.Start();

            //t1.Wait();
            //t2.Wait();
            int sum = t3.Result;
            Console.WriteLine(sum);
        }
    }
}
