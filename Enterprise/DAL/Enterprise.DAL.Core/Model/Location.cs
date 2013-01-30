// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Location.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class Location
    /// </summary>
    public class Location : ModelBase
    {
        /// <summary>
        ///     The _code
        /// </summary>
        private string _code;

        /// <summary>
        ///     The _location id
        /// </summary>
        private int _locationId;

        /// <summary>
        ///     The _name
        /// </summary>
        private string _name;

        /// <summary>
        ///     The _organization id
        /// </summary>
        private int _organizationId;

        /// <summary>
        ///     The _type id
        /// </summary>
        private int _typeId;


        /// <summary>
        ///     Gets or sets the location id.
        /// </summary>
        /// <value>The location id.</value>
        public Int32 LocationId
        {
            get { return _locationId; }
            set { SetProperty(ref _locationId, value); }
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
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public String Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        ///     Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        public String Code
        {
            get { return _code; }
            set { SetProperty(ref _code, value); }
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

        #region public methods

        /// <summary>
        ///     Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        public Location()
        {
            EntityNumber = Location_EntityId;
        }

        #endregion
    }
}