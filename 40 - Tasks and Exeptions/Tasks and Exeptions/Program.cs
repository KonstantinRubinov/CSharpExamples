using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks_and_Exeptions
{
    class Program
    {
        static void F1()
        {
            Thread.Sleep(1000);
            int a = 0, b = 1 / a;
        }

        static void F2()
        {
            Thread.Sleep(2000);
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[10]);
        }

        static void F3()
        {
            Thread.Sleep(3000);
            StreamWriter writer = null;
            writer.Write("Hi");
        }

        static void Parent()
        {
            Task t1 = new Task(F1, TaskCreationOptions.AttachedToParent);
            Task t2 = new Task(F2, TaskCreationOptions.AttachedToParent);
            Task t3 = new Task(F3, TaskCreationOptions.AttachedToParent);

            t1.Start();
            t2.Start();
            t3.Start();
        }

        static void Main(string[] args)
        {
            try
            {
                Task t = new Task(Parent);
                t.Start();
                t.Wait();
                Console.WriteLine("Done");
            }
            catch(AggregateException ex)
            {
                foreach (var item in ex.Flatten().InnerExceptions)
                    Console.WriteLine(item.Message);
            }

            Console.ReadLine();
        }
    }
}
