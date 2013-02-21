// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="UserService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class UserService
    /// </summary>
    public class UserService : ServiceBase<User>
    {
        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>User.</returns>
        public static User Build(ITypeReader reader)
        {
            var record = new User
                {
                    UserID = reader.GetInt32("UserID"),
                    OrganizationID = reader.GetInt32("OrganizationID"),
                    FirstName = reader.GetString("FirstName"),
                    LastName = reader.GetString("LastName"),
                    StatusID = reader.GetInt32("StatusID"),
                    AuthenticationID = reader.GetNullGuid("AuthenticationID")
                };

            return record;
        }


        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns>List{User}.</returns>
        public List<User> GetAllUsers()
        {
            return QueryAll(SqlDatabase, Procedure.User_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the user by id.
        /// </summary>
        /// <param name="idUser">The id user.</param>
        /// <returns>User.</returns>
        public User GetUserById(int idUser)
        {
            if (IsCached)
            {
                Predicate<User> h = h2 => h2.UserID == idUser;
                return GetAllUsers().Find(h);
            }
            return Query(SqlDatabase, Procedure.User_SelectById, Build, idUser);
        }

        /// <summary>
        /// Gets the users by organization id.
        /// </summary>
        /// <param name="idOrganization">The id organization.</param>
        /// <returns>List{User}.</returns>
        public List<User> GetUsersByOrganizationId(int idOrganization)
        {
            if (IsCached)
            {
                Predicate<User> h = h2 => h2.OrganizationID == idOrganization;
                return GetAllUsers().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.User_SelectByOrganizationId, Build, idOrganization);
        }

        /// <summary>
        /// Gets the users by organization id and is active.
        /// </summary>
        /// <param name="idOrganization">The id organization.</param>
        /// <param name="idStatus">The id status.</param>
        /// <returns>List{User}.</returns>
        public List<User> GetUsersByOrganizationIdAndIsActive(int idOrganization, int idStatus)
        {
            if (IsCached)
            {
                Predicate<User> h = h2 => h2.OrganizationID == idOrganization && h2.StatusID == idStatus;
                return GetAllUsers().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.User_SelectByOrganizationIdAndStatusId, Build, idOrganization,
                            idStatus);
        }
    }
}