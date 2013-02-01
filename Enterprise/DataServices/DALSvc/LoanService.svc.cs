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
    public class LoanService : ILoanService
    {
        public List<Loan> GetAllLoans()
        {
            throw new NotImplementedException();
        }

        public Loan GetLoanById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Loan loan)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Loan loan)
        {
            throw new NotImplementedException();
        }
    }
}
