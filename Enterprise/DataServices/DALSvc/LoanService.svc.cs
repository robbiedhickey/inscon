using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.LoanService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the Loan table.
    /// </summary>
    public class LoanService : ILoanService
    {
        /// <summary>
        /// Gets all loans.
        /// </summary>
        /// <returns>A list of all loan objects.</returns>
        public List<Loan> GetAllLoans()
        {
            try
            {
                return new dbSvc().GetAllLoans();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the loan by id.
        /// </summary>
        /// <param name="id">The id of the loan.</param>
        /// <returns>The loan that matches the id.</returns>
        public Loan GetLoanById(int id)
        {
            try
            {
                return new dbSvc().GetLoanById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the loan record.
        /// </summary>
        /// <param name="loan">The loan to delete.</param>
        public void DeleteRecord(Loan loan)
        {
            try
            {
                new dbSvc().DeleteRecord(loan);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the loan record.
        /// </summary>
        /// <param name="loan">The loan.</param>
        /// <returns>The id of the saved loan.</returns>
        public int SaveRecord(Loan loan)
        {
            try
            {
                return new dbSvc().SaveRecord(loan);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
