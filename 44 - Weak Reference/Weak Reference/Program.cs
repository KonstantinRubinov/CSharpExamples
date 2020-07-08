using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weak_Reference
{
    class Cat {
        public override string ToString()
        {
            return "I'm a cat...";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeakReference wrCat = new WeakReference(new Cat());

            if(wrCat.Target == null)
            {
                Cat c = new Cat();
                wrCat.Target = c;
            }

            Console.WriteLine(wrCat.Target);

            Cat c2 = new Cat();
            GC.KeepAlive(c2);
        }
    }
}
