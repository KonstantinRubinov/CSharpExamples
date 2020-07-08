using System;

namespace EmployeeService
{
	public class BaseManager //: IDisposable
	{
		protected EmployeeDBEntities DB = new EmployeeDBEntities();

		public void Dispose()
		{
			DB.Dispose();
		}
	}
}
