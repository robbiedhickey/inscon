// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="AddressLocation.cs" company="Mortgage Specialist International, LLC">
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
    /// Class AddressLocation
    /// </summary>
    public class AddressLocation : ModelBase
    {
        /// <summary>
        /// The _address ID
        /// </summary>
        private int _addressID;

        /// <summary>
        /// The _building number
        /// </summary>
        private string _buildingNumber;

        /// <summary>
        /// The _city
        /// </summary>
        private string _city;

        /// <summary>
        /// The _geo code
        /// </summary>
        private string _geoCode;

        /// <summary>
        /// The _lattitude
        /// </summary>
        private float _lattitude;

        /// <summary>
        /// The _longitude
        /// </summary>
        private float _longitude;

        /// <summary>
        /// The _state
        /// </summary>
        private string _state;

        /// <summary>
        /// The _street name
        /// </summary>
        private string _streetName;

        /// <summary>
        /// The _zip
        /// </summary>
        private string _zip;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressLocation"/> class.
        /// </summary>
        public AddressLocation()
        {
            EntityNumber = AddressLocation_EntityId;
        }

        /// <summary>
        /// Gets or sets the address ID.
        /// </summary>
        /// <value>The address ID.</value>
        public Int32 AddressID
        {
            get { return _addressID; }
            set { SetProperty(ref _addressID, value); }
        }

        /// <summary>
        /// Gets or sets the building number.
        /// </summary>
        /// <value>The building number.</value>
        public String BuildingNumber
        {
            get { return _buildingNumber; }
            set { SetProperty(ref _buildingNumber, value); }
        }

        /// <summary>
        /// Gets or sets the name of the street.
        /// </summary>
        /// <value>The name of the street.</value>
        public String StreetName
        {
            get { return _streetName; }
            set { SetProperty(ref _streetName, value); }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public String City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public String State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>The zip.</value>
        public String Zip
        {
            get { return _zip; }
            set { SetProperty(ref _zip, value); }
        }

        /// <summary>
        /// Gets or sets the geo code.
        /// </summary>
        /// <value>The geo code.</value>
        public String GeoCode
        {
            get { return _geoCode; }
            set { SetProperty(ref _geoCode, value); }
        }

        /// <summary>
        /// Gets or sets the lattitude.
        /// </summary>
        /// <value>The lattitude.</value>
        public float Lattitude
        {
            get { return _lattitude; }
            set { SetProperty(ref _lattitude, value); }
        }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>The longitude.</value>
        public float Longitude

        {
            get { return _longitude; }
            set { SetProperty(ref _longitude, value); }
        }

        #region public methods

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>AddressLocation.</returns>
        public static AddressLocation Build(ITypeReader reader)
        {
            var record = new AddressLocation
                {
                    AddressID = reader.GetInt32("AddressID"),
                    BuildingNumber = reader.GetString("BuildingNumber"),
                    StreetName = reader.GetString("StreetName"),
                    City = reader.GetString("City"),
                    State = reader.GetString("State"),
                    Zip = reader.GetString("Zip"),
                    GeoCode = reader.GetString("GeoCode"),
                    Lattitude = reader.GetFloat("Lattitude"),
                    Longitude = reader.GetFloat("Longitude")
                };

            return record;
        }


        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            if (_addressID != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressLocation_Update
                                       , _addressID
                                       , _buildingNumber
                                       , _streetName
                                       , _city
                                       , _state
                                       , _zip
                                       , _geoCode
                                       , _lattitude
                                       , _longitude));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _addressID = Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressLocation_Insert
                                                , _addressID
                                                , _buildingNumber
                                                , _streetName
                                                , _city
                                                , _state
                                                , _zip
                                                , _geoCode
                                                , _lattitude
                                                , _longitude), Convert.ToInt32);
                CacheItem.Clear<AddressLocation>();
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressLocation_Delete, _addressID));
            CacheItem.Clear<AddressLocation>();
        }

        #endregion
    }
}