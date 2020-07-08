using System.Collections.Generic;

namespace cTaxi
{
	public interface IDriversRepository
	{
		List<DriversModel> GetAllDrivers();
		DriversModel GetOneDriver(string id);
		DriversModel AddDriver(DriversModel driver);
		DriversModel UpdateDriver(DriversModel driver);
		void DeleteDriver(string id);
	}
}
