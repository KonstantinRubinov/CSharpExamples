using System;
using System.Linq;
using System.Text;

namespace SwapString
{
	class Program
	{
		static void Main(string[] args)
		{
            StringSwap("coffee", "eecoff");

            Console.WriteLine("Hello World!");
		}

        public static int StringSwap(string stringToSwap, string swappedString)
        {
            if (stringToSwap == null)
            {
                throw new ArgumentNullException("stringToSwap");
            }

            if (swappedString == null)
            {
                throw new ArgumentNullException("swappedString");
            }

            if (stringToSwap.Length != swappedString.Length)
            {
                return -1;
            }

            if (!stringToSwap.Equals(swappedString) && stringToSwap.Length==1)
            {
                return -1;
            }

            if (stringToSwap.Equals(swappedString))
            {
                return 0;
            }

            StringBuilder swap = new StringBuilder();
            swap.Append(stringToSwap);

            for(int i = 0; i < stringToSwap.Length; i++)
			{
                char charToMove = swap.ToString().ElementAt(0);
                swap.Remove(0, 1);
                swap.Append(charToMove);
				if (swap.ToString().Equals(swappedString))
				{
                    return i+1;
				}
            }
            return -1;
        }
    }
}
