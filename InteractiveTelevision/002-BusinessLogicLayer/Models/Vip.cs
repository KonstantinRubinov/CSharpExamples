using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Vip : Signedin
    {
        private int VIP_ID; // Vip Id
        private DateTime VIP_VALIDITY; // Vip Validity

        public Vip() // Vip Constructor
        {
        }

        public Vip(int V_ID, DateTime V_VALIDITY) // Vip Id, Validity Constructor
        {
            VIP_ID = V_ID;
            VIP_VALIDITY = V_VALIDITY;
        }

        public Vip(int S_ID, int S_PERMISSION, string S_NAME, string S_PASSWORD, string F_NAME, string L_NAME, string S_COUNTRY, DateTime S_BIRTHDATE, string S_EMAIL, int V_ID, DateTime V_VALIDITY) // Vip Data Constructor
        {
            VIP_ID = V_ID;
            VIP_VALIDITY = V_VALIDITY;
        }

        public int MY_VIP_ID // Vip Id get/set
        {
            set
            {
                VIP_ID = value;
            }
            get
            {
                return VIP_ID;
            }
        }

        public DateTime MY_VIP_VALIDITY // Vip Validity get/set
        {
            set
            {
                VIP_VALIDITY = value;
            }
            get
            {
                return VIP_VALIDITY;
            }
        }
    }
}
