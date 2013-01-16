using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
namespace Enterprise.DAL.Core.Service
{
    public class AddressLocationService : ServiceBase<Address>
    {

        /// <summary>
        /// Get All AddressLocation Records
        /// </summary>
        /// <returns></returns>
        public List<AddressLocation> GetAllAddressesLocationRecords()
        {
            return QueryAll(SqlDatabase, Procedure.AddressLocation_SelectAll, AddressLocation.Build,
                            CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get AddressLocation By RecordID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AddressLocation GetAddressLocationById(int id)
        {
            if (IsCached)
            {
                Predicate<AddressLocation> h = h2 => h2.AddressID == id;
                return GetAllAddressesLocationRecords().Find(h) ?? new AddressLocation();
            }

            return Query(SqlDatabase, Procedure.AddressLocation_SelectById, AddressLocation.Build, CacheMinutesToExpire,
                         IsCached, id);
        }
    }
}
