using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeeService
{
	[EnableCors("*", "*", "*")]
	[RoutePrefix("api")]
	public class EmployeesApiController : ApiController
    {
		private IEmployeesRepository employeesRepository;

		public EmployeesApiController(IEmployeesRepository _employeesRepository)
		{
			employeesRepository = _employeesRepository;
		}

		[BasicAuthentication]
		[HttpGet]
		[Route("employees")]
		public HttpResponseMessage GetAllEmployees()
		{
			try
			{
				List<EmployeeModel> allEmployees = employeesRepository.GetAllEmployees();
				return Request.CreateResponse(HttpStatusCode.OK, allEmployees);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpGet]
		[Route("employees/{id}")]
		public HttpResponseMessage GetEmployeeById(int id)
		{
			try
			{
				EmployeeModel oneEmployee = employeesRepository.GetEmployeeById(id);
				return Request.CreateResponse(HttpStatusCode.OK, oneEmployee);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpPost]
		[Route("employees")]
		public HttpResponseMessage AddEmployee(EmployeeModel employeeModel)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}
				EmployeeModel addedEmployee = employeesRepository.AddEmployee(employeeModel);
				return Request.CreateResponse(HttpStatusCode.Created, addedEmployee);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}


		[HttpPut]
		[Route("employees/{id}")]
		public HttpResponseMessage UpdateEmployee(int id, EmployeeModel employeeModel)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}

				employeeModel.ID = id;
				EmployeeModel updatedEmployee = employeesRepository.UpdateEmployee(employeeModel);
				return Request.CreateResponse(HttpStatusCode.OK, updatedEmployee);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpDelete]
		[Route("employees/{id}")]
		public HttpResponseMessage DeleteEmployee(int id)
		{
			try
			{
				employeesRepository.DeleteEmployee(id);
				return Request.CreateResponse(HttpStatusCode.NoContent);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}
	}
}
