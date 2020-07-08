using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Example
{
    class Cat : IComparable<Cat>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Cat other)
        {
            return Name.CompareTo(other.Name);
        }
    }

    class CatAgeComparer : IComparer<Cat>
    {
        public int Compare(Cat x, Cat y)
        {
            return x.Age - y.Age;
        }
    }
}
