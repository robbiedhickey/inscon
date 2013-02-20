// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Lookup.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Enterprise.DAL.Core.Service;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class Lookup
    /// </summary>
    public class Lookup : ModelBase<Lookup>
    {

        /// <summary>
        /// The _lookup group
        /// </summary>
        private LookupGroup _lookupGroup;

        /// <summary>
        /// The _lookup group ID
        /// </summary>
        private Int16 _lookupGroupID;

        /// <summary>
        /// The _lookup ID
        /// </summary>
        private Int32 _lookupID;

        /// <summary>
        /// The _value
        /// </summary>
        private String _value;


        /// <summary>
        /// Gets or sets the lookup ID.
        /// </summary>
        /// <value>The lookup ID.</value>
        public int LookupID
        {
            get { return _lookupID; }
            set { SetProperty(ref _lookupID, value); }
        }


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
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }

        /// <summary>
        /// Gets the group.
        /// </summary>
        /// <value>The group.</value>
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

       
    }
}