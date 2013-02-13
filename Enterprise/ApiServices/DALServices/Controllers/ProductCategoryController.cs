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
    public class ProductCategoryController : ApiController
    {
        private readonly IProductCategoryRepository _repository = new ProductCategoryRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        public List<ProductCategory> GetAllProductCategories()
        {
            return _repository.GetAllProductCategories();
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the product category must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetProductCategoryById(id);
        }

        public void DeleteRecord(ProductCategory productCategory)
        {
            if (productCategory == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The product category must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            _repository.DeleteRecord(productCategory);
        }

        public int SaveRecord(ProductCategory productCategory)
        {
            if (productCategory == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The product category must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(productCategory);
        }
    }
}
