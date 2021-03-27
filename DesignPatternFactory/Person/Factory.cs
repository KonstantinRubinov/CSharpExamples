using System;
using System.Collections.Generic;
using System.Text;
using static DesignPatternFactory.Program;

namespace DesignPatternFactory
{
    public class Factory
    {
        public IPerson GetPerson(PersonType type)
        {
            switch (type)
            {
                case PersonType.Rural:
                    return new Villager();
                case PersonType.Urban:
                    return new CityPerson();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
