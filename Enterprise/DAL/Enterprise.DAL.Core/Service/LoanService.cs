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

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class LoanService
    /// </summary>
    public class LoanService : ServiceBase<Organization>
    {
        /// <summary>
        /// Gets all loans.
        /// </summary>
        /// <returns>List{Loan}.</returns>
        public List<Loan> GetAllLoans()
        {
            return QueryAll(SqlDatabase, Procedure.Loan_SelectAll, Loan.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the loan by id.
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

            return Query(SqlDatabase, Procedure.Loan_SelectById, Loan.Build, id);
        }
    }
}