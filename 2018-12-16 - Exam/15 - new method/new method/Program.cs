using System;

namespace new_method
{
    class A
    {
        public void F() {
            Console.WriteLine("A.F");
        }
    }

    class B : A
    {
        public new void F()
        {
            Console.WriteLine("B.F");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj = new B();
            obj.F(); // A.F
            ((B)obj).F(); // B.F
            (obj as B).F(); // B.F
        }
    }
}
