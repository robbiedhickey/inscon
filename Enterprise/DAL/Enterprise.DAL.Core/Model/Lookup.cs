using System;

using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{

    public class Lookup : SqlDataRecord
    {
        // Constructor
        public Lookup()
        {
            TrackChanges = true;
            LookupID = 0;
        }

        #region private variables

        private Int32 _lookupID;
        private Int16 _lookupGroupID;
        private String _value;
        private LookupGroup _lookupGroup;

        #endregion

        #region public properties

      
        public int LookupID
        {
            get { return _lookupID; }
            set { SetProperty(ref _lookupID, value); }
        }


        public Int16 LookupGroupID
        {
            get { return _lookupGroupID; }
            set { SetProperty(ref _lookupGroupID,  value); }
        }
        
        public string Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }

        public LookupGroup Group
        {
            get
            {
                if (_lookupGroup != null)
                {
                    return _lookupGroup;
                }

                var grp = new LookupGroupService();
                _lookupGroup = grp.GetLookupGroupById(_lookupGroupID);
                return _lookupGroup;
            }
        }

        #endregion

        #region public methods

        public static Lookup Build(ITypeReader reader)
        {
            var record = new Lookup
                {
                    LookupID = reader.GetInt32("idLookup"),
                    LookupGroupID = reader.GetInt16("idLookupGroup"),
                    Value = reader.GetString("Caption")
                };

            return record;
        }

        /// <summary>
        /// Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_lookupID != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Lookup_Update
                                        , _lookupID
                                        , _lookupGroupID
                                        , _value));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _lookupID = Execute(GetCommand(Database.EnterpriseDb, Procedure.Lookup_Insert
                                        , _lookupGroupID
                                        , _value), Convert.ToInt32);
                CacheItem.Clear<Lookup>();
            }
        }

        /// <summary>
        /// Removes current record using ID
        ///  </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Lookup_Delete, _lookupID));
            CacheItem.Clear<Lookup>();
        }

        #endregion
    }
}