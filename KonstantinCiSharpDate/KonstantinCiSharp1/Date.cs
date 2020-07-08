// Konstantin Rubinov 311078026
// Ido Shettah 301780375
// Matan Ben David302871074

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstantinCiSharp1
{
    public class Date
    {
        private int day;
        private string month;
        private int year;

        public Date()
        {
            day = DateTime.Now.Day;
            month = NumToMonth(DateTime.Now.Month); //add function
            year = DateTime.Now.Year;
        }

        public int MyDay
        {
            set
            {
                if (value>0 && value<32) day = value;
            }

            get
            {
                return day;
            }
        }


        public string MyMonth
        {
            set
            {
                int tmp = MonthToNum(value); 
                if (tmp>=1 && tmp<13) month = value;
            }
            
            get
            {
                return month;
            }
        }


        public int MyYear
        {
            set
            {
                if (value > 0) year = value;
            }

            get
            {
                return year;
            }
        }


        public void AddDay(int d)
        {
            int Tmonth = MonthToNum(month);
            day = day + d;
            while ((year % 4 == 0 && Tmonth == 2 && day > 29) || (year % 4 != 0 && Tmonth == 2 && day > 28) || ((Tmonth == 1 || Tmonth == 3 || Tmonth == 5 || Tmonth == 7 || Tmonth == 8 || Tmonth == 10 || Tmonth == 12) && day > 31) || ((Tmonth == 4 || Tmonth == 6 || Tmonth == 9 || Tmonth == 11) && (day > 30)))
            {
                if (year % 4 == 0 && Tmonth == 2 && day > 29)
                {
                    day = day - 29;
                    Tmonth++;
                }

                else if (year % 4 != 0 && Tmonth == 2 && day > 28)
                {
                    day = day - 28;
                    Tmonth++;
                }
                    
                else if ((Tmonth == 1 || Tmonth == 3 || Tmonth == 5 || Tmonth == 7 || Tmonth == 8 || Tmonth == 10 || Tmonth == 12) && day > 31)
                {
                    day = day - 31;
                    Tmonth++;
                }
                    
                else if ((Tmonth == 4 || Tmonth == 6 || Tmonth == 9 || Tmonth == 11) && day > 30)
                {
                    day = day - 30;
                    Tmonth++;
                }
                if (Tmonth > 12)
                {
                    year++;
                    Tmonth = 1;
                }
                    
            }
            month = NumToMonth(Tmonth);
        }


        public void AddMonth(int m)
        {
            int Tmonth = MonthToNum(month);

            Tmonth = Tmonth + m;

            while (Tmonth > 12)
            {
                Tmonth = Tmonth - 12;
                year++;
            }
            month=NumToMonth(Tmonth);
        }


        public void AddYear(int y)
        {
            year = year + y;
            y = 0;
        }


        static int MonthToNum(string mMonth)
        {
            int temp=0;
            if (mMonth=="January") temp=1;
            else if (mMonth=="February") temp=2;
            else if (mMonth=="March") temp=3;
            else if (mMonth=="April") temp=4;
            else if (mMonth=="May") temp=5;
            else if (mMonth=="June") temp=6;
            else if (mMonth=="July") temp=7;
            else if (mMonth=="August") temp=8;
            else if (mMonth=="September") temp=9;
            else if (mMonth=="October") temp=10;
            else if (mMonth=="November") temp=11;
            else if (mMonth=="December") temp=12;
            return temp;
        }


        static string NumToMonth(int mMonth)
        {
            string temp = "0";
            if (mMonth == 1) temp = "January";
            else if (mMonth == 2) temp = "February";
            else if (mMonth == 3) temp = "March";
            else if (mMonth == 4) temp = "April";
            else if (mMonth == 5) temp = "May";
            else if (mMonth == 6) temp = "June";
            else if (mMonth == 7) temp = "July";
            else if (mMonth == 8) temp = "August";
            else if (mMonth == 9) temp = "September";
            else if (mMonth == 10) temp = "October";
            else if (mMonth == 11) temp = "November";
            else if (mMonth == 12) temp = "December";
            return temp;
        }

        public string toString()
        {
            return day + ":" + month + ":" + year;
        }
    }
}
