using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWebApi
{
	public class EvenValidator : ValidationAttribute
	{
		public EvenValidator() : base("my custom error message")
		{
		}
		public EvenValidator(string msg) : base(msg)
		{
		}

		public override bool IsValid(object value)
		{
			int number = (int)(double)value;
			return number % 2 == 0;
		}
	}
}
