using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersRest
{
	public class OrderDetailsStrings
	{
		static private string queryOrderDataString = "SELECT * from [Order Details] where [OrderID] = {0}";

		static public string getOrderData(int id)
		{
			string toReturn = string.Format(queryOrderDataString, id);
			return toReturn;
		}
	}
}
