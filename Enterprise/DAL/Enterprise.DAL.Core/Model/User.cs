using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class User : ModelBase
    {
        private string _firstName;
        private string _lastName;
        private Organization _organization;
        private int _organizationID;
        private int _statusID;
        private string _title;
        private int _userID;

        public User()
        {
            EntityNumber = (short) Entities.User;
        }


        public int UserID
        {
            get { return _userID; }
            set { SetProperty(ref _userID, value); }
        }

        public int OrganizationID
        {
            get { return _organizationID; }
            set { SetProperty(ref _organizationID, value); }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }


        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
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

        public string FullName
        {
            get { return string.Format("{0} {1}", _firstName, _lastName); }
        }


        public Organization Organization
        {
            get
            {
                if (_organization != null)
                {
                    return _organization;
                }
                _organization = new OrganizationService().GetOrganizationById(_organizationID);
                return _organization;
            }
        }

        #region public methods

        public static User Build(ITypeReader reader)
        {
            var record = new User
                {
                    UserID = reader.GetInt32("UserID"),
                    OrganizationID = reader.GetInt32("OrganizationID"),
                    FirstName = reader.GetString("FirstName"),
                    LastName = reader.GetString("LastName"),
                    StatusID = reader.GetInt32("StatusID")
                };

            return record;
        }


        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_userID != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.User_Update
                                       , _userID
                                       , _organizationID
                                       , _firstName
                                       , _lastName
                                       , _title
                                       , _statusID));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _userID = Execute(GetCommand(Database.EnterpriseDb, Procedure.User_Insert
                                             , _organizationID
                                             , _firstName
                                             , _lastName
                                             , _title
                                             , _statusID), Convert.ToInt32);
                CacheItem.Clear<User>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.User_Delete, _userID));
            CacheItem.Clear<User>();
        }

        #endregion
    }
}