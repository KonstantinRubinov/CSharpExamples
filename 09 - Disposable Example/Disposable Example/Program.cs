using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger logger = new Logger(); // Logger.
            //try
            //{
            //    logger.Write("First line...");
            //    logger.Write("Second line...");
            //    int a = 0, b = 1 / a;
            //    logger.Write("Third line...");
            //}
            //finally
            //{
            //    logger.Dispose();
            //}


            using (Logger logger = new Logger())
            {
                logger.Write("First line...");
                logger.Write("Second line...");
                int a = 0, b = 1 / a;
                logger.Write("Third line...");
            }

            Console.ReadLine();
        }
    }
}
