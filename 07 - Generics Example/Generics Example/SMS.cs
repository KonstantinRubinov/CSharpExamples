using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example
{
    // Generics can be done on: 
    // class, struct, interface, delegate, function


    class SMS<T> // Open Type
    {
        public string Phone { get; set; }
        public T Message { get; set; }

        public SMS(string phone, T message)
        {
            Phone = phone;
            Message = message;
        }

        public void Send()
        {
            Console.WriteLine("Sending '{0}' to {1}", Message, Phone);
        }
    }
}
