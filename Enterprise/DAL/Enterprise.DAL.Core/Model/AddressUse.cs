// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="AddressUse.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class AddressUse
    /// </summary>
    public class AddressUse : ModelBase
    {
        /// <summary>
        /// The _address id
        /// </summary>
        private int _addressId;

        /// <summary>
        /// The _address use id
        /// </summary>
        private int _addressUseId;

        /// <summary>
        /// The _type id
        /// </summary>
        private int _typeId;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressUse"/> class.
        /// </summary>
        public AddressUse()
        {
            EntityNumber = AddressUse_EntityId;
        }

        /// <summary>
        /// Gets or sets the address use id.
        /// </summary>
        /// <value>The address use id.</value>
        public Int32 AddressUseId
        {
            get { return _addressUseId; }
            set { SetProperty(ref _addressUseId, value); }
        }

        /// <summary>
        /// Gets or sets the address id.
        /// </summary>
        /// <value>The address id.</value>
        public Int32 AddressId
        {
            get { return _addressId; }
            set { SetProperty(ref _addressId, value); }
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

        #region public methods

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>AddressUse.</returns>
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
        /// Saves this instance.
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
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.AddressUse_Delete, _addressUseId));
            CacheItem.Clear<AddressUse>();
        }

        #endregion
    }
}