using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_about_Interfaces
{
    class TV : ILab, IQA
    {
        public void Test()
        {
            Console.WriteLine("QA Testing...");
        }

        void ILab.Test()
        {
            Console.WriteLine("Lab Testing...");
        }
    }
}
