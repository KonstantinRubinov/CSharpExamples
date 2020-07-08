using System;

namespace Serialization_Example
{
    // For SoapFormatter

    [Serializable]
    public class Cat2
    {
        public string Name;

        public string Color;

        [NonSerialized]
        public int Age;

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Color: {2}", Name, Age, Color);
        }
    }
}
