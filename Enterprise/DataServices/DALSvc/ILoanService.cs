using Enterprise.DAL.Core.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Enterprise.DataServices.DALSvc
{
    [ServiceContract(Namespace = "http://msi.enterprise.dataservices.dalsvc")]
    public interface ILoanService
    {
        [OperationContract]
        List<Loan> GetAllLoans();

        [OperationContract]
        Loan GetLoanById(Int32 id);

        [OperationContract]
        void DeleteRecord(Loan loan);

        [OperationContract]
        int SaveRecord(Loan loan);
    }
}
