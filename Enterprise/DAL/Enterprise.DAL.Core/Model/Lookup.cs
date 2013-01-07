using System;

using Enterprise.DAL.Core.Service;
using Enterprise.DAL.Core.Type;
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
            idLookup = 0;
        }

        #region private variables

        private int _idLookup;
        private int _idLookupGroup;
        private string _code;
        private string _abreviation;
        private string _caption;
        private decimal _sort;
        private string _note;
        private Guid _objectID;
        private LookupGroup _lookupGroup;

        #endregion

        #region public properties

      
        public int idLookup
        {
            get { return _idLookup; }
            set { SetProperty(ref _idLookup, value); }
        }


        public int idLookupGroup
        {
            get { return _idLookupGroup; }
            set { SetProperty(ref _idLookupGroup,  value); }
        }

        public string Code
        {
            get { return _code; }
            set { SetProperty(ref _code, value); }
        }

        public string Abreviation
        {
            get { return _abreviation; }
            set { SetProperty(ref _abreviation, value); }
        }

   
        public string Caption
        {
            get { return _caption; }
            set { SetProperty(ref _caption, value); }
        }

        public decimal Sort
        {
            get { return _sort; }
            set { SetProperty(ref _sort, value); }
        }

        public string Note
        {
            get { return _note; }
            set { SetProperty(ref _note, value); }
        }

        public Guid ObjectID
        {
            get { return _objectID; }
            set { SetProperty(ref _objectID, value); }
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
                _lookupGroup = grp.GetLookupGroupById(_idLookupGroup);
                return _lookupGroup;
            }
        }

        #endregion

        #region public methods

        public static Lookup Build(ITypeReader reader)
        {
            var record = new Lookup
                {
                    idLookup = reader.GetInt("idLookup"),
                    idLookupGroup = reader.GetInt("idLookupGroup"),
                    Code = reader.GetString("code"),
                    Abreviation = reader.GetString("Abreviation"),
                    Caption = reader.GetString("Caption"),
                    Sort = reader.GetInt("Sort"),
                    Note = reader.GetString("Note"),
                    ObjectID = reader.GetGuid("ObjectID")
                };

            return record;
        }

        /// <summary>
        /// Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_idLookup != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupUpdate
                                        , _idLookup
                                        , _idLookupGroup
                                        , _code
                                        , _abreviation
                                        , _caption
                                        , _sort
                                        , _note
                                        , _objectID));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _idLookup = Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupInsert
                                        , _idLookupGroup
                                        , _code
                                        , _abreviation
                                        , _caption
                                        , _sort
                                        , _note
                                        , _objectID), Convert.ToInt32);
                CacheItem.Clear<Lookup>();
            }
        }

        /// <summary>
        /// Removes current record using ID
        ///  </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupDelete, _idLookup));
            CacheItem.Clear<Lookup>();
        }

        #endregion
    }
}