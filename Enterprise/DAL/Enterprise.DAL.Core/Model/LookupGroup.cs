using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;
using Enterprise.DAL.Framework.Cache;

namespace Enterprise.DAL.Core.Model
{
    public class LookupGroup : ModelBase
    {

        #region private variables

        private Int16 _lookupGroupID;
        private string _name;

        #endregion

        #region public properties


        public Int16 LookupGroupID
        {
            get { return _lookupGroupID; }
            set { SetProperty(ref _lookupGroupID, value); }
        }


        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        #endregion

        #region public methods

       public LookupGroup()
       {
           EntityNumber = (short) Entities.LookupGroup;
       }

        public static LookupGroup Build(ITypeReader reader)
        {
            var record = new LookupGroup
                {
                    LookupGroupID = reader.GetInt16("LookupGroupID"),
                    Name = reader.GetString("Name")
                };

            return record;
        }


        /// <summary>
        /// Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_lookupGroupID != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupGroup_Update
                                       , _lookupGroupID
                                       , _name));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _lookupGroupID = Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupGroup_Insert
                                        , _name), Convert.ToInt16);
                CacheItem.Clear<LookupGroup>();
            }
        }

        /// <summary>
        /// Removes current record using ID
        ///  </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupGroup_Delete, _lookupGroupID));
            CacheItem.Clear<LookupGroup>();
        }

        #endregion
    }
}