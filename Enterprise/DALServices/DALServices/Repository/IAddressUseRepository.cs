using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IAddressUseRepository
    {
        List<AddressUse> GetAllAddressUseRecords();
        //AddressUse GetAddressUseById(int id);
        List<AddressUse> GetAddressUseByAddressId(int addressId);
        AddressUse GetAddressUseByAddressIdAndTypeId(int addressId, Int16 typeId);
        void DeleteRecord(AddressUse addressUse);
        int SaveRecord(AddressUse addressUse);
    }
}
