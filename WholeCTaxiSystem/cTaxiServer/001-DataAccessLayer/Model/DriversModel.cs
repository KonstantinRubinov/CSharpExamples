using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cTaxi
{
	public class DriversModel
	{
		private string id;
		private string firstName;
		private string lastName;
		private string phoneNumber;
		private DateTime startWorkingDate;
		private DateTime checkWorkingDate;
		private string address;
		private string email;

		
		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		public DateTime StartWorkingDate
		{
			get { return startWorkingDate; }
			set { startWorkingDate = value; }
		}

		public DateTime CheckWorkingDate
		{
			get { return checkWorkingDate; }
			set { checkWorkingDate = value; }
		}

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

	}
}
