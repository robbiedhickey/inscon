using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbSvc = Enterprise.DAL.Core.Service.MortgagorService;
using Enterprise.DAL.Core.Model;

namespace Enterprise.DataServices.DALSvc
{
    /// <summary>
    /// Handles access to the Mortgagor table.
    /// </summary>
    public class MortgagorService : IMortgagorService
    {
        /// <summary>
        /// Gets all mortgagors.
        /// </summary>
        /// <returns>A list of Mortgagor objects.</returns>
        public List<Mortgagor> GetAllMortgagors()
        {
            try
            {
                return new dbSvc().GetAllMortgagors();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the mortgagor by id.
        /// </summary>
        /// <param name="id">The id of the mortgator.</param>
        /// <returns>The mortgator that matches the id.</returns>
        public Mortgagor GetMortgagorById(int id)
        {
            try
            {
                return new dbSvc().GetMortgagorById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the mortgagors by loan id.
        /// </summary>
        /// <param name="loanId">The loan id of the mortgagor.</param>
        /// <returns>A list of mortgagor objects that match the loan id.</returns>
        public List<Mortgagor> GetMortgagorsByLoanId(int loanId)
        {
            try
            {
                return new dbSvc().GetMortgagorsByLoanId(loanId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the mortgagors by loan id and type id.
        /// </summary>
        /// <param name="loanId">The loan id of the mortgagor.</param>
        /// <param name="typeId">The type id of the mortgagor.</param>
        /// <returns>The mortgagor that matches the parameter list.</returns>
        public Mortgagor GetMortgagorsByLoanIdAndTypeId(int loanId, int typeId)
        {
            try
            {
                return new dbSvc().GetMortgagorsByLoanIdAndTypeId(loanId, typeId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the mortgagor record.
        /// </summary>
        /// <param name="mortgagor">The mortgagor to delete.</param>
        public void DeleteRecord(Mortgagor mortgagor)
        {
            try
            {
                new dbSvc().DeleteRecord(mortgagor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Saves the mortgagor record.
        /// </summary>
        /// <param name="mortgagor">The mortgagor to save.</param>
        /// <returns>The id of the saved mortgator.</returns>
        public int SaveRecord(Mortgagor mortgagor)
        {
            try
            {
                return new dbSvc().SaveRecord(mortgagor);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
