using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Names
    {
        public List<string> items = new List<string>();

        public void AddName(string name)
        {
            items.Add(name);
        }

        // Indexer: 
        public string this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
    }
}
