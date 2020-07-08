using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using System.Web.UI.WebControls;

namespace RestWebApi
{
	public class HeroesOutOfRangeFilter : ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext actionExecutedContext)
		{
			if (actionExecutedContext.Exception is ArgumentOutOfRangeException)
			{
				actionExecutedContext.Response = new HttpResponseMessage()
				{
					Content = new StringContent("Id must be greater than 0"),
					StatusCode = HttpStatusCode.Forbidden
				};
			}
		}
	}
}