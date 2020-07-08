using CustomersRest.Filters.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace CustomersRest.Filters
{
	public class ExceptionHandlingAttribute : ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext context)
		{
			if (context.Exception is MakeObjectException)
			{
				throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent(context.Exception.Message),
					ReasonPhrase = "Exception"
				});

			}

			//Log Critical errors
			Debug.WriteLine(context.Exception);

			throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
			{
				Content = new StringContent("An error occurred, please try again or contact the administrator."),
				ReasonPhrase = "Critical Exception"
			});
		}
	}
}