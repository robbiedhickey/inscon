using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface ICommentService
    {
        [OperationContract]
        List<Comment> GetAllComments();

        [OperationContract]
        Comment GetCommentById(int id);

        [OperationContract]
        Comment GetCommentByParentIdAndEntityID(int parentID, Int16 entityID);

        [OperationContract]
        void DeleteRecord(Comment comment);

        [OperationContract]
        int SaveRecord(Comment comment);
    }
}
