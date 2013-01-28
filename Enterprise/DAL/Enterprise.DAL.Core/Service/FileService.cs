﻿// ***********************************************************************
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

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class FileService
    /// </summary>
    public class FileService : ServiceBase<File>
    {
        /// <summary>
        /// Gets all files.
        /// </summary>
        /// <returns>List{File}.</returns>
        public List<File> GetAllFiles()
        {
            return QueryAll(SqlDatabase, Procedure.File_SelectAll, File.Build, CacheMinutesToExpire, IsCached);
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
                Predicate<File> h = h2 => h2.FileId == id;
                return GetAllFiles().Find(h) ?? new File();
            }

            return Query(SqlDatabase, Procedure.File_SelectById, File.Build, id);
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
                Predicate<File> h = h2 => h2.ParentId == parentID && h2.EntityId == entityID;
                return GetAllFiles().Find(h) ?? new File();
            }

            return Query(SqlDatabase, Procedure.File_SelectByParentIdAndEntityId, File.Build, parentID, entityID);
        }
    }
}