using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class Location : ModelBase
    {
        private string _code;
        private int _locationId;
        private string _name;
        private int _organizationId;
        private int _typeId;

        public Location()
        {
            EntityNumber = (short) Entities.AddressLocation;
        }

        public Int32 LocationId
        {
            get { return _locationId; }
            set { SetProperty(ref _locationId, value); }
        }

        public Int32 OrganizationId
        {
            get { return _organizationId; }
            set { SetProperty(ref _organizationId, value); }
        }

        public String Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public String Code
        {
            get { return _code; }
            set { SetProperty(ref _code, value); }
        }

        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        #region public methods

        public static Location Build(ITypeReader reader)
        {
            var record = new Location
                {
                    LocationId = reader.GetInt32("LocationID"),
                    OrganizationId = reader.GetInt32("OrganizationID"),
                    Name = reader.GetString("Name"),
                    Code = reader.GetString("Code"),
                    TypeId = reader.GetInt32("TypeID")
                };

            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_locationId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Location_Update
                                       , _locationId
                                       , _organizationId
                                       , _name
                                       , _code
                                       , _typeId));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _locationId = Execute(GetCommand(Database.EnterpriseDb, Procedure.Location_Insert
                                                 , _organizationId
                                                 , _name
                                                 , _code
                                                 , _typeId), Convert.ToInt32);
                CacheItem.Clear<Location>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Location_Delete, _locationId));
            CacheItem.Clear<Location>();
        }

        #endregion
    }
}