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
	public class OrderApiController : ApiController
    {
		private IOrdersRepository ordersRepository;

		public OrderApiController(IOrdersRepository _ordersRepository)
		{
			ordersRepository = _ordersRepository;
		}

		[HttpGet]
		[Route("orders/{id}")]
		public HttpResponseMessage GetOrdersByCustomer(string id)
		{
			try
			{
				List<Order> allOrders = ordersRepository.GetOrdersByCustomer(id);
				return Request.CreateResponse(HttpStatusCode.OK, allOrders);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		
	}
}
