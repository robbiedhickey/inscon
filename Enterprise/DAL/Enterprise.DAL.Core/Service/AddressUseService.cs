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
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class AddressUseService
    /// </summary>
    public class AddressUseService : ServiceBase<Address>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>AddressUse.</returns>
        public static AddressUse Build(ITypeReader reader)
        {
            var record = new AddressUse
                {
                    AddressUseId = reader.GetInt32("AddressUseID"),
                    AddressId = reader.GetInt32("AddressID"),
                    TypeId = reader.GetInt32("TypeID")
                };
            return record;
        }

        /// <summary>
        /// Gets all address use records.
        /// </summary>
        /// <returns>List{AddressUse}.</returns>
        public List<AddressUse> GetAllAddressUseRecords()
        {
            return QueryAll(SqlDatabase, Procedure.AddressUse_SelectAll, Build, CacheMinutesToExpire,
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

            return Query(SqlDatabase, Procedure.Address_SelectById, Build, CacheMinutesToExpire, IsCached, id);
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

            return QueryAll(SqlDatabase, Procedure.AddressUse_SelectByAddressId, Build, addressID);
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

            return Query(SqlDatabase, Procedure.AddressUse_SelectByAddressIdAndTypeId, Build, addressID,
                         typeID);
        }
    }
}