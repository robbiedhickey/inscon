﻿using System.Collections.Generic;
using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Framework.Data;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Core.Type;


namespace Enterprise.DAL.Core.Model
{
    [Serializable]
    public class Organization : SqlDataRecord
    {

        #region private variables

        private int _idOrganization;
        private string _organizationName;
        private string _organizationCode;
        private int _idType;
        private int _idStatus;
        private Guid _objectID;

        private List<User> _users;

            #endregion

        #region public properties


        public int idOrganization
        {
            get { return _idOrganization; }
            set { SetProperty(ref _idOrganization, value); }
        }


        public string Name
        {
            get { return _organizationName; }
            set { SetProperty(ref _organizationName, value); }
        }

        public string Code
        {
            get { return _organizationCode; }
            set { SetProperty(ref _organizationCode, value); }
        }

        public int idType
        {
            get { return _idType; }
            set { SetProperty(ref _idType, value); }
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

        public string Type
        {
            get { return new LookupService().GetLookupById(_idType).Caption; }
        }
      

        public List<User> Users
        {
            get
            {
                if (_users != null)
                {
                    return _users;
                }
                _users = new UserService().GetUserByOrganizationId(_idOrganization);
                return _users;
            }
        }

        #endregion

        #region public methods

        public static Organization Build(ITypeReader reader)
        {
            var record = new Organization
                {
                    idOrganization = reader.GetInt("idOrganization"),
                    Name = reader.GetString("Name"),
                    Code = reader.GetString("Code"),
                    idType = reader.GetInt("idType"),
                    idStatus = reader.GetInt("idStatus"),
                    ObjectID = reader.GetGuid("ObjectID")
                };

            return record;
        }

       

        /// <summary>
        /// Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_idOrganization != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.OrganizationUpdate
                                       , _idOrganization
                                       , _organizationName
                                       , _organizationCode
                                       , _idType
                                       , _idStatus
                                       , _objectID));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _idOrganization = Execute(GetCommand(Database.EnterpriseDb, Procedure.OrganizationInsert
                                       , _organizationName
                                       , _organizationCode
                                       , _idType
                                       , _idStatus
                                       , _objectID), Convert.ToInt32);
                CacheItem.Clear<Organization>();
            }
        }

        /// <summary>
        /// Removes current record using ID
        ///  </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.OrganizationDelete, _idOrganization));
            CacheItem.Clear<Organization>();
        }

        #endregion
    }
}