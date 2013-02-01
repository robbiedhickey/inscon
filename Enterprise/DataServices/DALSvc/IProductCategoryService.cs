using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IProductCategoryService
    {
        [OperationContract]
        List<ProductCategory> GetAllProductCategories();

        [OperationContract]
        ProductCategory GetProductCategoryById(int id);

        [OperationContract]
        void DeleteRecord(ProductCategory productCategory);

        [OperationContract]
        int SaveRecord(ProductCategory productCategory);
    }
}
