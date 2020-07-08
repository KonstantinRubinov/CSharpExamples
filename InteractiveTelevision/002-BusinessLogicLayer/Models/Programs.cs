using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Programs
    {
        protected int PROGRAM_ID; // Programs Id
        protected DateTime PROGRAM_DATE; // Programs Date
        protected string PROGRAM_NAME; // Programs Name
        protected string LINK; // Programs Link
        protected int PART_NUMBER; // Programs Part Number
        protected int VIEWERS; // Programs Viewers number

        public Programs() // Programs Constructor
        {
        }

        public Programs(int ID, DateTime DATE, string NAME, string PLINK, int NUMBER, int PVIEWERS) // Programs Data Constructor
        {
            PROGRAM_ID = ID;
            PROGRAM_DATE = DATE;
            PROGRAM_NAME = NAME;
            LINK = PLINK;
            PART_NUMBER = NUMBER;
            VIEWERS = PVIEWERS;
        }

        public int MY_PROGRAM_ID // Programs Id get/set
        {
            set
            {
                PROGRAM_ID = value;
            }
            get
            {
                return PROGRAM_ID;
            }
        }

        public DateTime MY_PROGRAM_DATE // Programs Date get/set
        {
            set
            {
                PROGRAM_DATE = value;
            }
            get
            {
                return PROGRAM_DATE;
            }
        }

        public string MY_PROGRAM_NAME // Programs Name get/set
        {
            set
            {
                PROGRAM_NAME = value;
            }
            get
            {
                return PROGRAM_NAME;
            }
        }

        public string MY_LINK // Programs Link get/set
        {
            set
            {
                LINK = value;
            }
            get
            {
                return LINK;
            }
        }

        public int MY_PART_NUMBER // Programs Part Number get/set
        {
            set
            {
                PART_NUMBER = value;
            }
            get
            {
                return PART_NUMBER;
            }
        }

        public int MY_VIEWERS // Programs Viewers get/set
        {
            set
            {
                VIEWERS = value;
            }
            get
            {
                return VIEWERS;
            }
        }
    }
}
