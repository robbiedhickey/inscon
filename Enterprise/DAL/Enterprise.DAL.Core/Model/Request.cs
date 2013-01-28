// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Request.cs" company="Mortgage Specialist International, LLC">
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
    /// Class Request
    /// </summary>
    public class Request : ModelBase
    {
        /// <summary>
        /// The _customer request id
        /// </summary>
        private string _customerRequestId;

        /// <summary>
        /// The _date inserted
        /// </summary>
        private DateTime _dateInserted;

        /// <summary>
        /// The _organization id
        /// </summary>
        private int _organizationId;

        /// <summary>
        /// The _request id
        /// </summary>
        private int _requestId;

        /// <summary>
        /// Initializes a new instance of the <see cref="Request"/> class.
        /// </summary>
        public Request()
        {
            EntityNumber = Request_EntityId;
        }

        /// <summary>
        /// Gets or sets the request id.
        /// </summary>
        /// <value>The request id.</value>
        public Int32 RequestId
        {
            get { return _requestId; }
            set { SetProperty(ref _requestId, value); }
        }

        /// <summary>
        /// Gets or sets the organization id.
        /// </summary>
        /// <value>The organization id.</value>
        public Int32 OrganizationId
        {
            get { return _organizationId; }
            set { SetProperty(ref _organizationId, value); }
        }

        /// <summary>
        /// Gets or sets the date inserted.
        /// </summary>
        /// <value>The date inserted.</value>
        public DateTime DateInserted
        {
            get { return _dateInserted; }
            set { SetProperty(ref _dateInserted, value); }
        }

        /// <summary>
        /// Gets or sets the customer request id.
        /// </summary>
        /// <value>The customer request id.</value>
        public String CustomerRequestId
        {
            get { return _customerRequestId; }
            set { SetProperty(ref _customerRequestId, value); }
        }

        #region public methods

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Request.</returns>
        public static Request Build(ITypeReader reader)
        {
            var record = new Request
                {
                    RequestId = reader.GetInt32("RequestID"),
                    OrganizationId = reader.GetInt32("OrganizationID"),
                    DateInserted = reader.GetDate("DateInserted"),
                    CustomerRequestId = reader.GetString("CustomerRequestID")
                };
            return record;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            if (_requestId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Request_Update
                                       , _requestId
                                       , _organizationId
                                       , _dateInserted
                                       , CustomerRequestId));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _requestId = Execute(GetCommand(Database.EnterpriseDb, Procedure.Request_Insert
                                                , _organizationId
                                                , _dateInserted
                                                , CustomerRequestId), Convert.ToInt32);
                CacheItem.Clear<Request>();
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Request_Delete, _requestId));
            CacheItem.Clear<Request>();
        }

        #endregion
    }
}