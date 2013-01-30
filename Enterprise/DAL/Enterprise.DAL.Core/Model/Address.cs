// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Address.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class Address
    /// </summary>
    public class Address : ModelBase
    {
        #region private variables

        /// <summary>
        ///     The _address ID
        /// </summary>
        private int _addressID;

        /// <summary>
        ///     The _city
        /// </summary>
        private string _city;

        /// <summary>
        ///     The _entity ID
        /// </summary>
        private Int16 _entityID;

        /// <summary>
        ///     The _parent ID
        /// </summary>
        private int _parentID;

        /// <summary>
        ///     The _state
        /// </summary>
        private string _state;

        /// <summary>
        ///     The _street
        /// </summary>
        private string _street;

        /// <summary>
        ///     The _suite
        /// </summary>
        private string _suite;

        /// <summary>
        ///     The _zip
        /// </summary>
        private string _zip;

        #endregion

        #region public properties

        /// <summary>
        ///     Gets or sets the address ID.
        /// </summary>
        /// <value>The address ID.</value>
        public int AddressID
        {
            get { return _addressID; }
            set { SetProperty(ref _addressID, value); }
        }

        /// <summary>
        ///     Gets or sets the parent ID.
        /// </summary>
        /// <value>The parent ID.</value>
        public int ParentID
        {
            get { return _parentID; }
            set { SetProperty(ref _parentID, value); }
        }

        /// <summary>
        ///     Gets or sets the entity ID.
        /// </summary>
        /// <value>The entity ID.</value>
        public Int16 EntityID
        {
            get { return _entityID; }
            set { SetProperty(ref _entityID, value); }
        }

        /// <summary>
        ///     Gets or sets the street.
        /// </summary>
        /// <value>The street.</value>
        public string Street
        {
            get { return _street; }
            set { SetProperty(ref _street, value); }
        }

        /// <summary>
        ///     Gets or sets the suite.
        /// </summary>
        /// <value>The suite.</value>
        public string Suite
        {
            get { return _suite; }
            set { SetProperty(ref _suite, value); }
        }

        /// <summary>
        ///     Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }

        /// <summary>
        ///     Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }

        /// <summary>
        ///     Gets or sets the zip code.
        /// </summary>
        /// <value>The zip code.</value>
        public string Zip
        {
            get { return _zip; }
            set { SetProperty(ref _zip, value); }
        }

        #endregion

        #region public methods

        /// <summary>
        ///     Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        public Address()
        {
            EntityNumber = Address_EntityId;
        }

        #endregion'
    }
}