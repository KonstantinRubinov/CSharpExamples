using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Talkshow : Programs
    {
        private int TALKSHOW_ID; // Talkshow Id
        private string TALKSHOW_SUBJECT; // Talkshow Subject

        public Talkshow(int ID, DateTime DATE, string NAME, string PLINK, int NUMBER, int PVIEWERS, int T_ID, string T_SUBJECT) // Talkshow Data Constructor
        {
            PROGRAM_ID = ID;
            PROGRAM_DATE = DATE;
            PROGRAM_NAME = NAME;
            LINK = PLINK;
            PART_NUMBER = NUMBER;
            VIEWERS = PVIEWERS;
            TALKSHOW_ID = T_ID;
            TALKSHOW_SUBJECT = T_SUBJECT;
        }

        public int MY_TALKSHOW_ID // Talkshow Id get/set
        {
            set
            {
                TALKSHOW_ID = value;
            }
            get
            {
                return TALKSHOW_ID;
            }
        }

        public string MY_TALKSHOW_SUBJECT // Talkshow Subject get/set
        {
            set
            {
                TALKSHOW_SUBJECT = value;
            }
            get
            {
                return TALKSHOW_SUBJECT;
            }
        }
    }
}
