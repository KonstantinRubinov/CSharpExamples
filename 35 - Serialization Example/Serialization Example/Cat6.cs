using System.Runtime.Serialization;

namespace Serialization_Example
{
    public class Cat6
    {
        public string Name;

        public string Color;

        public int Age;

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Color: {2}", Name, Age, Color);
        }
    }
}
