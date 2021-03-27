using System;
using System.Linq;

namespace NumberOfStepsToOrderArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 3,2,1 };

            Console.WriteLine(GetOrderSteps(array));
		}

        public static int GetOrderSteps(int[] unsortedArray)
        {
            int[] sorterArray = unsortedArray.OrderBy(number => number).ToArray();
            int tempNumber;
            int numberOfSwaps = 0;

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                if (sorterArray[i] != unsortedArray[i])
                {
                    tempNumber = unsortedArray[i];
                    unsortedArray[i] = sorterArray[i];
                    for (int j = i + 1; j < unsortedArray.Length; j++)
                    {
                        if (unsortedArray[j] == sorterArray[i])
                        {
                            unsortedArray[j] = tempNumber;
                            numberOfSwaps++;
                            break;
                        }
                    }
                }
            }

            return numberOfSwaps;
        }
    }
}
