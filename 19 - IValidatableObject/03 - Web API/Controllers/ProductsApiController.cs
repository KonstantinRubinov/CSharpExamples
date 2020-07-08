using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JohnBryce
{
    [EnableCors("http://localhost:4200","*","*")]
    [RoutePrefix("api")]
    public class ProductsApiController : ApiController
    {
        private ProductsLogic logic = new ProductsLogic();

        [HttpGet]
        [Route("products")]
        public HttpResponseMessage GetAllProducts()
        {
            try
            {
                List<ProductModel> allProducts = logic.GetAllProducts();
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
        public HttpResponseMessage GetOneProduct(int id)
        {
            try
            {
                ProductModel oneProduct = logic.GetOneProduct(id);
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
        public HttpResponseMessage AddProduct(ProductModel productModel)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    Errors errors = ErrorsHelper.GetErrors(ModelState);
                    return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
                }

                ProductModel addedProduct = logic.AddProduct(productModel);
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
        public HttpResponseMessage UpdateProduct(int id, ProductModel productModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    Errors errors = ErrorsHelper.GetErrors(ModelState);
                    return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
                }

                productModel.id = id;
                ProductModel updatedProduct = logic.UpdateProduct(productModel);
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
                logic.DeleteProduct(id);
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
