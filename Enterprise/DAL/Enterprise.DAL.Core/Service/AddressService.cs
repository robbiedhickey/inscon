using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Type;
using Enterprise.DAL.Framework.Data.Service;

namespace Enterprise.DAL.Core.Service
{
    public class AddressService : ServiceBase
    {
        private readonly int _cacheMinutesToExpire;
        private readonly string _sqlDatabase;
        private readonly bool _isCached;

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
            return QueryAll<Address>(Database.EnterpriseDb, Procedure.AddressSelect, Address.Build);
            // return DataService.GetDataObjectList<Address>(_sqlDatabase, Procedure.AddressSelect, _cacheMinutesToExpire, _isCached);
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

            return DataService.GetDataObject<Address>(_sqlDatabase, Procedure.AddressSelectById, idAddress);
        }
    }
}
