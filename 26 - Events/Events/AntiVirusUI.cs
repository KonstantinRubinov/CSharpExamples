using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class AntiVirusUI
    {
        public void Start()
        {
            VirusFinder vf = new VirusFinder();
            vf.FoundVirus += ShowVirus;
            vf.Scan();
        }

        private void ShowVirus(string fileName)
        {
            Console.WriteLine(fileName);
        }
    }
}
