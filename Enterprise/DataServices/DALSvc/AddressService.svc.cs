using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.AddressService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class AddressService : IAddressService
    {
        public List<Address> GetAllAddressRecords()
        {
            throw new NotImplementedException();
        }

        public Address GetAddressRecordById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetRecordByParentIdAndEntityID(int parentID, short entityID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Address address)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
