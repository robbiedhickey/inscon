using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
  
    public class User : SqlDataRecord
    {
        private int _idUser;
        private int _idOrganization;
        private string _firstName;
        private string _lastName;
        private string _title;
        private int _idStatus;
        private Guid _objectID;
        private Organization _organization;

       
        public int idUser
        {
            get { return _idUser; }
            set { SetProperty(ref _idUser, value); }
        }

        public int idOrganization
        {
            get { return _idOrganization; }
            set { SetProperty(ref _idOrganization, value); }
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
       
        public int idStatus
        {
            get { return _idStatus; }
            set { SetProperty(ref _idStatus, value); }
        }

        public Guid ObjectID
        {
            get { return _objectID; }
            set { SetProperty(ref _objectID, value); }

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
                _organization = new OrganizationService().GetOrganizationById(_idOrganization);
                return _organization;
            }
        }
  

        #region public methods
        
        
        public static User Build(ITypeReader reader)
        {

            var record = new User
                {
                    idUser = reader.GetInt32("idUser"),
                    idOrganization = reader.GetInt32("idOrganization"),
                    FirstName = reader.GetString("FirstName"),
                    LastName = reader.GetString("LastName"),
                    idStatus = reader.GetInt32("idStatus"),
                    ObjectID = reader.GetGuid("ObjectID")
                };

            return record;


        }


        /// <summary>
        /// Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_idUser != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.UserUpdate
                                       , _idUser
                                       , _idOrganization
                                       , _firstName
                                       , _lastName
                                       , _title
                                       , _idStatus
                                       , _objectID));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _idUser = Execute(GetCommand(Database.EnterpriseDb, Procedure.UserInsert
                                       , _idOrganization
                                       , _firstName
                                       , _lastName
                                       , _title
                                       , _idStatus
                                       , _objectID), Convert.ToInt32);
                CacheItem.Clear<User>();
            }
        }

        /// <summary>
        /// Removes current record using ID
        ///  </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.UserDelete, _idUser));
            CacheItem.Clear<User>();
        }

        #endregion
    }
}