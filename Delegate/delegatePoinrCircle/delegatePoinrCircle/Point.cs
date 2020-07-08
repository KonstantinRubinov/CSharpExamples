using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatePoinrCircle
{
    public delegate void PointChangedDelegate(Point p,string msg);
    public delegate void PrintCall(string msg);
    public delegate void ChangeField(string str,int val); // הגדרה עבור איבנט

    public class Point
    {
        public int x;
        public int y;
        public PointChangedDelegate pointDelegate;
        public PrintCall printC;
        public event ChangeField AttributeChange; 

        public Point(int tmpX, int tmpY) //בנאי
        {
            x = tmpX;
            y = tmpY;
        }

        public int PointX //תכונות
        {
            get
            {
                return x;
            }
            set
            {
                if (value>=0 && value <=1024)
                {
                    x = value;
                    if (pointDelegate !=null)
                        pointDelegate(this,"From pointX");

                    if (AttributeChange != null)
                        AttributeChange("PointX changed", x);
                }
            }
        } 

        public int PointY //תכונות
        {
            get
            {
                return y;
            }
            set
            {
                if (value >= 0 && value <= 1024)
                {
                    y = value;
                    if (pointDelegate!=null)
                        pointDelegate(this,"From pointY");

                    if (AttributeChange != null)
                        AttributeChange("PointY changed", y);
                }
            }
        } 


        public void Print() //הדפסה
        {
            Console.WriteLine("X={0},Y={1}", x, y);
            printC("Adir");
            
        }




    }
}
