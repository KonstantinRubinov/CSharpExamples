using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Game : Programs
    {
        private int GAME_ID; // Game Id
        private int GAME_NUMBER; // Game Number
        private string GAME_TYPE; // Game Type

        public Game(int ID, DateTime DATE, string NAME, string PLINK, int NUMBER, int PVIEWERS, int G_ID, int G_NUMBER, string G_TYPE) // Game Data Constructor
        {
            PROGRAM_ID = ID;
            PROGRAM_DATE = DATE;
            PROGRAM_NAME = NAME;
            LINK = PLINK;
            PART_NUMBER = NUMBER;
            VIEWERS = PVIEWERS;
            GAME_ID = G_ID;
            GAME_NUMBER = G_NUMBER;
            GAME_TYPE = G_TYPE;
        }


        public int MY_GAME_ID // Game Id get/set
        {
            set
            {
                GAME_ID = value;
            }
            get
            {
                return GAME_ID;
            }
        }


        public int MY_GAME_NUMBER // Game Number get/set
        {
            set
            {
                GAME_NUMBER = value;
            }
            get
            {
                return GAME_NUMBER;
            }
        }

        public string MY_GAME_TYPE // Game Type get/set
        {
            set
            {
                GAME_TYPE = value;
            }
            get
            {
                return GAME_TYPE;
            }
        }
    }
}
