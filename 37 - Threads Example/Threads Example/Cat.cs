using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_Example
{
    class Cat
    {
        ~Cat()
        {
            Console.WriteLine("Cat dtor: " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
