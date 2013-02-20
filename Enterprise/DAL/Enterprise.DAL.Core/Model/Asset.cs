// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-30-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-30-2013
// ***********************************************************************
// <copyright file="Asset.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Service;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class Asset
    /// </summary>
    public class Asset : ModelBase<Asset>
    {
        /// <summary>
        /// The _asset id
        /// </summary>
        private int _assetId;

        /// <summary>
        /// The _asset number
        /// </summary>
        private string _assetNumber;

        /// <summary>
        /// The _loan number
        /// </summary>
        private String _loanNumber;

        /// <summary>
        /// The _organization id
        /// </summary>
        private int _organizationId;

        /// <summary>
        /// The _type id
        /// </summary>
        private int _typeId;

        /// <summary>
        /// The _loan type id
        /// </summary>
        private int? _loanTypeId;

        /// <summary>
        /// The _mortgagor name
        /// </summary>
        private string _mortgagorName;

        /// <summary>
        /// The _mortgagor phone
        /// </summary>
        private string _mortgagorPhone;

        /// <summary>
        /// The _hud case number
        /// </summary>
        private string _hudCaseNumber;

        /// <summary>
        /// The _conveyance date
        /// </summary>
        private DateTime? _conveyanceDate;

        /// <summary>
        /// The _first time vacant date
        /// </summary>
        private DateTime? _firstTimeVacantDate;

        /// <summary>
        /// The _addresses
        /// </summary>
        private List<Address> _addresses;

        /// <summary>
        /// Gets or sets the asset ID.
        /// </summary>
        /// <value>The asset ID.</value>
        public Int32 AssetID
        {
            get { return _assetId; }
            set { SetProperty(ref _assetId, value); }
        }

        /// <summary>
        /// Gets or sets the organization ID.
        /// </summary>
        /// <value>The organization ID.</value>
        public Int32 OrganizationID
        {
            get { return _organizationId; }
            set { SetProperty(ref _organizationId, value); }
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

        /// <summary>
        /// Gets or sets the loan number.
        /// </summary>
        /// <value>The loan number.</value>
        public String LoanNumber
        {
            get { return _loanNumber; }
            set { SetProperty(ref _loanNumber, value); }
        }

        /// <summary>
        /// Gets or sets the asset number.
        /// </summary>
        /// <value>The asset number.</value>
        public String AssetNumber
        {
            get { return _assetNumber; }
            set { SetProperty(ref _assetNumber, value); }
        }


        /// <summary>
        /// Gets or sets the loan type ID.
        /// </summary>
        /// <value>The loan type ID.</value>
        public Int32? LoanTypeID
        {
            get { return _loanTypeId; }
            set { _loanTypeId = value; }
        }

        /// <summary>
        /// Gets or sets the name of the mortgagor.
        /// </summary>
        /// <value>The name of the mortgagor.</value>
        public String MortgagorName
        {
            get { return _mortgagorName; }
            set { _mortgagorName = value; }
        }

        /// <summary>
        /// Gets or sets the mortgagor phone.
        /// </summary>
        /// <value>The mortgagor phone.</value>
        public String MortgagorPhone
        {
            get { return _mortgagorPhone; }
            set { _mortgagorPhone = value; }
        }

        /// <summary>
        /// Gets or sets the hud case number.
        /// </summary>
        /// <value>The hud case number.</value>
        public String HudCaseNumber
        {
            get { return _hudCaseNumber; }
            set { _hudCaseNumber = value; }
        }

        /// <summary>
        /// Gets or sets the conveyance date.
        /// </summary>
        /// <value>The conveyance date.</value>
        public DateTime? ConveyanceDate
        {
            get { return _conveyanceDate; }
            set { _conveyanceDate = value; }
        }

        /// <summary>
        /// Gets or sets the first time vacant date.
        /// </summary>
        /// <value>The first time vacant date.</value>
        public DateTime? FirstTimeVacantDate
        {
            get { return _firstTimeVacantDate; }
            set { _firstTimeVacantDate = value; }
        }

        /// <summary>
        /// Gets the addresses.
        /// </summary>
        /// <value>The addresses.</value>
        public List<Address> Addresses
        {
            get
            {
                if (_addresses != null)
                {
                    return _addresses;
                }
                _addresses = new AddressService().GetAddressRecordsByParentIdAndEntityID(_assetId, EntityNumber);
                return _addresses;
            }
        }
    }
}