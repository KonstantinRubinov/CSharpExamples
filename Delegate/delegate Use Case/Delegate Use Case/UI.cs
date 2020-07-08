using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Use_Case
{
    class UI
    {
        //public void DisplayPercent(int percent)
        //{
        //    Console.Write("\r" + percent + " %");
        //}

        public void Start()
        {
            // שליחת פונקציה חיצונית
            //NasaCalculator nc = new NasaCalculator();
            //long sum = nc.LongCalculation(DisplayPercent);
            //Console.WriteLine("\n\nsum: " + sum);
            
            // פונקציה אנונימית
            //NasaCalculator nc = new NasaCalculator();
            //long sum = nc.LongCalculation(delegate(int percent) {
            //    Console.Write("\r" + percent + " %");
            //});
            //Console.WriteLine("\n\nsum: " + sum);

            // Lambda Expression
            //NasaCalculator nc = new NasaCalculator();
            //long sum = nc.LongCalculation((percent) => {
            //    Console.Write("\r" + percent + " %");
            //});
            //Console.WriteLine("\n\nsum: " + sum);

            // Lambda Expression - one parameter can reduce the round brackets: 
            //NasaCalculator nc = new NasaCalculator();
            //long sum = nc.LongCalculation(percent => {
            //    Console.Write("\r" + percent + " %");
            //});
            //Console.WriteLine("\n\nsum: " + sum);

            // Lambda Expression - one command can reduce the curlly brackets: 
            // (remove also return if exists)
            NasaCalculator nc = new NasaCalculator();
            long sum = nc.LongCalculation(percent => Console.Write("\r" + percent + " %"));
            Console.WriteLine("\n\nsum: " + sum);
        }
    }
}
