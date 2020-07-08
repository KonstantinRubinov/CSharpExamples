using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Admin : Signedin
    {
        private int ADMIN_ID; // Admin Id


        public Admin(int A_ID) // Admin Id Constructor
        {
            ADMIN_ID = A_ID;
        }

        public Admin(int S_ID, int S_PERMISSION, string S_NAME, string S_PASSWORD, string F_NAME, string L_NAME, string S_COUNTRY, DateTime S_BIRTHDATE, string S_EMAIL, int A_ID) // Admin Data Constructor
        {
            ADMIN_ID = A_ID;
        }

        public int MY_ADMIN_ID // Admin get/set
        {
            set
            {
                ADMIN_ID = value;
            }
            get
            {
                return ADMIN_ID;
            }
        }
    }
}
