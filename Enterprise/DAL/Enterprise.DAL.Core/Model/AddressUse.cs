using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    public class AddressUse : ModelBase
    {
        private int _addressId;
        private int _addressUseId;
        private int _typeId;

        public AddressUse()
        {
            EntityNumber = (short) Entities.AddressUse;
        }

        public Int32 AddressUseId
        {
            get { return _addressUseId; }
            set { SetProperty(ref _addressUseId, value); }
        }

        public Int32 AddressId
        {
            get { return _addressId; }
            set { SetProperty(ref _addressId, value); }
        }

        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        #region public methods

        public static AddressUse Build(ITypeReader reader)
        {
            var record = new AddressUse
                {
                    AddressUseId = reader.GetInt32("AddressUseID"),
                    AddressId = reader.GetInt32("AddressID"),
                    TypeId = reader.GetInt32("TypeID")
                };
            return record;
        }

        /// <summary>
        ///     Insert a new record, or update the current record using ID
        /// </summary>
        public void Save()
        {
            if (_addressUseId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressUse_Update
                                       , _addressUseId
                                       , _addressId
                                       , _typeId));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _addressUseId = Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressUse_Insert
                                                   , _addressId
                                                   , _typeId), Convert.ToInt32);
                CacheItem.Clear<AddressUse>();
            }
        }

        /// <summary>
        ///     Removes current record using ID
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressUse_Delete, _addressUseId));
            CacheItem.Clear<AddressUse>();
        }

        #endregion
    }
}