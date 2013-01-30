// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="UserAreaCoverage.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class UserAreaCoverage
    /// </summary>
    public class UserAreaCoverage : ModelBase
    {
        /// <summary>
        ///     The _service id
        /// </summary>
        private int _serviceId;

        /// <summary>
        ///     The _user area coverage id
        /// </summary>
        private int _userAreaCoverageId;

        /// <summary>
        ///     The _user id
        /// </summary>
        private int _userId;

        /// <summary>
        ///     The _zip code
        /// </summary>
        private string _zipCode;

        /// <summary>
        ///     Initializes a new instance of the <see cref="UserAreaCoverage" /> class.
        /// </summary>
        public UserAreaCoverage()
        {
            EntityNumber = UserAreaCoverage_EntityId;
        }


        /// <summary>
        ///     Gets or sets the user area coverage id.
        /// </summary>
        /// <value>The user area coverage id.</value>
        public Int32 UserAreaCoverageId
        {
            get { return _userAreaCoverageId; }
            set { SetProperty(ref _userAreaCoverageId, value); }
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
        ///     Gets or sets the zip code.
        /// </summary>
        /// <value>The zip code.</value>
        public String ZipCode
        {
            get { return _zipCode; }
            set { SetProperty(ref _zipCode, value); }
        }

        /// <summary>
        ///     Gets or sets the service id.
        /// </summary>
        /// <value>The service id.</value>
        public Int32 ServiceId
        {
            get { return _serviceId; }
            set { SetProperty(ref _serviceId, value); }
        }
    }
}