// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="MortgagorService.cs" company="Mortgage Specialist International, LLC">
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
    /// Class MortgagorService
    /// </summary>
    public class MortgagorService : ServiceBase<Mortgagor>
    {
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
                    Phone = reader.GetString("Phone")
                };

            return record;
        }

        /// <summary>
        /// Gets all mortgagors.
        /// </summary>
        /// <returns>List{Mortgagor}.</returns>
        public List<Mortgagor> GetAllMortgagors()
        {
            return QueryAll(SqlDatabase, Procedure.Mortgagor_SelectAll, Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the mortgagor by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Mortgagor.</returns>
        public Mortgagor GetMortgagorById(int id)
        {
            if (IsCached)
            {
                Predicate<Mortgagor> h = h2 => h2.MortgagorId == id;
                return GetAllMortgagors().Find(h) ?? new Mortgagor();
            }

            return Query(SqlDatabase, Procedure.Mortgagor_SelectById, Build, id);
        }


        /// <summary>
        /// Gets the mortgagors by loan id.
        /// </summary>
        /// <param name="loanId">The loan id.</param>
        /// <returns>List{Mortgagor}.</returns>
        public List<Mortgagor> GetMortgagorsByLoanId(Int32 loanId)
        {
            if (IsCached)
            {
                Predicate<Mortgagor> h = h2 => h2.LoanId == loanId;
                return GetAllMortgagors().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Mortgagor_SelectByLoanId, Build, loanId);
        }

        /// <summary>
        /// Gets the mortgagors by loan id and type id.
        /// </summary>
        /// <param name="loanId">The loan id.</param>
        /// <param name="typeId">The type id.</param>
        /// <returns>Mortgagor.</returns>
        public Mortgagor GetMortgagorsByLoanIdAndTypeId(Int32 loanId, Int32 typeId)
        {
            if (IsCached)
            {
                Predicate<Mortgagor> h = h2 => h2.LoanId == loanId && h2.TypeId == typeId;
                return GetAllMortgagors().Find(h) ?? new Mortgagor();
            }

            return Query(SqlDatabase, Procedure.Mortgagor_SelectByLoanIdAndTypeId, Build, loanId, typeId);
        }
    }
}