using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class CommentService : ServiceBase<Comment>
    {

        /// <summary>
        /// Get all Comment records
        /// </summary>
        /// <returns></returns>
        public List<Comment> GetAllComments()
        {
            return QueryAll(SqlDatabase, Procedure.Comment_SelectAll, Comment.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get Comment record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Comment GetCommentById(int id)
        {
            if (IsCached)
            {
                Predicate<Comment> h = h2 => h2.CommentId == id;
                return GetAllComments().Find(h) ?? new Comment();
            }

            return Query(SqlDatabase, Procedure.Comment_SelectById, Comment.Build, id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="entityID"></param>
        /// <returns></returns>
        public Comment GetCommentByParentIdAndEntityID(int parentID, Int16 entityID)
        {
            if (IsCached)
            {
                Predicate<Comment> h = h2 => h2.ParentId == parentID && h2.EntityId == entityID;
                return GetAllComments().Find(h) ?? new Comment();
            }

            return Query(SqlDatabase, Procedure.Comment_SelectByParentIdAndEntityId, Comment.Build, parentID, entityID);
        }
    }
}
