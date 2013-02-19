// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="LocationService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class LocationService
    /// </summary>
    public class LocationService : ServiceBase<Location>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Location.</returns>
        public static Location Build(ITypeReader reader)
        {
            var record = new Location
                {
                    LocationID = reader.GetInt32("LocationID"),
                    OrganizationID = reader.GetInt32("OrganizationID"),
                    Name = reader.GetString("Name"),
                    Code = reader.GetString("Code"),
                    TypeID = reader.GetInt32("TypeID")
                };

            return record;
        }

        /// <summary>
        /// Gets all locations.
        /// </summary>
        /// <returns>List{Location}.</returns>
        public List<Location> GetAllLocations()
        {
            return QueryAll(SqlDatabase, Procedure.Location_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the location by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Location.</returns>
        public Location GetLocationById(int id)
        {
            if (IsCached)
            {
                Predicate<Location> h = h2 => h2.LocationID == id;
                return GetAllLocations().Find(h) ?? new Location();
            }

            return Query(SqlDatabase, Procedure.Location_SelectById, Build, id);
        }

        /// <summary>
        /// Gets the locations by organization id.
        /// </summary>
        /// <param name="orgId">The org id.</param>
        /// <returns>List{Location}.</returns>
        public List<Location> GetLocationsByOrganizationId(int orgId)
        {
            if (IsCached)
            {
                Predicate<Location> h = h2 => h2.OrganizationID == orgId;
                return GetAllLocations().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Location_SelectByOrganizationId, Build, orgId);
        }

        /// <summary>
        /// Gets the locations by organization idand type id.
        /// </summary>
        /// <param name="orgId">The org id.</param>
        /// <param name="typeId">The type id.</param>
        /// <returns>List{Location}.</returns>
        public List<Location> GetLocationsByOrganizationIdandTypeId(Int32 orgId, Int32 typeId)
        {
            if (IsCached)
            {
                Predicate<Location> h = h2 => h2.OrganizationID == orgId && h2.TypeID == typeId;
                return GetAllLocations().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Location_SelectByOrganizationIdAndTypeId, Build, orgId,
                            typeId);
        }
    }
}