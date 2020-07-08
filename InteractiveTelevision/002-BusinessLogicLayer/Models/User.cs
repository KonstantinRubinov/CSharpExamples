using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class User
    {
        protected int USER_ID; // User Id
        protected int USER_PERMISSION; // User Permission

        public User() // User Constructor
        {
        }

        public User(int ID, int U_PERMISSION) // User Data Constructor
        {
            USER_ID = ID;
            USER_PERMISSION = U_PERMISSION;
        }

        public int MY_USER_ID // User Id get/set
        {
            set
            {
                USER_ID = value;
            }
            get
            {
                return USER_ID;
            }
        }

        public int MY_USER_PERMISSION // User Permission get/set
        {
            set
            {
                USER_PERMISSION = value;
            }
            get
            {
                return USER_PERMISSION;
            }
        }
    }
}
