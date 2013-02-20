using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.AddressUseService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class AddressUseRepository : IAddressUseRepository
    {
        public List<AddressUse> GetAllAddressUseRecords()
        {
            return new dbSvc().GetAllAddressUseRecords();
        }

        //public AddressUse GetAddressUseById(int id)
        //{
        //    return new dbSvc().GetAddressUseById(id);
        //}

        public List<AddressUse> GetAddressUseByAddressId(int addressId)
        {
            return new dbSvc().GetAddressUseByAddressId(addressId);
        }

        public AddressUse GetAddressUseByAddressIdAndTypeId(int addressId, short typeId)
        {
            return new dbSvc().GetAddressUseByAddressIdAndTypeId(addressId, typeId);
        }

        public bool DeleteRecord(AddressUse addressUse)
        {
            return new dbSvc().DeleteRecord(addressUse);
        }

        public int SaveRecord(AddressUse addressUse)
        {
            return new dbSvc().SaveRecord(addressUse);
        }
    }
}