using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternFactory
{
    public class CityPerson : IPerson
    {
        public string GetName()
        {
            return "City Person";
        }
    }
}
