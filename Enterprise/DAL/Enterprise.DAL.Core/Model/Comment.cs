// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Comment.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class Comment
    /// </summary>
    public class Comment : ModelBase
    {
        /// <summary>
        ///     The _comment
        /// </summary>
        private String _comment;

        /// <summary>
        ///     The _comment id
        /// </summary>
        private Int32 _commentId;

        /// <summary>
        ///     The _entity id
        /// </summary>
        private Int16 _entityId;

        /// <summary>
        ///     The _parent id
        /// </summary>
        private Int32 _parentId;

        /// <summary>
        ///     The _type id
        /// </summary>
        private Int32 _typeId;

        /// <summary>
        ///     The _user id
        /// </summary>
        private Int32 _userId;


        /// <summary>
        ///     Gets or sets the comment id.
        /// </summary>
        /// <value>The comment id.</value>
        public Int32 CommentId
        {
            get { return _commentId; }
            set { SetProperty(ref _commentId, value); }
        }

        /// <summary>
        ///     Gets or sets the parent id.
        /// </summary>
        /// <value>The parent id.</value>
        public Int32 ParentId
        {
            get { return _parentId; }
            set { SetProperty(ref _parentId, value); }
        }

        /// <summary>
        ///     Gets or sets the entity id.
        /// </summary>
        /// <value>The entity id.</value>
        public Int16 EntityId
        {
            get { return _entityId; }
            set { SetProperty(ref _entityId, value); }
        }

        /// <summary>
        ///     Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public Int32 UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        /// <summary>
        ///     Gets or sets the type id.
        /// </summary>
        /// <value>The type id.</value>
        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public String Value
        {
            get { return _comment; }
            set { SetProperty(ref _comment, value); }
        }

        #region public methods

        /// <summary>
        ///     Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        public Comment()
        {
            EntityNumber = Comment_EntityId;
        }

        #endregion
    }
}