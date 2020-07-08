using System;

namespace Triangle
{
	class Program
	{
		public static void createTriangle(int number){
			int[] useArr = new int[number * 2 - 1];
			int[] tmpArr = new int[useArr.Length];

			for (int j = 0; j < number; j++)
			{
				for (int i = 0; i < useArr.Length; i++)
				{
					if (j == 0)
					{
						useArr[useArr.Length / 2] = 1;
					}
					else
					{
						int left = 0;
						int right = 0;
						if (i > 0)
						{
							left = tmpArr[i - 1];
						}
						if (i < tmpArr.Length - 1)
						{
							right = tmpArr[i + 1];
						}
						useArr[i] = left + right;
					}
				}
				writeArray(useArr);
				
				Array.Copy(useArr, tmpArr, useArr.Length);
				useArr = new int[number * 2 - 1];
			}
		}


		public static void writeArray(int[] arrToWrite) 
		{
			for (int i = 0; i < arrToWrite.Length; i++) {
				if (arrToWrite[i]==0)
				{
					Console.Write("__");
				} else if ((arrToWrite[i] > 0) && (arrToWrite[i] < 10))
				{
					Console.Write("0" + arrToWrite[i]);
				}
				else
				{
					Console.Write(arrToWrite[i]);
				}

				if (i < arrToWrite.Length-1)
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}


		static void Main(string[] args)
		{
			createTriangle(9);
		}
	}
}
