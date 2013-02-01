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
    public interface ILocationService
    {
        [OperationContract]
        List<Location> GetAllLocations();

        [OperationContract]
        Location GetLocationById(int id);

        [OperationContract]
        List<Location> GetLocationsByOrganizationId(int orgId);

        [OperationContract]
        List<Location> GetLocationsByOrganizationIdandTypeId(Int32 orgId, Int32 typeId);

        [OperationContract]
        void DeleteRecord(Location location);

        [OperationContract]
        int SaveRecord(Location location);
    }
}
