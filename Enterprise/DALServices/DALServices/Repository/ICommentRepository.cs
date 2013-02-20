using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface ICommentRepository
    {
        List<Comment> GetAllComments();
        Comment GetCommentById(int id);
        Comment GetCommentByParentIdAndEntityID(int parentId, Int16 entityId);
        void DeleteRecord(Comment comment);
        int SaveRecord(Comment comment);
    }
}
