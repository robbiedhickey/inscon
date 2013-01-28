// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="LookupGroupService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class LookupGroupService
    /// </summary>
    public class LookupGroupService : ServiceBase<LookupGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupGroupService"/> class.
        /// </summary>
        public LookupGroupService()
        {
            IsCached = true;
        }

        /// <summary>
        /// Gets all lookup groups.
        /// </summary>
        /// <returns>List{LookupGroup}.</returns>
        public List<LookupGroup> GetAllLookupGroups()
        {
            return QueryAll(SqlDatabase, Procedure.LookupGroup_SelectAll, LookupGroup.Build, CacheMinutesToExpire,
                            IsCached);
        }

        /// <summary>
        /// Gets the lookup group by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>LookupGroup.</returns>
        public LookupGroup GetLookupGroupById(int id)
        {
            if (IsCached)
            {
                Predicate<LookupGroup> h = h2 => h2.LookupGroupID == id;
                return GetAllLookupGroups().Find(h) ?? new LookupGroup();
            }

            return Query(SqlDatabase, Procedure.LookupGroup_SelectById, LookupGroup.Build, id);
        }
    }
}