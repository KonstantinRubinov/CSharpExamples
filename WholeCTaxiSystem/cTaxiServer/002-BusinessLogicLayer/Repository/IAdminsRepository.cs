using System.Collections.Generic;

namespace cTaxi
{
	public interface IAdminsRepository
	{
		List<AdminsModel> GetAllUsers();
		AdminsModel GetUserByNameAndPassword(AdminsModel admin);
		AdminsModel AddUser(AdminsModel admin);
		AdminsModel UpdateUser(AdminsModel admin);
		void DeleteUser(string username);
	}
}
