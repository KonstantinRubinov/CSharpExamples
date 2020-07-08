using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatePoinrCircle
{

    public delegate void ChangePointChanged(string str, int val);
    public delegate void ChangeRadiusChanged(string str, int val);


    public class Circle
    {
        Point position;
        int radius;

        public event ChangePointChanged XyChange;
        public event ChangeRadiusChanged RChange;


        public Circle(int tmpX, int tmpY, int tmpRadius) // בנאי
        {
            position = new Point(tmpX, tmpY);
            radius = tmpRadius;
        }

        public int RadiusCH //תכונות
        {
            get
            {
                return radius;
            }
            set
            {
                if (value >= 0 && value <= 1024)
                {
                    radius = value;
                    if (RChange != null)
                        RChange("From RadiusCHanged", value);


                }
            }
        }

        public int PointX //תכונות
        {
            get
            {
                return position.x;
            }
            set
            {
                if (value >= 0 && value <= 1024)
                {
                    position.x= value;
                    if (XyChange != null)
                        XyChange("From pointX",value);


                }
            }
        }

        public int PointY //תכונות
        {
            get
            {
                return position.y;
            }
            set
            {
                if (value >= 0 && value <= 1024)
                {
                    position.y = value;
                    if (XyChange != null)
                        XyChange("From pointY", value);

                }
            }
        } 

        public void Print() //הדפסה
        {
            position.Print();
            Console.WriteLine("radius= " + radius);
        }
    }
}
