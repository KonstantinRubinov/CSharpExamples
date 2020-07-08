using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
    public class News
    {
        private int NEWS_ID; // News Id
        private string NEWS_CONTENT; // News Content

        public News(int N_ID, string N_CONTENT) // News Data Constructor
        {
            NEWS_ID = N_ID;
            NEWS_CONTENT = N_CONTENT;
        }

        public int MY_NEWS_ID // News Id get/set
        {
            set
            {
                NEWS_ID = value;
            }
            get
            {
                return NEWS_ID;
            }
        }

        public string MY_NEWS_CONTENT // News Constent get/set
        {
            set
            {
                NEWS_CONTENT = value;
            }
            get
            {
                return NEWS_CONTENT;
            }
        }
    }
}
