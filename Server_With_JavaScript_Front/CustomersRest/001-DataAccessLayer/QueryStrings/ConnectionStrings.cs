using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersRest
{
	public class ConnectionStrings
	{
		static private string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";

		static public string getConnection()
		{
			return connectionString;
		}
	}
}
