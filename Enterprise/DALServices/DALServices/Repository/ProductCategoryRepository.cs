using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.ProductCategoryService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        public List<ProductCategory> GetAllProductCategories()
        {
            return new dbSvc().GetAllProductCategories();
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            return new dbSvc().GetProductCategoryById(id);
        }

        public bool DeleteRecord(ProductCategory productCategory)
        {
            return new dbSvc().DeleteRecord(productCategory);
        }

        public int SaveRecord(ProductCategory productCategory)
        {
            return new dbSvc().SaveRecord(productCategory);
        }
    }
}