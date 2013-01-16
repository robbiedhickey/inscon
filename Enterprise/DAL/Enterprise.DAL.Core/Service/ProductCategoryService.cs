using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class ProductCategoryService : ServiceBase<Address>
    {
        /// <summary>
        ///     Get all ProductCategory records
        /// </summary>
        /// <returns></returns>
        public List<ProductCategory> GetAllProductCategories()
        {
            return QueryAll(SqlDatabase, Procedure.ProductCategory_SelectAll, ProductCategory.Build,
                            CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        ///     Get ProductCategory record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductCategory GetProductCategoryById(int id)
        {
            if (IsCached)
            {
                Predicate<ProductCategory> h = h2 => h2.ProductCategoryId == id;
                return GetAllProductCategories().Find(h) ?? new ProductCategory();
            }

            return Query(SqlDatabase, Procedure.ProductCategory_SelectById, ProductCategory.Build, id);
        }
    }
}