using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class Address : SqlDataRecord
    {
        #region private variables

        private int _addressID;
        private string _city;
        private Int16 _entityID;
        private int _parentID;
        private string _state;
        private string _street;
        private string _suite;
        private string _zip;

        #endregion

        #region public properties

        public int AddressID
        {
            get { return _addressID; }
            set { SetProperty(ref _addressID, value); }
        }

        public int ParentID
        {
            get { return _parentID; }
            set { SetProperty(ref _parentID, value); }
        }

        public Int16 EntityID
        {
            get { return _entityID; }
            set { SetProperty(ref _entityID, value); }
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
            get { return _zip; }
            set { SetProperty(ref _zip, value); }
        }

        #endregion

        #region public methods

        // Constructor
        public Address()
        {
            EntityNumber = 6;
        }

        public static Address Build(ITypeReader reader)
        {
            var record = new Address
                {
                    AddressID = reader.GetInt32("AddressID"),
                    ParentID = reader.GetInt32("ParentID"),
                    EntityID = reader.GetInt16("EntityID"),
                    Street = reader.GetString("Address"),
                    Suite = reader.GetString("Suite"),
                    City = reader.GetString("City"),
                    State = reader.GetString("State"),
                    ZipCode = reader.GetString("Zip")
                };

            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (AddressID != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Address_Update
                                       , _addressID
                                       , _parentID
                                       , _entityID
                                       , _street
                                       , _suite
                                       , _city
                                       , _state
                                       , _zip));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _addressID = Execute(GetCommand(Database.EnterpriseDb, Procedure.Address_Insert
                                                , _parentID
                                                , _entityID
                                                , _street
                                                , _suite
                                                , _city
                                                , _state
                                                , _zip), Convert.ToInt32);
                CacheItem.Clear<Address>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Address_Delete, _addressID));
            CacheItem.Clear<Address>();
        }

        #endregion'



    }
}