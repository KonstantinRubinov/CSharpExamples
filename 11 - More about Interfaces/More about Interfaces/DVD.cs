using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_about_Interfaces
{
    class DVD : ILab, IQA
    {
        public void Test()
        {
            Console.WriteLine("Lab Testing...");
            Console.WriteLine("QA Testing...");
        }
    }
}
