using System.Runtime.Serialization;

namespace Serialization_Example
{
    [DataContract(Name = "Cat", Namespace = "JohnBryce")]
    public class Cat5
    {
        [DataMember(Name = "CatName", Order = 3)]
        public string Name;

        [DataMember(Name = "CatColor", Order = 2)]
        public string Color;

        [DataMember(Name = "CatAge", Order = 1)]
        public int Age;

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Color: {2}", Name, Age, Color);
        }
    }
}
