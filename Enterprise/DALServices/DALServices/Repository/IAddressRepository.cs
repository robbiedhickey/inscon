using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IAddressRepository
    {
        List<Address> GetAllAddressRecords();
        Address GetAddressRecordById(int id);
        List<Address> GetRecordByParentIdAndEntityID(int parentId, Int16 entityId);
        void DeleteRecord(Address address);
        int SaveRecord(Address address);
    }
}
