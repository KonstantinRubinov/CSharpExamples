using System.Collections.Generic;

namespace CustomersRest
{
	public interface ICustomersRepository
	{
		List<Customer> GetAllCustomers();
		Customer GetCustomerById(string customerID);
		Customer PostCustomer(Customer value);
		int DeleteCustomer(string id);
	}
}
