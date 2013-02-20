using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.CommentService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class CommentRepository : ICommentRepository
    {
        public List<Comment> GetAllComments()
        {
            return new dbSvc().GetAllComments();
        }

        public Comment GetCommentById(int id)
        {
            return new dbSvc().GetCommentById(id);
        }

        public Comment GetCommentByParentIdAndEntityID(int parentId, short entityId)
        {
            return new dbSvc().GetCommentByParentIdAndEntityID(parentId, entityId);
        }

        public bool DeleteRecord(Comment comment)
        {
            return new dbSvc().DeleteRecord(comment);
        }

        public int SaveRecord(Comment comment)
        {
            return new dbSvc().SaveRecord(comment);
        }
    }
}