using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CustomersRest
{
	public class Customer
	{
		public string CustomerID { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string ContactTitle { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }

		public static Customer ToObject(SqlDataReader reader)
		{
			Customer customer = new Customer();
			customer.CustomerID = reader[0].ToString();
			customer.CompanyName = reader[1].ToString();
			customer.ContactName = reader[2].ToString();
			customer.ContactTitle = reader[3].ToString();
			customer.Address = reader[4].ToString();
			customer.City = reader[5].ToString();
			customer.Region = reader[6].ToString();
			customer.PostalCode = reader[7].ToString();
			customer.Country = reader[8].ToString();
			customer.Phone = reader[9].ToString();
			customer.Fax = reader[10].ToString();
			return customer;
		}
	}
}