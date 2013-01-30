// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Event.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Enterprise.DAL.Core.Service;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class Event
    /// </summary>
    public class Event : ModelBase
    {
        /// <summary>
        ///     The _date
        /// </summary>
        private DateTime _date;

        /// <summary>
        ///     The _entity id
        /// </summary>
        private short _entityId;

        /// <summary>
        ///     The _event id
        /// </summary>
        private int _eventId;

        /// <summary>
        ///     The _parent id
        /// </summary>
        private int _parentId;

        /// <summary>
        ///     The _type id
        /// </summary>
        private int _typeId;

        /// <summary>
        ///     The _user id
        /// </summary>
        private int _userId;


        /// <summary>
        ///     Gets or sets the event id.
        /// </summary>
        /// <value>The event id.</value>
        public Int32 EventId
        {
            get { return _eventId; }
            set { SetProperty(ref _eventId, value); }
        }

        /// <summary>
        ///     Gets or sets the parent id.
        /// </summary>
        /// <value>The parent id.</value>
        public Int32 ParentId
        {
            get { return _parentId; }
            set { SetProperty(ref _parentId, value); }
        }

        /// <summary>
        ///     Gets or sets the entity id.
        /// </summary>
        /// <value>The entity id.</value>
        public Int16 EntityId
        {
            get { return _entityId; }
            set { SetProperty(ref _entityId, value); }
        }

        /// <summary>
        ///     Gets or sets the type id.
        /// </summary>
        /// <value>The type id.</value>
        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
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
        ///     Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeId).Value; }
        }

        #region public methods

        /// <summary>
        ///     Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        public Event()
        {
            EntityNumber = Event_EntityId;
        }

        #endregion
    }
}