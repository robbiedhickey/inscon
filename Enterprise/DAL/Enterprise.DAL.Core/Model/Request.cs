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
        /// Gets or sets the request ID.
        /// </summary>
        /// <value>The request ID.</value>
        public Int32 RequestID
        {
            get { return _requestId; }
            set { SetProperty(ref _requestId, value); }
        }

        /// <summary>
        /// Gets or sets the organization ID.
        /// </summary>
        /// <value>The organization ID.</value>
        public Int32 OrganizationID
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
        /// Gets or sets the customer request ID.
        /// </summary>
        /// <value>The customer request ID.</value>
        public String CustomerRequestID
        {
            get { return _customerRequestId; }
            set { SetProperty(ref _customerRequestId, value); }
        }

        #region public methods

        /// <summary>
        /// Initializes a new instance of the <see cref="Request"/> class.
        /// </summary>
        public Request()
        {
            EntityNumber = Request_EntityId;
        }

        #endregion
    }
}