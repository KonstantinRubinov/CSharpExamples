using System.Collections.Generic;
using System.Linq;

namespace EmployeeService
{
	public class EmployeesManager : BaseManager, IEmployeesRepository
	{
		public List<EmployeeModel> GetAllEmployees()
		{
			var allEmployee = DB.Employees.Select(e => new EmployeeModel
			{
				ID = e.ID,
				FirstName = e.FirstName,
				LastName = e.LastName,
				Gender = e.Gender,
				Salary = e.Salary
			});

			return allEmployee.ToList();
		}

		public EmployeeModel GetEmployeeById(int id)
		{
			EmployeeModel employeeModel = DB.Employees.Where(e => e.ID==id).Select(e => new EmployeeModel
			{
				ID = e.ID,
				FirstName = e.FirstName,
				LastName = e.LastName,
				Gender = e.Gender,
				Salary = e.Salary
			}).SingleOrDefault();

			return employeeModel;
		}

		public EmployeeModel AddEmployee(EmployeeModel employeeModel)
		{
			Employee employee = new Employee
			{
				ID = employeeModel.ID,
				FirstName = employeeModel.FirstName,
				LastName = employeeModel.LastName,
				Gender = employeeModel.Gender,
				Salary = employeeModel.Salary
			};
			DB.Employees.Add(employee);
			DB.SaveChanges();
			return GetEmployeeById(employee.ID);
		}

		public EmployeeModel UpdateEmployee(EmployeeModel employeeModel)
		{
			//// Update without two database access:
			//Employee employee = new Employee();
			//employee.ID = employeeModel.ID;
			//employee.FirstName = employeeModel.FirstName;
			//employee.LastName = employeeModel.LastName;
			//employee.Gender = employeeModel.Gender;
			//employee.Salary = employeeModel.Salary;
			//DB.Employees.Attach(employee);
			//DB.Entry(employee).State = EntityState.Modified;
			//DB.SaveChanges();
			//return GetEmployeeById(employee.ID);

			// Update but with two database access:
			Employee employee = DB.Employees.Where(e => e.ID==employeeModel.ID).SingleOrDefault();
			if (employee == null)
				return null;
			employee.ID = employeeModel.ID;
			employee.FirstName = employeeModel.FirstName;
			employee.LastName = employeeModel.LastName;
			employee.Gender = employeeModel.Gender;
			employee.Salary = employeeModel.Salary;
			DB.SaveChanges();
			return GetEmployeeById(employee.ID);
		}

		public void DeleteEmployee(int id)
		{
			Employee employee = DB.Employees.Where(e => e.ID == id).SingleOrDefault();
			DB.Employees.Attach(employee);
			if (employee == null)
				return;
			DB.Employees.Remove(employee);
			DB.SaveChanges();
		}
	}
}
