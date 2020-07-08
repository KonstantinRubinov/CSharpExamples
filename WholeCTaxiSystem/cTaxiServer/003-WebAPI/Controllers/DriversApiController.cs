using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace cTaxi
{
	[EnableCors("*", "*", "*")]
	[RoutePrefix("api")]
	public class DriversApiController : ApiController
    {
		private IDriversRepository driversRepository;

		public DriversApiController(IDriversRepository _driversRepository)
		{
			driversRepository = _driversRepository;
		}

		[HttpGet]
		[Route("drivers")]
		public HttpResponseMessage GetAllDrivers()
		{
			try
			{
				List<DriversModel> allProducts = driversRepository.GetAllDrivers();
				return Request.CreateResponse(HttpStatusCode.OK, allProducts);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpGet]
		[Route("drivers/{id}")]
		public HttpResponseMessage GetOneDriver(string id)
		{
			try
			{
				DriversModel oneProduct = driversRepository.GetOneDriver(id);
				return Request.CreateResponse(HttpStatusCode.OK, oneProduct);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpPost]
		[Route("drivers")]
		public HttpResponseMessage AddDriver(DriversModel driversModel)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}

				DriversModel addedDriver = driversRepository.AddDriver(driversModel);
				return Request.CreateResponse(HttpStatusCode.Created, addedDriver);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[Route("drivers/{id}")]
		public HttpResponseMessage UpdateDriver(string id, DriversModel driversModel)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}

				driversModel.Id = id;
				DriversModel updatedDriver = driversRepository.UpdateDriver(driversModel);
				return Request.CreateResponse(HttpStatusCode.OK, updatedDriver);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpDelete]
		[Route("drivers/{id}")]
		public HttpResponseMessage DeleteDriver(string id)
		{
			try
			{
				driversRepository.DeleteDriver(id);
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
