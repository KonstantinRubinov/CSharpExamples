using System;

namespace Flags_on_Enums
{
    [Flags]
    enum Weather { Sunny = 1, Rainy = 2, Cloudy = 4, Foggy = 8, Snowy = 16 }

    class Program
    {
        static void Main(string[] args)
        {
            Weather w = Weather.Cloudy | Weather.Foggy;
            Console.WriteLine(w);
            Console.WriteLine(w == Weather.Cloudy);
            Console.WriteLine(w == Weather.Rainy);
            Console.WriteLine(w == (Weather.Cloudy | Weather.Foggy));

            Weather w2 = Weather.Cloudy;
            Console.WriteLine(w2);
            Console.WriteLine(w2 == Weather.Cloudy);

            Console.WriteLine(w2 < Weather.Snowy);

        }
    }
}
