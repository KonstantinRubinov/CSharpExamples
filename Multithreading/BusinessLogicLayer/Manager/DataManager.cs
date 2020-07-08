using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Multithreading
{
	public class DataManager
	{
		private static string[] summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		//public async Task<Tuple<int, bool>> Intos(int num)
		//{
		//	summaries[num] = new CreateHash().CreateStr(num);
		//	return Tuple.Create(num, true);
		//}

		//public async Task<string[]> GetStrings()
		//{
		//	var tasks = new List<Task<Tuple<int, bool>>>();
		//	for (int i = 0; i < summaries.Length; i++)
		//	{
		//		Console.WriteLine("Starting Process {0}", i);
		//		tasks.Add(Intos(i));
		//	}
		//	foreach (var task in await Task.WhenAll(tasks))
		//	{
		//		if (task.Item2)
		//		{
		//			Debug.WriteLine("Ending Process {0}", task.Item1);
		//		}
		//	}
		//	return summaries;
		//}


		public string[] GetStrings()
		{
			List<Task> TaskList = new List<Task>();
			Task t1;
			for (int i = 0; i < summaries.Length; i++)
			{
				t1 = new Task(Intos, i);
				t1.Start();
				TaskList.Add(t1);
			}

			Task.WaitAll(TaskList.ToArray());

			return summaries;

		}

		public void Intos(object num)
		{
			Debug.WriteLine((int)num);
			summaries[(int)num] = new CreateHash().CreateStr((int)num);
		}
	}
}
