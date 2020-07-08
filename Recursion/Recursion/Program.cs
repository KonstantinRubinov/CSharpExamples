using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr1 = { 1, 3, 5, 7, 11, 13 };
			Console.WriteLine(find(arr1, 0, arr1.Length - 1));

			int[] arr2 = { 1,2,3,2,3,4,3,2 };
			Console.WriteLine(polindrom(arr2, 0, arr2.Length - 1));
		}

		


		static public int find(int[] array, int start, int end)
		{
			int middle = (end+start) / 2;
			if (end-start==1)
			{
				int res= array[middle] + (array[end] - array[start]) / 2;
				return res;
			}
			if (array[end] - array[middle] > array[middle]- array[start])
			{
				return find(array, middle, end);
			} else
			{
				return find(array, start, middle);
			}
		}







		static public int polindrom(int[] array, int start1, int end1)
		{
			int start = start1;
			int end = end1;
			while (array[start]!= array[end] && start<end)
			{
				end--;
			}
			int maxtmp = end - start;
			while ((array[start] == array[end]) && start<end)
			{
				start++;
				end--;
				if (start >= end) return maxtmp;
			}

			return polindrom(array, start1 + 1, end1);
		}
	}
}
