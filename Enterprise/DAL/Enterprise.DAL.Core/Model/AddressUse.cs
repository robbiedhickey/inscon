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
    ///     Class AddressUse
    /// </summary>
    public class AddressUse : ModelBase
    {
        /// <summary>
        ///     The _address id
        /// </summary>
        private int _addressId;

        /// <summary>
        ///     The _address use id
        /// </summary>
        private int _addressUseId;

        /// <summary>
        ///     The _type id
        /// </summary>
        private int _typeId;


        /// <summary>
        ///     Gets or sets the address use id.
        /// </summary>
        /// <value>The address use id.</value>
        public Int32 AddressUseID
        {
            get { return _addressUseId; }
            set { SetProperty(ref _addressUseId, value); }
        }

        /// <summary>
        ///     Gets or sets the address id.
        /// </summary>
        /// <value>The address id.</value>
        public Int32 AddressID
        {
            get { return _addressId; }
            set { SetProperty(ref _addressId, value); }
        }

        /// <summary>
        ///     Gets or sets the type id.
        /// </summary>
        /// <value>The type id.</value>
        public Int32 TypeID
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        #region public methods

        /// <summary>
        ///     Initializes a new instance of the <see cref="AddressUse" /> class.
        /// </summary>
        public AddressUse()
        {
            EntityNumber = AddressUse_EntityId;
        }

        #endregion
    }
}