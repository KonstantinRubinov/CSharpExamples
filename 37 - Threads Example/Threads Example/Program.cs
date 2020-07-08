using System;
using System.Threading;

namespace Threads_Example
{
    class Program
    {
        static CancellationTokenSource cts = new CancellationTokenSource();
        
        static void Print1()
        {
            Console.WriteLine("Print1: " + Thread.CurrentThread.ManagedThreadId);

            for (int i = 1; i <= 30; i++)
            {
                Console.Write("1 ");
                for (long j = 1; j <= 150000000; j++) ;

                // if (cts.IsCancellationRequested) break;
                if (cts.Token.IsCancellationRequested) break;
            }
        }

        static void Print2(object count)
        {
            Console.WriteLine("Print2: " + Thread.CurrentThread.ManagedThreadId);

            for (int i = 1; i <= (int)count; i++)
            {
                Console.Write("2 ");
                for (long j = 1; j <= 150000000; j++) ;

                //if(i == 3)
                //{
                //    Thread.Sleep(2000);
                //}
            }
        }

        static void Main(string[] args) // The Main Thread
        {
            Console.WriteLine("Main: " + Thread.CurrentThread.ManagedThreadId);

            //Print1(); // Synchronous Call - קריאה סינכרונית
            //Print2(); // Synchronous Call - קריאה סינכרונית

            Thread t1 = new Thread(Print1);
            Thread t2 = new Thread(Print2);
            //t1.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Lowest;

            //t1.IsBackground = true;
            //t2.IsBackground = true;

            // Console.WriteLine(t1.IsAlive);

            t1.Start(); // Asynchronous Call - קריאה אסינכרונית
            // Console.WriteLine(t1.IsAlive);


            t2.Start(30); // Asynchronous Call - קריאה אסינכרונית

            //t2.Join();

            // Thread.Sleep(5000);
            

            Console.WriteLine("End of Main");

            Console.ReadLine();
            cts.Cancel();


            // Console.WriteLine(t1.IsAlive);

            Cat c = new Cat();
        }
    }
}
