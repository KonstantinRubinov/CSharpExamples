﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace cTaxi
{
	static class ErrorsHelper
	{
		public static Errors GetErrors(Exception ex)
		{
			Errors errors = new Errors();
#if DEBUG
			errors.Add(GetMostInnerMessage(ex));
#else
            errors.Add("An error occur, please try again.");
#endif

			return errors;
		}

		public static Errors GetErrors(ModelStateDictionary modelState)
		{
			Errors errors = new Errors();

			foreach (var prop in modelState.Values) // Values = The illegal value properties.
				foreach (var err in prop.Errors) // err = The single data annotation error.
					errors.Add(err.ErrorMessage);

			return errors;
		}

		private static string GetMostInnerMessage(Exception ex)
		{
			if (ex.InnerException == null)
				return ex.Message;
			return GetMostInnerMessage(ex.InnerException);
		}
	}
}