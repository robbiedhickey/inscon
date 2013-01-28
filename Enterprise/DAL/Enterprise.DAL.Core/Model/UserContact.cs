// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="UserContact.cs" company="Mortgage Specialist International, LLC">
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
    /// Class UserContact
    /// </summary>
    public class UserContact : ModelBase
    {
        /// <summary>
        /// The _is primary
        /// </summary>
        private bool _isPrimary;

        /// <summary>
        /// The _type id
        /// </summary>
        private int _typeId;

        /// <summary>
        /// The _user contact id
        /// </summary>
        private int _userContactId;

        /// <summary>
        /// The _user id
        /// </summary>
        private int _userId;

        /// <summary>
        /// The _value
        /// </summary>
        private string _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserContact"/> class.
        /// </summary>
        public UserContact()
        {
            EntityNumber = UserContact_EntityId;
        }

        /// <summary>
        /// Gets or sets the user contact id.
        /// </summary>
        /// <value>The user contact id.</value>
        public Int32 UserContactId
        {
            get { return _userContactId; }
            set { SetProperty(ref _userContactId, value); }
        }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public Int32 UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public String Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
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
        /// Gets or sets the is primary.
        /// </summary>
        /// <value>The is primary.</value>
        public Boolean IsPrimary
        {
            get { return _isPrimary; }
            set { SetProperty(ref _isPrimary, value); }
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
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>UserContact.</returns>
        public static UserContact Build(ITypeReader reader)
        {
            var record = new UserContact
                {
                    UserContactId = reader.GetInt32("UserContactID"),
                    UserId = reader.GetInt32("UserID"),
                    Value = reader.GetString("Value"),
                    TypeId = reader.GetInt32("TypeID"),
                    IsPrimary = reader.GetBool("IsPrimary")
                };
            return record;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            if (_userContactId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Update
                                       , _userContactId
                                       , _userId
                                       , _value
                                       , _typeId
                                       , _isPrimary));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _userContactId = Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Insert
                                                    , _userId
                                                    , _value
                                                    , _typeId
                                                    , _isPrimary), Convert.ToInt32);
                CacheItem.Clear<UserContact>();
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.File_Delete, _userContactId));
            CacheItem.Clear<UserContact>();
        }
    }
}