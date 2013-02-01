using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.CommentService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class CommentService : ICommentService
    {
        public List<Comment> GetAllComments()
        {
            throw new NotImplementedException();
        }

        public Comment GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public Comment GetCommentByParentIdAndEntityID(int parentID, short entityID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Comment comment)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
