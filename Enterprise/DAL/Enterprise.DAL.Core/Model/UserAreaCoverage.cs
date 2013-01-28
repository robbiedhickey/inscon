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
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class UserAreaCoverage
    /// </summary>
    public class UserAreaCoverage : ModelBase
    {
        /// <summary>
        /// The _service id
        /// </summary>
        private int _serviceId;

        /// <summary>
        /// The _user area coverage id
        /// </summary>
        private int _userAreaCoverageId;

        /// <summary>
        /// The _user id
        /// </summary>
        private int _userId;

        /// <summary>
        /// The _zip code
        /// </summary>
        private string _zipCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAreaCoverage"/> class.
        /// </summary>
        public UserAreaCoverage()
        {
            EntityNumber = UserAreaCoverage_EntityId;
        }

        /// <summary>
        /// Gets or sets the user area coverage id.
        /// </summary>
        /// <value>The user area coverage id.</value>
        public Int32 UserAreaCoverageId
        {
            get { return _userAreaCoverageId; }
            set { SetProperty(ref _userAreaCoverageId, value); }
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
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>The zip code.</value>
        public String ZipCode
        {
            get { return _zipCode; }
            set { SetProperty(ref _zipCode, value); }
        }

        /// <summary>
        /// Gets or sets the service id.
        /// </summary>
        /// <value>The service id.</value>
        public Int32 ServiceId
        {
            get { return _serviceId; }
            set { SetProperty(ref _serviceId, value); }
        }


        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>UserAreaCoverage.</returns>
        public static UserAreaCoverage Build(ITypeReader reader)
        {
            var record = new UserAreaCoverage
                {
                    UserAreaCoverageId = reader.GetInt32("UserAreaCoverageID"),
                    UserId = reader.GetInt32("UserID"),
                    ZipCode = reader.GetString("ZipCode"),
                    ServiceId = reader.GetInt32("ServiceID")
                };
            return record;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            if (_userAreaCoverageId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.UserAreaCoverage_Update
                                       , _userAreaCoverageId
                                       , _userId
                                       , _zipCode
                                       , _serviceId));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _userAreaCoverageId = Execute(GetCommand(Database.EnterpriseDb, Procedure.UserAreaCoverage_Insert
                                                         , _userId
                                                         , _zipCode
                                                         , _serviceId), Convert.ToInt32);
                CacheItem.Clear<UserAreaCoverage>();
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.UserAreaCoverage_Delete, _userAreaCoverageId));
            CacheItem.Clear<UserAreaCoverage>();
        }
    }
}