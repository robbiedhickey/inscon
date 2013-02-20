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
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class LookupGroupService
    /// </summary>
    public class LookupGroupService : ServiceBase<LookupGroup>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>LookupGroup.</returns>
        public static LookupGroup Build(ITypeReader reader)
        {
            var record = new LookupGroup
                {
                    LookupGroupID = reader.GetInt16("LookupGroupID"),
                    Name = reader.GetString("Name")
                };

            return record;
        }

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
            return QueryAll(SqlDatabase, Procedure.LookupGroup_SelectAll, Build, CacheMinutesToExpire,
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
                return GetAllLookupGroups().Find(h);
            }

            return Query(SqlDatabase, Procedure.LookupGroup_SelectById, Build, id);
        }
    }
}