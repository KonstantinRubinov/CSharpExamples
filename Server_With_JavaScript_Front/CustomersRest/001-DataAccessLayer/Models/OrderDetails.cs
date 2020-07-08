using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CustomersRest
{
	public class OrderDetails
	{
		public int OrderID { get; set; }
		public int ProductID { get; set; }
		public float UnitPrice { get; set; }
		public int Quantity { get; set; }
		public int Discount { get; set; }

		public static OrderDetails ToObject(SqlDataReader reader)
		{
			OrderDetails orderDetails = new OrderDetails();
			orderDetails.OrderID = int.Parse(reader[0].ToString());
			orderDetails.ProductID = int.Parse(reader[1].ToString());
			orderDetails.UnitPrice = float.Parse(reader[2].ToString());
			orderDetails.Quantity = int.Parse(reader[3].ToString());
			orderDetails.Discount = int.Parse(reader[4].ToString());
			return orderDetails;
		}
	}
}