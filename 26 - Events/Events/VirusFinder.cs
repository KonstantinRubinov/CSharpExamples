using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    delegate void VirusHandler(string fileName);

    class VirusFinder
    {
        public event VirusHandler FoundVirus;

        public void Scan()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);

                // Virus Found:
                string fileName = Guid.NewGuid() + ".exe";

                // העלאת הארוע - Raising the event:
                FoundVirus?.Invoke(fileName);
            }
        }
    }
}
