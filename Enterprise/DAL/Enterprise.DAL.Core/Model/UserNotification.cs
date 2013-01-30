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

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class UserNotification
    /// </summary>
    public class UserNotification : ModelBase
    {
        /// <summary>
        ///     The _date posted
        /// </summary>
        private DateTime _datePosted;

        /// <summary>
        ///     The _date read
        /// </summary>
        private DateTime? _dateRead;

        /// <summary>
        ///     The _user id
        /// </summary>
        private int _userId;

        /// <summary>
        ///     The _user notification id
        /// </summary>
        private int _userNotificationId;

        /// <summary>
        ///     Initializes a new instance of the <see cref="UserNotification" /> class.
        /// </summary>
        public UserNotification()
        {
            EntityNumber = UserNotification_EntityId;
        }


        /// <summary>
        ///     Gets or sets the user notification id.
        /// </summary>
        /// <value>The user notification id.</value>
        public Int32 UserNotificationId
        {
            get { return _userNotificationId; }
            set { SetProperty(ref _userNotificationId, value); }
        }

        /// <summary>
        ///     Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public Int32 UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        /// <summary>
        ///     Gets or sets the date posted.
        /// </summary>
        /// <value>The date posted.</value>
        public DateTime DatePosted
        {
            get { return _datePosted; }
            set { SetProperty(ref _datePosted, value); }
        }

        /// <summary>
        ///     Gets or sets the date read.
        /// </summary>
        /// <value>The date read.</value>
        public DateTime? DateRead
        {
            get { return _dateRead; }
            set { SetProperty(ref _dateRead, value); }
        }
    }
}