using System.Xml.Serialization;

namespace Serialization_Example
{
    // For XmlSerializer

    [XmlRoot("Cat", Namespace = "JohnBryce")]
    public class Cat4
    {
        [XmlAttribute(AttributeName = "CatName")]
        public string Name;

        [XmlElement("CatColor")]
        public string Color;

        [XmlIgnore]
        public int Age;

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Color: {2}", Name, Age, Color);
        }
    }
}
