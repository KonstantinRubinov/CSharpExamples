using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomersRest.Filters.Exceptions
{
	public class MakeObjectException:Exception
	{
		public MakeObjectException()
		{
		}

		public MakeObjectException(string message)
			: base(message)
		{
		}

		public MakeObjectException(string message, Exception inner): base(message, inner)
		{
		}
	}
}