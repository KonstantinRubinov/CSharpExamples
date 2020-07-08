using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CustomersRest
{
	public class Order
	{
		public int OrderID { get; set; }
		public string CustomerID { get; set; }
		public int EmployeeID { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime RequiredDate { get; set; }
		public DateTime ShippedDate { get; set; }
		public int ShipVia { get; set; }
		public float Freight { get; set; }

		public string ShipName { get; set; }
		public string ShipAddress { get; set; }
		public string ShipCity { get; set; }

		public string ShipRegion { get; set; }
		public string ShipPostalCode { get; set; }
		public string ShipCountry { get; set; }


		public static Order ToObject(SqlDataReader reader)
		{
			Order order = new Order();
			order.OrderID = int.Parse(reader[0].ToString());
			order.CustomerID = reader[1].ToString();
			order.EmployeeID = int.Parse(reader[2].ToString());
			order.OrderDate = DateTime.Parse(reader[3].ToString());
			order.RequiredDate = DateTime.Parse(reader[4].ToString());
			order.ShippedDate = DateTime.Parse(reader[5].ToString());
			order.ShipVia = int.Parse(reader[6].ToString());
			order.Freight = float.Parse(reader[7].ToString());
			order.ShipName = reader[8].ToString();
			order.ShipAddress = reader[9].ToString();
			order.ShipCity = reader[10].ToString();
			order.ShipRegion = reader[11].ToString();
			order.ShipPostalCode = reader[12].ToString();
			order.ShipCountry = reader[13].ToString();
			return order;
		}
	}
}