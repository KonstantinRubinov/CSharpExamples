using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Analitics : Programs
    {
        private int ANALITICS_ID; // Analitics Id
        private string ANALITICS_NAME; // Analitics Name
        private string ANALITICS_SUBJECT; // Analitics Subject

        public Analitics(int ID, DateTime DATE, string NAME, string PLINK, int NUMBER, int PVIEWERS, int A_ID, string A_NAME, string A_SUBJECT) // Analitics Data Constructor
        {
            PROGRAM_ID = ID;
            PROGRAM_DATE = DATE;
            PROGRAM_NAME = NAME;
            LINK = PLINK;
            PART_NUMBER = NUMBER;
            VIEWERS = PVIEWERS;
            ANALITICS_ID = A_ID;
            ANALITICS_NAME = A_NAME;
            ANALITICS_SUBJECT = A_SUBJECT;
        }

        public int MY_ANALITICS_ID // Analitics Id get/set
        {
            set
            {
                ANALITICS_ID = value;
            }
            get
            {
                return ANALITICS_ID;
            }
        }


        public string MY_ANALITICS_NAME // Analitics name get/set
        {
            set
            {
                ANALITICS_NAME = value;
            }
            get
            {
                return ANALITICS_NAME;
            }
        }


        public string MY_ANALITICS_SUBJECT // Analitics subgect get/set
        {
            set
            {
                ANALITICS_SUBJECT = value;
            }
            get
            {
                return ANALITICS_SUBJECT;
            }
        }
    }
}
