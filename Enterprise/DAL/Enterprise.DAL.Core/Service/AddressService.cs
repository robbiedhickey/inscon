using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class AddressService : ServiceBase<Address>
    {
        
        /// <summary>
        /// Get all Address records
        /// </summary>
        /// <returns></returns>
        public List<Address> GetAllAddressRecords()
        {
            return QueryAll(SqlDatabase, Procedure.Address_SelectAll, Address.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get Address record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Address GetAddressRecordById(int id)
        {
            if (IsCached)
            {
                Predicate<Address> h = h2 => h2.AddressID == id;
                return GetAllAddressRecords().Find(h) ?? new Address();
            }

            return Query(SqlDatabase, Procedure.Address_SelectById, Address.Build, id);
        }

        /// <summary>
        /// Get all Address records for the provided EntityID and ParentID)
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="entityID"></param>
        /// <returns></returns>
        public List<Address> GetRecordByParentIdAndEntityID(int parentID, Int16 entityID)
        {
            if (IsCached)
            {
                Predicate<Address> h = h2 => h2.ParentID == parentID && h2.EntityID == entityID;
                return GetAllAddressRecords().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Address_SelectByParentIdAndEntityId, Address.Build, parentID, entityID);
        }
    }
}
