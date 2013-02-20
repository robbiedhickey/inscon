using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public interface IFileRepository
    {
        List<File> GetAllFiles();
        File GetFileById(Int32 id);
        File GetFileByParentIdAndEntityID(Int32 parentId, Int16 entityId);
        void DeleteRecord(File file);
        int SaveRecord(File file);
    }
}
