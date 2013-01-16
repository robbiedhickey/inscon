using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class ProductService : ServiceBase<Product>
    {
        /// <summary>
        ///     Get all Product records
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            return QueryAll(SqlDatabase, Procedure.Product_SelectAll, Product.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        ///     Get Product record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<Product> h = h2 => h2.ProductId == id;
                return GetAllProducts().Find(h) ?? new Product();
            }

            return Query(SqlDatabase, Procedure.Product_SelectById, Product.Build, id);
        }


        public List<Product> GetProductsByCategoryId(Int32 categoryId)
        {
            if (IsCached)
            {
                Predicate<Product> h = h2 => h2.ProductCategoryId == categoryId;
                return GetAllProducts().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Product_SelectByCategoryId, Product.Build, categoryId);
        }
    }
}