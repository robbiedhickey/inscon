// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="OrganizationService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class OrganizationService
    /// </summary>
    public class OrganizationService : ServiceBase<Organization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationService"/> class.
        /// </summary>
        public OrganizationService()
        {
            IsCached = true;
        }

        /// <summary>
        /// Gets all organizations.
        /// </summary>
        /// <returns>List{Organization}.</returns>
        public List<Organization> GetAllOrganizations()
        {
            return QueryAll(SqlDatabase, Procedure.Organization_SelectAll, Organization.Build, CacheMinutesToExpire,
                            IsCached);
        }

        /// <summary>
        /// Gets the organization by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Organization.</returns>
        public Organization GetOrganizationById(int id)
        {
            if (IsCached)
            {
                Predicate<Organization> h = h2 => h2.OrganizationID == id;
                return GetAllOrganizations().Find(h) ?? new Organization();
            }

            return Query(SqlDatabase, Procedure.Organization_SelectById, Organization.Build, id);
        }

        /// <summary>
        /// Gets the organizations by type id.
        /// </summary>
        /// <param name="typeID">The type ID.</param>
        /// <returns>List{Organization}.</returns>
        public List<Organization> GetOrganizationsByTypeId(int? typeID)
        {
            if (typeID == null)
            {
                return GetAllOrganizations();
            }
            if (IsCached)
            {
                Predicate<Organization> d = d2 => d2.TypeID == typeID;
                return GetAllOrganizations().FindAll(d);
            }

            return QueryAll(SqlDatabase, Procedure.Organization_SelectByTypeId, Organization.Build, typeID);
        }
    }
}