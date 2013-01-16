using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;


namespace Enterprise.DAL.Core.Service
{
    public class FileService : ServiceBase<File>
    {
        /// <summary>
        /// Get all Address records
        /// </summary>
        /// <returns></returns>
        public List<File> GetAllFiles()
        {
            return QueryAll(SqlDatabase, Procedure.File_SelectAll, File.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get File record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public File GetFileById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<File> h = h2 => h2.FileId == id;
                return GetAllFiles().Find(h) ?? new File();
            }

            return Query(SqlDatabase, Procedure.File_SelectById, File.Build, id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="entityID"></param>
        /// <returns></returns>
        public File GetFileByParentIdAndEntityID(Int32 parentID, Int16 entityID)
        {
            if (IsCached)
            {
                Predicate<File> h = h2 => h2.ParentId == parentID && h2.EntityId == entityID;
                return GetAllFiles().Find(h) ?? new File();
            }

            return Query(SqlDatabase, Procedure.File_SelectByParentIdAndEntityId, File.Build, parentID, entityID);
        }
    }
}
