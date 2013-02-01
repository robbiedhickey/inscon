using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.FileService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    public class FileService : IFileService
    {
        public List<File> GetAllFiles()
        {
            throw new NotImplementedException();
        }

        public File GetFileById(int id)
        {
            throw new NotImplementedException();
        }

        public File GetFileByParentIdAndEntityID(int parentID, short entityID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(File file)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(File file)
        {
            throw new NotImplementedException();
        }
    }
}
