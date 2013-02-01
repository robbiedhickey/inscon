using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.ProductCategoryService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class ProductCategoryService : IProductCategoryService
    {
        public List<ProductCategory> GetAllProductCategories()
        {
            throw new NotImplementedException();
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
    }
}
