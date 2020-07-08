using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CustomersRest
{
	public class OrderDetailsManager: IOrderDetailsRepository
	{
		static private SqlDataReader reader = null;

		public List<OrderDetails> GetOrderDetails(int id)
		{
			if (id<0)
				throw new ArgumentOutOfRangeException();
			List<OrderDetails> arrOrderDetails = new List<OrderDetails>();
			DataBase.getConnection().Open();
			reader = DataBase.getReader(OrderDetailsStrings.getOrderData(id));
			try
			{
				while (reader.Read())
				{
					arrOrderDetails.Add(OrderDetails.ToObject(reader));
				}
			}
			finally
			{
				reader.Close();
				DataBase.getConnection().Close();
			}
			return arrOrderDetails;
		}
	}
}
