using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class Movie : Programs
    {
        private int MOVIE_ID; // Movie Id
        private string MOVIE_GENRE; // Movie Genre

        public Movie(int ID, DateTime DATE, string NAME, string PLINK, int NUMBER, int PVIEWERS, int M_ID, string M_GENRE) // Movie Data Constructor
        {
            PROGRAM_ID = ID;
            PROGRAM_DATE = DATE;
            PROGRAM_NAME = NAME;
            LINK = PLINK;
            PART_NUMBER = NUMBER;
            VIEWERS = PVIEWERS;
            MOVIE_ID = M_ID;
            MOVIE_GENRE = M_GENRE;
        }


        public int MY_MOVIE_ID // Movie Id get/set
        {
            set
            {
                MOVIE_ID = value;
            }
            get
            {
                return MOVIE_ID;
            }
        }

        public string MY_MOVIE_GENRE // Movie Genre get/set
        {
            set
            {
                MOVIE_GENRE = value;
            }
            get
            {
                return MOVIE_GENRE;
            }
        }
    }
}
