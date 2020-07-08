using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RestWebApi
{
	[EnableCors("*", "*", "*")]
	[RoutePrefix("api")]
	public class ProductsApiController : ApiController
    {
		private IProductsRepository productsRepository;

		public ProductsApiController(IProductsRepository _productsRepository)
		{
			productsRepository = _productsRepository;
		}

		[HttpGet]
		[Route("products")]
		public HttpResponseMessage GetAllProducts()
		{
			try
			{
				List<Product> allProducts = productsRepository.GetAllProducts();
				return Request.CreateResponse(HttpStatusCode.OK, allProducts);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpGet]
		[Route("products/{id}")]
		public HttpResponseMessage GetProductById(int id)
		{
			try
			{
				Product oneProduct = productsRepository.GetProductById(id);
				return Request.CreateResponse(HttpStatusCode.OK, oneProduct);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpGet]
		[Route("products/{price}")]
		public HttpResponseMessage GetProductByPrice(double price)
		{
			try
			{
				Product oneProduct = productsRepository.GetProductByPrice(price);
				return Request.CreateResponse(HttpStatusCode.OK, oneProduct);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpPost]
		[Route("products")]
		public HttpResponseMessage PostProduct([FromBody]Product product)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}
				Product addedProduct = productsRepository.PostProduct(product);
				return Request.CreateResponse(HttpStatusCode.Created, addedProduct);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpPut]
		[Route("products/{id}")]
		public HttpResponseMessage PutProduct(int id, [FromBody]Product product)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}

				product.id = id;
				Product updatedProduct = productsRepository.PutProduct(product.id, product);
				return Request.CreateResponse(HttpStatusCode.OK, updatedProduct);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpDelete]
		[Route("products/{id}")]
		public HttpResponseMessage DeleteProduct(int id)
		{
			try
			{
				productsRepository.DeleteProduct(id);
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
