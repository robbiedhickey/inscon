using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
namespace Enterprise.DAL.Core.Service
{
    public class UserContactService : ServiceBase<UserContact>
    {

        /// <summary>
        /// Get all UserContact records
        /// </summary>
        /// <returns></returns>
        public List<UserContact> GetAllUserContacts()
        {
            return QueryAll(SqlDatabase, Procedure.UserContact_SelectAll, UserContact.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get UserContact record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserContact GetUserContactById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<UserContact> h = h2 => h2.UserContactId == id;
                return GetAllUserContacts().Find(h) ?? new UserContact();
            }

            return Query(SqlDatabase, Procedure.UserContact_SelectById, UserContact.Build, id);
        }

        
        public List<UserContact> GetUserContactsByUserId(Int32 userID)
        {
            if (IsCached)
            {
                Predicate<UserContact> h = h2 => h2.UserId == userID;
                return GetAllUserContacts().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.UserContact_SelectByUserId, UserContact.Build, userID);
        }

        public List<UserContact> GetUserContactsByUserIdAndTypeId(Int32 userID, Int32 typeId)
        {
            if (IsCached)
            {
                Predicate<UserContact> h = h2 => h2.UserId == userID && h2.TypeId == typeId;
                return GetAllUserContacts().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.UserContact_SelectByUserId, UserContact.Build, userID, typeId);
        }
    }
}
