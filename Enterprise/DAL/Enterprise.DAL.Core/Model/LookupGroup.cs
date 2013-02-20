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

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class LookupGroup
    /// </summary>
    public class LookupGroup : ModelBase<LookupGroup>
    {

        /// <summary>
        /// The _lookup group ID
        /// </summary>
        private Int32 _lookupGroupID;

        /// <summary>
        /// The _name
        /// </summary>
        private string _name;


        /// <summary>
        /// Gets or sets the lookup group ID.
        /// </summary>
        /// <value>The lookup group ID.</value>
        public Int32 LookupGroupID
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
    }
}