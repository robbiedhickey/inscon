using Enterprise.DAL.Core.Model;
using System.Collections.Generic;
using dbSvc = Enterprise.DAL.Core.Service.FileService;

namespace Enterprise.ApiServices.DALServices.Repository
{
    public class FileRepository : IFileRepository
    {
        public List<File> GetAllFiles()
        {
            return new dbSvc().GetAllFiles();
        }

        public File GetFileById(int id)
        {
            return new dbSvc().GetFileById(id);
        }

        public File GetFileByParentIdAndEntityID(int parentId, short entityId)
        {
            return new dbSvc().GetFileByParentIdAndEntityID(parentId, entityId);
        }

        public void DeleteRecord(File file)
        {
            new dbSvc().DeleteRecord(file);
        }

        public int SaveRecord(File file)
        {
            return new dbSvc().SaveRecord(file);
        }
    }
}