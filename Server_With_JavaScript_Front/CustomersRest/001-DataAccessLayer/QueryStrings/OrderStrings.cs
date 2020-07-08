using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersRest
{
	public class OrderStrings
	{
		static private string queryOrdersString = "SELECT * from Orders where CustomerID = '{0}'";

		static public string getOrders(string id)
		{
			string toReturn = string.Format(queryOrdersString, id);
			return toReturn;
		}
	}
}
