using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Advertisement : Programs
    {
        private int ADVERTISEMENT_ID; // Advertisement Id
        private string COMPANY_NAME; // Advertisement Company
        private string PRODUCT_NAME; // Advertisement Product

        public Advertisement(int ID, DateTime DATE, string NAME, string PLINK, int NUMBER, int PVIEWERS, int AID, string C_NAME, string P_NAME) // Advertisement Data Constructor
        {
            PROGRAM_ID = ID;
            PROGRAM_DATE = DATE;
            PROGRAM_NAME = NAME;
            LINK = PLINK;
            PART_NUMBER = NUMBER;
            VIEWERS = PVIEWERS;
            ADVERTISEMENT_ID=AID;
            COMPANY_NAME = C_NAME;
            PRODUCT_NAME = P_NAME;
        }


        public int MY_ADVERTISEMENT_ID // Advertisement Id get/set
        {
            set
            {
                ADVERTISEMENT_ID = value;
            }
            get
            {
                return ADVERTISEMENT_ID;
            }
        }


        public string MY_COMPANY_NAME // Advertisement Company get/set
        {
            set
            {
                COMPANY_NAME = value;
            }
            get
            {
                return COMPANY_NAME;
            }
        }


        public string MY_PRODUCT_NAME // Advertisement Product get/set
        {
            set
            {
                PRODUCT_NAME = value;
            }
            get
            {
                return PRODUCT_NAME;
            }
        }
    }
}
