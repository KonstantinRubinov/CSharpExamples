using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Lection : Programs
    {
        private int LECTION_ID; // Lection Id
        private int LECTION_NUMBER; // Lection Number
        private string LECTION_SUBJECT; // Lection Subject

        public Lection(int ID, DateTime DATE, string NAME, string PLINK, int NUMBER, int PVIEWERS, int L_ID, int L_NUMBER, string L_SUBJECT) // Lection Data Constructor
        {
            PROGRAM_ID = ID;
            PROGRAM_DATE = DATE;
            PROGRAM_NAME = NAME;
            LINK = PLINK;
            PART_NUMBER = NUMBER;
            VIEWERS = PVIEWERS;
            LECTION_ID = L_ID;
            LECTION_NUMBER = L_NUMBER;
            LECTION_SUBJECT = L_SUBJECT;
        }

        public int MY_LECTION_ID // Lection Id get/set
        {
            set
            {
                LECTION_ID = value;
            }
            get
            {
                return LECTION_ID;
            }
        }

        public int MY_LECTION_NUMBER // Lection Number get/set
        {
            set
            {
                LECTION_NUMBER = value;
            }
            get
            {
                return LECTION_NUMBER;
            }
        }

        public string MY_LECTION_SUBJECT // Lection Subject get/set
        {
            set
            {
                LECTION_SUBJECT = value;
            }
            get
            {
                return LECTION_SUBJECT;
            }
        }
    }
}
