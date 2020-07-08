using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Videoclip : Programs
    {
        private int VIDEOCLIP_ID; // Videoclip Id
        private string PERFORMER; // Videoclip Performer
        private string MUSIC_TYPE; // Videoclip Music Type

        public Videoclip(int ID, DateTime DATE, string NAME, string PLINK, int NUMBER, int PVIEWERS, int V_ID, string V_PERFORMER, string M_TYPE) // Videoclip Data Constructor
        {
            PROGRAM_ID = ID;
            PROGRAM_DATE = DATE;
            PROGRAM_NAME = NAME;
            LINK = PLINK;
            PART_NUMBER = NUMBER;
            VIEWERS = PVIEWERS;
            VIDEOCLIP_ID = V_ID;
            PERFORMER = V_PERFORMER;
            MUSIC_TYPE = M_TYPE;
        }

        public int MY_VIDEOCLIP_ID // Videoclip Id get/set
        {
            set
            {
                VIDEOCLIP_ID = value;
            }
            get
            {
                return VIDEOCLIP_ID;
            }
        }

        public string MY_PERFORMER // Videoclip Performer get/set
        {
            set
            {
                PERFORMER = value;
            }
            get
            {
                return PERFORMER;
            }
        }

        public string MY_MUSIC_TYPE // Videoclip Music Type get/set
        {
            set
            {
                MUSIC_TYPE = value;
            }
            get
            {
                return MUSIC_TYPE;
            }
        }
    }
}
