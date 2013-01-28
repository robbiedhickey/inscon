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
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class File
    /// </summary>
    public class File : ModelBase
    {
        /// <summary>
        /// The _caption
        /// </summary>
        private string _caption;

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
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        public File()
        {
            EntityNumber = File_EntityId;
        }

        /// <summary>
        /// Gets or sets the file id.
        /// </summary>
        /// <value>The file id.</value>
        public Int32 FileId
        {
            get { return _fileId; }
            set { SetProperty(ref _fileId, value); }
        }

        /// <summary>
        /// Gets or sets the parent id.
        /// </summary>
        /// <value>The parent id.</value>
        public Int32 ParentId
        {
            get { return _parentId; }
            set { SetProperty(ref _parentId, value); }
        }

        /// <summary>
        /// Gets or sets the entity id.
        /// </summary>
        /// <value>The entity id.</value>
        public Int16 EntityId
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
        /// Gets or sets the type id.
        /// </summary>
        /// <value>The type id.</value>
        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public Int32 UserId { get; set; }

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

        #region public methods

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>File.</returns>
        public static File Build(ITypeReader reader)
        {
            var record = new File
                {
                    FileId = reader.GetInt32("FileID"),
                    ParentId = reader.GetInt32("ParentID"),
                    EntityId = reader.GetInt16("EntityID"),
                    ParentFolder = reader.GetString("ParentFolder"),
                    Name = reader.GetString("Name"),
                    Size = reader.GetDecimal("Size"),
                    TypeId = reader.GetInt32("TypeID"),
                    Caption = reader.GetString("Caption")
                };

            return record;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            if (_fileId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Update
                                       , _fileId
                                       , _parentId
                                       , _entityId
                                       , _parentFolder
                                       , _name
                                       , _size
                                       , _typeId
                                       , _caption));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _fileId = Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Insert
                                             , _parentId
                                             , _entityId
                                             , _parentFolder
                                             , _name
                                             , _size
                                             , _typeId
                                             , _caption), Convert.ToInt32);
                CacheItem.Clear<File>();
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Delete, _fileId));
            CacheItem.Clear<File>();
        }

        #endregion
    }
}