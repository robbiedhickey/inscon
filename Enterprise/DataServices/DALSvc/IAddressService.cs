using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IAddressService
    {
        [OperationContract]
        List<Address> GetAllAddressRecords();

        [OperationContract]
        Address GetAddressRecordById(int id);

        [OperationContract]
        List<Address> GetRecordByParentIdAndEntityID(int parentID, Int16 entityID);

        [OperationContract]
        void DeleteRecord(Address address);

        [OperationContract]
        int SaveRecord(Address address);
    }
}
