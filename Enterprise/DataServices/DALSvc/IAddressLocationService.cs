using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract]
    public interface IAddressLocationService
    {
        [OperationContract]
        List<AddressLocation> GetAllAddressesLocationRecords();

        [OperationContract]
        AddressLocation GetAddressLocationById(int id);

        [OperationContract]
        void DeleteRecord(AddressLocation addressLocation);

        [OperationContract]
        int SaveRecord(AddressLocation addressLocation);
    }
}
