using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data.Service;

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
            return QueryAll(_sqlDatabase, Procedure.Address_Select, Address.Build, _cacheMinutesToExpire, _isCached);
        }

        /// <summary>
        /// Get Address record by ID
        /// </summary>
        /// <param name="idAddress"></param>
        /// <returns></returns>
        public Address GetAddressById(int idAddress)
        {
            if (_isCached)
            {
                Predicate<Address> h = h2 => h2.idAddress == idAddress;
                return GetAllAddresses().Find(h) ?? new Address();
            }

            return Query(_sqlDatabase, Procedure.Address_SelectById, Address.Build, _cacheMinutesToExpire, _isCached, idAddress);
        }
    }
}
