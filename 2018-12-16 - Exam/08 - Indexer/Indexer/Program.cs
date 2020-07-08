using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Names
    {
        private List<string> _innerValues = new List<string>();

        public void Add(string name)
        {
            _innerValues.Add(name);
        }

        public void PrintAll()
        {
            foreach (string item in _innerValues)
            {
                Console.WriteLine(item);
            }
        }

        public string this[int index] // Indexer = אופרטור סוגריים מרובעים
        {
            get
            {
                return _innerValues[index];
            }
            set
            {
                _innerValues[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Names myNames = new Names();
            myNames.Add("Moishe");
            myNames.Add("Ugi");
            myNames.Add("Kipi");
            myNames.PrintAll();
            Console.WriteLine("First item: " + myNames[0]);
            myNames[0] = "Moshiko";
            Console.WriteLine("First item: " + myNames[0]);
        }
    }
}
