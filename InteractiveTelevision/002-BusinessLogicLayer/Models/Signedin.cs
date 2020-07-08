using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Signedin : User
    {
        protected int SIGNEDIN_ID; // Signedin Id
        protected int SIGNEDIN_PERMISSION; // Signedin Permission
        protected string NAME; // Signedin Name
        protected string PASSWORD; // Signedin Password
        protected string FIRST_NAME; // Signedin First Name
        protected string LAST_NAME; // Signedin Family Name
        protected string COUNTRY; // Signedin Country
        protected DateTime BIRTHDATE; // Signedin BirthDate
        protected string EMAIL; // Signedin Email

        public Signedin() // Signedin Constructor
        {
        }

        public Signedin(int S_ID) // Signedin Id Constructor
        {
            SIGNEDIN_ID = S_ID;
        }

        public Signedin(int S_ID, string S_NAME, string S_PASS) // Signedin Id, Name, Password Constructor
        {
            SIGNEDIN_ID = S_ID;
            NAME = S_NAME;
            PASSWORD = S_PASS;
        }

        public Signedin(int S_ID, string S_NAME) // Signedin Id, Name Constructor
        {
            SIGNEDIN_ID = S_ID;
            NAME = S_NAME;
        }

        public Signedin(int S_ID, int S_PERMISSION, string S_NAME, string S_PASSWORD, string F_NAME, string L_NAME, string S_COUNTRY, DateTime S_BIRTHDATE, string S_EMAIL) // Signedin Data Constructor
        {
            SIGNEDIN_ID = S_ID;
            SIGNEDIN_PERMISSION = S_PERMISSION;
            NAME = S_NAME;
            PASSWORD = S_PASSWORD;
            FIRST_NAME = F_NAME;
            LAST_NAME = L_NAME;
            COUNTRY = S_COUNTRY;
            BIRTHDATE = S_BIRTHDATE;
            EMAIL = S_EMAIL;
        }

        public int MY_SIGNEDIN_ID // Signedin Id get/set
        {
            set
            {
                SIGNEDIN_ID = value;
            }
            get
            {
                return SIGNEDIN_ID;
            }
        }

        public int MY_SIGNEDIN_PERMISSION // Signedin Permission get/set
        {
            set
            {
                SIGNEDIN_PERMISSION = value;
            }
            get
            {
                return SIGNEDIN_PERMISSION;
            }
        }

        public string MY_NAME // Signedin Name get/set
        {
            set
            {
                NAME = value;
            }
            get
            {
                return NAME;
            }
        }

        public string MY_PASSWORD // Signedin Password get/set
        {
            set
            {
                PASSWORD = value;
            }
            get
            {
                return PASSWORD;
            }
        }

        public string MY_FIRST_NAME // Signedin First Name get/set
        {
            set
            {
                FIRST_NAME = value;
            }
            get
            {
                return FIRST_NAME;
            }
        }

        public string MY_LAST_NAME // Signedin Family Name get/set
        {
            set
            {
                LAST_NAME = value;
            }
            get
            {
                return LAST_NAME;
            }
        }

        public string MY_COUNTRY // Signedin Country get/set
        {
            set
            {
                COUNTRY = value;
            }
            get
            {
                return COUNTRY;
            }
        }

        public DateTime MY_BIRTHDATE // Signedin BirthDate get/set
        {
            set
            {
                BIRTHDATE = value;
            }
            get
            {
                return BIRTHDATE;
            }
        }

        public string MY_EMAIL // Signedin Email get/set
        {
            set
            {
                EMAIL = value;
            }
            get
            {
                return EMAIL;
            }
        }
    }
}
