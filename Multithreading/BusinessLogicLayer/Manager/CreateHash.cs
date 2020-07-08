using System.Diagnostics;
using System.Threading;

namespace Multithreading
{
	public class CreateHash
	{
		public string CreateStr(int num)
		{
			Thread.Sleep(10000);
			Debug.WriteLine("The number is: " + num);
			return num + "";
		}

		
	}
}
