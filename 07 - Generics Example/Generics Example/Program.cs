using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            SMS<string> s1 = new SMS<string>("052-9658999", "Hi");
            s1.Send();

            SMS<DateTime> s2 = new SMS<DateTime>("052-9658745", DateTime.Now);
            s2.Send();

            SMS<string> s3 = new SMS<string>("052-9658999", "Bye");
            s3.Send();
        }
    }
}
