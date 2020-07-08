using System.Collections.Generic;
using System.Data.SqlClient;

namespace CustomersRest
{
	public class OrdersManager: IOrdersRepository
	{
		static private SqlDataReader reader = null;

		public List<Order> GetOrdersByCustomer(string id)
		{
			List<Order> arrOrder = new List<Order>();
			DataBase.getConnection().Open();
			reader = DataBase.getReader(OrderStrings.getOrders(id));
			
			try{
				while (reader.Read())
				{
					arrOrder.Add(Order.ToObject(reader));
				}
			}
			finally
			{
				reader.Close();
				DataBase.getConnection().Close();
			}
			
			
			return arrOrder;
		}
	}
}
