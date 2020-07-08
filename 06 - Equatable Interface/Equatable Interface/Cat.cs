using System;

namespace Equatable_Interface
{
    class Cat : IEquatable<Cat>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public bool Equals(Cat other)
        {
            return ID == other.ID;
        }
    }

    //class Cat
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        return obj is Cat && ID == (obj as Cat).ID;
    //    }
    //}
}

