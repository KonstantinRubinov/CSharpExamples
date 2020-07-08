using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_about_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD dvd = new DVD();
            dvd.Test();
            Console.WriteLine("----------------------");

            Radio radio = new Radio();
            (radio as ILab).Test();
            ((IQA)radio).Test();
            Console.WriteLine("----------------------");

            TV tv = new TV();
            (tv as ILab).Test();
            tv.Test();
        }
    }
}
