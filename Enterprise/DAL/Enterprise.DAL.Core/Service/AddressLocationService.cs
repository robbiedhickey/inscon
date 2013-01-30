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
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class AddressLocationService
    /// </summary>
    public class AddressLocationService : ServiceBase<Address>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>AddressLocation.</returns>
        public static AddressLocation Build(ITypeReader reader)
        {
            var record = new AddressLocation
                {
                    AddressID = reader.GetInt32("AddressID"),
                    BuildingNumber = reader.GetString("BuildingNumber"),
                    StreetName = reader.GetString("StreetName"),
                    City = reader.GetString("City"),
                    State = reader.GetString("State"),
                    Zip = reader.GetString("Zip"),
                    GeoCode = reader.GetString("GeoCode"),
                    Lattitude = reader.GetFloat("Lattitude"),
                    Longitude = reader.GetFloat("Longitude")
                };

            return record;
        }

        /// <summary>
        /// Gets all addresses location records.
        /// </summary>
        /// <returns>List{AddressLocation}.</returns>
        public List<AddressLocation> GetAllAddressesLocationRecords()
        {
            return QueryAll(SqlDatabase, Procedure.AddressLocation_SelectAll, Build,
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

            return Query(SqlDatabase, Procedure.AddressLocation_SelectById, Build, CacheMinutesToExpire,
                         IsCached, id);
        }
    }
}