using System;

namespace More_about_Interfaces
{
    class Radio : ILab, IQA
    {
        void ILab.Test()
        {
            Console.WriteLine("Lab Testing...");
        }

        void IQA.Test()
        {
            Console.WriteLine("QA Testing...");
        }
    }
}
