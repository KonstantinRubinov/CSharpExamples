using System;
using System.Collections.Generic;
using System.Data;

namespace cTaxi
{
	public sealed class Drivers
	{
		private static readonly Drivers instance = new Drivers();

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static Drivers()
		{
		}

		private Drivers()
		{
		}

		public static Drivers Instance
		{
			get
			{
				return instance;
			}
		}

		private DataSet driversSet;
		private DataTable drivers;
		private DataTable admins;

		private void createDataBase()
		{
			MakeDriversTable();
			MakeAdminTable();
			MakeDataSet();
		}

		private void MakeDataSet()
		{
			driversSet = new DataSet("driversSet");
			driversSet.Tables.Add(drivers);
			driversSet.Tables.Add(admins);
		}

		private void MakeDriversTable()
		{
			drivers = new DataTable("drivers");

			DataColumn id = new DataColumn("id");
			id.DataType = Type.GetType("System.String");
			drivers.Columns.Add(id);

			DataColumn firstName = new DataColumn("firstName");
			firstName.DataType = Type.GetType("System.String");
			drivers.Columns.Add(firstName);

			DataColumn lastName = new DataColumn("lastName");
			lastName.DataType = Type.GetType("System.String");
			drivers.Columns.Add(lastName);


			DataColumn phoneNumber = new DataColumn("phoneNumber");
			phoneNumber.DataType = Type.GetType("System.String");
			drivers.Columns.Add(phoneNumber);

			DataColumn startWorkingDate = new DataColumn("startWorkingDate");
			startWorkingDate.DataType = Type.GetType("System.DateTime");
			drivers.Columns.Add(startWorkingDate);

			DataColumn checkWorkingDate = new DataColumn("checkWorkingDate");
			checkWorkingDate.DataType = Type.GetType("System.DateTime");
			drivers.Columns.Add(checkWorkingDate);

			DataColumn address = new DataColumn("address");
			address.DataType = Type.GetType("System.String");
			drivers.Columns.Add(address);

			DataColumn email = new DataColumn("email");
			email.DataType = Type.GetType("System.String");
			drivers.Columns.Add(email);

			DataColumn[] keys = new DataColumn[1];
			keys[0] = id;
			drivers.PrimaryKey = keys;
		}

		private void MakeAdminTable()
		{
			admins = new DataTable("admin");

			DataColumn username = new DataColumn("username");
			username.DataType = Type.GetType("System.String");
			admins.Columns.Add(username);

			DataColumn password = new DataColumn("password");
			password.DataType = Type.GetType("System.String");
			admins.Columns.Add(password);
		}

		public List<DriversModel> GetAllDrivers()
		{
			List<DriversModel> driversList = new List<DriversModel>();

			DriversModel driver;

			for (int i = 0; i < driversSet.Tables["drivers"].Rows.Count; i++)
			{
				driver = new DriversModel();
				driver.Id = driversSet.Tables["drivers"].Rows[i]["id"].ToString();
				driver.FirstName = driversSet.Tables["drivers"].Rows[i]["firstName"].ToString();
				driver.LastName = driversSet.Tables["drivers"].Rows[i]["lastName"].ToString();
				driver.PhoneNumber = driversSet.Tables["drivers"].Rows[i]["phoneNumber"].ToString();
				driver.StartWorkingDate = DateTime.Parse(driversSet.Tables["drivers"].Rows[i]["startWorkingDate"].ToString());
				driver.CheckWorkingDate = DateTime.Parse(driversSet.Tables["drivers"].Rows[i]["checkWorkingDate"].ToString());
				driver.Address = driversSet.Tables["drivers"].Rows[i]["address"].ToString();
				driver.Email = driversSet.Tables["drivers"].Rows[i]["email"].ToString();

				driversList.Add(driver);
			}
			return driversList;
		}

		public DriversModel GetDriverById(string id)
		{
			DriversModel driver = null;

			for (int i = 0; i < driversSet.Tables["drivers"].Rows.Count; i++)
			{
				if (driversSet.Tables["drivers"].Rows[i]["id"].ToString().Equals(id))
				{
					driver = new DriversModel();
					driver.Id = driversSet.Tables["drivers"].Rows[i]["id"].ToString();
					driver.FirstName = driversSet.Tables["drivers"].Rows[i]["firstName"].ToString();
					driver.LastName = driversSet.Tables["drivers"].Rows[i]["lastName"].ToString();
					driver.PhoneNumber = driversSet.Tables["drivers"].Rows[i]["phoneNumber"].ToString();
					driver.StartWorkingDate = DateTime.Parse(driversSet.Tables["drivers"].Rows[i]["startWorkingDate"].ToString());
					driver.CheckWorkingDate = DateTime.Parse(driversSet.Tables["drivers"].Rows[i]["checkWorkingDate"].ToString());
					driver.Address = driversSet.Tables["drivers"].Rows[i]["address"].ToString();
					driver.Email = driversSet.Tables["drivers"].Rows[i]["email"].ToString();
				}
			}
			return driver;
		}

		public void AddDriver(DriversModel newDriver)
		{
			DataRow myNewRow = drivers.NewRow();
			myNewRow["id"] = newDriver.Id;
			myNewRow["firstName"] = newDriver.FirstName;
			myNewRow["lastName"] = newDriver.LastName;
			myNewRow["phoneNumber"] = newDriver.PhoneNumber;
			myNewRow["startWorkingDate"] = newDriver.StartWorkingDate;
			myNewRow["checkWorkingDate"] = newDriver.CheckWorkingDate;
			myNewRow["address"] = newDriver.Address;
			myNewRow["email"] = newDriver.Email;
			drivers.Rows.Add(myNewRow);
		}

		public void UpdateDriver(DriversModel newDriver)
		{
			DataRow[] rows = drivers.Select($"id={newDriver.Id}");
			DataRow row = rows[0];
			row["id"] = newDriver.Id;
			row["firstName"] = newDriver.FirstName;
			row["lastName"] = newDriver.LastName;
			row["phoneNumber"] = newDriver.PhoneNumber;
			row["startWorkingDate"] = newDriver.StartWorkingDate;
			row["checkWorkingDate"] = newDriver.CheckWorkingDate;
			row["address"] = newDriver.Address;
			row["email"] = newDriver.Email;
		}

		public void DeleteDriver(string id)
		{
			for (int i = drivers.Rows.Count - 1; i >= 0; i--)
			{
				DataRow dr = drivers.Rows[i];
				if (dr["id"].Equals(id))
					dr.Delete();
			}
			drivers.AcceptChanges();
		}

		public List<AdminsModel> GetAllAdmins()
		{
			List<AdminsModel> adminsList = new List<AdminsModel>();

			AdminsModel admin;

			for (int i = 0; i < driversSet.Tables["admins"].Rows.Count; i++)
			{
				admin = new AdminsModel();
				admin.Username = driversSet.Tables["admins"].Rows[i]["username"].ToString();
				admin.Password = driversSet.Tables["admins"].Rows[i]["password"].ToString();
				adminsList.Add(admin);
			}
			return adminsList;
		}

		public AdminsModel GetAdminByNameAndPassword(AdminsModel adminsModel)
		{
			AdminsModel admin = null;

			for (int i = 0; i < driversSet.Tables["drivers"].Rows.Count; i++)
			{
				if (driversSet.Tables["drivers"].Rows[i]["username"].ToString().Equals(adminsModel.Username))
				{
					if (driversSet.Tables["drivers"].Rows[i]["password"].ToString().Equals(adminsModel.Password))
					{
						admin = new AdminsModel();
						admin.Username = driversSet.Tables["admins"].Rows[i]["username"].ToString();
						admin.Password = driversSet.Tables["admins"].Rows[i]["password"].ToString();
					}
				}
			}
			return admin;
		}

		public void AddAdmin(AdminsModel newAdmin)
		{
			DataRow myNewRow = admins.NewRow();
			myNewRow["username"] = newAdmin.Username;
			myNewRow["password"] = newAdmin.Password;
			admins.Rows.Add(myNewRow);
		}

		public void UpdateAdmin(AdminsModel newAdmin)
		{
			DataRow[] rows = drivers.Select($"username={newAdmin.Username}");
			DataRow row = rows[0];
			row["username"] = newAdmin.Username;
			row["password"] = newAdmin.Password;
		}

		public void DeleteAdmin(string username)
		{
			for (int i = drivers.Rows.Count - 1; i >= 0; i--)
			{
				DataRow dr = drivers.Rows[i];
				if (dr["username"].Equals(username))
					dr.Delete();
			}
			drivers.AcceptChanges();
		}
	}
}
