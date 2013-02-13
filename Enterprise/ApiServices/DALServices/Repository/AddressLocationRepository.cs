using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.AddressLocationService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class AddressLocationRepository : IAddressLocationRepository
    {
        public List<AddressLocation> GetAllAddressesLocationRecords()
        {
            return new dbSvc().GetAllAddressesLocationRecords();
        }

        public AddressLocation GetAddressLocationById(int id)
        {
            return new dbSvc().GetAddressLocationById(id);
        }

        public void DeleteRecord(AddressLocation addressLocation)
        {
            new dbSvc().DeleteRecord(addressLocation);
        }

        public int SaveRecord(AddressLocation addressLocation)
        {
            return new dbSvc().SaveRecord(addressLocation);
        }
    }
}