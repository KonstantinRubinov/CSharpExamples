using System;
using System.Collections.Generic;
using System.Text;

namespace SheckelGroup
{
	public interface IUsersRepository
	{
		public UserModel AddUser(UserModel userModel);
	}
}
