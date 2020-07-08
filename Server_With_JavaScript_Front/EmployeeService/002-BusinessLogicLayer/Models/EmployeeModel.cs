using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
	public class EmployeeModel
	{
		private int id;
		private string firstName;
		private string lastName;
		private string gender;
		private int? salary;

		public int ID
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

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		public int? Salary
		{
			get { return salary; }
			set { salary = value; }
		}
	}
}
