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
	public class OrderDetailsApiController : ApiController
    {
		private IOrderDetailsRepository orderDetailsRepository;

		public OrderDetailsApiController(IOrderDetailsRepository _orderDetailsRepository)
		{
			orderDetailsRepository = _orderDetailsRepository;
		}


		[HttpGet]
		[Route("orderDetails/{id}")]
		public HttpResponseMessage GetOrderDetails(int id)
		{
			try
			{
				List<OrderDetails> orderDetailsModel = orderDetailsRepository.GetOrderDetails(id);
				return Request.CreateResponse(HttpStatusCode.OK, orderDetailsModel);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}


		
	}
}
