// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="File.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Enterprise.DAL.Core.Service;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class File
    /// </summary>
    public class File : ModelBase<File>
    {
        /// <summary>
        /// The _caption
        /// </summary>
        private string _caption;

        /// <summary>
        /// The _date inserted
        /// </summary>
        private DateTime _dateInserted;

        /// <summary>
        /// The _entity id
        /// </summary>
        private short _entityId;

        /// <summary>
        /// The _file id
        /// </summary>
        private int _fileId;

        /// <summary>
        /// The _name
        /// </summary>
        private string _name;

        /// <summary>
        /// The _parent folder
        /// </summary>
        private string _parentFolder;

        /// <summary>
        /// The _parent id
        /// </summary>
        private int _parentId;

        /// <summary>
        /// The _size
        /// </summary>
        private decimal _size;

        /// <summary>
        /// The _type id
        /// </summary>
        private int _typeId;


        /// <summary>
        /// Gets or sets the file ID.
        /// </summary>
        /// <value>The file ID.</value>
        public Int32 FileID
        {
            get { return _fileId; }
            set { SetProperty(ref _fileId, value); }
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
        /// Gets or sets the parent folder.
        /// </summary>
        /// <value>The parent folder.</value>
        public String ParentFolder
        {
            get { return _parentFolder; }
            set { SetProperty(ref _parentFolder, value); }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public String Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        public Decimal Size
        {
            get { return _size; }
            set { SetProperty(ref _size, value); }
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
        /// Gets or sets the caption.
        /// </summary>
        /// <value>The caption.</value>
        public String Caption
        {
            get { return _caption; }
            set { SetProperty(ref _caption, value); }
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeId).Value; }
        }

        /// <summary>
        /// Gets or sets the date inserted.
        /// </summary>
        /// <value>The date inserted.</value>
        public DateTime DateInserted
        {
            get { return _dateInserted; }
            set { _dateInserted = value; }
        }
    }
}