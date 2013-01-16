using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class MortgagorService : ServiceBase<Mortgagor>
    {
        /// <summary>
        ///     Get all Mortgagor records
        /// </summary>
        /// <returns></returns>
        public List<Mortgagor> GetAllMortgagors()
        {
            return QueryAll(SqlDatabase, Procedure.Mortgagor_SelectAll, Mortgagor.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        ///     Get Mortgagor record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Mortgagor GetMortgagorById(int id)
        {
            if (IsCached)
            {
                Predicate<Mortgagor> h = h2 => h2.MortgagorId == id;
                return GetAllMortgagors().Find(h) ?? new Mortgagor();
            }

            return Query(SqlDatabase, Procedure.Mortgagor_SelectById, Mortgagor.Build, id);
        }


        public List<Mortgagor> GetMortgagorsByLoanId(Int32 loanId)
        {
            if (IsCached)
            {
                Predicate<Mortgagor> h = h2 => h2.LoanId == loanId;
                return GetAllMortgagors().FindAll(h);
            }

            return QueryAll(SqlDatabase, Procedure.Mortgagor_SelectByLoanId, Mortgagor.Build, loanId);
        }

        public Mortgagor GetMortgagorsByLoanIdAndTypeId(Int32 loanId, Int32 typeId)
        {
            if (IsCached)
            {
                Predicate<Mortgagor> h = h2 => h2.LoanId == loanId && h2.TypeId == typeId;
                return GetAllMortgagors().Find(h) ?? new Mortgagor();
            }

            return Query(SqlDatabase, Procedure.Mortgagor_SelectByLoanIdAndTypeId, Mortgagor.Build, loanId, typeId);
        }
    }
}