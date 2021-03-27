using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternFactory
{
    public class Villager : IPerson
    {
        public string GetName()
        {
            return "Village Person";
        }
    }
}
