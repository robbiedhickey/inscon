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

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class Asset
    /// </summary>
    public class Asset : ModelBase
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
        /// The _loan id
        /// </summary>
        private int? _loanId;
        /// <summary>
        /// The _organization id
        /// </summary>
        private int _organizationId;
        /// <summary>
        /// The _type id
        /// </summary>
        private int _typeId;
        

        /// <summary>
        /// Gets or sets the asset id.
        /// </summary>
        /// <value>The asset id.</value>
        public Int32 AssetId
        {
            get { return _assetId; }
            set { SetProperty(ref _assetId, value); }
        }

        /// <summary>
        /// Gets or sets the organization id.
        /// </summary>
        /// <value>The organization id.</value>
        public Int32 OrganizationId
        {
            get { return _organizationId; }
            set { SetProperty(ref _organizationId, value); }
        }

        /// <summary>
        /// Gets or sets the type id.
        /// </summary>
        /// <value>The type id.</value>
        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        /// <summary>
        /// Gets or sets the loan id.
        /// </summary>
        /// <value>The loan id.</value>
        public Int32? LoanId
        {
            get { return _loanId; }
            set { SetProperty(ref _loanId, value); }
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
        /// Initializes a new instance of the <see cref="Asset"/> class.
        /// </summary>
        public Asset()
        {
            EntityNumber = Asset_EntityId;
        }
    }
}