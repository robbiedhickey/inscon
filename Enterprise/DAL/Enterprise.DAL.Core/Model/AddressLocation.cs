using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class AddressLocation : ModelBase
    {
        private int _addressID;
        private string _buildingNumber;
        private string _city;
        private string _geoCode;
        private float _lattitude;
        private float _longitude;
        private string _state;
        private string _streetName;
        private string _zip;

        public AddressLocation()
        {
            EntityNumber = (short) Entities.AddressLocation;
        }

        public Int32 AddressID
        {
            get { return _addressID; }
            set { SetProperty(ref _addressID, value); }
        }

        public String BuildingNumber
        {
            get { return _buildingNumber; }
            set { SetProperty(ref _buildingNumber, value); }
        }

        public String StreetName
        {
            get { return _streetName; }
            set { SetProperty(ref _streetName, value); }
        }

        public String City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }

        public String State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }

        public String Zip
        {
            get { return _zip; }
            set { SetProperty(ref _zip, value); }
        }

        public String GeoCode
        {
            get { return _geoCode; }
            set { SetProperty(ref _geoCode, value); }
        }

        public float Lattitude
        {
            get { return _lattitude; }
            set { SetProperty(ref _lattitude, value); }
        }

        public float Longitude

        {
            get { return _longitude; }
            set { SetProperty(ref _longitude, value); }
        }

        #region public methods

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
        ///     Insert a new record, or update the current record using ID
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
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressLocation_Delete, _addressID));
            CacheItem.Clear<AddressLocation>();
        }

        #endregion
    }
}