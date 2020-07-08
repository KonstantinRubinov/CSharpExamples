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
	public class UsersApiController : ApiController
    {
		private IAdminsRepository adminsRepository;
		public UsersApiController(IAdminsRepository _adminsRepository)
		{
			adminsRepository = _adminsRepository;
		}

		[HttpGet]
		[Route("users")]
		public HttpResponseMessage GetAllUsers()
		{
			try
			{
				List<AdminsModel> allUsers = adminsRepository.GetAllUsers();
				return Request.CreateResponse(HttpStatusCode.OK, allUsers);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpPost]
		[Route("users/check")]
		public HttpResponseMessage GetUserByNameAndPassword(AdminsModel admin)
		{
			try
			{
				AdminsModel oneUser = adminsRepository.GetUserByNameAndPassword(admin);
				return Request.CreateResponse(HttpStatusCode.OK, oneUser);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpPost]
		[Route("users")]
		public HttpResponseMessage AddUser(AdminsModel user)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}

				AdminsModel addedUser = adminsRepository.AddUser(user);
				return Request.CreateResponse(HttpStatusCode.Created, addedUser);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[Route("users/{userame}")]
		public HttpResponseMessage UpdateUser(string userame, AdminsModel user)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}

				user.Username = userame;
				AdminsModel updatedUser = adminsRepository.UpdateUser(user);
				return Request.CreateResponse(HttpStatusCode.OK, updatedUser);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpDelete]
		[Route("users/{userame}")]
		public HttpResponseMessage DeleteDriver(string userame)
		{
			try
			{
				adminsRepository.DeleteUser(userame);
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
