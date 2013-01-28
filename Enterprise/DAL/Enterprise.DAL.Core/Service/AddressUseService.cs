// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="AddressUseService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class AddressUseService
    /// </summary>
    public class AddressUseService : ServiceBase<Address>
    {
        /// <summary>
        /// Gets all address use records.
        /// </summary>
        /// <returns>List{AddressUse}.</returns>
        public List<AddressUse> GetAllAddressUseRecords()
        {
            return QueryAll(SqlDatabase, Procedure.AddressUse_SelectAll, AddressUse.Build, CacheMinutesToExpire,
                            IsCached);
        }

        /// <summary>
        /// Gets the address use by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>AddressUse.</returns>
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
        /// Gets the address use by address id.
        /// </summary>
        /// <param name="addressID">The address ID.</param>
        /// <returns>List{AddressUse}.</returns>
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
        /// Gets the address use by address id and type id.
        /// </summary>
        /// <param name="addressID">The address ID.</param>
        /// <param name="typeID">The type ID.</param>
        /// <returns>AddressUse.</returns>
        public AddressUse GetAddressUseByAddressIdAndTypeId(int addressID, Int16 typeID)
        {
            if (IsCached)
            {
                Predicate<AddressUse> h = h2 => h2.AddressId == addressID && h2.TypeId == typeID;
                return GetAllAddressUseRecords().Find(h) ?? new AddressUse();
            }

            return Query(SqlDatabase, Procedure.AddressUse_SelectByAddressIdAndTypeId, AddressUse.Build, addressID,
                         typeID);
        }
    }
}