using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.CommentService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the Comment table.
    /// </summary>
    public class CommentService : ICommentService
    {
        /// <summary>
        /// Gets all comments.
        /// </summary>
        /// <returns>A list of comment objects.</returns>
        public List<Comment> GetAllComments()
        {
            try
            {
                return new dbSvc().GetAllComments();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the comment by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>The comment that matches the id.</returns>
        public Comment GetCommentById(int id)
        {
            try
            {
                return new dbSvc().GetCommentById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the comment by parent id and entity ID.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        /// <param name="entityID">The entity ID.</param>
        /// <returns>The comment that matches the parameter list.</returns>
        public Comment GetCommentByParentIdAndEntityID(int parentID, short entityID)
        {
            try
            {
                return new dbSvc().GetCommentByParentIdAndEntityID(parentID, entityID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the comment record.
        /// </summary>
        /// <param name="comment">The comment.</param>
        public void DeleteRecord(Comment comment)
        {
            try
            {
                new dbSvc().DeleteRecord(comment);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the comment record.
        /// </summary>
        /// <param name="comment">The comment.</param>
        /// <returns>The id value for the saved comment record.</returns>
        public int SaveRecord(Comment comment)
        {
            try
            {
                return new dbSvc().SaveRecord(comment);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
