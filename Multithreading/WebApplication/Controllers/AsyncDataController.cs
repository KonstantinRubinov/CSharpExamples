using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Multithreading
{
	[ApiController]
	[Route("[controller]")]
	public class AsyncDataController : ControllerBase
    {
		DataManager dataManager = new DataManager();

		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				string[] summariesTmp = dataManager.GetStrings();
				return Ok(summariesTmp);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}
	}
}