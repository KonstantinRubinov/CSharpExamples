using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Sport : Programs
    {
        private int SPORT_ID; // Sport Id
        private int SPORT_NUMBER; // Sport Number
        private string SPORT_TYPE; // Sport Type

        public Sport(int ID, DateTime DATE, string NAME, string PLINK, int NUMBER, int PVIEWERS, int S_ID, int S_NUMBER, string S_TYPE) // Sport Data Constructor
        {
            PROGRAM_ID = ID;
            PROGRAM_DATE = DATE;
            PROGRAM_NAME = NAME;
            LINK = PLINK;
            PART_NUMBER = NUMBER;
            VIEWERS = PVIEWERS;
            SPORT_ID = S_ID;
            SPORT_NUMBER = S_NUMBER;
            SPORT_TYPE = S_TYPE;
        }

        public int MY_SPORT_ID // Sport Id get/set
        {
            set
            {
                SPORT_ID = value;
            }
            get
            {
                return SPORT_ID;
            }
        }

        public int MY_SPORT_NUMBER // Sport Number get/set
        {
            set
            {
                SPORT_NUMBER = value;
            }
            get
            {
                return SPORT_NUMBER;
            }
        }

        public string MY_SPORT_TYPE // Sport Type get/set
        {
            set
            {
                SPORT_TYPE = value;
            }
            get
            {
                return SPORT_TYPE;
            }
        }
    }
}
