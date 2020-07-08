using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Message
    {
        private int MESSAGE_ID; // Message Id
        private int FROM_ID; // Message Sender Id
        private int TO_ID; // Message To Id
        private string MESSAGE_CONTENT; // Message Content

        public Message(int M_ID, int F_ID, int T_ID, string M_CONTENT) // Message Data Constructor
        {
            MESSAGE_ID=M_ID;
            FROM_ID=F_ID;
            TO_ID=T_ID;
            MESSAGE_CONTENT = M_CONTENT;
        }

        public Message(int M_ID) // Message Id Constructor
        {
            MESSAGE_ID = M_ID;
           
        }

        public int MY_MESSAGE_ID // Message Id get/set
        {
            set
            {
                MESSAGE_ID = value;
            }
            get
            {
                return MESSAGE_ID;
            }
        }

        public int MY_FROM_ID // Message Sender Id get/set
        {
            set
            {
                FROM_ID = value;
            }
            get
            {
                return FROM_ID;
            }
        }


        public int MY_TO_ID // Message To Id get/set
        {
            set
            {
                TO_ID = value;
            }
            get
            {
                return TO_ID;
            }
        }


        public string MY_MESSAGE_CONTENT // Message Content get/set
        {
            set
            {
                MESSAGE_CONTENT = value;
            }
            get
            {
                return MESSAGE_CONTENT;
            }
        }
    }
}
