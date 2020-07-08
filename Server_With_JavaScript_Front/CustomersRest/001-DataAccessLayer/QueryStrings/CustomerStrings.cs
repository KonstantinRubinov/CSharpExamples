using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersRest
{
	public class CustomerStrings
	{
		static private string queryCustomerString = "SELECT * from Customers";
		static private string queryCustomerByIdString = "SELECT * from Customers where CustomerID = '{0}'";
		static private string queryCustomerPost = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', )";
		static private string queryCustomerDelete = "DELETE FROM Customers WHERE [Customers].[CustomerID]= '{0}' ";
		static public string getAllCustomers()
		{
			return queryCustomerString;
		}

		static public string getCustomerById(string id)
		{
			string toReturn = string.Format(queryCustomerByIdString, id);
			return toReturn;
		}


		static public string PostCustomer(Customer customer)
		{
			string toReturn = string.Format(queryCustomerPost, customer.CustomerID, customer.CompanyName, customer.ContactName, customer.ContactTitle, customer.Address, customer.City, customer.Region, customer.PostalCode, customer.Country, customer.Phone, customer.Fax);
			return toReturn;
		}

		static public string DeleteCustomer(string id)
		{
			string toReturn = string.Format(queryCustomerDelete, id);
			return toReturn;
		}
	}
}
