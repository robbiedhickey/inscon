﻿// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="WorkOrderAssignment.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class WorkOrderAssignment
    /// </summary>
    public class WorkOrderAssignment : ModelBase
    {
        /// <summary>
        ///     The _event date
        /// </summary>
        private DateTime _eventDate;

        /// <summary>
        ///     The _status id
        /// </summary>
        private int _statusId;

        /// <summary>
        ///     The _user id
        /// </summary>
        private int _userId;

        /// <summary>
        ///     The _work order assignment id
        /// </summary>
        private int _workOrderAssignmentId;

        /// <summary>
        ///     The _work order id
        /// </summary>
        private int _workOrderId;

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkOrderAssignment" /> class.
        /// </summary>
        public WorkOrderAssignment()
        {
            EntityNumber = WorkOrderAssignment_EntityId;
        }


        /// <summary>
        ///     Gets or sets the work order assignment id.
        /// </summary>
        /// <value>The work order assignment id.</value>
        public Int32 WorkOrderAssignmentID
        {
            get { return _workOrderAssignmentId; }
            set { SetProperty(ref _workOrderAssignmentId, value); }
        }

        /// <summary>
        ///     Gets or sets the work order id.
        /// </summary>
        /// <value>The work order id.</value>
        public Int32 WorkOrderID
        {
            get { return _workOrderId; }
            set { SetProperty(ref _workOrderId, value); }
        }

        /// <summary>
        ///     Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public Int32 UserID
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        /// <summary>
        ///     Gets or sets the event date.
        /// </summary>
        /// <value>The event date.</value>
        public DateTime EventDate
        {
            get { return _eventDate; }
            set { SetProperty(ref _eventDate, value); }
        }

        /// <summary>
        ///     Gets or sets the status id.
        /// </summary>
        /// <value>The status id.</value>
        public Int32 StatusID
        {
            get { return _statusId; }
            set { SetProperty(ref _statusId, value); }
        }
    }
}