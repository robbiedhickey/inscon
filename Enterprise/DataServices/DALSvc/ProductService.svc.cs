using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.ProductService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Product product)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
