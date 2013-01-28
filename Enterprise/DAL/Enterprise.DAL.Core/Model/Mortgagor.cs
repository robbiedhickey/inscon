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
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Cache;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Model
{
    /// <summary>
    /// Class Mortgagor
    /// </summary>
    public class Mortgagor : ModelBase
    {
        /// <summary>
        /// The _loan id
        /// </summary>
        private int _loanId;

        /// <summary>
        /// The _mortgagor id
        /// </summary>
        private int _mortgagorId;

        /// <summary>
        /// The _name
        /// </summary>
        private string _name;

        /// <summary>
        /// The _phone number
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// The _type id
        /// </summary>
        private int _typeId;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mortgagor"/> class.
        /// </summary>
        public Mortgagor()
        {
            EntityNumber = Mortgagor_EntityId;
        }

        /// <summary>
        /// Gets or sets the mortgagor id.
        /// </summary>
        /// <value>The mortgagor id.</value>
        public Int32 MortgagorId
        {
            get { return _mortgagorId; }
            set { SetProperty(ref _mortgagorId, value); }
        }

        /// <summary>
        /// Gets or sets the loan id.
        /// </summary>
        /// <value>The loan id.</value>
        public Int32 LoanId
        {
            get { return _loanId; }
            set { SetProperty(ref _loanId, value); }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public String Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
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
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        public String PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type
        {
            // Read only lookup value
            get { return new LookupService().GetLookupById(_typeId).Value; }
        }

        #region public methods

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Mortgagor.</returns>
        public static Mortgagor Build(ITypeReader reader)
        {
            var record = new Mortgagor
                {
                    MortgagorId = reader.GetInt32("MortgagorID"),
                    LoanId = reader.GetInt32("LoanID"),
                    Name = reader.GetString("Name"),
                    TypeId = reader.GetInt32("TypeID"),
                    PhoneNumber = reader.GetString("Phone")
                };

            return record;
        }


        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            if (_mortgagorId != 0)
            {
                if (IsChanged())
                {
                    // Update
                    Execute(GetCommand(Database.EnterpriseDb, Procedure.Mortgagor_Update
                                       , _mortgagorId
                                       , _loanId
                                       , _name
                                       , _typeId
                                       , _phoneNumber));
                    CommitChanges();
                }
            }
            else
            {
                // Insert
                _mortgagorId = Execute(GetCommand(Database.EnterpriseDb, Procedure.Mortgagor_Insert
                                                  , _loanId
                                                  , _name
                                                  , _typeId
                                                  , _phoneNumber), Convert.ToInt32);
                CacheItem.Clear<Mortgagor>();
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(GetCommand(Database.EnterpriseDb, Procedure.Mortgagor_Delete, _mortgagorId));
            CacheItem.Clear<Mortgagor>();
        }

        #endregion
    }
}