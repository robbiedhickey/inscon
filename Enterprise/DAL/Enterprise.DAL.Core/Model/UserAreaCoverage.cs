using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class UserAreaCoverage : ModelBase
    {
        private int _serviceId;
        private int _userAreaCoverageId;
        private int _userId;
        private string _zipCode;

        public UserAreaCoverage()
        {
            EntityNumber = (short) Entities.UserAreaCoverage;
        }

        public Int32 UserAreaCoverageId
        {
            get { return _userAreaCoverageId; }
            set { SetProperty(ref _userAreaCoverageId, value); }
        }

        public Int32 UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        public String ZipCode
        {
            get { return _zipCode; }
            set { SetProperty(ref _zipCode, value); }
        }

        public Int32 ServiceId
        {
            get { return _serviceId; }
            set { SetProperty(ref _serviceId, value); }
        }


        public static UserAreaCoverage Build(ITypeReader reader)
        {
            var record = new UserAreaCoverage
                {
                    UserAreaCoverageId = reader.GetInt32("UserAreaCoverageID"),
                    UserId = reader.GetInt32("UserID"),
                    ZipCode = reader.GetString("ZipCode"),
                    ServiceId = reader.GetInt32("ServiceID")
                };
            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_userAreaCoverageId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.UserAreaCoverage_Update
                                       , _userAreaCoverageId
                                       , _userId
                                       , _zipCode
                                       , _serviceId));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _userAreaCoverageId = Execute(GetCommand(Database.EnterpriseDb, Procedure.UserAreaCoverage_Insert
                                                         , _userId
                                                         , _zipCode
                                                         , _serviceId), Convert.ToInt32);
                CacheItem.Clear<UserAreaCoverage>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.UserAreaCoverage_Delete, _userAreaCoverageId));
            CacheItem.Clear<UserAreaCoverage>();
        }
    }
}