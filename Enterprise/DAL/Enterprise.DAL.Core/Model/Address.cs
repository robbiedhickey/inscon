using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{

    public class Address : SqlDataRecord
    {
        #region private variables

        private int _idAddress;
        private int _idAddressLocation;
        private string _street;
        private string _suite;
        private string _city;
        private string _state;
        private string _zipCode;
        private Guid _objectID;

        #endregion

        #region public properties

        public int idAddress
        {
            get { return _idAddress; }
            set { SetProperty(ref _idAddress, value); }
        }

        public int idAddressLocation
        {
            get { return _idAddressLocation; }
            set { SetProperty(ref _idAddressLocation, value); }
        }

        public string Street
        {
            get { return _street; }
            set { SetProperty(ref _street, value); }
        }

        public string Suite
        {
            get { return _suite; }
            set { SetProperty(ref _suite, value); }
        }

        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }

        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }

        public string ZipCode
        {
            get { return _zipCode; }
            set { SetProperty(ref _zipCode, value); }
        }

        public Guid ObjectID
        {
            get { return _objectID; }
            set { SetProperty(ref _objectID, value); }
        }

        #endregion

        #region public methods


        public static Address Build(ITypeReader reader)
        {
            var record = new Address
                {
                    idAddress = reader.GetInt32("idAddress"),
                    idAddressLocation = reader.GetInt32("idAddressLocation"),
                    Street = reader.GetString("Address"),
                    Suite = reader.GetString("Suite"),
                    City = reader.GetString("City"),
                    State = reader.GetString("State"),
                    ZipCode = reader.GetString("Zip")
                };

            return record;
        }

        /// <summary>
        /// Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (idAddress != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressUpdate
                                       , _idAddress
                                       , _idAddressLocation
                                       , _objectID
                                       , _street
                                       , _suite
                                       , _city
                                       , _state
                                       , _zipCode));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _idAddress = Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressInsert
                                       , _idAddressLocation
                                       , _objectID
                                       , _street
                                       , _suite
                                       , _city
                                       , _state
                                       , _zipCode), Convert.ToInt32);
            }
        }

        /// <summary>
        /// Removes current record using ID
        ///  </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressDelete, _idAddress));
        }

        #endregion
    }
}