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

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class AddressUse
    /// </summary>
    public class AddressUse : ModelBase<AddressUse>
    {
        /// <summary>
        /// The _address id
        /// </summary>
        private int _addressId;

        /// <summary>
        /// The _type id
        /// </summary>
        private int _typeId;


        /// <summary>
        /// Gets or sets the address ID.
        /// </summary>
        /// <value>The address ID.</value>
        public Int32 AddressID
        {
            get { return _addressId; }
            set { SetProperty(ref _addressId, value); }
        }

        /// <summary>
        /// Gets or sets the type ID.
        /// </summary>
        /// <value>The type ID.</value>
        public Int32 TypeID
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }
    }
}