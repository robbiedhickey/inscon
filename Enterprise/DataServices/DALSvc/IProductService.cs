using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        Product GetProductById(Int32 id);

        [OperationContract]
        List<Product> GetProductsByCategoryId(Int32 categoryId);

        [OperationContract]
        void DeleteRecord(Product product);

        [OperationContract]
        int SaveRecord(Product product);
    }
}
