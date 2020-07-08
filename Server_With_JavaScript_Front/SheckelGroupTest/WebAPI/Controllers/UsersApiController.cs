using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SheckelGroup
{
	[Route("api")]
    [ApiController]
    public class UsersApiController : ControllerBase
    {
        private IUsersRepository usersRepository;

        public UsersApiController(IUsersRepository _usersRepository)
        {
            usersRepository = _usersRepository;
        }

		[AllowAnonymous]
		[HttpPost("users")]
		public IActionResult AddUser(UserModel userModel)
		{
			try
			{
				if (userModel == null)
				{
					return BadRequest("Data is null.");
				}

				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return BadRequest(errors);
				}


				int age = 0;
				age = DateTime.Now.Year - userModel.userBirthDate.Year;
				if (DateTime.Now.DayOfYear < userModel.userBirthDate.DayOfYear)
					age = age - 1;

				if (age <= 20)
				{
					return BadRequest("Only above age 20");
				}

				UserModel addedUser = usersRepository.AddUser(userModel);

				return StatusCode(StatusCodes.Status201Created, addedUser);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return StatusCode(StatusCodes.Status500InternalServerError, errors);
			}
		}
	}
}