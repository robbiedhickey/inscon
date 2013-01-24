using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;

namespace Enterprise.DAL.Core.Service
{
    public class LoanService : ServiceBase<Organization>
    {

        /// <summary>
        /// Get all Loan records
        /// </summary>
        /// <returns></returns>
        public List<Loan> GetAllLoans()
        {
            return QueryAll(SqlDatabase, Procedure.Loan_SelectAll, Loan.Build, CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Get Loan record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
