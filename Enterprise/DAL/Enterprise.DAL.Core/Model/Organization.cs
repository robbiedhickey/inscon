using System.Collections.Generic;
using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;
using Enterprise.DAL.Framework.Cache;


namespace Enterprise.DAL.Core.Model
{
    [Serializable]
    public class Organization : SqlDataRecord
    {

        #region private variables

        private int _organizationID;
        private string _name;
        private string _code;
        private int _typeID;
        private int _statusID;
      

        private List<User> _users;

        #endregion

        #region public properties


        public int OrganizationID
        {
            get { return _organizationID; }
            set { SetProperty(ref _organizationID, value); }
        }


        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public string Code
        {
            get { return _code; }
            set { SetProperty(ref _code, value); }
        }

        public int TypeID
        {
            get { return _typeID; }
            set { SetProperty(ref _typeID, value); }
        }

        public int StatusID
        {
            get { return _statusID; }
            set { SetProperty(ref _statusID, value); }
        }

        public string Status
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_statusID).Value; }
        }

        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeID).Value; }
        }
      
        // Constructor
        public Organization()
        {
            EntityNumber = 14;
        }
        public List<User> Users
        {
            get
            {
                if (_users != null)
                {
                    return _users;
                }
                _users = new UserService().GetUsersByOrganizationId(_organizationID);
                return _users;
            }
        }

        #endregion

        #region public methods

        public static Organization Build(ITypeReader reader)
        {
            var record = new Organization
                {
                    OrganizationID = reader.GetInt32("OrganizationID"),
                    Name = reader.GetString("Name"),
                    Code = reader.GetString("Code"),
                    TypeID = reader.GetInt32("TypeID"),
                    StatusID = reader.GetInt32("StatusID")
                };

            return record;
        }

       

        /// <summary>
        /// Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_organizationID != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Organization_Update
                                       , _organizationID
                                       , _name
                                       , _code
                                       , _typeID
                                       , _statusID));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _organizationID = Execute(GetCommand(Database.EnterpriseDb, Procedure.Organization_Insert
                                       , _name
                                       , _code
                                       , _typeID
                                       , _statusID), Convert.ToInt32);
                CacheItem.Clear<Organization>();
            }
        }

        /// <summary>
        /// Removes current record using ID
        ///  </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Organization_Delete, _organizationID));
            CacheItem.Clear<Organization>();
        }

        #endregion
    }
}