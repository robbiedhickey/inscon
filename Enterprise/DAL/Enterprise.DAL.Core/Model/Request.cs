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
    ///     Class Request
    /// </summary>
    public class Request : ModelBase
    {
        /// <summary>
        ///     The _customer request id
        /// </summary>
        private string _customerRequestId;

        /// <summary>
        ///     The _date inserted
        /// </summary>
        private DateTime _dateInserted;

        /// <summary>
        ///     The _organization id
        /// </summary>
        private int _organizationId;

        /// <summary>
        ///     The _request id
        /// </summary>
        private int _requestId;


        /// <summary>
        ///     Gets or sets the request id.
        /// </summary>
        /// <value>The request id.</value>
        public Int32 RequestId
        {
            get { return _requestId; }
            set { SetProperty(ref _requestId, value); }
        }

        /// <summary>
        ///     Gets or sets the organization id.
        /// </summary>
        /// <value>The organization id.</value>
        public Int32 OrganizationId
        {
            get { return _organizationId; }
            set { SetProperty(ref _organizationId, value); }
        }

        /// <summary>
        ///     Gets or sets the date inserted.
        /// </summary>
        /// <value>The date inserted.</value>
        public DateTime DateInserted
        {
            get { return _dateInserted; }
            set { SetProperty(ref _dateInserted, value); }
        }

        /// <summary>
        ///     Gets or sets the customer request id.
        /// </summary>
        /// <value>The customer request id.</value>
        public String CustomerRequestId
        {
            get { return _customerRequestId; }
            set { SetProperty(ref _customerRequestId, value); }
        }

        #region public methods

        /// <summary>
        ///     Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        public Request()
        {
            EntityNumber = Request_EntityId;
        }

        #endregion
    }
}