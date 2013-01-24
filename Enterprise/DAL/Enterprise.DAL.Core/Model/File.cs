using System;
using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class File : ModelBase
    {
        private string _caption;
        private short _entityId;
        private int _fileId;
        private string _name;
        private string _parentFolder;
        private int _parentId;
        private decimal _size;
        private int _typeId;

        public File()
        {
            EntityNumber = (short) Entities.File;
        }

        public Int32 FileId
        {
            get { return _fileId; }
            set { SetProperty(ref _fileId, value); }
        }

        public Int32 ParentId
        {
            get { return _parentId; }
            set { SetProperty(ref _parentId, value); }
        }

        public Int16 EntityId
        {
            get { return _entityId; }
            set { SetProperty(ref _entityId, value); }
        }

        public String ParentFolder
        {
            get { return _parentFolder; }
            set { SetProperty(ref _parentFolder, value); }
        }

        public String Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public Decimal Size
        {
            get { return _size; }
            set { SetProperty(ref _size, value); }
        }

        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        public Int32 UserId { get; set; }

        public String Caption
        {
            get { return _caption; }
            set { SetProperty(ref _caption, value); }
        }

        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeId).Value; }
        }

        #region public methods

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
        ///     Insert a new record, or update the current record using ID
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
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Delete, _fileId));
            CacheItem.Clear<File>();
        }

        #endregion
    }
}