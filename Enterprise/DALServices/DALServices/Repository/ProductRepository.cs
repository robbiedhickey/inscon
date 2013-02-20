using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.ProductService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return new dbSvc().GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return new dbSvc().GetProductById(id);
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return new dbSvc().GetProductsByCategoryId(categoryId);
        }

        public bool DeleteRecord(Product product)
        {
            return new dbSvc().DeleteRecord(product);
        }

        public int SaveRecord(Product product)
        {
            return new dbSvc().SaveRecord(product);
        }
    }
}