// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="UserAreaCoverageService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class UserAreaCoverageService
    /// </summary>
    public class UserAreaCoverageService : ServiceBase<UserAreaCoverage>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>UserAreaCoverage.</returns>
        public static UserAreaCoverage Build(ITypeReader reader)
        {
            var record = new UserAreaCoverage
                {
                    UserAreaCoverageId = reader.GetInt32("UserAreaCoverageID"),
                    UserId = reader.GetInt32("UserID"),
                    ZipCode = reader.GetString("ZipCode"),
                    ServiceId = reader.GetInt32("ServiceID")
                };
            return record;
        }

        /// <summary>
        /// Gets all user area coverages.
        /// </summary>
        /// <returns>List{UserAreaCoverage}.</returns>
        public List<UserAreaCoverage> GetAllUserAreaCoverages()
        {
            return QueryAll(SqlDatabase, Procedure.UserAreaCoverage_SelectAll, Build,
                            CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the address by parent id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>UserAreaCoverage.</returns>
        public UserAreaCoverage GetAddressByParentId(int id)
        {
            if (IsCached)
            {
                Predicate<UserAreaCoverage> h = h2 => h2.UserAreaCoverageId == id;
                return GetAllUserAreaCoverages().Find(h) ?? new UserAreaCoverage();
            }

            return Query(SqlDatabase, Procedure.UserAreaCoverage_SelectById, Build, id);
        }

        /// <summary>
        /// Gets the user area coverage by user idand service id.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="serviceId">The service id.</param>
        /// <returns>List{UserAreaCoverage}.</returns>
        public List<UserAreaCoverage> GetUserAreaCoverageByUserIdandServiceId(Int32 userId, Int32 serviceId)
        {
            if (IsCached)
            {
                Predicate<UserAreaCoverage> h = h2 => h2.UserId == userId && h2.ServiceId == serviceId;
                return GetAllUserAreaCoverages().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.UserAreaCoverage_SelectByUserIdAndServiceId, Build,
                            userId, serviceId);
        }
    }
}