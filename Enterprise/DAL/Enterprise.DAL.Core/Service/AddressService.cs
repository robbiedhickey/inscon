using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class AddressService : ServiceBase
    {
        private readonly Int32 _cacheMinutesToExpire;
        private readonly String _sqlDatabase;
        private readonly Boolean _isCached;

        public AddressService()
        {
            _cacheMinutesToExpire = 0;
            _sqlDatabase = Database.EnterpriseDb;
            _isCached = false;
        }

        /// <summary>
        /// Get all Address records
        /// </summary>
        /// <returns></returns>
        public List<Address> GetAllAddresses()
        {
            return QueryAll(_sqlDatabase, Procedure.Address_SelectAll, Address.Build, _cacheMinutesToExpire, _isCached);
        }

        /// <summary>
        /// Get Address record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Address GetAddressByParentId(int id)
        {
            if (_isCached)
            {
                Predicate<Address> h = h2 => h2.AddressID == id;
                return GetAllAddresses().Find(h) ?? new Address();
            }

            return Query(_sqlDatabase, Procedure.Address_SelectById, Address.Build, _cacheMinutesToExpire, _isCached, id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="entityID"></param>
        /// <returns></returns>
        public Address GetAddressByParentIdAndEntityID(int parentID, Int16 entityID)
        {
            if (_isCached)
            {
                Predicate<Address> h = h2 => h2.ParentID == parentID && h2.EntityID == entityID;
                return GetAllAddresses().Find(h) ?? new Address();
            }

            return Query(_sqlDatabase, Procedure.Address_SelectByParentIdAndEntityId, Address.Build, _cacheMinutesToExpire, _isCached, parentID, entityID);
        }
    }
}
