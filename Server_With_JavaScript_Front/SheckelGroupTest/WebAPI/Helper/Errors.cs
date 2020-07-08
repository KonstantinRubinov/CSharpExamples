using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SheckelGroup
{
	class Errors
	{
		private List<string> errors { get; set; } = new List<string>();

		public void Add(string errorMessage)
		{
			errors.Add(errorMessage);
			Debug.WriteLine("errors: " + errorMessage);
		}
	}
}
