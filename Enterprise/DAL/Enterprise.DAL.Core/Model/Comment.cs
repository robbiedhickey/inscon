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
    /// Class Comment
    /// </summary>
    public class Comment : ModelBase<Comment>
    {
        /// <summary>
        /// The _comment
        /// </summary>
        private String _comment;

        /// <summary>
        /// The _comment id
        /// </summary>
        private Int32 _commentId;

        /// <summary>
        /// The _date inserted
        /// </summary>
        private DateTime _dateInserted;

        /// <summary>
        /// The _entity id
        /// </summary>
        private Int16 _entityId;

        /// <summary>
        /// The _parent id
        /// </summary>
        private Int32 _parentId;

        /// <summary>
        /// The _type id
        /// </summary>
        private Int32 _typeId;

        /// <summary>
        /// The _user id
        /// </summary>
        private Int32 _userId;


        /// <summary>
        /// Gets or sets the comment ID.
        /// </summary>
        /// <value>The comment ID.</value>
        public Int32 CommentID
        {
            get { return _commentId; }
            set { SetProperty(ref _commentId, value); }
        }

        /// <summary>
        /// Gets or sets the parent ID.
        /// </summary>
        /// <value>The parent ID.</value>
        public Int32 ParentID
        {
            get { return _parentId; }
            set { SetProperty(ref _parentId, value); }
        }

        /// <summary>
        /// Gets or sets the entity ID.
        /// </summary>
        /// <value>The entity ID.</value>
        public Int16 EntityID
        {
            get { return _entityId; }
            set { SetProperty(ref _entityId, value); }
        }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        /// <value>The user ID.</value>
        public Int32 UserID
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        /// <summary>
        /// Gets or sets the type ID.
        /// </summary>
        /// <value>The type ID.</value>
        public Int32 TypeID
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public String Value
        {
            get { return _comment; }
            set { SetProperty(ref _comment, value); }
        }

        /// <summary>
        /// Gets or sets the date inserted.
        /// </summary>
        /// <value>The date inserted.</value>
        public DateTime DateInserted
        {
            get { return _dateInserted; }
            set { SetProperty(ref _dateInserted, value); }
        }
    }
}