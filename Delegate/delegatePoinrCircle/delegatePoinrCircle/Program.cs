using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatePoinrCircle
{   
    class PrTest
    {
        public static void Func1(Point p, string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("PrTest.Func1:" + p.PointX.ToString() + "," + p.PointY.ToString());
        }
    }

    class Program
    {
        private static void Func1(Point p, string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("Func1: " + p.PointX.ToString() + "," + p.PointY.ToString());
        }

        private static void Func3(Point p, string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("Func3: " + p.PointX.ToString() + "," + p.PointY.ToString());
        }

        private static void Func2(string text)
        {
            Console.WriteLine(text);
        }

        private static void PointChanged(Point p,string str)
        {
            Console.WriteLine(str);
            Console.WriteLine("pointChanged: " + p.PointX + " " + p.PointY);
        }

        private static void Print_call(string str)
        {
            Console.WriteLine(str);
        }

       


        static void Main(string[] args)
        {

            Point p2 = new Point(2, 4);
           // p2.pointDelegate = new PointChangedDelegate(PointChanged);

            p2.AttributeChange += p2_AttributeChange;     //סביבה יוצרת לבד (TAB+TAB)
            p2.AttributeChange += new ChangeField(OnAttributeChange); // פונקצייה שהיא תגובה לאירוע 
            p2.PointX = 10;
            p2.PointY = 30;

            Circle c1 = new Circle(3, 4, 5);
           // c1.XyChange += c1_XyChange;
            c1.XyChange += new ChangePointChanged(CirclePointChange);

            //c1.RChange += c1_RChange;
            c1.RChange += new ChangeRadiusChanged(R_Change);

            c1.PointX = 12;
            c1.PointY = 10;
            c1.RadiusCH = 10;


/*
            PointChangedDelegate del1 = new PointChangedDelegate(Func1);
            PointChangedDelegate del2 = new PointChangedDelegate(Func3);
            PointChangedDelegate del3 = new PointChangedDelegate(PrTest.Func1);

            Point p1 = new Point(2, 5);
            p1.PointX = 10;
            p1.pointDelegate = del1 + del2 + del3;
            p1.PointY = 10;
            p1.pointDelegate -= del1;

            p1.PointX = 20;


            Point p11 = new Point(2, 4);
            p11.pointDelegate = new PointChangedDelegate(PointChanged);
            p11.PointX = 10;
            p11.PointY = 30;


            p11.printC = new PrintCall(Print_call);
            p11.Print(); */

        }

        static void c1_RChange(string str, int val)
        {
            Console.WriteLine("{0}, new value {1}", str, val);
        }


        static void R_Change(string str, int val)
        {
            Console.WriteLine("{0}, new value {1}", str, val);
        }


        static void c1_XyChange(string str, int val)
        {
            Console.WriteLine("{0}, new value {1}", str, val);
        }

        private static void CirclePointChange(string str,int val)
        {
            Console.WriteLine("{0}, new value {1}", str, val);
        }


        private static void p2_AttributeChange(string str, int val)
        {
            Console.WriteLine("{0}, new value {1}", str, val);
        }

        static void OnAttributeChange(string str,int val)
        {
            Console.WriteLine("{0}, new value {1}", str, val);
        }

    }  
}

