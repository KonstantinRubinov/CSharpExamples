using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Point> points = new List<Point>();
            for (int i = 0; i < 100; i++)
            {
                Point p = new Point { X = rnd.Next(100), Y = rnd.Next(100) };
                points.Add(p);
            }

            //var results = points.Where(IsXLargerThan90);
            //foreach (Point item in results)
            //    Console.WriteLine(item);

            //var results = points.Where(p => p.X > 90);
            //foreach (Point item in results)
            //    Console.WriteLine(item);

            //var results = points.Where(p => p.X > 90).ToList();
            //results.ForEach(p => Console.WriteLine(p));

            //points.Where(p => p.X > 90).ToList().ForEach(p => Console.WriteLine(p));

            //points.Where(p => p.X > 90).OrderBy(p => p.X).ToList().ForEach(p => Console.WriteLine(p));

            // points.Where(p => p.X > 90).OrderByDescending(p => p.X).ToList().ForEach(p => Console.WriteLine(p));

            // points.Where(p => p.X > 90).OrderBy(p => p.X).ThenBy(p => p.Y).ToList().ForEach(p => Console.WriteLine(p));

            //points.Where(p => p.X > 90).OrderBy(p => p.X).ThenByDescending(p => p.Y).ToList().ForEach(p => Console.WriteLine(p));

            // points.Where(p => p.X > 90).OrderByDescending(p => p.X).ThenByDescending(p => p.Y).ToList().ForEach(p => Console.WriteLine(p));

            // points.Where(p => p.X > 90).OrderBy(p => p.X).Select(p => "The X is: " + p.X).ToList().ForEach(p => Console.WriteLine(p));

            // points.Where(p => p.X > 90).OrderBy(p => p.X).Select(p => p).ToList().ForEach(p => Console.WriteLine(p)); // Default Select

            // points.Where(p => p.X > 90).OrderBy(p => p.X).Select(p => new { p.X, p.Y, PowerX = p.X * p.X, PowerY = p.Y * p.Y }).ToList().ForEach(p => Console.WriteLine(p));

            // Console.WriteLine("------------------------------");

            //var query = from p in points // SQL Like Syntax
            //            where p.X > 90
            //            orderby p.X
            //            select new { p.X, p.Y, PowerX = p.X * p.X, PowerY = p.Y * p.Y };
            //query.ToList().ForEach(p => Console.WriteLine(p));


            // points.Where(p => p.X > 90).Select(p => p.X).Distinct().ToList().ForEach(p => Console.WriteLine(p));

            // points.Where(p => p.X % 2 == 0).OrderBy(p => p.X).Skip(20).ToList().ForEach(p => Console.WriteLine(p));

            // points.Where(p => p.X % 2 == 0).OrderBy(p => p.X).Skip(20).Take(10).ToList().ForEach(p => Console.WriteLine(p));

        }

        //static bool IsXLargerThan90(Point p)
        //{
        //    return p.X > 90;
        //}
    }
}
