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

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class UserContact
    /// </summary>
    public class UserContact : ModelBase
    {
        /// <summary>
        ///     The _is primary
        /// </summary>
        private bool _isPrimary;

        /// <summary>
        ///     The _type id
        /// </summary>
        private int _typeId;

        /// <summary>
        ///     The _user contact id
        /// </summary>
        private int _userContactId;

        /// <summary>
        ///     The _user id
        /// </summary>
        private int _userId;

        /// <summary>
        ///     The _value
        /// </summary>
        private string _value;

        /// <summary>
        ///     Initializes a new instance of the <see cref="UserContact" /> class.
        /// </summary>
        public UserContact()
        {
            EntityNumber = UserContact_EntityId;
        }


        /// <summary>
        ///     Gets or sets the user contact id.
        /// </summary>
        /// <value>The user contact id.</value>
        public Int32 UserContactID
        {
            get { return _userContactId; }
            set { SetProperty(ref _userContactId, value); }
        }

        /// <summary>
        ///     Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public Int32 UserID
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public String Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
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

        /// <summary>
        ///     Gets or sets the is primary.
        /// </summary>
        /// <value>The is primary.</value>
        public Boolean IsPrimary
        {
            get { return _isPrimary; }
            set { SetProperty(ref _isPrimary, value); }
        }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeId).Value; }
        }
    }
}