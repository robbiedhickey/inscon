// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Organization.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using Enterprise.DAL.Core.Service;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class Organization
    /// </summary>
    public class Organization : ModelBase<Organization>
    {
        /// <summary>
        /// The _code
        /// </summary>
        private string _code;

        /// <summary>
        /// The _name
        /// </summary>
        private string _name;

        /// <summary>
        /// The _organization ID
        /// </summary>
        private int _organizationID;

        /// <summary>
        /// The _status ID
        /// </summary>
        private int _statusID;

        /// <summary>
        /// The _type ID
        /// </summary>
        private int _typeID;

        /// <summary>
        /// The _users
        /// </summary>
        private List<User> _users;

        /// <summary>
        /// Gets or sets the organization ID.
        /// </summary>
        /// <value>The organization ID.</value>
        public int OrganizationID
        {
            get { return _organizationID; }
            set { SetProperty(ref _organizationID, value); }
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

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        public string Code
        {
            get { return _code; }
            set { SetProperty(ref _code, value); }
        }

        /// <summary>
        /// Gets or sets the type ID.
        /// </summary>
        /// <value>The type ID.</value>
        public int TypeID
        {
            get { return _typeID; }
            set { SetProperty(ref _typeID, value); }
        }

        /// <summary>
        /// Gets or sets the status ID.
        /// </summary>
        /// <value>The status ID.</value>
        public int StatusID
        {
            get { return _statusID; }
            set { SetProperty(ref _statusID, value); }
        }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public string Status
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_statusID).Value; }
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeID).Value; }
        }

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <value>The users.</value>
        public List<User> Users
        {
            get
            {
                if (_users != null)
                {
                    return _users;
                }
                _users = new UserService().GetUsersByOrganizationId(_organizationID);
                return _users;
            }
        }
    }
}