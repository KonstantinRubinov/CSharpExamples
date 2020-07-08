using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace EmployeeService
{
	public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
	{
		public override void OnAuthorization(HttpActionContext actionContext)
		{
			string username = "";
			string password = "";
			if (actionContext.Request.Headers == null || actionContext.Request.Headers.Authorization == null)
			{
				actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
			}
			else
			{
				string athenticationToken = actionContext.Request.Headers.Authorization.Parameter;
				string decodedAthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(athenticationToken));
				string[] usernamePasswordArray = decodedAthenticationToken.Split(':');
				username = usernamePasswordArray[0];
				password = usernamePasswordArray[1];
				if (EmployeeSecurity.Login(username, password))
				{
					Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
				}
				else
				{
					actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
				}
			}
		}
	}
}