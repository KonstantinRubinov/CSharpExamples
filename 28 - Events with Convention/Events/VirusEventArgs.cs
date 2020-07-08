using System;

namespace Events
{
    class VirusEventArgs : EventArgs
    {
        public readonly string FileName;

        public VirusEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }
}
