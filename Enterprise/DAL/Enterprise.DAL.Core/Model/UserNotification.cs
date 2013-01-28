// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="UserNotification.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class UserNotification
    /// </summary>
    public class UserNotification : ModelBase
    {
        /// <summary>
        /// The _date posted
        /// </summary>
        private DateTime _datePosted;

        /// <summary>
        /// The _date read
        /// </summary>
        private DateTime? _dateRead;

        /// <summary>
        /// The _user id
        /// </summary>
        private int _userId;

        /// <summary>
        /// The _user notification id
        /// </summary>
        private int _userNotificationId;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotification"/> class.
        /// </summary>
        public UserNotification()
        {
            EntityNumber = UserNotification_EntityId;
        }

        /// <summary>
        /// Gets or sets the user notification id.
        /// </summary>
        /// <value>The user notification id.</value>
        public Int32 UserNotificationId
        {
            get { return _userNotificationId; }
            set { SetProperty(ref _userNotificationId, value); }
        }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public Int32 UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        /// <summary>
        /// Gets or sets the date posted.
        /// </summary>
        /// <value>The date posted.</value>
        public DateTime DatePosted
        {
            get { return _datePosted; }
            set { SetProperty(ref _datePosted, value); }
        }

        /// <summary>
        /// Gets or sets the date read.
        /// </summary>
        /// <value>The date read.</value>
        public DateTime? DateRead
        {
            get { return _dateRead; }
            set { SetProperty(ref _dateRead, value); }
        }


        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>UserNotification.</returns>
        public static UserNotification Build(ITypeReader reader)
        {
            var record = new UserNotification
                {
                    UserNotificationId = reader.GetInt32("UserNotificationID"),
                    UserId = reader.GetInt32("UserID"),
                    DatePosted = reader.GetDate("DatePosted"),
                    DateRead = reader.GetNullDate("DateRead")
                };

            return record;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            if (_userNotificationId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.UserNotification_Update
                                       , _userNotificationId
                                       , _userId
                                       , _datePosted
                                       , _dateRead));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _userNotificationId = Execute(GetCommand(Database.EnterpriseDb, Procedure.UserNotification_Insert
                                                         , _userId
                                                         , _datePosted
                                                         , _dateRead), Convert.ToInt32);
                CacheItem.Clear<UserNotification>();
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.UserNotification_Delete, _userNotificationId));
            CacheItem.Clear<UserNotification>();
        }
    }
}