using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
	public class UserModel
	{
		private int id;
		private string userName;
		private string userPassword;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}
		
		public string UserPassword
		{
			get { return userPassword; }
			set { userPassword = value; }
		}

	}
}
