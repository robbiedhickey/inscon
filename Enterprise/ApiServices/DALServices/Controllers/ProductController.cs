using Enterprise.ApiServices.DALServices.Helpers;
using Enterprise.ApiServices.DALServices.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Enterprise.DAL.Core.Model;

namespace Enterprise.ApiServices.DALServices.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductRepository _repository = new ProductRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetProductById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the product must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetProductById(id);
        }

        public List<Product> GetProductsByCategoryId(Int32 categoryId)
        {
            if (categoryId < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The Category ID for the product must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetProductsByCategoryId(categoryId);
        }

        public void DeleteRecord(Product product)
        {
            if (product == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The product must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(product);
        }

        public int SaveRecord(Product product)
        {
            if (product == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The product must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(product);
        }
    }
}
