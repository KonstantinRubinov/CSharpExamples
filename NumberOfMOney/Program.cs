using System;

namespace NumberOfMOney
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] returnedMoney = MoneyFromNumber(30);
			Console.WriteLine("[{0}]", string.Join(", ", returnedMoney));
		}

		private static int[] MoneyFromNumber(int number)
		{
			int[] numToReturn = new int[3];

			if (number == 0)
			{
				return numToReturn;
			}
			int hungreds = number / 100;
			int fifties = number % 100 / 50;
			int twenties = number % 50 / 20;
			int left = number % 50 % 20;

			if (left > 0)
			{
				return numToReturn;
			} else {
				numToReturn[0] = hungreds;
				numToReturn[1] = fifties;
				numToReturn[2] = twenties;
				return numToReturn;
			}

		}
	}
}
