using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(Int32 id);
        List<Product> GetProductsByCategoryId(Int32 categoryId);
        bool DeleteRecord(Product product);
        int SaveRecord(Product product);
    }
}
