using Enterprise.DAL.Core.Model;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IProductCategoryRepository
    {
        List<ProductCategory> GetAllProductCategories();
        ProductCategory GetProductCategoryById(int id);
        bool DeleteRecord(ProductCategory productCategory);
        int SaveRecord(ProductCategory productCategory);
    }
}
