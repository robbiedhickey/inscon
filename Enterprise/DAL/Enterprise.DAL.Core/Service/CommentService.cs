// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="CommentService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class CommentService
    /// </summary>
    public class CommentService : ServiceBase<Comment>
    {

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Comment.</returns>
        public static Comment Build(ITypeReader reader)
        {
            var record = new Comment
            {
                CommentID = reader.GetInt32("CommentID"),
                ParentID = reader.GetInt32("ParentID"),
                EntityID = reader.GetInt16("EntityID"),
                UserID = reader.GetInt32("UserID"),
                TypeID = reader.GetInt32("TypeID"),
                Value = reader.GetString("Value")
            };

            return record;
        }

        /// <summary>
        /// Gets all comments.
        /// </summary>
        /// <returns>List{Comment}.</returns>
        public List<Comment> GetAllComments()
        {
            return QueryAll(SqlDatabase, Procedure.Comment_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the comment by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Comment.</returns>
        public Comment GetCommentById(int id)
        {
            if (IsCached)
            {
                Predicate<Comment> h = h2 => h2.CommentID == id;
                return GetAllComments().Find(h);
            }

            return Query(SqlDatabase, Procedure.Comment_SelectById, Build, id);
        }

        /// <summary>
        /// Gets the comment by parent id and entity ID.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns>Comment.</returns>
        public Comment GetCommentByParentIdAndEntityID(int parentID, Int16 entityID)
        {
            if (IsCached)
            {
                Predicate<Comment> h = h2 => h2.ParentID == parentID && h2.EntityID == entityID;
                return GetAllComments().Find(h);
            }

            return Query(SqlDatabase, Procedure.Comment_SelectByParentIdAndEntityId, Build, parentID, entityID);
        }
    }
}