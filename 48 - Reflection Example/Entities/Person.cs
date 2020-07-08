using System;

namespace Entities
{
    public class Person
    {
        private int _age;

        public string FullName { get; set; }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                    _age = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Age: " + Age);
        }

        private void DoSomething()
        {
            Console.WriteLine("Doing Something...");
        }
    }
}
