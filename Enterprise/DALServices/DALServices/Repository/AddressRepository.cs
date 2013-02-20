using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.AddressService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class AddressRepository : IAddressRepository
    {
        public List<Address> GetAllAddressRecords()
        {
            return new dbSvc().GetAllAddressRecords();
        }

        public Address GetAddressRecordById(int id)
        {
            return new dbSvc().GetAddressRecordById(id);
        }

        public List<Address> GetRecordByParentIdAndEntityID(int parentId, short entityId)
        {
            return new dbSvc().GetAddressRecordsByParentIdAndEntityID(parentId, entityId);
        }

        public bool DeleteRecord(Address address)
        {
            return new dbSvc().DeleteRecord(address);
        }

        public int SaveRecord(Address address)
        {
            return new dbSvc().SaveRecord(address);
        }
    }
}