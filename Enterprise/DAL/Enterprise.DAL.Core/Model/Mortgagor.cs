// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Mortgagor.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Enterprise.DAL.Core.Service;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    ///     Class Mortgagor
    /// </summary>
    public class Mortgagor : ModelBase
    {
        /// <summary>
        ///     The _loan id
        /// </summary>
        private int _loanId;

        /// <summary>
        ///     The _mortgagor id
        /// </summary>
        private int _mortgagorId;

        /// <summary>
        ///     The _name
        /// </summary>
        private string _name;

        /// <summary>
        ///     The _phone number
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        ///     The _type id
        /// </summary>
        private int _typeId;


        /// <summary>
        ///     Gets or sets the mortgagor id.
        /// </summary>
        /// <value>The mortgagor id.</value>
        public Int32 MortgagorId
        {
            get { return _mortgagorId; }
            set { SetProperty(ref _mortgagorId, value); }
        }

        /// <summary>
        ///     Gets or sets the loan id.
        /// </summary>
        /// <value>The loan id.</value>
        public Int32 LoanId
        {
            get { return _loanId; }
            set { SetProperty(ref _loanId, value); }
        }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public String Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        ///     Gets or sets the type id.
        /// </summary>
        /// <value>The type id.</value>
        public Int32 TypeId
        {
            get { return _typeId; }
            set { SetProperty(ref _typeId, value); }
        }

        /// <summary>
        ///     Gets or sets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        public String Phone
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
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

        #region public methods

        /// <summary>
        ///     Initializes a new instance of the <see cref="Mortgagor" /> class.
        /// </summary>
        public Mortgagor()
        {
            EntityNumber = Mortgagor_EntityId;
        }

        #endregion
    }
}