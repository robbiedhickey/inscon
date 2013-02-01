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
    public class MortgagorService : IMortgagorService
    {
        public List<Mortgagor> GetAllMortgagors()
        {
            throw new NotImplementedException();
        }

        public Mortgagor GetMortgagorById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mortgagor> GetMortgagorsByLoanId(int loanId)
        {
            throw new NotImplementedException();
        }

        public Mortgagor GetMortgagorsByLoanIdAndTypeId(int loanId, int typeId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Mortgagor mortgagor)
        {
            throw new NotImplementedException();
        }

        public int SaveRecord(Mortgagor mortgagor)
        {
            throw new NotImplementedException();
        }
    }
}
