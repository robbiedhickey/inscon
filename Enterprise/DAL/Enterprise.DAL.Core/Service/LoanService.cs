// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="LoanService.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    ///     Class LoanService
    /// </summary>
    public class LoanService : ServiceBase<Organization>
    {
        /// <summary>
        ///     Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Loan.</returns>
        public static Loan Build(ITypeReader reader)
        {
            var record = new Loan
                {
                    LoanID = reader.GetInt32("LoanID"),
                    OrganizationID = reader.GetInt32("OrganizationID"),
                    TypeID = reader.GetInt32("TypeID"),
                    LoanNumber = reader.GetString("LoanNumber"),
                    HudCaseNumber = reader.GetString("HudCaseNumber")
                };

            return record;
        }

        /// <summary>
        ///     Gets all loans.
        /// </summary>
        /// <returns>List{Loan}.</returns>
        public List<Loan> GetAllLoans()
        {
            return QueryAll(SqlDatabase, Procedure.Loan_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        ///     Gets the loan by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Loan.</returns>
        public Loan GetLoanById(Int32 id)
        {
            if (IsCached)
            {
                Predicate<Loan> h = h2 => h2.LoanID == id;
                return GetAllLoans().Find(h) ?? new Loan();
            }

            return Query(SqlDatabase, Procedure.Loan_SelectById, Build, id);
        }
    }
}