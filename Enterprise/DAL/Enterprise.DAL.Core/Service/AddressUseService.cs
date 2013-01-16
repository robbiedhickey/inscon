using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class AddressUseService : ServiceBase<Address>
    {
        /// <summary>
        /// Get all AddressUse records
        /// </summary>
        /// <returns></returns>
        public List<AddressUse> GetAllAddressUseRecords()
        {
            return QueryAll(SqlDatabase, Procedure.AddressUse_SelectAll, AddressUse.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get Address record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AddressUse GetAddressUseById(int id)
        {
            if (IsCached)
            {
                Predicate<AddressUse> h = h2 => h2.AddressUseId == id;
                return GetAllAddressUseRecords().Find(h) ?? new AddressUse();
            }

            return Query(SqlDatabase, Procedure.Address_SelectById, AddressUse.Build, CacheMinutesToExpire, IsCached, id);
        }

        /// <summary>
        /// Get all AddressesUse records by AddressId
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns></returns>
        public List<AddressUse> GetAddressUseByAddressId(int addressID)
        {
            if (IsCached)
            {
                Predicate<AddressUse> h = h2 => h2.AddressId == addressID;
                return GetAllAddressUseRecords().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.AddressUse_SelectByAddressId, AddressUse.Build, addressID);
        }

        /// <summary>
        /// Get all AddressesUse records by AddressId and TypeId
        /// </summary>
        /// <param name="addressID"></param>
        /// <param name="typeID"></param>
        /// <returns></returns>
        public AddressUse GetAddressUseByAddressIdAndTypeId(int addressID, Int16 typeID)
        {
            if (IsCached)
            {
                Predicate<AddressUse> h = h2 => h2.AddressId == addressID && h2.TypeId == typeID;
                return GetAllAddressUseRecords().Find(h) ?? new AddressUse();
            }

            return Query(SqlDatabase, Procedure.AddressUse_SelectByAddressIdAndTypeId, AddressUse.Build, addressID, typeID);
        }
    }
}
