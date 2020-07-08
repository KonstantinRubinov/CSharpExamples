using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    class Program
    {
        static void F1()
        {
            Console.WriteLine("F1");
            int a = 0, b = 1 / a;
        }

        static void F2()
        {
            try
            {
                Console.WriteLine("F2");
                F1();
            }
            catch(Exception ex)
            {
                Console.WriteLine("F2 Catch - " + ex.Message);
                //throw new Exception("bla");
                //throw ex;
                throw;
            }
        }

        static void F3()
        {
            Console.WriteLine("F3");
            F2();
        }

        static void Main(string[] args)
        {
            try
            {
                F3();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero! " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
