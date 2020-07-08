using System;

namespace Rollup_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                F1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }

        static void F1()
        {
            try
            {
                F2();
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                throw;
            }
        }
        static void F2()
        {
            throw new Exception("F2");
        }
    }
}
