// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="LookupService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class LookupService
    /// </summary>
    public class LookupService : ServiceBase<Lookup>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Lookup.</returns>
        public static Lookup Build(ITypeReader reader)
        {
            var record = new Lookup
                {
                    LookupID = reader.GetInt32("LookupID"),
                    LookupGroupID = reader.GetInt16("LookupGroupID"),
                    Value = reader.GetString("Value")
                };

            return record;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupService"/> class.
        /// </summary>
        public LookupService()
        {
            IsCached = true;
        }

        /// <summary>
        /// Gets all lookups.
        /// </summary>
        /// <returns>List{Lookup}.</returns>
        public List<Lookup> GetAllLookups()
        {
            return QueryAll(SqlDatabase, Procedure.Lookup_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the lookup by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Lookup.</returns>
        public Lookup GetLookupById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<Lookup> h = h2 => h2.LookupID == id;
                return GetAllLookups().Find(h);
            }
            return Query(SqlDatabase, Procedure.Lookup_SelectById, Build, id);
        }

        /// <summary>
        /// Gets the lookup values by group id.
        /// </summary>
        /// <param name="groupID">The group ID.</param>
        /// <returns>List{Lookup}.</returns>
        public List<Lookup> GetLookupValuesByGroupId(Int16 groupID)
        {
            if (IsCached)
            {
                Predicate<Lookup> l = l2 => l2.LookupGroupID == groupID;
                return GetAllLookups().FindAll(l);
            }

            return QueryAll(SqlDatabase, Procedure.Lookup_SelectByGroupId, Build, groupID);
        }
    }
}