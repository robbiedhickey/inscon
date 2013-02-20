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
    /// Class UserNotification
    /// </summary>
    public class UserNotification : ModelBase<UserNotification>
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
        /// Gets or sets the user notification ID.
        /// </summary>
        /// <value>The user notification ID.</value>
        public Int32 UserNotificationID
        {
            get { return _userNotificationId; }
            set { SetProperty(ref _userNotificationId, value); }
        }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        /// <value>The user ID.</value>
        public Int32 UserID
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
    }
}