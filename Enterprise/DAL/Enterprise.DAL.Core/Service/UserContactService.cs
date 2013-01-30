// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="UserContactService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class UserContactService
    /// </summary>
    public class UserContactService : ServiceBase<UserContact>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>UserContact.</returns>
        public static UserContact Build(ITypeReader reader)
        {
            var record = new UserContact
                {
                    UserContactId = reader.GetInt32("UserContactID"),
                    UserId = reader.GetInt32("UserID"),
                    Value = reader.GetString("Value"),
                    TypeId = reader.GetInt32("TypeID"),
                    IsPrimary = reader.GetBool("IsPrimary")
                };
            return record;
        }

        /// <summary>
        /// Gets all user contacts.
        /// </summary>
        /// <returns>List{UserContact}.</returns>
        public List<UserContact> GetAllUserContacts()
        {
            return QueryAll(SqlDatabase, Procedure.UserContact_SelectAll, Build, CacheMinutesToExpire,
                            IsCached);
        }

        /// <summary>
        /// Gets the user contact by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>UserContact.</returns>
        public UserContact GetUserContactById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<UserContact> h = h2 => h2.UserContactId == id;
                return GetAllUserContacts().Find(h) ?? new UserContact();
            }

            return Query(SqlDatabase, Procedure.UserContact_SelectById, Build, id);
        }


        /// <summary>
        /// Gets the user contacts by user id.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <returns>List{UserContact}.</returns>
        public List<UserContact> GetUserContactsByUserId(Int32 userID)
        {
            if (IsCached)
            {
                Predicate<UserContact> h = h2 => h2.UserId == userID;
                return GetAllUserContacts().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.UserContact_SelectByUserId, Build, userID);
        }

        /// <summary>
        /// Gets the user contacts by user id and type id.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="typeId">The type id.</param>
        /// <returns>List{UserContact}.</returns>
        public List<UserContact> GetUserContactsByUserIdAndTypeId(Int32 userID, Int32 typeId)
        {
            if (IsCached)
            {
                Predicate<UserContact> h = h2 => h2.UserId == userID && h2.TypeId == typeId;
                return GetAllUserContacts().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.UserContact_SelectByUserId, Build, userID, typeId);
        }
    }
}