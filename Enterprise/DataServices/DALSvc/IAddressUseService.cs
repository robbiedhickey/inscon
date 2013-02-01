using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IAddressUseService
    {
        [OperationContract]
        List<AddressUse> GetAllAddressUseRecords();

        [OperationContract]
        AddressUse GetAddressUseById(int id);

        [OperationContract]
        List<AddressUse> GetAddressUseByAddressId(int addressID);

        [OperationContract]
        AddressUse GetAddressUseByAddressIdAndTypeId(int addressID, Int16 typeID);

        [OperationContract]
        void DeleteRecord(AddressUse addressUse);

        [OperationContract]
        int SaveRecord(AddressUse addressUse);
    }
}
