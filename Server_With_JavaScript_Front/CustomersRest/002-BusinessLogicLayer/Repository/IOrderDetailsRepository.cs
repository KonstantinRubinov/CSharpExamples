using System.Collections.Generic;

namespace CustomersRest
{
	public interface IOrderDetailsRepository
	{
		List<OrderDetails> GetOrderDetails(int id);
	}
}
