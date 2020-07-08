using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsParallel
{
    class Tester
    {
        private List<int> customers = new List<int>();

        public Tester()
        {
            for (int i = 0; i < 1000; i++)
            {
                customers.Add(i);
            }
        }

        private bool ValidCustomer(int c)
        {
            return true;
        }

        public List<int> GetValidCustomers()
        {
            List<int> validCustomers = (from c in customers.AsParallel() where ValidCustomer(c) select c).ToList();
            return validCustomers;
        }

    }

    class Program
    {
        static string DoSomething() {
            return "s";
        }

        static List<string> DoSomething2()
        {
            List<string> list = new List<string>();
            // ...
            return list;
        }

        static void Main(string[] args)
        {
            Task<string> t1 = new Task<string>(DoSomething);
            Task<List<string>> t2 = new Task<List<string>>(DoSomething2);
        }
    }
}
