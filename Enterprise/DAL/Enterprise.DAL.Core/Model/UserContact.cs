using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class UserContact : SqlDataRecord
    {
        private bool _isPrimary;
        private int _typeId;
        private int _userContactId;
        private int _userId;
        private string _value;

        public UserContact()
        {
            EntityNumber = 18;
        }

        public Int32 UserContactId
        {
            get { return _userContactId; }
            set { _userContactId = value; }
        }

        public Int32 UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public String Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Int32 TypeId
        {
            get { return _typeId; }
            set { _typeId = value; }
        }

        public Boolean IsPrimary
        {
            get { return _isPrimary; }
            set { _isPrimary = value; }
        }

        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeId).Value; }
        }

        public static UserContact Build(ITypeReader reader)
        {
            var record = new UserContact
                {
                    UserContactId = reader.GetInt32("UserContactID"),
                    UserId = reader.GetInt32("UserID"),
                    Value = reader.GetString("Value"),
                    TypeId = reader.GetInt32("TypeID"),
                    IsPrimary = reader.GetBool("IsPrimary")
                };
            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_userContactId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Update
                                       , _userContactId
                                       , _userId
                                       , _value
                                       , _typeId
                                       , _isPrimary));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _userContactId = Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Insert
                                                    , _userId
                                                    , _value
                                                    , _typeId
                                                    , _isPrimary), Convert.ToInt32);
                CacheItem.Clear<UserContact>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Delete, _userContactId));
            CacheItem.Clear<UserContact>();
        }
    }
}