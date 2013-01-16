using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class UserNotification : SqlDataRecord
    {
        private DateTime _datePosted;
        private DateTime? _dateRead;
        private int _userId;
        private int _userNotificationId;

        public UserNotification()
        {
            EntityNumber = 16;
        }

        public Int32 UserNotificationId
        {
            get { return _userNotificationId; }
            set { _userNotificationId = value; }
        }

        public Int32 UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public DateTime DatePosted
        {
            get { return _datePosted; }
            set { _datePosted = value; }
        }

        public DateTime? DateRead
        {
            get { return _dateRead; }
            set { _dateRead = value; }
        }


        public static UserNotification Build(ITypeReader reader)
        {
            var record = new UserNotification
                {
                    UserNotificationId = reader.GetInt32("UserNotificationID"),
                    UserId = reader.GetInt32("UserID"),
                    DatePosted = reader.GetDate("DatePosted"),
                    DateRead = reader.GetNullDate("DateRead")
                };

            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_userNotificationId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.UserNotification_Update
                                       , _userNotificationId
                                       , _userId
                                       , _datePosted
                                       , _dateRead));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _userNotificationId = Execute(GetCommand(Database.EnterpriseDb, Procedure.UserNotification_Insert
                                                         , _userId
                                                         , _datePosted
                                                         , _dateRead), Convert.ToInt32);
                CacheItem.Clear<UserNotification>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.UserNotification_Delete, _userNotificationId));
            CacheItem.Clear<UserNotification>();
        }
    }
}