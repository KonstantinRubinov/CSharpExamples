using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    delegate void VirusHandler(object sender, VirusEventArgs e);
    delegate void ComputerCrahsedHandler(object sender, EventArgs e);

    class VirusFinder
    {
        public string DriveName;
        public event VirusHandler FoundVirus;
        public event ComputerCrahsedHandler ComputerCrashed;

        public VirusFinder(string driveName)
        {
            DriveName = driveName;
        }

        public void Scan()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);

                // Virus Found:
                string fileName = Guid.NewGuid() + ".exe";

                // העלאת הארוע - Raising the event:
                FoundVirus?.Invoke(this, new VirusEventArgs(fileName));

                if(i == 5)
                {
                    ComputerCrashed?.Invoke(this, EventArgs.Empty);
                    break;
                }
            }
        }
    }
}
