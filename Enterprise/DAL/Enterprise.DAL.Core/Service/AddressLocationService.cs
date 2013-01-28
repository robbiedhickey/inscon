// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="AddressLocationService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class AddressLocationService
    /// </summary>
    public class AddressLocationService : ServiceBase<Address>
    {
        /// <summary>
        /// Gets all addresses location records.
        /// </summary>
        /// <returns>List{AddressLocation}.</returns>
        public List<AddressLocation> GetAllAddressesLocationRecords()
        {
            return QueryAll(SqlDatabase, Procedure.AddressLocation_SelectAll, AddressLocation.Build,
                            CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the address location by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>AddressLocation.</returns>
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