using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class Comment : SqlDataRecord
    {
        private String _comment;
        private Int32 _commentId;
        private Int16 _entityId;
        private Int32 _parentId;
        private Int32 _typeId;
        private Int32 _userId;

        public Comment()
        {
            EntityNumber = 7;
        }

        public Int32 CommentId
        {
            get { return _commentId; }
            set { SetProperty(ref _commentId, value); }
        }

        public Int32 ParentId
        {
            get { return _parentId; }
            set { SetProperty(ref _parentId, value); }
        }

        public Int16 EntityId
        {
            get { return _entityId; }
            set { SetProperty(ref _entityId, value); }
        }

        public Int32 UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        public String Value
        {
            get { return _comment; }
            set { SetProperty(ref _comment, value); }
        }

        #region public methods

        public static Comment Build(ITypeReader reader)
        {
            var record = new Comment
                {
                    CommentId = reader.GetInt32("CommentID"),
                    ParentId = reader.GetInt32("ParentID"),
                    EntityId = reader.GetInt16("EntityId"),
                    UserId = reader.GetInt32("UserID"),
                    TypeId = reader.GetInt32("TypeID"),
                    Value = reader.GetString("Comment")
                };

            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_commentId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Comment_Update
                                       , _commentId
                                       , _parentId
                                       , _entityId
                                       , _userId
                                       , _typeId
                                       , _comment));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _commentId = Execute(GetCommand(Database.EnterpriseDb, Procedure.Comment_Insert
                                        , _parentId
                                        , _entityId
                                        , _userId
                                        , _typeId
                                        , _comment), Convert.ToInt32);
                CacheItem.Clear<Comment>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Comment_Delete, _commentId));
            CacheItem.Clear<Comment>();
        }

        #endregion
    }
}