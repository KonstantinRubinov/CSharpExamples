using System;
using System.Reflection;

namespace Reflection_Example
{
    class Cat
    {
        public void DoSomething(int a, int b)
        {
            Console.WriteLine("Doing Something a = " + a + ", b = " + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat(); // יצירת אובייקט

            Type t = c.GetType(); // מביא אובייקט המכיל מידע בנוגע למחלקה

            MethodInfo mi = t.GetMethod("DoSomething"); // מציאת הפונקציה והחזרת אובייקט המתאר אותה

            object[] arr = new object[2]; // מערך פרמטרים לפונקציה
            arr[0] = 10; // פרמטר ראשון
            arr[1] = 20; // פרמטר שני

            mi.Invoke(c, arr); // קריאה לפונקציה
        }
    }
}
