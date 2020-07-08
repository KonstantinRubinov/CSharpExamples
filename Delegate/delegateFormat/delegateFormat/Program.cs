using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateFormat
{
    delegate void FormatNumber(double number);

    class Program
    {
        static void FormatNumberAsCurrency(double num)
        {
            Console.WriteLine("A Currency: {0:C}", num);
        }

        static void FormatNumberWithCommas(double num)
        {
            Console.WriteLine("With Commas: {0:N}", num);
        }

        static void FormatNumberWithTwoPlaces(double num)
        {
            Console.WriteLine("With 2 places: {0:.##}", num);
        }
        static void Main(string[] args)
        {
            FormatNumber format = FormatNumberAsCurrency;
            format += FormatNumberWithCommas;
            format += FormatNumberWithTwoPlaces; 

            format(12345.67891234);

            format -= FormatNumberAsCurrency;


            format(3.14);

        }

    }
   
}

