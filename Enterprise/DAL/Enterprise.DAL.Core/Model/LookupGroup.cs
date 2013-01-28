// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="LookupGroup.cs" company="Mortgage Specialist International, LLC">
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
    /// Class LookupGroup
    /// </summary>
    public class LookupGroup : ModelBase
    {
        #region private variables

        /// <summary>
        /// The _lookup group ID
        /// </summary>
        private Int16 _lookupGroupID;

        /// <summary>
        /// The _name
        /// </summary>
        private string _name;

        #endregion

        #region public properties

        /// <summary>
        /// Gets or sets the lookup group ID.
        /// </summary>
        /// <value>The lookup group ID.</value>
        public Int16 LookupGroupID
        {
            get { return _lookupGroupID; }
            set { SetProperty(ref _lookupGroupID, value); }
        }


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        #endregion

        #region public methods

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupGroup"/> class.
        /// </summary>
        public LookupGroup()
        {
            EntityNumber = LookupGroup_EntityId;
        }

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>LookupGroup.</returns>
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
        /// Saves this instance.
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
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.LookupGroup_Delete, _lookupGroupID));
            CacheItem.Clear<LookupGroup>();
        }

        #endregion
    }
}