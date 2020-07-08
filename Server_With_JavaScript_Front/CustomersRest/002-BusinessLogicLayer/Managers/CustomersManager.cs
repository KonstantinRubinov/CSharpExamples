using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CustomersRest
{
	public class CustomersManager: ICustomersRepository
	{
		static private SqlDataReader reader = null;

		public List<Customer> GetAllCustomers()
		{
			List<Customer> arrCustomer = new List<Customer>();
			DataBase.getConnection().Open();
			reader = DataBase.getReader(CustomerStrings.getAllCustomers());

			try
			{
				while (reader.Read())
				{
					arrCustomer.Add(Customer.ToObject(reader));
				}
			}
			finally
			{
				reader.Close();
				DataBase.getConnection().Close();
			}
			return arrCustomer;
		}

		public Customer GetCustomerById(string customerID)
		{
			if (customerID.Equals(""))
				throw new ArgumentOutOfRangeException();
			Customer customer = new Customer();
			DataBase.getConnection().Open();
			reader = DataBase.getReader(CustomerStrings.getCustomerById(customerID));
			try
			{
				while (reader.Read())
				{
					customer = Customer.ToObject(reader);
				}
			}
			finally
			{
				reader.Close();
				DataBase.getConnection().Close();
			}
			return customer;
		}

		public Customer PostCustomer(Customer value)
		{
			int i = -1;
			DataBase.getConnection().Open();
			i = DataBase.ExecutePost(CustomerStrings.PostCustomer(value));
			DataBase.getConnection().Close();
			return GetCustomerById(value.CustomerID);
		}

		public int DeleteCustomer(string id)
		{
			int i = 0;
			DataBase.getConnection().Open();
			i = DataBase.ExecuteUpdate(CustomerStrings.DeleteCustomer(id));
			DataBase.getConnection().Close();
			return i;
		}
	}
}
