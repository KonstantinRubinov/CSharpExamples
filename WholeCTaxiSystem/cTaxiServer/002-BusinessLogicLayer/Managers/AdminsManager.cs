using System.Collections.Generic;

namespace cTaxi
{
	public class AdminsManager: IAdminsRepository
	{
		private Drivers driversDB;

		public List<AdminsModel> GetAllUsers()
		{
			return driversDB.GetAllAdmins();
		}

		public AdminsModel GetUserByNameAndPassword(AdminsModel admin)
		{
			return driversDB.GetAdminByNameAndPassword(admin);
		}

		public AdminsModel AddUser(AdminsModel admin)
		{
			driversDB.AddAdmin(admin);
			return GetUserByNameAndPassword(admin);
		}

		public AdminsModel UpdateUser(AdminsModel admin)
		{
			driversDB.UpdateAdmin(admin);
			return GetUserByNameAndPassword(admin);
		}

		public void DeleteUser(string username)
		{
			driversDB.DeleteAdmin(username);
		}
	}
}
