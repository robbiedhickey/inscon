using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;
using Enterprise.DAL.Framework.Cache;

namespace Enterprise.DAL.Core.Model
{
    public class LookupGroup : SqlDataRecord
    {
        // Constructor
        public LookupGroup()
        {
            TrackChanges = true;
            idLookupGroup = 0;
        }

        #region private variables

        private int _idLookupGroup;
        private string _name;
        private Guid _objectID;

        #endregion

        #region public properties


        public int idLookupGroup
        {
            get { return _idLookupGroup; }
            set { SetProperty(ref _idLookupGroup, value); }
        }


        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public Guid ObjectID
        {
            get { return _objectID; }
            set { SetProperty(ref _objectID, value); }
        }

        #endregion

        #region public methods

        public static LookupGroup Build(ITypeReader reader)
        {
            var record = new LookupGroup
                {
                    idLookupGroup = reader.GetInt32("idLookupGroup"),
                    Name = reader.GetString("GroupName"),
                    ObjectID = reader.GetGuid("ObjectID")
                };

            return record;
        }


        /// <summary>
        /// Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_idLookupGroup != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupGroupUpdate
                                       , _idLookupGroup
                                       , _name
                                       , _objectID));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _idLookupGroup = Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupGroupInsert
                                        , _name
                                        , _objectID), Convert.ToInt32);
                CacheItem.Clear<LookupGroup>();
            }
        }

        /// <summary>
        /// Removes current record using ID
        ///  </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupGroupDelete, _idLookupGroup));
            CacheItem.Clear<LookupGroup>();
        }

        #endregion
    }
}