using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.AddressUseService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class AddressUseService : IAddressUseService
    {
        public List<AddressUse> GetAllAddressUseRecords()
        {
            throw new NotImplementedException();
        }

        public AddressUse GetAddressUseById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AddressUse> GetAddressUseByAddressId(int addressID)
        {
            throw new NotImplementedException();
        }

        public AddressUse GetAddressUseByAddressIdAndTypeId(int addressID, short typeID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(AddressUse addressUse)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(AddressUse addressUse)
        {
            throw new NotImplementedException();
        }
    }
}
