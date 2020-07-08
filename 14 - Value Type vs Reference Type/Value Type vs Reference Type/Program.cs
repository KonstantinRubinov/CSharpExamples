using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Type_vs_Reference_Type
{
    enum Color { Red, Green, Blue }

    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine("X: {0}, Y: {1}", X, Y);
        }
    }

    class Person { };

    delegate void DoSomething(int x);

    interface IDisplayable { };

    class Program
    {
        static void Init(Point pnt)
        {
            pnt.X = 100;
            pnt.Y = 200;
        }

        static void Main(string[] args)
        {
            // enum, struct, class, interface, delegate
            Point p = new Point(0, 0);
            p.X = 10;
            p.Y = 20;
            p.Display(); // 10, 20
            Init(p);
            p.Display(); // 10, 20

        }
    }
}
