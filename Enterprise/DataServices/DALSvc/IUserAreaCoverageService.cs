using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IUserAreaCoverageService
    {
        [OperationContract]
        List<UserAreaCoverage> GetAllUserAreaCoverages();

        [OperationContract]
        UserAreaCoverage GetUserAreaCoverageByParentId(int id);

        [OperationContract]
        List<UserAreaCoverage> GetUserAreaCoverageByUserIdandServiceId(Int32 userId, Int32 serviceId);

        [OperationContract]
        void DeleteRecord(UserAreaCoverage userAreaCoverage);

        [OperationContract]
        int SaveRecord(UserAreaCoverage userAreaCoverage);
    }
}
