using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
	public interface IEmployeesRepository
	{
		List<EmployeeModel> GetAllEmployees();
		EmployeeModel GetEmployeeById(int id);
		EmployeeModel AddEmployee(EmployeeModel employeeModel);
		EmployeeModel UpdateEmployee(EmployeeModel employeeModel);
		void DeleteEmployee(int id);
	}
}
