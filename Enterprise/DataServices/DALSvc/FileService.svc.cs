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
    /// <summary>
    /// Handles access to the File table.
    /// </summary>
    public class FileService : IFileService
    {
        /// <summary>
        /// Gets all files.
        /// </summary>
        /// <returns>A list of all file objects.</returns>
        public List<File> GetAllFiles()
        {
            try
            {
                return new dbSvc().GetAllFiles();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the file by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The file record that matches the id.</returns>
        public File GetFileById(int id)
        {
            try
            {
                return new dbSvc().GetFileById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the file by parent id and entity ID.
        /// </summary>
        /// <param name="parentID">The parent ID of the file.</param>
        /// <param name="entityID">The entity ID of the file.</param>
        /// <returns>The file that matches the parameter list.</returns>
        public File GetFileByParentIdAndEntityID(int parentID, short entityID)
        {
            try
            {
                return new dbSvc().GetFileByParentIdAndEntityID(parentID, entityID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the file record.
        /// </summary>
        /// <param name="file">The file record to delete.</param>
        public void DeleteRecord(File file)
        {
            try
            {
                new dbSvc().DeleteRecord(file);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the file record.
        /// </summary>
        /// <param name="file">The file object to save.</param>
        /// <returns>The id of the saved file.</returns>
        public int SaveRecord(File file)
        {
            try
            {
                return new dbSvc().SaveRecord(file);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
