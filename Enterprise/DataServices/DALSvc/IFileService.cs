using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface IFileService
    {
        [OperationContract]
        List<File> GetAllFiles();

        [OperationContract]
        File GetFileById(Int32 id);

        [OperationContract]
        File GetFileByParentIdAndEntityID(Int32 parentID, Int16 entityID);

        [OperationContract]
        void DeleteRecord(File file);

        [OperationContract]
        int SaveRecord(File file);
    }
}
