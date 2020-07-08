using System.Collections.Generic;

namespace cTaxi
{
	public class DriversManager: IDriversRepository
	{
		private Drivers driversDB;

		public List<DriversModel> GetAllDrivers()
		{
			return driversDB.GetAllDrivers();
		}

		public DriversModel GetOneDriver(string id)
		{
			return driversDB.GetDriverById(id);
		}

		public DriversModel AddDriver(DriversModel driver)
		{
			driversDB.AddDriver(driver);
			return GetOneDriver(driver.Id);
		}

		public DriversModel UpdateDriver(DriversModel driver)
		{
			driversDB.UpdateDriver(driver);
			return GetOneDriver(driver.Id);
		}

		public void DeleteDriver(string id)
		{
			driversDB.DeleteDriver(id);
		}
	}
}
