using System.Collections.Generic;

namespace CustomersRest
{
	public interface IOrdersRepository
	{
		List<Order> GetOrdersByCustomer(string id);
	}
}
