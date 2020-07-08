using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CustomersRest
{
	[EnableCors("*", "*", "*")]
	[RoutePrefix("api")]
	public class CustomerApiController : ApiController
    {
		private ICustomersRepository customersRepository;

		public CustomerApiController(ICustomersRepository _customersRepository)
		{
			customersRepository = _customersRepository;
		}

		[HttpGet]
		[Route("customers")]
		public HttpResponseMessage GetCustomers()
		{
			try
			{
				List<Customer> allCustomers = customersRepository.GetAllCustomers();
				return Request.CreateResponse(HttpStatusCode.OK, allCustomers);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}


		[HttpGet]
		[Route("customers/{id}")]
		public HttpResponseMessage GetCustomerById(string id)
		{
			try
			{
				Customer customerModel = customersRepository.GetCustomerById(id);
				return Request.CreateResponse(HttpStatusCode.OK, customerModel);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpPost]
		[Route("customers")]
		public HttpResponseMessage AddCustomer([FromBody]Customer value)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}

				Customer addedCustomer = customersRepository.PostCustomer(value);
				return Request.CreateResponse(HttpStatusCode.Created, addedCustomer);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}


		[HttpDelete]
		[Route("customers/{id}")]
		public HttpResponseMessage DeleteCustomer(string id)
		{
			try
			{
				int i = customersRepository.DeleteCustomer(id);
				if (i > 0)
				{
					return Request.CreateResponse(HttpStatusCode.OK);
				}
				else
				{
					return Request.CreateResponse(HttpStatusCode.NoContent);
				}
				
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

	}
}
