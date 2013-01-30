// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="User.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Enterprise.DAL.Core.Service;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class User
    /// </summary>
    public class User : ModelBase
    {
        /// <summary>
        ///     The _authentication
        /// </summary>
        private int _authentication;

        /// <summary>
        ///     The _first name
        /// </summary>
        private string _firstName;

        /// <summary>
        ///     The _last name
        /// </summary>
        private string _lastName;

        /// <summary>
        ///     The _organization
        /// </summary>
        private Organization _organization;

        /// <summary>
        ///     The _organization ID
        /// </summary>
        private int _organizationID;

        /// <summary>
        ///     The _status ID
        /// </summary>
        private int _statusID;

        /// <summary>
        ///     The _title
        /// </summary>
        private string _title;

        /// <summary>
        ///     The _user ID
        /// </summary>
        private int _userID;


        /// <summary>
        ///     Gets or sets the user ID.
        /// </summary>
        /// <value>The user ID.</value>
        public int UserID
        {
            get { return _userID; }
            set { SetProperty(ref _userID, value); }
        }

        /// <summary>
        ///     Gets or sets the organization ID.
        /// </summary>
        /// <value>The organization ID.</value>
        public int OrganizationID
        {
            get { return _organizationID; }
            set { SetProperty(ref _organizationID, value); }
        }

        /// <summary>
        ///     Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }


        /// <summary>
        ///     Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        /// <summary>
        ///     Gets or sets the status ID.
        /// </summary>
        /// <value>The status ID.</value>
        public int StatusID
        {
            get { return _statusID; }
            set { SetProperty(ref _statusID, value); }
        }

        /// <summary>
        ///     Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public string Status
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_statusID).Value; }
        }

        /// <summary>
        ///     Gets the full name.
        /// </summary>
        /// <value>The full name.</value>
        public string FullName
        {
            get { return string.Format("{0} {1}", _firstName, _lastName); }
        }

        /// <summary>
        ///     Gets or sets the authentication ID.
        /// </summary>
        /// <value>The authentication ID.</value>
        public Int32 AuthenticationID
        {
            get { return _authentication; }
            set { _authentication = value; }
        }


        /// <summary>
        ///     Gets the organization.
        /// </summary>
        /// <value>The organization.</value>
        public Organization Organization
        {
            get
            {
                if (_organization != null)
                {
                    return _organization;
                }
                _organization = new OrganizationService().GetOrganizationById(_organizationID);
                return _organization;
            }
        }

        #region public methods

        /// <summary>
        ///     Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
            EntityNumber = User_EntityId;
        }

        #endregion
    }
}