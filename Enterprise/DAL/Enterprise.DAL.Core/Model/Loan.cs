// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Loan.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Enterprise.DAL.Core.Service;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class Loan
    /// </summary>
    public class Loan : ModelBase
    {
        #region private variables

        /// <summary>
        ///     The _hud case number
        /// </summary>
        private string _hudCaseNumber;

        /// <summary>
        ///     The _loan ID
        /// </summary>
        private int _loanID;

        /// <summary>
        ///     The _loan number
        /// </summary>
        private string _loanNumber;

        /// <summary>
        ///     The _organization
        /// </summary>
        private Organization _organization;

        /// <summary>
        ///     The _organization ID
        /// </summary>
        private int _organizationID;

        /// <summary>
        ///     The _type ID
        /// </summary>
        private int _typeID;

        #endregion

        #region public properties

        /// <summary>
        ///     Gets or sets the loan ID.
        /// </summary>
        /// <value>The loan ID.</value>
        public Int32 LoanID
        {
            get { return _loanID; }
            set { SetProperty(ref _loanID, value); }
        }

        /// <summary>
        ///     Gets or sets the organization ID.
        /// </summary>
        /// <value>The organization ID.</value>
        public Int32 OrganizationID
        {
            get { return _organizationID; }
            set { SetProperty(ref _organizationID, value); }
        }

        /// <summary>
        ///     Gets or sets the type ID.
        /// </summary>
        /// <value>The type ID.</value>
        public Int32 TypeID
        {
            get { return _typeID; }
            set { SetProperty(ref _typeID, value); }
        }

        /// <summary>
        ///     Gets or sets the loan number.
        /// </summary>
        /// <value>The loan number.</value>
        public String LoanNumber
        {
            get { return _loanNumber; }
            set { SetProperty(ref _loanNumber, value); }
        }

        /// <summary>
        ///     Gets or sets the hud case number.
        /// </summary>
        /// <value>The hud case number.</value>
        public String HudCaseNumber
        {
            get { return _hudCaseNumber; }
            set { SetProperty(ref _hudCaseNumber, value); }
        }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeID).Value; }
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

        #endregion

        #region public methods

        // Constructor
        /// <summary>
        ///     Initializes a new instance of the <see cref="Loan" /> class.
        /// </summary>
        public Loan()
        {
            EntityNumber = Loan_EntityId;
        }

        #endregion
    }
}