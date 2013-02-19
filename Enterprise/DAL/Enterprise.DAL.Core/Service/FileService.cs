// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="FileService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class FileService
    /// </summary>
    public class FileService : ServiceBase<File>
    {

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>File.</returns>
        public static File Build(ITypeReader reader)
        {
            var record = new File
            {
                FileID = reader.GetInt32("FileID"),
                ParentID = reader.GetInt32("ParentID"),
                EntityID = reader.GetInt16("EntityID"),
                ParentFolder = reader.GetString("ParentFolder"),
                Name = reader.GetString("Name"),
                Size = reader.GetDecimal("Size"),
                TypeID = reader.GetInt32("TypeID"),
                Caption = reader.GetString("Caption")
            };

            return record;
        }

        /// <summary>
        /// Gets all files.
        /// </summary>
        /// <returns>List{File}.</returns>
        public List<File> GetAllFiles()
        {
            return QueryAll(SqlDatabase, Procedure.File_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the file by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>File.</returns>
        public File GetFileById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<File> h = h2 => h2.FileID == id;
                return GetAllFiles().Find(h) ?? new File();
            }

            return Query(SqlDatabase, Procedure.File_SelectById, Build, id);
        }

        /// <summary>
        /// Gets the file by parent id and entity ID.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns>File.</returns>
        public File GetFileByParentIdAndEntityID(Int32 parentID, Int16 entityID)
        {
            if (IsCached)
            {
                Predicate<File> h = h2 => h2.ParentID == parentID && h2.EntityID == entityID;
                return GetAllFiles().Find(h) ?? new File();
            }

            return Query(SqlDatabase, Procedure.File_SelectByParentIdAndEntityId, Build, parentID, entityID);
        }
    }
}