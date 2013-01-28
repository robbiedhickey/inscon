// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="UserNotificationService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class UserNotificationService
    /// </summary>
    public class UserNotificationService : ServiceBase<UserNotification>
    {
        /// <summary>
        /// Gets all user notifications.
        /// </summary>
        /// <returns>List{UserNotification}.</returns>
        public List<UserNotification> GetAllUserNotifications()
        {
            return QueryAll(SqlDatabase, Procedure.UserNotification_SelectAll, UserNotification.Build,
                            CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the user notification by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>UserNotification.</returns>
        public UserNotification GetUserNotificationById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<UserNotification> h = h2 => h2.UserNotificationId == id;
                return GetAllUserNotifications().Find(h) ?? new UserNotification();
            }

            return Query(SqlDatabase, Procedure.UserNotification_SelectById, UserNotification.Build, id);
        }

        /// <summary>
        /// Gets the user notifications by user id.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns>List{UserNotification}.</returns>
        public List<UserNotification> GetUserNotificationsByUserId(Int32 userId)
        {
            if (IsCached)
            {
                Predicate<UserNotification> h = h2 => h2.UserId == userId;
                return GetAllUserNotifications().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.UserNotification_SelectByUserId, UserNotification.Build, userId);
        }
    }
}