﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomersRest
{
	public class Errors
	{
		private List<string> errors { get; set; } = new List<string>();

		public void Add(string errorMessage)
		{
			errors.Add(errorMessage);
		}
	}
}