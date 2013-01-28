// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="AddressService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class AddressService
    /// </summary>
    public class AddressService : ServiceBase<Address>
    {
        /// <summary>
        /// Gets all address records.
        /// </summary>
        /// <returns>List{Address}.</returns>
        public List<Address> GetAllAddressRecords()
        {
            return QueryAll(SqlDatabase, Procedure.Address_SelectAll, Address.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the address record by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Address.</returns>
        public Address GetAddressRecordById(int id)
        {
            if (IsCached)
            {
                Predicate<Address> h = h2 => h2.AddressID == id;
                return GetAllAddressRecords().Find(h) ?? new Address();
            }

            return Query(SqlDatabase, Procedure.Address_SelectById, Address.Build, id);
        }

        /// <summary>
        /// Gets the record by parent id and entity ID.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns>List{Address}.</returns>
        public List<Address> GetRecordByParentIdAndEntityID(int parentID, Int16 entityID)
        {
            if (IsCached)
            {
                Predicate<Address> h = h2 => h2.ParentID == parentID && h2.EntityID == entityID;
                return GetAllAddressRecords().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Address_SelectByParentIdAndEntityId, Address.Build, parentID,
                            entityID);
        }
    }
}