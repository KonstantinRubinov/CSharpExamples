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
            VirusFinder vf = new VirusFinder("C:");
            vf.FoundVirus += ShowVirus; // Registering to the event - רישום לארוע
            vf.ComputerCrashed += DisplayCrashMessage; // Registering to the event - רישום לארוע
            vf.ComputerCrashed += SendEmail;
            // vf.ComputerCrashed -= SendEmail;
            vf.Scan();
        }

        private void SendEmail(object sender, EventArgs e)
        {
            Console.WriteLine("Sending email...");
        }

        private void ShowVirus(object sender, VirusEventArgs e)
        {
            Console.WriteLine("Virus: " + e.FileName + 
                ", Drive: " + (sender as VirusFinder).DriveName);
        }

        private void DisplayCrashMessage(object sener, EventArgs e)
        {
            Console.WriteLine("Computer Crashed!"); ;
        }
    }
}
