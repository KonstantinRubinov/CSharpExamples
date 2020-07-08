using System;
using System.IO;

namespace Disposable_Example
{
    class Logger : IDisposable
    {
        private StreamWriter writer = new StreamWriter("Logger.txt"); // Resource.

        public void Write(string msg)
        {
            writer.WriteLine(DateTime.Now + ": " + msg);
        }

        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Disposinig...");
            Console.ResetColor();
            writer.Dispose();
        }
    }
}
